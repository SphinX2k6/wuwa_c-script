using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DA9 RID: 11689
[NullableContext(1)]
[Nullable(0)]
public class BulletDataBase
{
	// Token: 0x17002126 RID: 8486
	// (get) Token: 0x060188FA RID: 100602 RVA: 0x00646E0D File Offset: 0x0064500D
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

	// Token: 0x17002127 RID: 8487
	// (get) Token: 0x060188FB RID: 100603 RVA: 0x00646E3D File Offset: 0x0064503D
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

	// Token: 0x17002128 RID: 8488
	// (get) Token: 0x060188FC RID: 100604 RVA: 0x00646E68 File Offset: 0x00645068
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

	// Token: 0x17002129 RID: 8489
	// (get) Token: 0x060188FD RID: 100605 RVA: 0x00646E98 File Offset: 0x00645098
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

	// Token: 0x1700212A RID: 8490
	// (get) Token: 0x060188FE RID: 100606 RVA: 0x00646EF8 File Offset: 0x006450F8
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

	// Token: 0x1700212B RID: 8491
	// (get) Token: 0x060188FF RID: 100607 RVA: 0x00646F28 File Offset: 0x00645128
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

	// Token: 0x1700212C RID: 8492
	// (get) Token: 0x06018900 RID: 100608 RVA: 0x00646F58 File Offset: 0x00645158
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

	// Token: 0x1700212D RID: 8493
	// (get) Token: 0x06018901 RID: 100609 RVA: 0x00646F88 File Offset: 0x00645188
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

	// Token: 0x1700212E RID: 8494
	// (get) Token: 0x06018902 RID: 100610 RVA: 0x00646FB8 File Offset: 0x006451B8
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

	// Token: 0x1700212F RID: 8495
	// (get) Token: 0x06018903 RID: 100611 RVA: 0x00646FE3 File Offset: 0x006451E3
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

	// Token: 0x17002130 RID: 8496
	// (get) Token: 0x06018904 RID: 100612 RVA: 0x00647018 File Offset: 0x00645218
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

	// Token: 0x17002131 RID: 8497
	// (get) Token: 0x06018905 RID: 100613 RVA: 0x00647043 File Offset: 0x00645243
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

	// Token: 0x17002132 RID: 8498
	// (get) Token: 0x06018906 RID: 100614 RVA: 0x0064706E File Offset: 0x0064526E
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

	// Token: 0x17002133 RID: 8499
	// (get) Token: 0x06018907 RID: 100615 RVA: 0x00647099 File Offset: 0x00645299
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

	// Token: 0x17002134 RID: 8500
	// (get) Token: 0x06018908 RID: 100616 RVA: 0x006470C9 File Offset: 0x006452C9
	public int HitConditionTagId
	{
		get
		{
			this.InitHitConditionTag();
			return this.HitConditionTagIdInternal;
		}
	}

	// Token: 0x06018909 RID: 100617 RVA: 0x006470D8 File Offset: 0x006452D8
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

	// Token: 0x17002135 RID: 8501
	// (get) Token: 0x0601890A RID: 100618 RVA: 0x00647122 File Offset: 0x00645322
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

	// Token: 0x17002136 RID: 8502
	// (get) Token: 0x0601890B RID: 100619 RVA: 0x00647157 File Offset: 0x00645357
	public FName DaHitTypePreset
	{
		get
		{
			this.InitBulletCamp();
			return this.DaHitTypePresetInternal;
		}
	}

	// Token: 0x0601890C RID: 100620 RVA: 0x00647168 File Offset: 0x00645368
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

	// Token: 0x17002137 RID: 8503
	// (get) Token: 0x0601890D RID: 100621 RVA: 0x006471ED File Offset: 0x006453ED
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

	// Token: 0x17002138 RID: 8504
	// (get) Token: 0x0601890E RID: 100622 RVA: 0x00647222 File Offset: 0x00645422
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

	// Token: 0x17002139 RID: 8505
	// (get) Token: 0x0601890F RID: 100623 RVA: 0x00647257 File Offset: 0x00645457
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

