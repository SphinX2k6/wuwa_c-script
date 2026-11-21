using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002307 RID: 8967
[NullableContext(1)]
[Nullable(0)]
public class BulletDataLogic
{
	// Token: 0x170021C8 RID: 8648
	// (get) Token: 0x060161F5 RID: 90613 RVA: 0x0066DF10 File Offset: 0x0066C110
	public string ComponentName
	{
		get
		{
			if (!this.ComponentNameInit)
			{
				this.ComponentNameInit = true;
				this.ComponentNameInternal = this.Data.只碰撞胶囊体;
			}
			return this.ComponentNameInternal;
		}
	}

	// Token: 0x170021C9 RID: 8649
	// (get) Token: 0x060161F6 RID: 90614 RVA: 0x0066DF38 File Offset: 0x0066C138
	public EBulletHitDirectionType HitDirectionType
	{
		get
		{
			if (this.HitDirectionTypeInternal == null)
			{
				this.HitDirectionTypeInternal = new EBulletHitDirectionType?((EBulletHitDirectionType)this.Data.子弹受击类型角度判断);
			}
			return this.HitDirectionTypeInternal.Value;
		}
	}

	// Token: 0x170021CA RID: 8650
	// (get) Token: 0x060161F7 RID: 90615 RVA: 0x0066DF6D File Offset: 0x0066C16D
	public bool DestroyOnHitCharacter
	{
		get
		{
			if (this.DestroyOnHitCharacterInternal == null)
			{
				this.DestroyOnHitCharacterInternal = new bool?(this.Data.子弹碰撞单位销毁);
			}
			return this.DestroyOnHitCharacterInternal.Value;
		}
	}

	// Token: 0x170021CB RID: 8651
	// (get) Token: 0x060161F8 RID: 90616 RVA: 0x0066DF9D File Offset: 0x0066C19D
	public bool DestroyOnHitObstacle
	{
		get
		{
			if (this.DestroyOnHitObstacleInternal == null)
			{
				this.DestroyOnHitObstacleInternal = new bool?(this.Data.子弹碰撞障碍销毁);
			}
			return this.DestroyOnHitObstacleInternal.Value;
		}
	}

	// Token: 0x170021CC RID: 8652
	// (get) Token: 0x060161F9 RID: 90617 RVA: 0x0066DFCD File Offset: 0x0066C1CD
	public FName ProfileName
	{
		get
		{
			if (!this.ProfileNameInit)
			{
				this.ProfileNameInit = true;
				this.ProfileNameInternal = new FName?(this.Data.子弹碰撞预设);
			}
			return this.ProfileNameInternal.Value;
		}
	}

	// Token: 0x170021CD RID: 8653
	// (get) Token: 0x060161FA RID: 90618 RVA: 0x0066DFFF File Offset: 0x0066C1FF
	public EBulletType Type
	{
		get
		{
			if (this.TypeInternal == null)
			{
				this.TypeInternal = new EBulletType?((EBulletType)this.Data.子弹类型);
			}
			return this.TypeInternal.Value;
		}
	}

	// Token: 0x170021CE RID: 8654
	// (get) Token: 0x060161FB RID: 90619 RVA: 0x0066E034 File Offset: 0x0066C234
	public bool InteractWithWater
	{
		get
		{
			if (this.InteractWithWaterInternal == null)
			{
				this.InteractWithWaterInternal = new bool?(this.Data.开启水面交互);
			}
			return this.InteractWithWaterInternal.Value;
		}
	}

	// Token: 0x170021CF RID: 8655
	// (get) Token: 0x060161FC RID: 90620 RVA: 0x0066E064 File Offset: 0x0066C264
	public bool InteractWithAirWall
	{
		get
		{
			if (this.InteractWithAirWallInternal == null)
			{
				this.InteractWithAirWallInternal = new bool?(this.Data.开启空气墙交互);
			}
			return this.InteractWithAirWallInternal.Value;
		}
	}

	// Token: 0x170021D0 RID: 8656
	// (get) Token: 0x060161FD RID: 90621 RVA: 0x0066E094 File Offset: 0x0066C294
	public int ReboundChannel
	{
		get
		{
			if (this.ReboundChannelInternal == null)
			{
				this.ReboundChannelInternal = new int?(this.Data.弹反通道);
			}
			return this.ReboundChannelInternal.Value;
		}
	}

