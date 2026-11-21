using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F6D RID: 3949
	[EnumExtensions]
	public enum EChildQuest
	{
		// Token: 0x040032D1 RID: 13009
		DoInteract,
		// Token: 0x040032D2 RID: 13010
		ReachArea,
		// Token: 0x040032D3 RID: 13011
		Kill,
		// Token: 0x040032D4 RID: 13012
		GetItem,
		// Token: 0x040032D5 RID: 13013
		UseSkill,
		// Token: 0x040032D6 RID: 13014
		GetSkill,
		// Token: 0x040032D7 RID: 13015
		PlayFlow,
		// Token: 0x040032D8 RID: 13016
		DetectCombatState,
		// Token: 0x040032D9 RID: 13017
		Parkour,
		// Token: 0x040032DA RID: 13018
		Timer,
		// Token: 0x040032DB RID: 13019
		HandInItems,
		// Token: 0x040032DC RID: 13020
		NewHandInItems,
		// Token: 0x040032DD RID: 13021
		MonsterCreator,
		// Token: 0x040032DE RID: 13022
		InformationViewCheck,
		// Token: 0x040032DF RID: 13023
		UseItem,
		// Token: 0x040032E0 RID: 13024
		CheckEntityState,
		// Token: 0x040032E1 RID: 13025
		CheckLevelPlay,
		// Token: 0x040032E2 RID: 13026
		CheckUiGame,
		// Token: 0x040032E3 RID: 13027
		FinishDungeon,
		// Token: 0x040032E4 RID: 13028
		WaitTime,
		// Token: 0x040032E5 RID: 13029
		ScheduleTime,
		// Token: 0x040032E6 RID: 13030
		ReadMail,
		// Token: 0x040032E7 RID: 13031
		Guide,
		// Token: 0x040032E8 RID: 13032
		EnterDungeon,
		// Token: 0x040032E9 RID: 13033
		LeaveDungeon,
		// Token: 0x040032EA RID: 13034
		CheckTargetBattleAttribute,
		// Token: 0x040032EB RID: 13035
		WaitBattleCondition,
		// Token: 0x040032EC RID: 13036
		CompareVar,
		// Token: 0x040032ED RID: 13037
		CompareActorVar,
		// Token: 0x040032EE RID: 13038
		ReceiveTelecom,
		// Token: 0x040032EF RID: 13039
		ShowUi,
		// Token: 0x040032F0 RID: 13040
		TakePhoto,
		// Token: 0x040032F1 RID: 13041
		TakePhoto2,
		// Token: 0x040032F2 RID: 13042
		VisionSystem,
		// Token: 0x040032F3 RID: 13043
		ParallaxAlign,
		// Token: 0x040032F4 RID: 13044
		CheckConditionGroup,
		// Token: 0x040032F5 RID: 13045
		CheckClientConditionGroup,
		// Token: 0x040032F6 RID: 13046
		CheckActivityState,
		// Token: 0x040032F7 RID: 13047
		CheckPlayerInput,
		// Token: 0x040032F8 RID: 13048
		AwakeAndLoadEntity,
		// Token: 0x040032F9 RID: 13049
		WalkingPattern,
		// Token: 0x040032FA RID: 13050
		DetectCombatState2,
		// Token: 0x040032FB RID: 13051
		FinishBvbChallenge,
		// Token: 0x040032FC RID: 13052
		FinishTrapDefense,
		// Token: 0x040032FD RID: 13053
		CheckTrapDefenseEvent,
		// Token: 0x040032FE RID: 13054
		ProgramSpecialProcess,
		// Token: 0x040032FF RID: 13055
		WaitUntilLevelSequenceReachMark,
		// Token: 0x04003300 RID: 13056
		FinishSurvivorsRouge,
		// Token: 0x04003301 RID: 13057
		TakePicturesWithTimeScale,
		// Token: 0x04003302 RID: 13058
		FinishRollBlock,
		// Token: 0x04003303 RID: 13059
		ReadPhoneMessage,
		// Token: 0x04003304 RID: 13060
		ListenToEvent,
		// Token: 0x04003305 RID: 13061
		AtomicProcess,
		// Token: 0x04003306 RID: 13062
		UseWeatherSwitch,
		// Token: 0x04003307 RID: 13063
		FinishRhythmSpaceship,
		// Token: 0x04003308 RID: 13064
		FinishFlipper,
		// Token: 0x04003309 RID: 13065
		FinishKurotato,
		// Token: 0x0400330A RID: 13066
		FinishRoleTower,
		// Token: 0x0400330B RID: 13067
		CheckSpringFestivalGameplayCompleted,
		// Token: 0x0400330C RID: 13068
		FinishTetris,
		// Token: 0x0400330D RID: 13069
		FinishArcadeGameplay,
		// Token: 0x0400330E RID: 13070
		FinishKuroSimpleCombatKillMonster,
		// Token: 0x0400330F RID: 13071
		CrossSceneSyncKillMonster,
		// Token: 0x04003310 RID: 13072
		PlaybackShowTimeline,
		// Token: 0x04003311 RID: 13073
		FinishJellyfishReturn
	}
}
