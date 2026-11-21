using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020022F1 RID: 8945
[NullableContext(1)]
[Nullable(0)]
public class BulletActionSummonBullet : BulletActionBase
{
	// Token: 0x060160EF RID: 90351 RVA: 0x00668633 File Offset: 0x00666833
	public BulletActionSummonBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060160F0 RID: 90352 RVA: 0x0066863C File Offset: 0x0066683C
	protected override void OnExecute()
	{
		this.ChildInfo = this.BulletInfo.ChildInfo;
		if (this.ChildInfo == null)
		{
			return;
		}
		this.ChildBulletData = this.BulletInfo.BulletDataMain.Children;
		BulletActionInfoSummonBullet bulletActionInfoSummonBullet = (BulletActionInfoSummonBullet)this.ActionInfo;
		if (bulletActionInfoSummonBullet.IsStayInCharacter)
		{
			this.SummonBulletOnCharacterStayBullet(bulletActionInfoSummonBullet);
			return;
		}
		this.SummonBulletOnHit(bulletActionInfoSummonBullet);
	}

	// Token: 0x060160F1 RID: 90353 RVA: 0x0066869C File Offset: 0x0066689C
	public override void Clear()
	{
		base.Clear();
		this.ChildInfo = null;
		this.ChildBulletData = null;
	}