	// Token: 0x1700213A RID: 8506
	// (get) Token: 0x06018910 RID: 100624 RVA: 0x00647282 File Offset: 0x00645482
	public int TagId
	{
		get
		{
			this.InitTag();
			return this.TagIdInternal;
		}
	}

	// Token: 0x06018911 RID: 100625 RVA: 0x00647290 File Offset: 0x00645490
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

	// Token: 0x1700213B RID: 8507
	// (get) Token: 0x06018912 RID: 100626 RVA: 0x006472DB File Offset: 0x006454DB
	public int[] BornRequireTagIds
	{
		get
		{
			this.InitBornTag();
			return this.BornRequireTagIdsInternal;
		}
	}

	// Token: 0x1700213C RID: 8508
	// (get) Token: 0x06018913 RID: 100627 RVA: 0x006472E9 File Offset: 0x006454E9
	public int[] BornForbidTagIds
	{
		get
		{
			this.InitBornTag();
			return this.BornForbidTagIdsInternal;
		}
	}

	// Token: 0x06018914 RID: 100628 RVA: 0x006472F8 File Offset: 0x006454F8
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

	// Token: 0x1700213D RID: 8509
	// (get) Token: 0x06018915 RID: 100629 RVA: 0x006473F3 File Offset: 0x006455F3
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

	// Token: 0x1700213E RID: 8510
	// (get) Token: 0x06018916 RID: 100630 RVA: 0x00647428 File Offset: 0x00645628
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

	// Token: 0x1700213F RID: 8511
	// (get) Token: 0x06018917 RID: 100631 RVA: 0x0064748C File Offset: 0x0064568C
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

	// Token: 0x17002140 RID: 8512
	// (get) Token: 0x06018918 RID: 100632 RVA: 0x006474BC File Offset: 0x006456BC
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

	// Token: 0x17002141 RID: 8513
	// (get) Token: 0x06018919 RID: 100633 RVA: 0x006474EC File Offset: 0x006456EC
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

	// Token: 0x17002142 RID: 8514
	// (get) Token: 0x0601891A RID: 100634 RVA: 0x0064751C File Offset: 0x0064571C
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

	// Token: 0x17002143 RID: 8515
	// (get) Token: 0x0601891B RID: 100635 RVA: 0x00647544 File Offset: 0x00645744
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

	// Token: 0x17002144 RID: 8516
	// (get) Token: 0x0601891C RID: 100636 RVA: 0x00647574 File Offset: 0x00645774
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

	// Token: 0x17002145 RID: 8517
	// (get) Token: 0x0601891D RID: 100637 RVA: 0x006475A4 File Offset: 0x006457A4
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

	// Token: 0x17002146 RID: 8518
	// (get) Token: 0x0601891E RID: 100638 RVA: 0x006475D4 File Offset: 0x006457D4
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

	// Token: 0x17002147 RID: 8519
	// (get) Token: 0x0601891F RID: 100639 RVA: 0x00647604 File Offset: 0x00645804
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

	// Token: 0x17002148 RID: 8520
	// (get) Token: 0x06018920 RID: 100640 RVA: 0x00647634 File Offset: 0x00645834
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

	// Token: 0x17002149 RID: 8521
	// (get) Token: 0x06018921 RID: 100641 RVA: 0x00647664 File Offset: 0x00645864
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

	// Token: 0x1700214A RID: 8522
	// (get) Token: 0x06018922 RID: 100642 RVA: 0x006476EC File Offset: 0x006458EC
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

	// Token: 0x1700214B RID: 8523
	// (get) Token: 0x06018923 RID: 100643 RVA: 0x0064771C File Offset: 0x0064591C
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

	// Token: 0x1700214C RID: 8524
	// (get) Token: 0x06018924 RID: 100644 RVA: 0x0064774C File Offset: 0x0064594C
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

	// Token: 0x1700214D RID: 8525
	// (get) Token: 0x06018925 RID: 100645 RVA: 0x00647781 File Offset: 0x00645981
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

