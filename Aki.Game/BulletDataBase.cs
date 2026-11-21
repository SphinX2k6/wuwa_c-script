using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002303 RID: 8963
[NullableContext(1)]
[Nullable(0)]
public class BulletDataBase
{
	// Token: 0x17002181 RID: 8577
	// (get) Token: 0x060161A1 RID: 90529 RVA: 0x0066CCB4 File Offset: 0x0066AEB4
	public bool IgnoreGradient
	{
		get
		{
			if (this.IgnoreGradientInternal == null)
			{
				this.IgnoreGradientInternal = new bool?(this.Data.不适配坡度);
			}
			return this.IgnoreGradientInternal.Value;
		}
	}

	// Token: 0x17002182 RID: 8578
	// (get) Token: 0x060161A2 RID: 90530 RVA: 0x0066CCE4 File Offset: 0x0066AEE4
	public Vector CenterOffset
	{
		get
		{
			if (this.CenterOffsetInternal == null)
			{
				this.CenterOffsetInternal = Vector.Create(this.Data.中心位置偏移);
			}
			return this.CenterOffsetInternal;
		}
	}

	// Token: 0x17002183 RID: 8579
	// (get) Token: 0x060161A3 RID: 90531 RVA: 0x0066CD0F File Offset: 0x0066AF0F
	public long DamageId
	{
		get
		{
			if (this.DamageIdInternal == null)
			{
				this.DamageIdInternal = new long?(this.Data.伤害ID);
			}
			return this.DamageIdInternal.Value;
		}
	}

	// Token: 0x17002184 RID: 8580
	// (get) Token: 0x060161A4 RID: 90532 RVA: 0x0066CD40 File Offset: 0x0066AF40
	[Nullable(2)]
	public long[] MultiDamageId
	{
		[NullableContext(2)]
		get
		{
			if (!this.InitedMultiDamageId)
			{
				this.InitedMultiDamageId = true;
				TArray<long> 多伤害ID = this.Data.多伤害ID;
				int num = 多伤害ID.Num();
				if (num > 0)
				{
					this.MultiDamageIdInternal = new long[num];
					for (int i = 0; i < num; i++)
					{
						this.MultiDamageIdInternal[i] = 多伤害ID.Get(i);
					}
				}
			}
			return this.MultiDamageIdInternal;
		}
	}

	// Token: 0x17002185 RID: 8581
	// (get) Token: 0x060161A5 RID: 90533 RVA: 0x0066CDA0 File Offset: 0x0066AFA0
	public bool EnablePartHitAudio
	{
		get
		{
			if (this.EnablePartHitAudioInternal == null)
			{
				this.EnablePartHitAudioInternal = new bool?(this.Data.是否响应材质受击音效);
			}
			return this.EnablePartHitAudioInternal.Value;
		}
	}

	// Token: 0x17002186 RID: 8582
	// (get) Token: 0x060161A6 RID: 90534 RVA: 0x0066CDD0 File Offset: 0x0066AFD0
	public bool IntervalAfterHit
	{
		get
		{
			if (this.IntervalAfterHitInternal == null)
			{
				this.IntervalAfterHitInternal = new bool?(this.Data.作用间隔基于个体);
			}
			return this.IntervalAfterHitInternal.Value;
		}
	}

	// Token: 0x17002187 RID: 8583
	// (get) Token: 0x060161A7 RID: 90535 RVA: 0x0066CE00 File Offset: 0x0066B000
	public float Interval
	{
		get
		{
			if (this.IntervalInternal == null)
			{
				this.IntervalInternal = new float?(this.Data.作用间隔);
			}
			return this.IntervalInternal.Value;
		}
	}

	// Token: 0x17002188 RID: 8584
	// (get) Token: 0x060161A8 RID: 90536 RVA: 0x0066CE30 File Offset: 0x0066B030
	public bool ShareCounter
	{
		get
		{
			if (this.ShareCounterInternal == null)
			{
				this.ShareCounterInternal = new bool?(this.Data.共享父子弹次数);
			}
			return this.ShareCounterInternal.Value;
		}
	}

	// Token: 0x17002189 RID: 8585
	// (get) Token: 0x060161A9 RID: 90537 RVA: 0x0066CE60 File Offset: 0x0066B060
	public Vector BornPosition
	{
		get
		{
			if (this.BornPositionInternal == null)
			{
				this.BornPositionInternal = Vector.Create(this.Data.出生位置偏移);
			}
			return this.BornPositionInternal;
		}
	}

