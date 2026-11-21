using System;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x0200469B RID: 18075
	public enum ELoadingReason
	{
		// Token: 0x0401855F RID: 99679
		Common,
		// Token: 0x04018560 RID: 99680
		Revive,
		// Token: 0x04018561 RID: 99681
		BehaviorTreeRollback,
		// Token: 0x04018562 RID: 99682
		JumpToNextSubtitleOrChildSeq,
		// Token: 0x04018563 RID: 99683
		TurntableControlViewOnBtnResetClicked,
		// Token: 0x04018564 RID: 99684
		SundialControlViewOnBtnResetClicked,
		// Token: 0x04018565 RID: 99685
		Teleport,
		// Token: 0x04018566 RID: 99686
		LoadingTeleport,
		// Token: 0x04018567 RID: 99687
		SimpleLevelSequence,
		// Token: 0x04018568 RID: 99688
		PlotTeleport,
		// Token: 0x04018569 RID: 99689
		CenterText,
		// Token: 0x0401856A RID: 99690
		Photograph,
		// Token: 0x0401856B RID: 99691
		WaitFormation,
		// Token: 0x0401856C RID: 99692
		Signal,
		// Token: 0x0401856D RID: 99693
		SubLevelLoading,
		// Token: 0x0401856E RID: 99694
		RogueSubLevelLoading,
		// Token: 0x0401856F RID: 99695
		BrokenRock,
		// Token: 0x04018570 RID: 99696
		AbyssSubLevelLoading,
		// Token: 0x04018571 RID: 99697
		RoverSubLevelLoading,
		// Token: 0x04018572 RID: 99698
		CG,
		// Token: 0x04018573 RID: 99699
		QuestFocusMode,
		// Token: 0x04018574 RID: 99700
		SpecialTransition,
		// Token: 0x04018575 RID: 99701
		SpecialTransitionKeep,
		// Token: 0x04018576 RID: 99702
		MotorRideSharing,
		// Token: 0x04018577 RID: 99703
		FindSunSpirit,
		// Token: 0x04018578 RID: 99704
		SlidingBlocks,
		// Token: 0x04018579 RID: 99705
		MusicalInstrument,
		// Token: 0x0401857A RID: 99706
		PlotFormationMemory,
		// Token: 0x0401857B RID: 99707
		UiTransition,
		// Token: 0x0401857C RID: 99708
		None
	}
}