	// Token: 0x170021D1 RID: 8657
	// (get) Token: 0x060161FE RID: 90622 RVA: 0x0066E0C4 File Offset: 0x0066C2C4
	public bool CanCounterAttack
	{
		get
		{
			if (this.CanCounterAttackInternal == null)
			{
				this.CanCounterAttackInternal = new bool?(this.Data.是否可以触发拼刀);
			}
			return this.CanCounterAttackInternal.Value;
		}
	}

	// Token: 0x170021D2 RID: 8658
	// (get) Token: 0x060161FF RID: 90623 RVA: 0x0066E0F4 File Offset: 0x0066C2F4
	public bool CounterAttackIgnoreAngle
	{
		get
		{
			if (this.CounterAttackIgnoreAngleInternal == null)
			{
				this.CounterAttackIgnoreAngleInternal = new bool?(this.Data.拼刀忽略角度);
			}
			return this.CounterAttackIgnoreAngleInternal.Value;
		}
	}

	// Token: 0x170021D3 RID: 8659
	// (get) Token: 0x06016200 RID: 90624 RVA: 0x0066E124 File Offset: 0x0066C324
	public bool CounterAttackIgnoreDist
	{
		get
		{
			if (this.CounterAttackIgnoreDistanceInternal == null)
			{
				this.CounterAttackIgnoreDistanceInternal = new bool?(this.Data.拼刀忽略距离);
			}
			return this.CounterAttackIgnoreDistanceInternal.Value;
		}
	}

	// Token: 0x170021D4 RID: 8660
	// (get) Token: 0x06016201 RID: 90625 RVA: 0x0066E154 File Offset: 0x0066C354
	public bool CanBreakWindupAttack
	{
		get
		{
			if (this.CanBreakWindupAttackInternal == null)
			{
				this.CanBreakWindupAttackInternal = new bool?(this.Data.触发前摇拼刀);
			}
			return this.CanBreakWindupAttackInternal.Value;
		}
	}

	// Token: 0x170021D5 RID: 8661
	// (get) Token: 0x06016202 RID: 90626 RVA: 0x0066E184 File Offset: 0x0066C384
	public bool CanVisionCounterAttack
	{
		get
		{
			if (this.CanVisionCounterAttackInternal == null)
			{
				this.CanVisionCounterAttackInternal = new bool?(this.Data.是否可以触发对策);
			}
			return this.CanVisionCounterAttackInternal.Value;
		}
	}

	// Token: 0x170021D6 RID: 8662
	// (get) Token: 0x06016203 RID: 90627 RVA: 0x0066E1B4 File Offset: 0x0066C3B4
	public bool CanDodge
	{
		get
		{
			if (this.CanDodgeInternal == null)
			{
				this.CanDodgeInternal = new bool?(this.Data.是否可以触发极限闪避);
			}
			return this.CanDodgeInternal.Value;
		}
	}

	// Token: 0x170021D7 RID: 8663
	// (get) Token: 0x06016204 RID: 90628 RVA: 0x0066E1E4 File Offset: 0x0066C3E4
	public bool DestroyOnCountZero
	{
		get
		{
			if (this.DestroyOnCountZeroInternal == null)
			{
				this.DestroyOnCountZeroInternal = new bool?(this.Data.次数为0时销毁);
			}
			return this.DestroyOnCountZeroInternal.Value;
		}
	}

	// Token: 0x170021D8 RID: 8664
	// (get) Token: 0x06016205 RID: 90629 RVA: 0x0066E214 File Offset: 0x0066C414
	public int[] PresentTagIds
	{
		get
		{
			this.InitPresetTag();
			return this.PresentTagIdsInternal;
		}
	}

	// Token: 0x06016206 RID: 90630 RVA: 0x0066E224 File Offset: 0x0066C424
	private void InitPresetTag()
	{
		if (!this.PresetTagInit)
		{
			this.PresetTagInit = true;
			List<int> list = new List<int>();
			TArray<FGameplayTag> gameplayTags = this.Data.预设标签.GameplayTags;
			int num = gameplayTags.Num();
			for (int i = 0; i < num; i++)
			{
				if (gameplayTags.IsValidIndex(i))
				{
					FGameplayTag tag = gameplayTags.Get(i);
					if (!tag.TagName.IsNone())
					{
						list.Add(tag.TagId());
					}
				}
			}
			this.PresentTagIdsInternal = list.ToArray();
		}
	}