	// Token: 0x1700218A RID: 8586
	// (get) Token: 0x060161AA RID: 90538 RVA: 0x0066CE8B File Offset: 0x0066B08B
	public EPositionStandard BornPositionStandard
	{
		get
		{
			if (this.BornPositionStandardInternal == null)
			{
				this.BornPositionStandardInternal = new EPositionStandard?((EPositionStandard)this.Data.出生位置基准);
			}
			return this.BornPositionStandardInternal.Value;
		}
	}

	// Token: 0x1700218B RID: 8587
	// (get) Token: 0x060161AB RID: 90539 RVA: 0x0066CEC0 File Offset: 0x0066B0C0
	public Vector BornPositionRandom
	{
		get
		{
			if (this.BornPositionRandomInternal == null)
			{
				this.BornPositionRandomInternal = Vector.Create(this.Data.出生位置随机);
			}
			return this.BornPositionRandomInternal;
		}
	}

	// Token: 0x1700218C RID: 8588
	// (get) Token: 0x060161AC RID: 90540 RVA: 0x0066CEEB File Offset: 0x0066B0EB
	public Vector Size
	{
		get
		{
			if (this.SizeInternal == null)
			{
				this.SizeInternal = Vector.Create(this.Data.初始大小);
			}
			return this.SizeInternal;
		}
	}

	// Token: 0x1700218D RID: 8589
	// (get) Token: 0x060161AD RID: 90541 RVA: 0x0066CF16 File Offset: 0x0066B116
	public Rotator Rotator
	{
		get
		{
			if (this.RotatorInternal == null)
			{
				this.RotatorInternal = Rotator.Create(this.Data.初始旋转);
			}
			return this.RotatorInternal;
		}
	}

	// Token: 0x1700218E RID: 8590
	// (get) Token: 0x060161AE RID: 90542 RVA: 0x0066CF41 File Offset: 0x0066B141
	public int VictimCount
	{
		get
		{
			if (this.VictimCountInternal == null)
			{
				this.VictimCountInternal = new int?(this.Data.命中个数);
			}
			return this.VictimCountInternal.Value;
		}
	}

	// Token: 0x1700218F RID: 8591
	// (get) Token: 0x060161AF RID: 90543 RVA: 0x0066CF71 File Offset: 0x0066B171
	public int HitConditionTagId
	{
		get
		{
			this.InitHitConditionTag();
			return this.HitConditionTagIdInternal;
		}
	}

	// Token: 0x060161B0 RID: 90544 RVA: 0x0066CF80 File Offset: 0x0066B180
	private void InitHitConditionTag()
	{
		if (!this.HitConditionTagInit)
		{
			this.HitConditionTagInit = true;
			FGameplayTag 命中判定Tag = this.Data.命中判定Tag;
			if (!命中判定Tag.TagName.IsNone())
			{
				this.HitConditionTagIdInternal = 命中判定Tag.TagId();
				return;
			}
			this.HitConditionTagIdInternal = 0;
		}
	}

	// Token: 0x17002190 RID: 8592
	// (get) Token: 0x060161B1 RID: 90545 RVA: 0x0066CFCA File Offset: 0x0066B1CA
	public int HitType
	{
		get
		{
			if (this.HitTypeInternal == null)
			{
				this.HitTypeInternal = new int?((int)this.Data.命中判定类型);
			}
			return this.HitTypeInternal.Value;
		}
	}

	// Token: 0x17002191 RID: 8593
	// (get) Token: 0x060161B2 RID: 90546 RVA: 0x0066CFFF File Offset: 0x0066B1FF
	public FName DaHitTypePreset
	{
		get
		{
			this.InitBulletCamp();
			return this.DaHitTypePresetInternal;
		}
	}

	// Token: 0x060161B3 RID: 90547 RVA: 0x0066D010 File Offset: 0x0066B210
	private void InitBulletCamp()
	{
		if (this.DaHitTypePresetInit)
		{
			return;
		}
		this.DaHitTypePresetInit = true;
		this.DaHitTypePresetInternal = this.Data.命中判定类型预设.GetAssetPathName();
		if (this.DaHitTypePresetInternal != FName.NAME_None)
		{
			BulletCampType_C bulletCampType_C = ResourceSystem.Instance.Load<BulletCampType_C>(this.DaHitTypePresetInternal.ToString(), "js_undefined");
			this.BulletCamp = ((bulletCampType_C != null) ? new int?(bulletCampType_C.阵营) : null);
		}
	}

