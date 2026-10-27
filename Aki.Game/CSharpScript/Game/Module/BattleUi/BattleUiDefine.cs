using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C70 RID: 23664
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiDefine
	{
		// Token: 0x0603BD14 RID: 245012 RVA: 0x00E4A478 File Offset: 0x00E48678
		// Note: this type is marked as 'beforefieldinit'.
		static BattleUiDefine()
		{
			Dictionary<EElementPowerType, int> dictionary = new Dictionary<EElementPowerType, int>();
			dictionary[EElementPowerType.ElementPower1] = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.冰"];
			dictionary[EElementPowerType.ElementPower2] = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.火"];
			dictionary[EElementPowerType.ElementPower3] = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.雷"];
			dictionary[EElementPowerType.ElementPower4] = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.风"];
			dictionary[EElementPowerType.ElementPower5] = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.光"];
			dictionary[EElementPowerType.ElementPower6] = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.暗"];
			BattleUiDefine.elementTypeToElementTag = dictionary;
			Dictionary<int, EElementPowerType> dictionary2 = new Dictionary<int, EElementPowerType>();
			int key = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.冰"];
			dictionary2[key] = EElementPowerType.ElementPower1;
			int key2 = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.火"];
			dictionary2[key2] = EElementPowerType.ElementPower2;
			int key3 = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.雷"];
			dictionary2[key3] = EElementPowerType.ElementPower3;
			int key4 = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.风"];
			dictionary2[key4] = EElementPowerType.ElementPower4;
			int key5 = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.光"];
			dictionary2[key5] = EElementPowerType.ElementPower5;
			int key6 = GameplayTagDefine.EGameplayTagId["GameplayCue.Common.元素.暗"];
			dictionary2[key6] = EElementPowerType.ElementPower6;
			BattleUiDefine.elementTagToElementType = dictionary2;
			Dictionary<EInputAction, int> dictionary3 = new Dictionary<EInputAction, int>();
			dictionary3[EInputAction.攻击] = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏普攻按键"];
			dictionary3[EInputAction.技能1] = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏技能按键"];
			dictionary3[EInputAction.幻象1] = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏探索幻象按键"];
			dictionary3[EInputAction.幻象2] = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏攻击幻象按键"];
			dictionary3[EInputAction.闪避] = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏冲刺按键"];
			dictionary3[EInputAction.跳跃] = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏跳跃按键"];
			dictionary3[EInputAction.大招] = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏大招按键"];
			BattleUiDefine.hideInputTagMap = dictionary3;
			Dictionary<EBossStateViewType, string> dictionary4 = new Dictionary<EBossStateViewType, string>();
			dictionary4[EBossStateViewType.Common] = "UiItem_BossState_Prefab";
			dictionary4[EBossStateViewType.DoubleBar] = "UiItem_BossStateDouble_Prefab";
			dictionary4[EBossStateViewType.MultiLayer] = "UiItem_BossStateMultiLayer_Prefab";
			BattleUiDefine.bossStateViewResourceIdMap = dictionary4;
		}

		// Token: 0x0401F296 RID: 127638
		public const float DAMAGE_LEFT_RATIO = 0.25f;

		// Token: 0x0401F297 RID: 127639
		public const float DAMAGE_MIDDLE_RATIO = 0.75f;

		// Token: 0x0401F298 RID: 127640
		public const float DAMAGE_RIGHT_RATIO = 1f;

		// Token: 0x0401F299 RID: 127641
		public const int DAMAGE_ANIMATION_MAX_LENGTH = 240;

		// Token: 0x0401F29A RID: 127642
		public const int CURE_DAMAGE_TEXT = 8;

		// Token: 0x0401F29B RID: 127643
		public const int IMMUNITY_DAMAGE_TEXT_ID = 9;

		// Token: 0x0401F29C RID: 127644
		public const int ATK_DAMAGE_TEXT = 10;

		// Token: 0x0401F29D RID: 127645
		public const int SHEILD_COVER_TEXT = 12;

		// Token: 0x0401F29E RID: 127646
		public const string IMMUNITY_DAMAGE_TEXT = "Immune";

		// Token: 0x0401F29F RID: 127647
		public const int SKILL_COOLDOWN_INTERVAL = 100;

		// Token: 0x0401F2A0 RID: 127648
		public const int SKILL_COOLDOWN_DELAY = 100;

		// Token: 0x0401F2A1 RID: 127649
		public const float SKILL_COOLDOWN_LOOP_INTERVAL = 0.1f;

		// Token: 0x0401F2A2 RID: 127650
		public const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x0401F2A3 RID: 127651
		public const int HEAD_STATE_RANGE = 1000000;

		// Token: 0x0401F2A4 RID: 127652
		public const int CHANGE_COOLDOWN_INTERVAL = 100;

		// Token: 0x0401F2A5 RID: 127653
		public const int CHANGE_COOLDOWN_DELAY = 100;

		// Token: 0x0401F2A6 RID: 127654
		public const float CHANGE_COOLDOWN_LOOP_INTERVAL = 0.1f;

		// Token: 0x0401F2A7 RID: 127655
		public const int BE_HIT_DELAY = 5000;

		// Token: 0x0401F2A8 RID: 127656
		public const int DAMAGE_VIEW_OFFSET_MAX_DISTANCE = 640000;

		// Token: 0x0401F2A9 RID: 127657
		public const float DAMAGE_VIEW_OFFSET_MIN_RATIO = 0.2f;

		// Token: 0x0401F2AA RID: 127658
		public const int REFRESH_POSITION_INTERVAL = 1000;

		// Token: 0x0401F2AB RID: 127659
		public const int CLAMP_RANGE = 130;

		// Token: 0x0401F2AC RID: 127660
		public const int INPUT_SKILL_ACTION_NUM = 6;

		// Token: 0x0401F2AD RID: 127661
		public const int SPECIAL_ENERGY_BAR_WIDTH = 440;

		// Token: 0x0401F2AE RID: 127662
		public const float AREAL_BOX_WIETH_A = 35.2f;

		// Token: 0x0401F2AF RID: 127663
		public const float AREAL_BOX_WIETH_B = 123.2f;

		// Token: 0x0401F2B0 RID: 127664
		public const float AREAL_BOX_WIETH_C = 250f;

		// Token: 0x0401F2B1 RID: 127665
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EElementPowerType, int> elementTypeToElementTag;

		// Token: 0x0401F2B2 RID: 127666
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<int, EElementPowerType> elementTagToElementType;

		// Token: 0x0401F2B3 RID: 127667
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EInputAction, int> hideInputTagMap;

		// Token: 0x0401F2B4 RID: 127668
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EBossStateViewType, string> bossStateViewResourceIdMap;

		// Token: 0x0401F2B5 RID: 127669
		public const int DELAY_REFRESH_ELEMENT_BALL = 3000;

		// Token: 0x0401F2B6 RID: 127670
		public const float BUFF_END_REMAINING_TIME = 2f;
	}
}