	// Token: 0x1700214E RID: 8526
	// (get) Token: 0x06018926 RID: 100646 RVA: 0x006477B4 File Offset: 0x006459B4
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

	// Token: 0x1700214F RID: 8527
	// (get) Token: 0x06018927 RID: 100647 RVA: 0x00647818 File Offset: 0x00645A18
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

	// Token: 0x17002150 RID: 8528
	// (get) Token: 0x06018928 RID: 100648 RVA: 0x00647843 File Offset: 0x00645A43
	public int BanHitTagId
	{
		get
		{
			this.InitBanHitTag();
			return this.BanHitTagIdInternal;
		}
	}

	// Token: 0x06018929 RID: 100649 RVA: 0x00647854 File Offset: 0x00645A54
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

	// Token: 0x17002151 RID: 8529
	// (get) Token: 0x0601892A RID: 100650 RVA: 0x0064789E File Offset: 0x00645A9E
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

	// Token: 0x17002152 RID: 8530
	// (get) Token: 0x0601892B RID: 100651 RVA: 0x006478CE File Offset: 0x00645ACE
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

	// Token: 0x17002153 RID: 8531
	// (get) Token: 0x0601892C RID: 100652 RVA: 0x006478FE File Offset: 0x00645AFE
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

	// Token: 0x17002154 RID: 8532
	// (get) Token: 0x0601892D RID: 100653 RVA: 0x00647933 File Offset: 0x00645B33
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

	// Token: 0x17002155 RID: 8533
	// (get) Token: 0x0601892E RID: 100654 RVA: 0x00647963 File Offset: 0x00645B63
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

	// Token: 0x0601892F RID: 100655 RVA: 0x00647993 File Offset: 0x00645B93
	public BulletDataBase(SReBulletDataBase data)
	{
		this.Data = data;
	}

	// Token: 0x06018930 RID: 100656 RVA: 0x006479B0 File Offset: 0x00645BB0
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

	// Token: 0x0400B60D RID: 46605
	private readonly SReBulletDataBase Data;

	// Token: 0x0400B60E RID: 46606
	private bool? IgnoreGradientInternal;

	// Token: 0x0400B60F RID: 46607
	[Nullable(2)]
	private Vector CenterOffsetInternal;

	// Token: 0x0400B610 RID: 46608
	private long? DamageIdInternal;

	// Token: 0x0400B611 RID: 46609
	private bool InitedMultiDamageId;

	// Token: 0x0400B612 RID: 46610
	[Nullable(2)]
	private long[] MultiDamageIdInternal;

	// Token: 0x0400B613 RID: 46611
	private bool? EnablePartHitAudioInternal;

	// Token: 0x0400B614 RID: 46612
	private bool? IntervalAfterHitInternal;

	// Token: 0x0400B615 RID: 46613
	private float? IntervalInternal;

	// Token: 0x0400B616 RID: 46614
	private bool? ShareCounterInternal;

	// Token: 0x0400B617 RID: 46615
	[Nullable(2)]
	private Vector BornPositionInternal;

	// Token: 0x0400B618 RID: 46616
	private EPositionStandard? BornPositionStandardInternal;

	// Token: 0x0400B619 RID: 46617
	[Nullable(2)]
	private Vector BornPositionRandomInternal;

	// Token: 0x0400B61A RID: 46618
	[Nullable(2)]
	private Vector SizeInternal;

	// Token: 0x0400B61B RID: 46619
	public bool IsOversizeForTrace;

	// Token: 0x0400B61C RID: 46620
	[Nullable(2)]
	private Rotator RotatorInternal;

	// Token: 0x0400B61D RID: 46621
	private int? VictimCountInternal;

	// Token: 0x0400B61E RID: 46622
	private int HitConditionTagIdInternal;

	// Token: 0x0400B61F RID: 46623
	private bool HitConditionTagInit;

	// Token: 0x0400B620 RID: 46624
	private int? HitTypeInternal;

	// Token: 0x0400B621 RID: 46625
	private bool DaHitTypePresetInit;

	// Token: 0x0400B622 RID: 46626
	private FName DaHitTypePresetInternal = FName.NAME_None;

