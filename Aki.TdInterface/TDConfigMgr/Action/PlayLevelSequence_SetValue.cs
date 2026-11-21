using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002379 RID: 9081
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayLevelSequence_SetValue
	{
		// Token: 0x040075C1 RID: 30145
		[Nullable(0)]
		public string LevelSequencePath;

		// Token: 0x040075C2 RID: 30146
		public bool? IsEnableCenterOffset;

		// Token: 0x040075C3 RID: 30147
		public bool? KeepUI;

		// Token: 0x040075C4 RID: 30148
		public string Mark;

		// Token: 0x040075C5 RID: 30149
		public TPlayMode? PlayMode;

		// Token: 0x040075C6 RID: 30150
		public ILoopRange LoopRange;

		// Token: 0x040075C7 RID: 30151
		public ILevelSequenceTransitionType Intro;

		// Token: 0x040075C8 RID: 30152
		public ILevelSequenceTransitionType Outro;

		// Token: 0x040075C9 RID: 30153
		public float? Rate;

		// Token: 0x040075CA RID: 30154
		public IEaseData RateEase;

		// Token: 0x040075CB RID: 30155
		public bool? IsPlayOnTeleport;

		// Token: 0x040075CC RID: 30156
		public bool? IsCarryCharacter;

		// Token: 0x040075CD RID: 30157
		public IFloatingSubtitleLanguageDiff PreprocessOperation;
	}
}
