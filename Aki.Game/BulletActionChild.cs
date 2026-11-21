using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020022DF RID: 8927
public class BulletActionChild : BulletActionBase
{
	// Token: 0x0601607E RID: 90238 RVA: 0x00661B63 File Offset: 0x0065FD63
	public BulletActionChild(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601607F RID: 90239 RVA: 0x00661B6C File Offset: 0x0065FD6C
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

	// Token: 0x06016080 RID: 90240 RVA: 0x00661BE7 File Offset: 0x0065FDE7
	public override void Clear()
	{
		base.Clear();
		this.ChildInfo = null;
		this.ChildBulletData = null;
	}

	// Token: 0x06016081 RID: 90241 RVA: 0x00661C00 File Offset: 0x0065FE00
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

	// Token: 0x06016082 RID: 90242 RVA: 0x00661C3A File Offset: 0x0065FE3A
	protected override void OnTick(float delta)
	{
		if (!this.BulletInfo.NeedDestroy)
		{
			this.UpdateSummonChildBullet();
		}
	}

	// Token: 0x06016083 RID: 90243 RVA: 0x00661C50 File Offset: 0x0065FE50
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

	// Token: 0x0400B8FB RID: 47355
	[Nullable(2)]
	public BulletChildInfo ChildInfo;

	// Token: 0x0400B8FC RID: 47356
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private BulletDataChild[] ChildBulletData;
}
