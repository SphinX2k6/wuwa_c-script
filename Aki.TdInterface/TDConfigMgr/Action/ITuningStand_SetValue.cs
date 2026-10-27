using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002007 RID: 8199
	[NullableContext(2)]
	[Nullable(0)]
	public class ITuningStand_SetValue
	{
		// Token: 0x04006CAE RID: 27822
		public ESimpleGameplayType Type;

		// Token: 0x04006CAF RID: 27823
		public ETuningStandVisualType VisualType;

		// Token: 0x04006CB0 RID: 27824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITuningStandBubbleConfig> BubbleConfig;

		// Token: 0x04006CB1 RID: 27825
		public string GuidancePath;

		// Token: 0x04006CB2 RID: 27826
		public string MusicScorePath;

		// Token: 0x04006CB3 RID: 27827
		public string NoteSequence;

		// Token: 0x04006CB4 RID: 27828
		public string CompleteMusic;

		// Token: 0x04006CB5 RID: 27829
		[Nullable(1)]
		public ITuningStandGridBoard BoardConfig;
	}
}
