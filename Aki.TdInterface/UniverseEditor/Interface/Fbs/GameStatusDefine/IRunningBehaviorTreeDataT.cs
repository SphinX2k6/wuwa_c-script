using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B66 RID: 19302
	public class IRunningBehaviorTreeDataT
	{
		// Token: 0x17008843 RID: 34883
		// (get) Token: 0x0601D57A RID: 120186 RVA: 0x0041EF5A File Offset: 0x0041D15A
		// (set) Token: 0x0601D57B RID: 120187 RVA: 0x0041EF62 File Offset: 0x0041D162
		public IRunningQuestsT Quest { get; set; }

		// Token: 0x17008844 RID: 34884
		// (get) Token: 0x0601D57C RID: 120188 RVA: 0x0041EF6B File Offset: 0x0041D16B
		// (set) Token: 0x0601D57D RID: 120189 RVA: 0x0041EF73 File Offset: 0x0041D173
		public List<IRunningTreeT> LevelPlays { get; set; }

		// Token: 0x17008845 RID: 34885
		// (get) Token: 0x0601D57E RID: 120190 RVA: 0x0041EF7C File Offset: 0x0041D17C
		// (set) Token: 0x0601D57F RID: 120191 RVA: 0x0041EF84 File Offset: 0x0041D184
		public List<int> FinishedQuests { get; set; }

		// Token: 0x17008846 RID: 34886
		// (get) Token: 0x0601D580 RID: 120192 RVA: 0x0041EF8D File Offset: 0x0041D18D
		// (set) Token: 0x0601D581 RID: 120193 RVA: 0x0041EF95 File Offset: 0x0041D195
		public List<int> FinishedLevelPlays { get; set; }

		// Token: 0x17008847 RID: 34887
		// (get) Token: 0x0601D582 RID: 120194 RVA: 0x0041EF9E File Offset: 0x0041D19E
		// (set) Token: 0x0601D583 RID: 120195 RVA: 0x0041EFA6 File Offset: 0x0041D1A6
		public List<Record_String_StringT> GlobalVars { get; set; }

		// Token: 0x17008848 RID: 34888
		// (get) Token: 0x0601D584 RID: 120196 RVA: 0x0041EFAF File Offset: 0x0041D1AF
		// (set) Token: 0x0601D585 RID: 120197 RVA: 0x0041EFB7 File Offset: 0x0041D1B7
		public List<IGameCurrBreakNodeEventInfoT> TriggerBreakNodes { get; set; }

		// Token: 0x17008849 RID: 34889
		// (get) Token: 0x0601D586 RID: 120198 RVA: 0x0041EFC0 File Offset: 0x0041D1C0
		// (set) Token: 0x0601D587 RID: 120199 RVA: 0x0041EFC8 File Offset: 0x0041D1C8
		public List<IHideRangeInfoT> HideRangeInfos { get; set; }

		// Token: 0x1700884A RID: 34890
		// (get) Token: 0x0601D588 RID: 120200 RVA: 0x0041EFD1 File Offset: 0x0041D1D1
		// (set) Token: 0x0601D589 RID: 120201 RVA: 0x0041EFD9 File Offset: 0x0041D1D9
		public string HideGroupInfo { get; set; }

		// Token: 0x1700884B RID: 34891
		// (get) Token: 0x0601D58A RID: 120202 RVA: 0x0041EFE2 File Offset: 0x0041D1E2
		// (set) Token: 0x0601D58B RID: 120203 RVA: 0x0041EFEA File Offset: 0x0041D1EA
		public List<Record_String_IRunningFlowInfoT> FlowInfos { get; set; }

		// Token: 0x1700884C RID: 34892
		// (get) Token: 0x0601D58C RID: 120204 RVA: 0x0041EFF3 File Offset: 0x0041D1F3
		// (set) Token: 0x0601D58D RID: 120205 RVA: 0x0041EFFB File Offset: 0x0041D1FB
		public byte NullMask { get; set; }

		// Token: 0x0601D58E RID: 120206 RVA: 0x0041F004 File Offset: 0x0041D204
		public IRunningBehaviorTreeDataT()
		{
			this.Quest = null;
			this.LevelPlays = null;
			this.FinishedQuests = null;
			this.FinishedLevelPlays = null;
			this.GlobalVars = null;
			this.TriggerBreakNodes = null;
			this.HideRangeInfos = null;
			this.HideGroupInfo = null;
			this.FlowInfos = null;
			this.NullMask = 0;
		}
	}
}