	// Token: 0x060160F2 RID: 90354 RVA: 0x006686B4 File Offset: 0x006668B4
	private void SummonBulletOnHit(BulletActionInfoSummonBullet actionInfo)
	{
		BulletDataChild[] childBulletData = this.ChildBulletData;
		int num = childBulletData.Length;
		FTransformDouble? ftransformDouble = null;
		for (int i = 0; i < num; i++)
		{
			EBulletChildrenType condition = childBulletData[i].Condition;
			EBulletChildrenType? childrenType = actionInfo.ChildrenType;
			if (condition == childrenType.GetValueOrDefault() & childrenType != null)
			{
				BulletDataChild bulletDataChild = childBulletData[i];
				if ((bulletDataChild.Num <= 0 || this.ChildInfo.HaveSummonedBulletNumber[i] < bulletDataChild.Num) && bulletDataChild.RowName != 0L)
				{
					if (ftransformDouble == null && actionInfo.ParentImpactPoint != null && actionInfo.ParentLastPosition != null)
					{
						Vector vector = BulletPool.CreateVector(false);
						Vector vector2 = BulletPool.CreateVector(false);
						vector.FromUeVector(actionInfo.ParentImpactPoint);
						vector.SubtractionEqual(actionInfo.ParentLastPosition);
						vector2.FromUeVector(this.BulletInfo.MoveInfo.BulletSpeedDir);
						vector2.Normalize(9.99999993922529E-09);
						double inB = vector.DotProduct(vector2);
						vector2.Multiply(inB, vector);
						actionInfo.ParentLastPosition.Addition(vector, vector2);
						FTransformDouble actorTransform = this.BulletInfo.ActorComponent.ActorTransform;
						FVectorDouble fvectorDouble = vector2.ToUeVector(false);
						ftransformDouble = new FTransformDouble?(new FTransformDouble(ref actorTransform.Rotation, ref fvectorDouble, ref actorTransform.Scale3D));
						BulletPool.RecycleVector(vector2);
						BulletPool.RecycleVector(vector);
					}
					List<int> haveSummonedBulletNumber = this.ChildInfo.HaveSummonedBulletNumber;
					int index = i;
					int num2 = haveSummonedBulletNumber[index];
					haveSummonedBulletNumber[index] = num2 + 1;
					HashSet<string> parentIds = BulletUtil.CollectParentsId(this.BulletInfo);
					BulletController instance = BulletController.Instance;
					Entity attacker = this.BulletInfo.Attacker;
					string bulletRowName = bulletDataChild.RowName.ToString();
					FTransformDouble? initialTransform = new FTransformDouble?(ftransformDouble ?? this.BulletInfo.ActorComponent.ActorTransform);
					BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
					bulletCreateParams.SkillId = this.BulletInfo.BulletInitParams.SkillId;
					bulletCreateParams.SkillContextId = this.BulletInfo.BulletInitParams.SkillContextId;
					Entity victim = actionInfo.Victim;
					bulletCreateParams.ParentVictimId = ((victim != null) ? new int?(victim.Id) : null);
					Entity target = this.BulletInfo.Target;
					bulletCreateParams.ParentTargetId = ((target != null) ? new int?(target.Id) : null);
					bulletCreateParams.ParentId = this.BulletInfo.Entity.Id;
					bulletCreateParams.CreateOnAuthority = actionInfo.CreateOnAuthority;
					bulletCreateParams.BattleContext = this.BulletInfo.BulletInitParams.BattleContext;
					bulletCreateParams.ParentIds = parentIds;
					BulletEntity bulletEntity = instance.CreateBulletCustomTarget(attacker, bulletRowName, initialTransform, bulletCreateParams, this.BulletInfo.ContextId, EBulletCreateSource.Others);
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

	// Token: 0x060160F3 RID: 90355 RVA: 0x00668990 File Offset: 0x00666B90
	private void SummonBulletOnCharacterStayBullet(BulletActionInfoSummonBullet actionInfo)
	{
		int num = this.ChildBulletData.Length;
		for (int i = 0; i < num; i++)
		{
			BulletDataChild bulletDataChild = this.ChildBulletData[i];
			int num2 = i;
			if (bulletDataChild.Condition == EBulletChildrenType.OnHitVictim && (bulletDataChild.Num <= 0 || this.ChildInfo.HaveSummonedBulletNumber[num2] < bulletDataChild.Num) && this.BulletInfo.LiveTime >= (float)this.ChildInfo.HaveSummonedBulletNumber[num2] * bulletDataChild.Interval * (float)TimeUtil.Instance.InverseMillisecond)
			{
				List<int> haveSummonedBulletNumber = this.ChildInfo.HaveSummonedBulletNumber;
				int index = num2;
				int num3 = haveSummonedBulletNumber[index];
				haveSummonedBulletNumber[index] = num3 + 1;
				HashSet<string> parentIds = BulletUtil.CollectParentsId(this.BulletInfo);
				BulletController instance = BulletController.Instance;
				Entity attacker = this.BulletInfo.Attacker;
				string bulletRowName = bulletDataChild.RowName.ToString();
				FTransformDouble? initialTransform = new FTransformDouble?(this.BulletInfo.ActorComponent.ActorTransform);
				BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
				bulletCreateParams.SkillId = this.BulletInfo.BulletInitParams.SkillId;
				bulletCreateParams.SkillContextId = this.BulletInfo.BulletInitParams.SkillContextId;
				Entity victim = actionInfo.Victim;
				bulletCreateParams.ParentVictimId = ((victim != null) ? new int?(victim.Id) : null);
				Entity target = this.BulletInfo.Target;
				bulletCreateParams.ParentTargetId = ((target != null) ? new int?(target.Id) : null);
				bulletCreateParams.ParentId = this.BulletInfo.Entity.Id;
				bulletCreateParams.CreateOnAuthority = actionInfo.CreateOnAuthority;
				bulletCreateParams.BattleContext = this.BulletInfo.BulletInitParams.BattleContext;
				bulletCreateParams.ParentIds = parentIds;
				BulletEntity bulletEntity = instance.CreateBulletCustomTarget(attacker, bulletRowName, initialTransform, bulletCreateParams, this.BulletInfo.ContextId, EBulletCreateSource.Others);
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

	// Token: 0x0400B956 RID: 47446
	[Nullable(2)]
	public BulletChildInfo ChildInfo;

	// Token: 0x0400B957 RID: 47447
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private BulletDataChild[] ChildBulletData;
}
