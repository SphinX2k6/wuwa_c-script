using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02002DAD RID: 11693
[NullableContext(1)]
[Nullable(0)]
public class BulletDataLogic
{
	// Token: 0x1700216C RID: 8556
	// (get) Token: 0x0601894D RID: 100685 RVA: 0x00648030 File Offset: 0x00646230
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

	// Token: 0x1700216D RID: 8557
	// (get) Token: 0x0601894E RID: 100686 RVA: 0x00648058 File Offset: 0x00646258
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

	// Token: 0x1700216E RID: 8558
	// (get) Token: 0x0601894F RID: 100687 RVA: 0x0064808D File Offset: 0x0064628D
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

	// Token: 0x1700216F RID: 8559
	// (get) Token: 0x06018950 RID: 100688 RVA: 0x006480BD File Offset: 0x006462BD
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

	// Token: 0x17002170 RID: 8560
	// (get) Token: 0x06018951 RID: 100689 RVA: 0x006480ED File Offset: 0x006462ED
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

	// Token: 0x17002171 RID: 8561
	// (get) Token: 0x06018952 RID: 100690 RVA: 0x0064811F File Offset: 0x0064631F
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

	// Token: 0x17002172 RID: 8562
	// (get) Token: 0x06018953 RID: 100691 RVA: 0x00648154 File Offset: 0x00646354
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

	// Token: 0x17002173 RID: 8563
	// (get) Token: 0x06018954 RID: 100692 RVA: 0x00648184 File Offset: 0x00646384
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

	// Token: 0x17002174 RID: 8564
	// (get) Token: 0x06018955 RID: 100693 RVA: 0x006481B4 File Offset: 0x006463B4
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

	// Token: 0x17002175 RID: 8565
	// (get) Token: 0x06018956 RID: 100694 RVA: 0x006481E4 File Offset: 0x006463E4
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

	// Token: 0x17002176 RID: 8566
	// (get) Token: 0x06018957 RID: 100695 RVA: 0x00648214 File Offset: 0x00646414
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

	// Token: 0x17002177 RID: 8567
	// (get) Token: 0x06018958 RID: 100696 RVA: 0x00648244 File Offset: 0x00646444
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

	// Token: 0x17002178 RID: 8568
	// (get) Token: 0x06018959 RID: 100697 RVA: 0x00648274 File Offset: 0x00646474
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

	// Token: 0x17002179 RID: 8569
	// (get) Token: 0x0601895A RID: 100698 RVA: 0x006482A4 File Offset: 0x006464A4
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

	// Token: 0x1700217A RID: 8570
	// (get) Token: 0x0601895B RID: 100699 RVA: 0x006482D4 File Offset: 0x006464D4
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

	// Token: 0x1700217B RID: 8571
	// (get) Token: 0x0601895C RID: 100700 RVA: 0x00648304 File Offset: 0x00646504
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

	// Token: 0x1700217C RID: 8572
	// (get) Token: 0x0601895D RID: 100701 RVA: 0x00648334 File Offset: 0x00646534
	public int[] PresentTagIds
	{
		get
		{
			this.InitPresetTag();
			return this.PresentTagIdsInternal;
		}
	}

	// Token: 0x0601895E RID: 100702 RVA: 0x00648344 File Offset: 0x00646544
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

	// Token: 0x1700217D RID: 8573
	// (get) Token: 0x0601895F RID: 100703 RVA: 0x006483C3 File Offset: 0x006465C3
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

	// Token: 0x1700217E RID: 8574
	// (get) Token: 0x06018960 RID: 100704 RVA: 0x006483F3 File Offset: 0x006465F3
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

	// Token: 0x06018961 RID: 100705 RVA: 0x00648424 File Offset: 0x00646624
	public BulletDataLogic(TSoftObjectPtr<BulletLogicType_C> data)
	{
		string text = data.ToAssetPathName();
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			if (!string.IsNullOrEmpty(text) && !(text == "None"))
			{
				TSoftObjectPtr<UObject> tsoftObjectPtr = data.As<UObject>();
				if (UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
				{
					goto IL_6F;
				}
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Bullet;
			Entity entity = null;
			string message = "子弹配置出错，没有配置逻辑设置.预设";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置路径", text ?? "");
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		IL_6F:
		this.Data = ResourceSystem.Instance.Load<BulletLogicType_C>(text, "js_undefined");
		if (this.Data == null)
		{
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Bullet;
				Entity entity2 = null;
				string message2 = "子弹配置出错，逻辑设置.预设 资源加载失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("配置路径", text ?? "");
				instance2.Error(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return;
		}
		if (Info.Instance.IsBuildDevelopmentOrDebug && !this.ProfileName.ToString().ToLower().StartsWith("bullet_"))
		{
			CombatLog instance3 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.Bullet;
			Entity entity3 = null;
			string message3 = "子弹配置出错，逻辑设置.预设.子弹碰撞预设 填写的值不对";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("配置路径", text);
			instance3.Error(flag3, entity3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		}
	}

	// Token: 0x06018962 RID: 100706 RVA: 0x00648552 File Offset: 0x00646752
	public void Preload()
	{
		this.InitPresetTag();
	}

	// Token: 0x0400B66B RID: 46699
	[Nullable(2)]
	public readonly BulletLogicType_C Data;

	// Token: 0x0400B66C RID: 46700
	[Nullable(2)]
	private string ComponentNameInternal;

	// Token: 0x0400B66D RID: 46701
	private bool ComponentNameInit;

	// Token: 0x0400B66E RID: 46702
	private EBulletHitDirectionType? HitDirectionTypeInternal;

	// Token: 0x0400B66F RID: 46703
	private bool? DestroyOnHitCharacterInternal;

	// Token: 0x0400B670 RID: 46704
	private bool? DestroyOnHitObstacleInternal;

	// Token: 0x0400B671 RID: 46705
	private FName? ProfileNameInternal;

	// Token: 0x0400B672 RID: 46706
	private bool ProfileNameInit;

	// Token: 0x0400B673 RID: 46707
	private EBulletType? TypeInternal;

	// Token: 0x0400B674 RID: 46708
	private bool? InteractWithWaterInternal;

	// Token: 0x0400B675 RID: 46709
	private bool? InteractWithAirWallInternal;

	// Token: 0x0400B676 RID: 46710
	private int? ReboundChannelInternal;

	// Token: 0x0400B677 RID: 46711
	private bool? CanCounterAttackInternal;

	// Token: 0x0400B678 RID: 46712
	private bool? CounterAttackIgnoreAngleInternal;

	// Token: 0x0400B679 RID: 46713
	private bool? CounterAttackIgnoreDistanceInternal;

	// Token: 0x0400B67A RID: 46714
	private bool? CanBreakWindupAttackInternal;

	// Token: 0x0400B67B RID: 46715
	private bool? CanVisionCounterAttackInternal;

	// Token: 0x0400B67C RID: 46716
	private bool? CanDodgeInternal;

	// Token: 0x0400B67D RID: 46717
	private bool? DestroyOnCountZeroInternal;

	// Token: 0x0400B67E RID: 46718
	[Nullable(2)]
	private int[] PresentTagIdsInternal;

	// Token: 0x0400B67F RID: 46719
	private bool PresetTagInit;

	// Token: 0x0400B680 RID: 46720
	private bool? IgnoreWaterInternal;

	// Token: 0x0400B681 RID: 46721
	private bool? DestroyOnFrozenInternal;
}
