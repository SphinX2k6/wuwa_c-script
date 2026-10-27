using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A96 RID: 6806
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowListInfo_SetValue
	{
		// Token: 0x040059E6 RID: 23014
		public int Id;

		// Token: 0x040059E7 RID: 23015
		[Nullable(1)]
		public Dictionary<int, IFlowTextConfig> Texts;

		// Token: 0x040059E8 RID: 23016
		[Nullable(1)]
		public List<IFlowInfo> Flows;

		// Token: 0x040059E9 RID: 23017
		public int? _selectedFlowId;

		// Token: 0x040059EA RID: 23018
		public string _filterText;

		// Token: 0x040059EB RID: 23019
		public string _highlightText;

		// Token: 0x040059EC RID: 23020
		public List<EAction> _filterActions;

		// Token: 0x040059ED RID: 23021
		public List<EAction> _highlightActions;

		// Token: 0x040059EE RID: 23022
		public string _filterEntityIdText;

		// Token: 0x040059EF RID: 23023
		public string _highlightEntityIdText;

		// Token: 0x040059F0 RID: 23024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> _highlightDataPaths;

		// Token: 0x040059F1 RID: 23025
		public string _focusDataPath;

		// Token: 0x040059F2 RID: 23026
		public string EdPlotPath;

		// Token: 0x040059F3 RID: 23027
		public bool? EdPreviewOnly;

		// Token: 0x040059F4 RID: 23028
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<string, List<string>> EdBubbleActorNames;
	}
}
