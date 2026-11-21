using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x0200496F RID: 18799
	public class GenericPromptDefine
	{
		// Token: 0x0602F25B RID: 193115 RVA: 0x00D240FC File Offset: 0x00D222FC
		// Note: this type is marked as 'beforefieldinit'.
		static GenericPromptDefine()
		{
			Dictionary<int, EUiViewName> dictionary = new Dictionary<int, EUiViewName>();
			dictionary[0] = EUiViewName.EventConditionFloatTips;
			dictionary[1] = EUiViewName.DungeonClearanceFloatTips;
			dictionary[2] = EUiViewName.DungeonAutoExitFloatTips;
			dictionary[3] = EUiViewName.ChallengeSuccessFloatTips;
			dictionary[4] = EUiViewName.ChallengeFailedFloatTips;
			dictionary[5] = EUiViewName.ChallengeAchieveFloatTips;
			dictionary[6] = EUiViewName.AdditionalTasksFloatTips;
			dictionary[7] = EUiViewName.DelegateCompletionFloatTips;
			dictionary[8] = EUiViewName.CountDownFloatTips;
			dictionary[9] = EUiViewName.GenericPromptView;
			dictionary[10] = EUiViewName.ChapterStartFloatTips;
			dictionary[11] = EUiViewName.ChapterEndFloatTips;
			dictionary[12] = EUiViewName.DailyTaskEndTips;
			dictionary[13] = EUiViewName.PrepareCountdownFloatTips;
			dictionary[14] = EUiViewName.ComboTeachingFloatTips;
			dictionary[15] = EUiViewName.RoguelikeRoomFloatTips;
			dictionary[16] = EUiViewName.FlowChapterStartTips;
			dictionary[17] = EUiViewName.FlowChapterEndTips;
			dictionary[18] = EUiViewName.RemainStarWarningTips;
			dictionary[19] = EUiViewName.TowerDefenseWaveTipView;
			dictionary[20] = EUiViewName.RogueSilentAreaFloatTips;
			dictionary[21] = EUiViewName.MowingRiskBuffTipView;
			dictionary[22] = EUiViewName.WhiteCatWarningTips;
			dictionary[23] = EUiViewName.BlackCatWarningTips;
			dictionary[24] = EUiViewName.ChapterBattleDeclarationTipsRed;
			dictionary[25] = EUiViewName.ChapterBattleDeclarationTipsWhite;
			dictionary[27] = EUiViewName.TeamTeleportFloatTips;
			dictionary[26] = EUiViewName.ChapterA;
			dictionary[28] = EUiViewName.DangoAbyssActivityOpen;
			dictionary[29] = EUiViewName.DangoAbyssNpcTips;
			dictionary[30] = EUiViewName.RogueResOpenTips;
			dictionary[31] = EUiViewName.MoralePrompt;
			dictionary[32] = EUiViewName.NightmareLordFloatTips;
			dictionary[33] = EUiViewName.NightmareSpawnPointFloatTips;
			dictionary[34] = EUiViewName.PhantomArenaActivityOpen;
			dictionary[35] = EUiViewName.PlotChapterA;
			dictionary[36] = EUiViewName.FightPhotoEventTipView;
			dictionary[37] = EUiViewName.VisionSettlementFloatTips;
			dictionary[38] = EUiViewName.FlagChallengePrompt;
			dictionary[39] = EUiViewName.ChallengeWantedAchieveFloatTips;
			dictionary[40] = EUiViewName.TowerDefenseStrengthenTipsView;
			GenericPromptDefine.genericPromptView = dictionary;
		}

		// Token: 0x04019076 RID: 102518
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<int, EUiViewName> genericPromptView;
	}
}
