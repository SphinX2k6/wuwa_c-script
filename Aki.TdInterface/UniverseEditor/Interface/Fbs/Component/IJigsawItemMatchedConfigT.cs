using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B0 RID: 21680
	public class IJigsawItemMatchedConfigT
	{
		// Token: 0x17009FB2 RID: 40882
		// (get) Token: 0x06023B58 RID: 146264 RVA: 0x004F0073 File Offset: 0x004EE273
		// (set) Token: 0x06023B59 RID: 146265 RVA: 0x004F007B File Offset: 0x004EE27B
		public IPieceIndexT TargetIndex { get; set; }

		// Token: 0x17009FB3 RID: 40883
		// (get) Token: 0x06023B5A RID: 146266 RVA: 0x004F0084 File Offset: 0x004EE284
		// (set) Token: 0x06023B5B RID: 146267 RVA: 0x004F008C File Offset: 0x004EE28C
		public List<int> JigsawItemIds { get; set; }

		// Token: 0x17009FB4 RID: 40884
		// (get) Token: 0x06023B5C RID: 146268 RVA: 0x004F0095 File Offset: 0x004EE295
		// (set) Token: 0x06023B5D RID: 146269 RVA: 0x004F009D File Offset: 0x004EE29D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009FB5 RID: 40885
		// (get) Token: 0x06023B5E RID: 146270 RVA: 0x004F00A6 File Offset: 0x004EE2A6
		// (set) Token: 0x06023B5F RID: 146271 RVA: 0x004F00AE File Offset: 0x004EE2AE
		public List<IConditionActionT> ConditionActions { get; set; }

		// Token: 0x17009FB6 RID: 40886
		// (get) Token: 0x06023B60 RID: 146272 RVA: 0x004F00B7 File Offset: 0x004EE2B7
		// (set) Token: 0x06023B61 RID: 146273 RVA: 0x004F00BF File Offset: 0x004EE2BF
		public List<IActionInfoT> UnmatchedActions { get; set; }

		// Token: 0x17009FB7 RID: 40887
		// (get) Token: 0x06023B62 RID: 146274 RVA: 0x004F00C8 File Offset: 0x004EE2C8
		// (set) Token: 0x06023B63 RID: 146275 RVA: 0x004F00D0 File Offset: 0x004EE2D0
		public byte NullMask { get; set; }

		// Token: 0x06023B64 RID: 146276 RVA: 0x004F00D9 File Offset: 0x004EE2D9
		public IJigsawItemMatchedConfigT()
		{
			this.TargetIndex = null;
			this.JigsawItemIds = null;
			this.Actions = null;
			this.ConditionActions = null;
			this.UnmatchedActions = null;
			this.NullMask = 0;
		}
	}
}