	// Token: 0x0400B623 RID: 46627
	public int? BulletCamp;

	// Token: 0x0400B624 RID: 46628
	private EBulletRelativeDir? RelativeDirectionInternal;

	// Token: 0x0400B625 RID: 46629
	private EBulletShape? ShapeInternal;

	// Token: 0x0400B626 RID: 46630
	[Nullable(2)]
	private Rotator AttackDirectionInternal;

	// Token: 0x0400B627 RID: 46631
	private int TagIdInternal;

	// Token: 0x0400B628 RID: 46632
	private bool TagInit;

	// Token: 0x0400B629 RID: 46633
	[Nullable(2)]
	private int[] BornRequireTagIdsInternal;

	// Token: 0x0400B62A RID: 46634
	[Nullable(2)]
	private int[] BornForbidTagIdsInternal;

	// Token: 0x0400B62B RID: 46635
	private bool BornTagInit;

	// Token: 0x0400B62C RID: 46636
	private bool HitEffectWeaknessInit;

	// Token: 0x0400B62D RID: 46637
	private FName? HitEffectWeaknessInternal;

	// Token: 0x0400B62E RID: 46638
	private bool MultiHitEffectWeaknessInit;

	// Token: 0x0400B62F RID: 46639
	[Nullable(2)]
	private FName[] MultiHitEffectWeaknessInternal;

	// Token: 0x0400B630 RID: 46640
	private int? HitCountMaxInternal;

	// Token: 0x0400B631 RID: 46641
	private bool? DestroyOnSkillEndInternal;

	// Token: 0x0400B632 RID: 46642
	private float? DurationInternal;

	// Token: 0x0400B633 RID: 46643
	private bool BlackboardKeyInit;

	// Token: 0x0400B634 RID: 46644
	[Nullable(2)]
	private string BlackboardKeyInternal;

	// Token: 0x0400B635 RID: 46645
	private bool? ContinuesCollisionInternal;

	// Token: 0x0400B636 RID: 46646
	private bool? StickGroundInternal;

	// Token: 0x0400B637 RID: 46647
	private bool? StickWaterInternal;

	// Token: 0x0400B638 RID: 46648
	private bool? NotFollowMovePlatformInternal;

	// Token: 0x0400B639 RID: 46649
	private float? StickTraceLenInternal;

	// Token: 0x0400B63A RID: 46650
	private int? HitCountPerVictimInternal;

	// Token: 0x0400B63B RID: 46651
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EBulletBaseSpecificParam, string> SpecialParamsInternal;

	// Token: 0x0400B63C RID: 46652
	private float? CollisionActiveDelayInternal;

	// Token: 0x0400B63D RID: 46653
	private float? CollisionActiveDurationInternal;

	// Token: 0x0400B63E RID: 46654
	private EBulletSyncTypeTs? SyncTypeInternal;

	// Token: 0x0400B63F RID: 46655
	private bool BeHitEffectInit;

	// Token: 0x0400B640 RID: 46656
	private FName? BeHitEffectInternal;

	// Token: 0x0400B641 RID: 46657
	private bool MultiBeHitEffectInit;

	// Token: 0x0400B642 RID: 46658
	[Nullable(2)]
	private FName[] MultiBeHitEffectInternal;

	// Token: 0x0400B643 RID: 46659
	[Nullable(2)]
	private Vector BornDistLimitInternal;

	// Token: 0x0400B644 RID: 46660
	private int BanHitTagIdInternal;

	// Token: 0x0400B645 RID: 46661
	private bool BanHitTagInit;

	// Token: 0x0400B646 RID: 46662
	private bool? DebugShowProgressInternal;

	// Token: 0x0400B647 RID: 46663
	private bool? BigRangeHitSceneItemInternal;

	// Token: 0x0400B648 RID: 46664
	private int? HitActorTypeInternal;

	// Token: 0x0400B649 RID: 46665
	private int? BigRangeSearchTypeInternal;

	// Token: 0x0400B64A RID: 46666
	private bool? IsRandomVictimInternal;
}
