using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002208 RID: 8712
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowTalk_SetValue
	{
		// Token: 0x04007205 RID: 29189
		public bool? ResetCamera;

		// Token: 0x04007206 RID: 29190
		[Nullable(1)]
		public List<ITalkItem> TalkItems;

		// Token: 0x04007207 RID: 29191
		public IShowTalkOutline TalkOutline;

		// Token: 0x04007208 RID: 29192
		public string SequenceDataAsset;

		// Token: 0x04007209 RID: 29193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IShowTalkFrameEvent> TalkFrameEvents;

		// Token: 0x0400720A RID: 29194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<List<int>> TalkSequence;

		// Token: 0x0400720B RID: 29195
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> SequenceNames;

		// Token: 0x0400720C RID: 29196
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<int, List<ITalkSequenceTransition>> SequenceTransitions;

		// Token: 0x0400720D RID: 29197
		public bool? SaveFinalPos;

		// Token: 0x0400720E RID: 29198
		public SetBlendAnim SeqBlendAnim;

		// Token: 0x0400720F RID: 29199
		public string EdSequencePath;

		// Token: 0x04007210 RID: 29200
		public IPlotConfig EdPlotConfig;

		// Token: 0x04007211 RID: 29201
		public string EdPreSeqSavePath;
	}
}