	// Token: 0x17002192 RID: 8594
	// (get) Token: 0x060161B4 RID: 90548 RVA: 0x0066D095 File Offset: 0x0066B295
	public EBulletRelativeDir RelativeDirection
	{
		get
		{
			if (this.RelativeDirectionInternal == null)
			{
				this.RelativeDirectionInternal = new EBulletRelativeDir?((EBulletRelativeDir)this.Data.子弹受击方向);
			}
			return this.RelativeDirectionInternal.Value;
		}
	}

	// Token: 0x17002193 RID: 8595
	// (get) Token: 0x060161B5 RID: 90549 RVA: 0x0066D0CA File Offset: 0x0066B2CA
	public EBulletShape Shape
	{
		get
		{
			if (this.ShapeInternal == null)
			{
				this.ShapeInternal = new EBulletShape?((EBulletShape)this.Data.子弹形状);
			}
			return this.ShapeInternal.Value;
		}
	}

	// Token: 0x17002194 RID: 8596
	// (get) Token: 0x060161B6 RID: 90550 RVA: 0x0066D0FF File Offset: 0x0066B2FF
	public Rotator AttackDirection
	{
		get
		{
			if (this.AttackDirectionInternal == null)
			{
				this.AttackDirectionInternal = Rotator.Create(this.Data.子弹攻击方向);
			}
			return this.AttackDirectionInternal;
		}
	}

	// Token: 0x17002195 RID: 8597
	// (get) Token: 0x060161B7 RID: 90551 RVA: 0x0066D12A File Offset: 0x0066B32A
	public int TagId
	{
		get
		{
			this.InitTag();
			return this.TagIdInternal;
		}
	}

	// Token: 0x060161B8 RID: 90552 RVA: 0x0066D138 File Offset: 0x0066B338
	private void InitTag()
	{
		if (this.TagInit)
		{
			return;
		}
		this.TagInit = true;
		FGameplayTag 子弹标签 = this.Data.子弹标签;
		if (!子弹标签.TagName.IsNone())
		{
			this.TagIdInternal = 子弹标签.TagId();
			return;
		}
		this.TagIdInternal = 0;
	}

	// Token: 0x17002196 RID: 8598
	// (get) Token: 0x060161B9 RID: 90553 RVA: 0x0066D183 File Offset: 0x0066B383
	public int[] BornRequireTagIds
	{
		get
		{
			this.InitBornTag();
			return this.BornRequireTagIdsInternal;
		}
	}

	// Token: 0x17002197 RID: 8599
	// (get) Token: 0x060161BA RID: 90554 RVA: 0x0066D191 File Offset: 0x0066B391
	public int[] BornForbidTagIds
	{
		get
		{
			this.InitBornTag();
			return this.BornForbidTagIdsInternal;
		}
	}

