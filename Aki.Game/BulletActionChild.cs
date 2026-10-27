using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002D85 RID: 11653
public class BulletActionChild : BulletActionBase
{
	// Token: 0x060187DC RID: 100316 RVA: 0x0063BE2A File Offset: 0x0063A02A
	public BulletActionChild(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187DD RID: 100317 RVA: 0x0063BE34 File Offset: 0x0063A034
	protected override void OnExecute()
	{
		this.ChildInfo = new BulletChildInfo();
		this.BulletInfo.ChildInfo = this.ChildInfo;
		this.ChildInfo.HaveSummonedBulletNumber = new List<int>();
		this.ChildBulletData = this.BulletInfo.BulletDataMain.Children;
		int num = this.ChildBulletData.Length;
		for (int i = 0; i < num; i++)
		{
			this.ChildInfo.HaveSummonedBulletNumber.Add(0);
		}
		this.SetSpecialChildrenBullet();
	}

	// Token: 0x060187DE RID: 100318 RVA: 0x0063BEAF File Offset: 0x0063A0AF
	public override void Clear()
	{
		base.Clear();
		this.ChildInfo = null;
		this.ChildBulletData = null;
	}

	// Token: 0x060187DF RID: 100319 RVA: 0x0063BEC8 File Offset: 0x0063A0C8
	private void SetSpecialChildrenBullet()
	{
		BulletDataChild[] childBulletData = this.ChildBulletData;
		for (int i = 0; i < childBulletData.Length; i++)
		{
			if (childBulletData[i].Condition == EBulletChildrenType.OnHitObstacle)
			{
				this.ChildInfo.HaveSpecialChildrenBullet = true;
				return;
			}
		}
	}

	// Token: 0x060187E0 RID: 100320 RVA: 0x0063BF02 File Offset: 0x0063A102
	protected override void OnTick(float delta)
	{
		if (!this.BulletInfo.NeedDestroy)
		{
			this.UpdateSummonChildBullet();
		}
	}

	// Token: 0x060187E1 RID: 100321 RVA: 0x0063BF18 File Offset: 0x0063A118
	private void UpdateSummonChildBullet()
	{
		int num = this.ChildBulletData.Length;
		for (int i = 0; i < num; i++)
		{
			BulletDataChild bulletDataChild = this.ChildBulletData[i];
			int num2 = i;
			if ((float)bulletDataChild.RowName > 0.0001f && bulletDataChild.Condition == EBulletChildrenType.Normal && (bulletDataChild.Num <= 0 || this.ChildInfo.HaveSummonedBulletNumber[num2] < bulletDataChild.Num))
			{
				if (bulletDataChild.Delay < 0f)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Bullet;
					ELogAuthor author = ELogAuthor.HCW;
					string message = "子弹Delay为负数！";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Bullet", this.BulletInfo.BulletRowName);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				if (this.BulletInfo.LiveTime >= bulletDataChild.Delay * (float)TimeUtil.Instance.InverseMillisecond + (float)this.ChildInfo.HaveSummonedBulletNumber[num2] * bulletDataChild.Interval * (float)TimeUtil.Instance.InverseMillisecond)
				{
					List<int> haveSummonedBulletNumber = this.ChildInfo.HaveSummonedBulletNumber;
					int index = num2;
					int num3 = haveSummonedBulletNumber[index];
					haveSummonedBulletNumber[index] = num3 + 1;
					HashSet<string> parentIds = BulletUtil.CollectParentsId(this.BulletInfo);
					BulletController instance2 = BulletController.Instance;
					Entity attacker = this.BulletInfo.Attacker;
					string bulletRowName = bulletDataChild.RowName.ToString();
					FTransformDouble? initialTransform = new FTransformDouble?(this.BulletInfo.ActorComponent.ActorTransform);
					BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
					bulletCreateParams.SkillId = this.BulletInfo.BulletInitParams.SkillId;
					bulletCreateParams.SkillContextId = this.BulletInfo.BulletInitParams.SkillContextId;
					Entity target = this.BulletInfo.Target;
					bulletCreateParams.ParentTargetId = ((target != null) ? new int?(target.Id) : null);
					bulletCreateParams.ParentId = this.BulletInfo.Entity.Id;
					bulletCreateParams.BattleContext = this.BulletInfo.BulletInitParams.BattleContext;
					bulletCreateParams.ParentIds = parentIds;
					BulletEntity bulletEntity = instance2.CreateBulletCustomTarget(attacker, bulletRowName, initialTransform, bulletCreateParams, this.BulletInfo.ContextId, EBulletCreateSource.Others);
					if (bulletEntity == null)
					{
						if (bulletDataChild.BreakOnFail)
						{
							return;
						}
					}
					else
					{
						BulletUtil.ProcessHandOverEffectToSon(this.BulletInfo, bulletEntity);
					}
				}
			}
		}
	}

	// Token: 0x0400B586 RID: 46470
	[Nullable(2)]
	public BulletChildInfo ChildInfo;

	// Token: 0x0400B587 RID: 46471
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private BulletDataChild[] ChildBulletData;
}