	// Token: 0x170021D9 RID: 8665
	// (get) Token: 0x06016207 RID: 90631 RVA: 0x0066E2A3 File Offset: 0x0066C4A3
	public bool IgnoreWater
	{
		get
		{
			if (this.IgnoreWaterInternal == null)
			{
				this.IgnoreWaterInternal = new bool?(this.Data.忽略水体);
			}
			return this.IgnoreWaterInternal.Value;
		}
	}

	// Token: 0x170021DA RID: 8666
	// (get) Token: 0x06016208 RID: 90632 RVA: 0x0066E2D3 File Offset: 0x0066C4D3
	public bool DestroyOnFrozen
	{
		get
		{
			if (this.DestroyOnFrozenInternal == null)
			{
				this.DestroyOnFrozenInternal = new bool?(this.Data.冰冻时销毁);
			}
			return this.DestroyOnFrozenInternal.Value;
		}
	}

	// Token: 0x06016209 RID: 90633 RVA: 0x0066E304 File Offset: 0x0066C504
	public BulletDataLogic(TSoftObjectPtr<BulletLogicType_C> data)
	{
		string path = data.ToAssetPathName();
		this.Data = ResourceSystem.Instance.Load<BulletLogicType_C>(path, "js_undefined");
		BulletLogicType_C data2 = this.Data;
	}

	// Token: 0x0601620A RID: 90634 RVA: 0x0066E33B File Offset: 0x0066C53B
	public void Preload()
	{
		this.InitPresetTag();
	}

	// Token: 0x0400B9E5 RID: 47589
	[Nullable(2)]
	public readonly BulletLogicType_C Data;

	// Token: 0x0400B9E6 RID: 47590
	[Nullable(2)]
	private string ComponentNameInternal;

	// Token: 0x0400B9E7 RID: 47591
	private bool ComponentNameInit;

	// Token: 0x0400B9E8 RID: 47592
	private EBulletHitDirectionType? HitDirectionTypeInternal;

	// Token: 0x0400B9E9 RID: 47593
	private bool? DestroyOnHitCharacterInternal;

	// Token: 0x0400B9EA RID: 47594
	private bool? DestroyOnHitObstacleInternal;

	// Token: 0x0400B9EB RID: 47595
	private FName? ProfileNameInternal;

	// Token: 0x0400B9EC RID: 47596
	private bool ProfileNameInit;

	// Token: 0x0400B9ED RID: 47597
	private EBulletType? TypeInternal;

	// Token: 0x0400B9EE RID: 47598
	private bool? InteractWithWaterInternal;

	// Token: 0x0400B9EF RID: 47599
	private bool? InteractWithAirWallInternal;

	// Token: 0x0400B9F0 RID: 47600
	private int? ReboundChannelInternal;

	// Token: 0x0400B9F1 RID: 47601
	private bool? CanCounterAttackInternal;

	// Token: 0x0400B9F2 RID: 47602
	private bool? CounterAttackIgnoreAngleInternal;

	// Token: 0x0400B9F3 RID: 47603
	private bool? CounterAttackIgnoreDistanceInternal;

	// Token: 0x0400B9F4 RID: 47604
	private bool? CanBreakWindupAttackInternal;

	// Token: 0x0400B9F5 RID: 47605
	private bool? CanVisionCounterAttackInternal;

	// Token: 0x0400B9F6 RID: 47606
	private bool? CanDodgeInternal;

	// Token: 0x0400B9F7 RID: 47607
	private bool? DestroyOnCountZeroInternal;

	// Token: 0x0400B9F8 RID: 47608
	[Nullable(2)]
	private int[] PresentTagIdsInternal;

	// Token: 0x0400B9F9 RID: 47609
	private bool PresetTagInit;

	// Token: 0x0400B9FA RID: 47610
	private bool? IgnoreWaterInternal;

	// Token: 0x0400B9FB RID: 47611
	private bool? DestroyOnFrozenInternal;
}
