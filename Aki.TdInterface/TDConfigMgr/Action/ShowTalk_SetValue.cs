using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002473 RID: 9331
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowTalk_SetValue
	{
		// Token: 0x0400784E RID: 30798
		public bool? ResetCamera;

		// Token: 0x0400784F RID: 30799
		[Nullable(0)]
		public List<ITalkItem> TalkItems;

		// Token: 0x04007850 RID: 30800
		public IShowTalkOutline TalkOutline;

		// Token: 0x04007851 RID: 30801
		public string SequenceDataAsset;

		// Token: 0x04007852 RID: 30802
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IShowTalkFrameEvent> TalkFrameEvents;

		// Token: 0x04007853 RID: 30803
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<List<int>> TalkSequence;

		// Token: 0x04007854 RID: 30804
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> SequenceNames;

		// Token: 0x04007855 RID: 30805
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		public Dictionary<int, List<ITalkSequenceTransition>> SequenceTransitions;

		// Token: 0x04007856 RID: 30806
		public bool? SaveFinalPos;

		// Token: 0x04007857 RID: 30807
		public SetBlendAnim SeqBlendAnim;

		// Token: 0x04007858 RID: 30808
		public string EdSequencePath;

		// Token: 0x04007859 RID: 30809
		public IPlotConfig EdPlotConfig;

		// Token: 0x0400785A RID: 30810
		public string EdPreSeqSavePath;
	}
}
