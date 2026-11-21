using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C2B RID: 7211
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowListInfo_SetValue
	{
		// Token: 0x04005E4E RID: 24142
		public int Id;

		// Token: 0x04005E4F RID: 24143
		[Nullable(0)]
		public Dictionary<int, IFlowTextConfig> Texts;

		// Token: 0x04005E50 RID: 24144
		[Nullable(0)]
		public List<IFlowInfo> Flows;

		// Token: 0x04005E51 RID: 24145
		public int? _selectedFlowId;

		// Token: 0x04005E52 RID: 24146
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IFlowSelectedNode> _multiSelectedNodes;

		// Token: 0x04005E53 RID: 24147
		public string _filterText;

		// Token: 0x04005E54 RID: 24148
		public string _highlightText;

		// Token: 0x04005E55 RID: 24149
		public List<EAction> _filterActions;

		// Token: 0x04005E56 RID: 24150
		public List<EAction> _highlightActions;

		// Token: 0x04005E57 RID: 24151
		public string _filterEntityIdText;

		// Token: 0x04005E58 RID: 24152
		public string _highlightEntityIdText;

		// Token: 0x04005E59 RID: 24153
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> _highlightDataPaths;

		// Token: 0x04005E5A RID: 24154
		public string _focusDataPath;

		// Token: 0x04005E5B RID: 24155
		public string EdPlotPath;

		// Token: 0x04005E5C RID: 24156
		public bool? EdPreviewOnly;

		// Token: 0x04005E5D RID: 24157
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		public Dictionary<string, List<string>> EdBubbleActorNames;
	}
}
