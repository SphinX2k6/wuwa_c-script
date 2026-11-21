using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C50 RID: 19536
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiDefine
	{
		// Token: 0x06030C62 RID: 199778 RVA: 0x00D9A9F4 File Offset: 0x00D98BF4
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

		// Token: 0x04019D4A RID: 105802
		public const float DAMAGE_LEFT_RATIO = 0.25f;

		// Token: 0x04019D4B RID: 105803
		public const float DAMAGE_MIDDLE_RATIO = 0.75f;

		// Token: 0x04019D4C RID: 105804
		public const float DAMAGE_RIGHT_RATIO = 1f;

		// Token: 0x04019D4D RID: 105805
		public const int DAMAGE_ANIMATION_MAX_LENGTH = 240;

		// Token: 0x04019D4E RID: 105806
		public const int CURE_DAMAGE_TEXT = 8;

		// Token: 0x04019D4F RID: 105807
		public const int IMMUNITY_DAMAGE_TEXT_ID = 9;

		// Token: 0x04019D50 RID: 105808
		public const int ATK_DAMAGE_TEXT = 10;

		// Token: 0x04019D51 RID: 105809
		public const int SHEILD_COVER_TEXT = 12;

		// Token: 0x04019D52 RID: 105810
		public const string IMMUNITY_DAMAGE_TEXT = "Immune";

		// Token: 0x04019D53 RID: 105811
		public const int SKILL_COOLDOWN_INTERVAL = 100;

		// Token: 0x04019D54 RID: 105812
		public const int SKILL_COOLDOWN_DELAY = 100;

		// Token: 0x04019D55 RID: 105813
		public const float SKILL_COOLDOWN_LOOP_INTERVAL = 0.1f;

		// Token: 0x04019D56 RID: 105814
		public const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x04019D57 RID: 105815
		public const int HEAD_STATE_RANGE = 1000000;

		// Token: 0x04019D58 RID: 105816
		public const int CHANGE_COOLDOWN_INTERVAL = 100;

		// Token: 0x04019D59 RID: 105817
		public const int CHANGE_COOLDOWN_DELAY = 100;

		// Token: 0x04019D5A RID: 105818
		public const float CHANGE_COOLDOWN_LOOP_INTERVAL = 0.1f;

		// Token: 0x04019D5B RID: 105819
		public const int BE_HIT_DELAY = 5000;

		// Token: 0x04019D5C RID: 105820
		public const int DAMAGE_VIEW_OFFSET_MAX_DISTANCE = 640000;

		// Token: 0x04019D5D RID: 105821
		public const float DAMAGE_VIEW_OFFSET_MIN_RATIO = 0.2f;

		// Token: 0x04019D5E RID: 105822
		public const int REFRESH_POSITION_INTERVAL = 1000;

		// Token: 0x04019D5F RID: 105823
		public const int CLAMP_RANGE = 130;

		// Token: 0x04019D60 RID: 105824
		public const int INPUT_SKILL_ACTION_NUM = 6;

		// Token: 0x04019D61 RID: 105825
		public const int SPECIAL_ENERGY_BAR_WIDTH = 440;

		// Token: 0x04019D62 RID: 105826
		public const float AREAL_BOX_WIETH_A = 35.2f;

		// Token: 0x04019D63 RID: 105827
		public const float AREAL_BOX_WIETH_B = 123.2f;

		// Token: 0x04019D64 RID: 105828
		public const float AREAL_BOX_WIETH_C = 250f;

		// Token: 0x04019D65 RID: 105829
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EElementPowerType, int> elementTypeToElementTag;

		// Token: 0x04019D66 RID: 105830
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<int, EElementPowerType> elementTagToElementType;

		// Token: 0x04019D67 RID: 105831
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EInputAction, int> hideInputTagMap;

		// Token: 0x04019D68 RID: 105832
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EBossStateViewType, string> bossStateViewResourceIdMap;

		// Token: 0x04019D69 RID: 105833
		public const int DELAY_REFRESH_ELEMENT_BALL = 3000;

		// Token: 0x04019D6A RID: 105834
		public const float BUFF_END_REMAINING_TIME = 2f;
	}
}