	// Token: 0x060161BB RID: 90555 RVA: 0x0066D1A0 File Offset: 0x0066B3A0
	private void InitBornTag()
	{
		if (this.BornTagInit)
		{
			return;
		}
		this.BornTagInit = true;
		TArray<FGameplayTag> gameplayTags = this.Data.子弹禁止生成Tag.GameplayTags;
		int num = gameplayTags.Num();
		if (num > 0)
		{
			this.BornForbidTagIdsInternal = new int[num];
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				int num3 = gameplayTags.Get(i).TagId();
				if (num3 != 0)
				{
					this.BornForbidTagIdsInternal[num2++] = num3;
				}
			}
			if (num2 < num)
			{
				Array.Resize<int>(ref this.BornForbidTagIdsInternal, num2);
			}
		}
		TArray<FGameplayTag> gameplayTags2 = this.Data.子弹允许生成Tag.GameplayTags;
		int num4 = gameplayTags2.Num();
		if (num4 > 0)
		{
			this.BornRequireTagIdsInternal = new int[num4];
			int num5 = 0;
			for (int j = 0; j < num4; j++)
			{
				int num6 = gameplayTags2.Get(j).TagId();
				if (num6 != 0)
				{
					this.BornRequireTagIdsInternal[num5++] = num6;
				}
			}
			if (num5 < num4)
			{
				Array.Resize<int>(ref this.BornRequireTagIdsInternal, num5);
			}
		}
	}

	// Token: 0x17002198 RID: 8600
	// (get) Token: 0x060161BC RID: 90556 RVA: 0x0066D29B File Offset: 0x0066B49B
	public FName HitEffectWeakness
	{
		get
		{
			if (!this.HitEffectWeaknessInit)
			{
				this.HitEffectWeaknessInit = true;
				this.HitEffectWeaknessInternal = new FName?(this.Data.弱点被击效果);
			}
			return this.HitEffectWeaknessInternal.Value;
		}
	}

	// Token: 0x17002199 RID: 8601
	// (get) Token: 0x060161BD RID: 90557 RVA: 0x0066D2D0 File Offset: 0x0066B4D0
	[Nullable(2)]
	public FName[] MultiHitEffectWeakness
	{
		[NullableContext(2)]
		get
		{
			if (!this.MultiHitEffectWeaknessInit)
			{
				this.MultiHitEffectWeaknessInit = true;
				TArray<FName> 多弱点被击效果 = this.Data.多弱点被击效果;
				int num = 多弱点被击效果.Num();
				if (num > 0)
				{
					this.MultiHitEffectWeaknessInternal = new FName[num];
					for (int i = 0; i < num; i++)
					{
						this.MultiHitEffectWeaknessInternal[i] = 多弱点被击效果.Get(i);
					}
				}
			}
			return this.MultiHitEffectWeaknessInternal;
		}
	}

	// Token: 0x1700219A RID: 8602
	// (get) Token: 0x060161BE RID: 90558 RVA: 0x0066D334 File Offset: 0x0066B534
	public int HitCountMax
	{
		get
		{
			if (this.HitCountMaxInternal == null)
			{
				this.HitCountMaxInternal = new int?(this.Data.总作用次数限制);
			}
			return this.HitCountMaxInternal.Value;
		}
	}

	// Token: 0x1700219B RID: 8603
	// (get) Token: 0x060161BF RID: 90559 RVA: 0x0066D364 File Offset: 0x0066B564
	public bool DestroyOnSkillEnd
	{
		get
		{
			if (this.DestroyOnSkillEndInternal == null)
			{
				this.DestroyOnSkillEndInternal = new bool?(this.Data.技能结束是否销毁子弹);
			}
			return this.DestroyOnSkillEndInternal.Value;
		}
	}

	// Token: 0x1700219C RID: 8604
	// (get) Token: 0x060161C0 RID: 90560 RVA: 0x0066D394 File Offset: 0x0066B594
	public float Duration
	{
		get
		{
			if (this.DurationInternal == null)
			{
				this.DurationInternal = new float?(this.Data.持续时间);
			}
			return this.DurationInternal.Value;
		}
	}

	// Token: 0x1700219D RID: 8605
	// (get) Token: 0x060161C1 RID: 90561 RVA: 0x0066D3C4 File Offset: 0x0066B5C4
	public string BlackboardKey
	{
		get
		{
			if (!this.BlackboardKeyInit)
			{
				this.BlackboardKeyInit = true;
				this.BlackboardKeyInternal = this.Data.攻击者黑板Key值;
			}
			return this.BlackboardKeyInternal;
		}
	}

	// Token: 0x1700219E RID: 8606
	// (get) Token: 0x060161C2 RID: 90562 RVA: 0x0066D3EC File Offset: 0x0066B5EC
	public bool ContinuesCollision
	{
		get
		{
			if (this.ContinuesCollisionInternal == null)
			{
				this.ContinuesCollisionInternal = new bool?(this.Data.是否持续碰撞);
			}
			return this.ContinuesCollisionInternal.Value;
		}
	}

	// Token: 0x1700219F RID: 8607
	// (get) Token: 0x060161C3 RID: 90563 RVA: 0x0066D41C File Offset: 0x0066B61C
	public bool StickGround
	{
		get
		{
			if (this.StickGroundInternal == null)
			{
				this.StickGroundInternal = new bool?(this.Data.是否贴地子弹);
			}
			return this.StickGroundInternal.Value;
		}
	}

	// Token: 0x170021A0 RID: 8608
	// (get) Token: 0x060161C4 RID: 90564 RVA: 0x0066D44C File Offset: 0x0066B64C
	public bool StickWater
	{
		get
		{
			if (this.StickWaterInternal == null)
			{
				this.StickWaterInternal = new bool?(this.Data.是否贴水面);
			}
			return this.StickWaterInternal.Value;
		}
	}

	// Token: 0x170021A1 RID: 8609
	// (get) Token: 0x060161C5 RID: 90565 RVA: 0x0066D47C File Offset: 0x0066B67C
	public bool NotFollowMovePlatform
	{
		get
		{
			if (this.NotFollowMovePlatformInternal == null)
			{
				this.NotFollowMovePlatformInternal = new bool?(this.Data.不跟随移动平台);
			}
			return this.NotFollowMovePlatformInternal.Value;
		}
	}

	// Token: 0x170021A2 RID: 8610
	// (get) Token: 0x060161C6 RID: 90566 RVA: 0x0066D4AC File Offset: 0x0066B6AC
	public float StickTraceLen
	{
		get
		{
			if (this.StickTraceLenInternal == null)
			{
				this.StickTraceLenInternal = new float?(this.Data.贴地探测距离);
			}
			return this.StickTraceLenInternal.Value;
		}
	}

	// Token: 0x170021A3 RID: 8611
	// (get) Token: 0x060161C7 RID: 90567 RVA: 0x0066D4DC File Offset: 0x0066B6DC
	public float StickGroundAngleLimit
	{
		get
		{
			if (this.StickGroundAngleLimitInternal == null)
			{
				this.StickGroundAngleLimitInternal = new float?(this.Data.贴地角度限制);
			}
			return this.StickGroundAngleLimitInternal.Value;
		}
	}

	// Token: 0x170021A4 RID: 8612
	// (get) Token: 0x060161C8 RID: 90568 RVA: 0x0066D50C File Offset: 0x0066B70C
	public int HitCountPerVictim
	{
		get
		{
			if (this.HitCountPerVictimInternal == null)
			{
				this.HitCountPerVictimInternal = new int?(this.Data.每个单位总作用次数);
			}
			return this.HitCountPerVictimInternal.Value;
		}
	}

	// Token: 0x170021A5 RID: 8613
	// (get) Token: 0x060161C9 RID: 90569 RVA: 0x0066D53C File Offset: 0x0066B73C
	public Dictionary<EBulletBaseSpecificParam, string> SpecialParams
	{
		get
		{
			if (this.SpecialParamsInternal == null)
			{
				this.SpecialParamsInternal = new Dictionary<EBulletBaseSpecificParam, string>();
				foreach (KeyValuePair<TEnumAsByte<EBulletBaseSpecificParam>, string> keyValuePair in this.Data.特殊参数)
				{
					TEnumAsByte<EBulletBaseSpecificParam> tenumAsByte;
					string text;
					keyValuePair.Deconstruct(out tenumAsByte, out text);
					TEnumAsByte<EBulletBaseSpecificParam> value = tenumAsByte;
					string value2 = text;
					this.SpecialParamsInternal.Add(value, value2);
				}
			}
			return this.SpecialParamsInternal;
		}
	}

	// Token: 0x170021A6 RID: 8614
	// (get) Token: 0x060161CA RID: 90570 RVA: 0x0066D5CC File Offset: 0x0066B7CC
	public float CollisionActiveDelay
	{
		get
		{
			if (this.CollisionActiveDelayInternal == null)
			{
				this.CollisionActiveDelayInternal = new float?(this.Data.碰撞判定延迟);
			}
			return this.CollisionActiveDelayInternal.Value;
		}
	}

	// Token: 0x170021A7 RID: 8615
	// (get) Token: 0x060161CB RID: 90571 RVA: 0x0066D5FC File Offset: 0x0066B7FC
	public float CollisionActiveDuration
	{
		get
		{
			if (this.CollisionActiveDurationInternal == null)
			{
				this.CollisionActiveDurationInternal = new float?(this.Data.碰撞判定时长);
			}
			return this.CollisionActiveDurationInternal.Value;
		}
	}

	// Token: 0x170021A8 RID: 8616
	// (get) Token: 0x060161CC RID: 90572 RVA: 0x0066D62C File Offset: 0x0066B82C
	public EBulletSyncTypeTs SyncType
	{
		get
		{
			if (this.SyncTypeInternal == null)
			{
				this.SyncTypeInternal = new EBulletSyncTypeTs?((EBulletSyncTypeTs)this.Data.网络同步类型);
			}
			return this.SyncTypeInternal.Value;
		}
	}

	// Token: 0x170021A9 RID: 8617
	// (get) Token: 0x060161CD RID: 90573 RVA: 0x0066D661 File Offset: 0x0066B861
	public FName BeHitEffect
	{
		get
		{
			if (!this.BeHitEffectInit)
			{
				this.BeHitEffectInit = true;
				this.BeHitEffectInternal = new FName?(this.Data.被击效果);
			}
			return this.BeHitEffectInternal.Value;
		}
	}

	// Token: 0x170021AA RID: 8618
	// (get) Token: 0x060161CE RID: 90574 RVA: 0x0066D694 File Offset: 0x0066B894
	[Nullable(2)]
	public FName[] MultiBeHitEffect
	{
		[NullableContext(2)]
		get
		{
			if (!this.MultiBeHitEffectInit)
			{
				this.MultiBeHitEffectInit = true;
				TArray<FName> 多被击效果 = this.Data.多被击效果;
				int num = 多被击效果.Num();
				if (num > 0)
				{
					this.MultiBeHitEffectInternal = new FName[num];
					for (int i = 0; i < num; i++)
					{
						this.MultiBeHitEffectInternal[i] = 多被击效果.Get(i);
					}
				}
			}
			return this.MultiBeHitEffectInternal;
		}
	}

	// Token: 0x170021AB RID: 8619
	// (get) Token: 0x060161CF RID: 90575 RVA: 0x0066D6F8 File Offset: 0x0066B8F8
	public Vector BornDistLimit
	{
		get
		{
			if (this.BornDistLimitInternal == null)
			{
				this.BornDistLimitInternal = Vector.Create(this.Data.限制生成距离);
			}
			return this.BornDistLimitInternal;
		}
	}

	// Token: 0x170021AC RID: 8620
	// (get) Token: 0x060161D0 RID: 90576 RVA: 0x0066D723 File Offset: 0x0066B923
	public int BanHitTagId
	{
		get
		{
			this.InitBanHitTag();
			return this.BanHitTagIdInternal;
		}
	}

	// Token: 0x060161D1 RID: 90577 RVA: 0x0066D734 File Offset: 0x0066B934
	private void InitBanHitTag()
	{
		if (!this.BanHitTagInit)
		{
			this.BanHitTagInit = true;
			FGameplayTag 禁止命中Tag = this.Data.禁止命中Tag;
			if (!禁止命中Tag.TagName.IsNone())
			{
				this.BanHitTagIdInternal = 禁止命中Tag.TagId();
				return;
			}
			this.BanHitTagIdInternal = 0;
		}
	}

	// Token: 0x170021AD RID: 8621
	// (get) Token: 0x060161D2 RID: 90578 RVA: 0x0066D77E File Offset: 0x0066B97E
	public bool DebugShowProgress
	{
		get
		{
			if (this.DebugShowProgressInternal == null)
			{
				this.DebugShowProgressInternal = new bool?(this.Data.Debug显示子弹进度);
			}
			return this.DebugShowProgressInternal.Value;
		}
	}

	// Token: 0x170021AE RID: 8622
	// (get) Token: 0x060161D3 RID: 90579 RVA: 0x0066D7AE File Offset: 0x0066B9AE
	public bool BigRangeHitSceneItem
	{
		get
		{
			if (this.BigRangeHitSceneItemInternal == null)
			{
				this.BigRangeHitSceneItemInternal = new bool?(this.Data.大范围子弹对场景物件生效);
			}
			return this.BigRangeHitSceneItemInternal.Value;
		}
	}

	// Token: 0x170021AF RID: 8623
	// (get) Token: 0x060161D4 RID: 90580 RVA: 0x0066D7DE File Offset: 0x0066B9DE
	public int HitActorType
	{
		get
		{
			if (this.HitActorTypeInternal == null)
			{
				this.HitActorTypeInternal = new int?((int)this.Data.命中实体类型);
			}
			return this.HitActorTypeInternal.Value;
		}
	}

	// Token: 0x170021B0 RID: 8624
	// (get) Token: 0x060161D5 RID: 90581 RVA: 0x0066D813 File Offset: 0x0066BA13
	public int BigRangeSearchType
	{
		get
		{
			if (this.BigRangeSearchTypeInternal == null)
			{
				this.BigRangeSearchTypeInternal = new int?(this.Data.大范围子弹检测方式);
			}
			return this.BigRangeSearchTypeInternal.Value;
		}
	}

	// Token: 0x170021B1 RID: 8625
	// (get) Token: 0x060161D6 RID: 90582 RVA: 0x0066D843 File Offset: 0x0066BA43
	public bool IsRandomVictim
	{
		get
		{
			if (this.IsRandomVictimInternal == null)
			{
				this.IsRandomVictimInternal = new bool?(this.Data.IsRandomVictim);
			}
			return this.IsRandomVictimInternal.Value;
		}
	}

	// Token: 0x060161D7 RID: 90583 RVA: 0x0066D873 File Offset: 0x0066BA73
	public BulletDataBase(SReBulletDataBase data)
	{
		this.Data = data;
	}

	// Token: 0x060161D8 RID: 90584 RVA: 0x0066D890 File Offset: 0x0066BA90
	public bool Preload()
	{
		this.InitBulletCamp();
		this.InitBornTag();
		this.InitHitConditionTag();
		this.InitBanHitTag();
		Vector centerOffset = this.CenterOffset;
		float interval = this.Interval;
		bool shareCounter = this.ShareCounter;
		Vector bornPosition = this.BornPosition;
		EPositionStandard bornPositionStandard = this.BornPositionStandard;
		Vector bornPositionRandom = this.BornPositionRandom;
		Vector size = this.Size;
		Rotator rotator = this.Rotator;
		int hitType = this.HitType;
		EBulletShape shape = this.Shape;
		int tagId = this.TagId;
		float duration = this.Duration;
		float collisionActiveDelay = this.CollisionActiveDelay;
		float collisionActiveDuration = this.CollisionActiveDuration;
		EBulletSyncTypeTs syncType = this.SyncType;
		Vector bornDistLimit = this.BornDistLimit;
		int hitActorType = this.HitActorType;
		return true;
	}

	// Token: 0x0400B986 RID: 47494
	private readonly SReBulletDataBase Data;

	// Token: 0x0400B987 RID: 47495
	private bool? IgnoreGradientInternal;

	// Token: 0x0400B988 RID: 47496
	[Nullable(2)]
	private Vector CenterOffsetInternal;

	// Token: 0x0400B989 RID: 47497
	private long? DamageIdInternal;

	// Token: 0x0400B98A RID: 47498
	private bool InitedMultiDamageId;

	// Token: 0x0400B98B RID: 47499
	[Nullable(2)]
	private long[] MultiDamageIdInternal;

	// Token: 0x0400B98C RID: 47500
	private bool? EnablePartHitAudioInternal;

	// Token: 0x0400B98D RID: 47501
	private bool? IntervalAfterHitInternal;

	// Token: 0x0400B98E RID: 47502
	private float? IntervalInternal;

	// Token: 0x0400B98F RID: 47503
	private bool? ShareCounterInternal;

	// Token: 0x0400B990 RID: 47504
	[Nullable(2)]
	private Vector BornPositionInternal;

	// Token: 0x0400B991 RID: 47505
	private EPositionStandard? BornPositionStandardInternal;

	// Token: 0x0400B992 RID: 47506
	[Nullable(2)]
	private Vector BornPositionRandomInternal;

	// Token: 0x0400B993 RID: 47507
	[Nullable(2)]
	private Vector SizeInternal;

	// Token: 0x0400B994 RID: 47508
	public bool IsOversizeForTrace;

	// Token: 0x0400B995 RID: 47509
	[Nullable(2)]
	private Rotator RotatorInternal;

	// Token: 0x0400B996 RID: 47510
	private int? VictimCountInternal;

	// Token: 0x0400B997 RID: 47511
	private int HitConditionTagIdInternal;

	// Token: 0x0400B998 RID: 47512
	private bool HitConditionTagInit;

	// Token: 0x0400B999 RID: 47513
	private int? HitTypeInternal;

	// Token: 0x0400B99A RID: 47514
	private bool DaHitTypePresetInit;

	// Token: 0x0400B99B RID: 47515
	private FName DaHitTypePresetInternal = FName.NAME_None;

	// Token: 0x0400B99C RID: 47516
	public int? BulletCamp;

	// Token: 0x0400B99D RID: 47517
	private EBulletRelativeDir? RelativeDirectionInternal;

	// Token: 0x0400B99E RID: 47518
	private EBulletShape? ShapeInternal;

	// Token: 0x0400B99F RID: 47519
	[Nullable(2)]
	private Rotator AttackDirectionInternal;

	// Token: 0x0400B9A0 RID: 47520
	private int TagIdInternal;

	// Token: 0x0400B9A1 RID: 47521
	private bool TagInit;

	// Token: 0x0400B9A2 RID: 47522
	[Nullable(2)]
	private int[] BornRequireTagIdsInternal;

	// Token: 0x0400B9A3 RID: 47523
	[Nullable(2)]
	private int[] BornForbidTagIdsInternal;

	// Token: 0x0400B9A4 RID: 47524
	private bool BornTagInit;

	// Token: 0x0400B9A5 RID: 47525
	private bool HitEffectWeaknessInit;

	// Token: 0x0400B9A6 RID: 47526
	private FName? HitEffectWeaknessInternal;

	// Token: 0x0400B9A7 RID: 47527
	private bool MultiHitEffectWeaknessInit;

	// Token: 0x0400B9A8 RID: 47528
	[Nullable(2)]
	private FName[] MultiHitEffectWeaknessInternal;

	// Token: 0x0400B9A9 RID: 47529
	private int? HitCountMaxInternal;

	// Token: 0x0400B9AA RID: 47530
	private bool? DestroyOnSkillEndInternal;

	// Token: 0x0400B9AB RID: 47531
	private float? DurationInternal;

	// Token: 0x0400B9AC RID: 47532
	private bool BlackboardKeyInit;

	// Token: 0x0400B9AD RID: 47533
	[Nullable(2)]
	private string BlackboardKeyInternal;

	// Token: 0x0400B9AE RID: 47534
	private bool? ContinuesCollisionInternal;

	// Token: 0x0400B9AF RID: 47535
	private bool? StickGroundInternal;

	// Token: 0x0400B9B0 RID: 47536
	private bool? StickWaterInternal;

	// Token: 0x0400B9B1 RID: 47537
	private bool? NotFollowMovePlatformInternal;

	// Token: 0x0400B9B2 RID: 47538
	private float? StickTraceLenInternal;

	// Token: 0x0400B9B3 RID: 47539
	private float? StickGroundAngleLimitInternal;

	// Token: 0x0400B9B4 RID: 47540
	private int? HitCountPerVictimInternal;

	// Token: 0x0400B9B5 RID: 47541
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EBulletBaseSpecificParam, string> SpecialParamsInternal;

	// Token: 0x0400B9B6 RID: 47542
	private float? CollisionActiveDelayInternal;

	// Token: 0x0400B9B7 RID: 47543
	private float? CollisionActiveDurationInternal;

	// Token: 0x0400B9B8 RID: 47544
	private EBulletSyncTypeTs? SyncTypeInternal;

	// Token: 0x0400B9B9 RID: 47545
	private bool BeHitEffectInit;

	// Token: 0x0400B9BA RID: 47546
	private FName? BeHitEffectInternal;

	// Token: 0x0400B9BB RID: 47547
	private bool MultiBeHitEffectInit;

	// Token: 0x0400B9BC RID: 47548
	[Nullable(2)]
	private FName[] MultiBeHitEffectInternal;

	// Token: 0x0400B9BD RID: 47549
	[Nullable(2)]
	private Vector BornDistLimitInternal;

	// Token: 0x0400B9BE RID: 47550
	private int BanHitTagIdInternal;

	// Token: 0x0400B9BF RID: 47551
	private bool BanHitTagInit;

	// Token: 0x0400B9C0 RID: 47552
	private bool? DebugShowProgressInternal;

	// Token: 0x0400B9C1 RID: 47553
	private bool? BigRangeHitSceneItemInternal;

	// Token: 0x0400B9C2 RID: 47554
	private int? HitActorTypeInternal;

	// Token: 0x0400B9C3 RID: 47555
	private int? BigRangeSearchTypeInternal;

	// Token: 0x0400B9C4 RID: 47556
	private bool? IsRandomVictimInternal;
}
