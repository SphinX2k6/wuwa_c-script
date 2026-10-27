using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002118 RID: 8472
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayLevelSequence_SetValue
	{
		// Token: 0x04006F8D RID: 28557
		[Nullable(1)]
		public string LevelSequencePath;

		// Token: 0x04006F8E RID: 28558
		public bool? IsEnableCenterOffset;

		// Token: 0x04006F8F RID: 28559
		public bool? KeepUI;

		// Token: 0x04006F90 RID: 28560
		public string Mark;

		// Token: 0x04006F91 RID: 28561
		public TPlayMode? PlayMode;

		// Token: 0x04006F92 RID: 28562
		public ILoopRange LoopRange;

		// Token: 0x04006F93 RID: 28563
		public ILevelSequenceTransitionType Intro;

		// Token: 0x04006F94 RID: 28564
		public ILevelSequenceTransitionType Outro;

		// Token: 0x04006F95 RID: 28565
		public float? Rate;

		// Token: 0x04006F96 RID: 28566
		public IEaseData RateEase;

		// Token: 0x04006F97 RID: 28567
		public bool? IsPlayOnTeleport;

		// Token: 0x04006F98 RID: 28568
		public bool? IsCarryCharacter;

		// Token: 0x04006F99 RID: 28569
		public IFloatingSubtitleLanguageDiff PreprocessOperation;
	}
}
