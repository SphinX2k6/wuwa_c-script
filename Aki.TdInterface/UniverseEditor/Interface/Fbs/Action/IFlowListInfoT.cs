using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9A RID: 28314
	public class IFlowListInfoT
	{
		// Token: 0x1700CFA4 RID: 53156
		// (get) Token: 0x06030F8E RID: 200590 RVA: 0x006A4C2D File Offset: 0x006A2E2D
		// (set) Token: 0x06030F8F RID: 200591 RVA: 0x006A4C35 File Offset: 0x006A2E35
		public int Id { get; set; }

		// Token: 0x1700CFA5 RID: 53157
		// (get) Token: 0x06030F90 RID: 200592 RVA: 0x006A4C3E File Offset: 0x006A2E3E
		// (set) Token: 0x06030F91 RID: 200593 RVA: 0x006A4C46 File Offset: 0x006A2E46
		public List<Record_Int_IFlowTextConfigT> Texts { get; set; }

		// Token: 0x1700CFA6 RID: 53158
		// (get) Token: 0x06030F92 RID: 200594 RVA: 0x006A4C4F File Offset: 0x006A2E4F
		// (set) Token: 0x06030F93 RID: 200595 RVA: 0x006A4C57 File Offset: 0x006A2E57
		public List<IFlowInfoT> Flows { get; set; }

		// Token: 0x1700CFA7 RID: 53159
		// (get) Token: 0x06030F94 RID: 200596 RVA: 0x006A4C60 File Offset: 0x006A2E60
		// (set) Token: 0x06030F95 RID: 200597 RVA: 0x006A4C68 File Offset: 0x006A2E68
		public int _SelectedFlowId { get; set; }

		// Token: 0x1700CFA8 RID: 53160
		// (get) Token: 0x06030F96 RID: 200598 RVA: 0x006A4C71 File Offset: 0x006A2E71
		// (set) Token: 0x06030F97 RID: 200599 RVA: 0x006A4C79 File Offset: 0x006A2E79
		public List<IFlowSelectedNodeT> _MultiSelectedNodes { get; set; }

		// Token: 0x1700CFA9 RID: 53161
		// (get) Token: 0x06030F98 RID: 200600 RVA: 0x006A4C82 File Offset: 0x006A2E82
		// (set) Token: 0x06030F99 RID: 200601 RVA: 0x006A4C8A File Offset: 0x006A2E8A
		public string _FilterText { get; set; }

		// Token: 0x1700CFAA RID: 53162
		// (get) Token: 0x06030F9A RID: 200602 RVA: 0x006A4C93 File Offset: 0x006A2E93
		// (set) Token: 0x06030F9B RID: 200603 RVA: 0x006A4C9B File Offset: 0x006A2E9B
		public string _HighlightText { get; set; }

		// Token: 0x1700CFAB RID: 53163
		// (get) Token: 0x06030F9C RID: 200604 RVA: 0x006A4CA4 File Offset: 0x006A2EA4
		// (set) Token: 0x06030F9D RID: 200605 RVA: 0x006A4CAC File Offset: 0x006A2EAC
		public List<EAction> _FilterActions { get; set; }

		// Token: 0x1700CFAC RID: 53164
		// (get) Token: 0x06030F9E RID: 200606 RVA: 0x006A4CB5 File Offset: 0x006A2EB5
		// (set) Token: 0x06030F9F RID: 200607 RVA: 0x006A4CBD File Offset: 0x006A2EBD
		public List<EAction> _HighlightActions { get; set; }

		// Token: 0x1700CFAD RID: 53165
		// (get) Token: 0x06030FA0 RID: 200608 RVA: 0x006A4CC6 File Offset: 0x006A2EC6
		// (set) Token: 0x06030FA1 RID: 200609 RVA: 0x006A4CCE File Offset: 0x006A2ECE
		public string _FilterEntityIdText { get; set; }

		// Token: 0x1700CFAE RID: 53166
		// (get) Token: 0x06030FA2 RID: 200610 RVA: 0x006A4CD7 File Offset: 0x006A2ED7
		// (set) Token: 0x06030FA3 RID: 200611 RVA: 0x006A4CDF File Offset: 0x006A2EDF
		public string _HighlightEntityIdText { get; set; }

		// Token: 0x1700CFAF RID: 53167
		// (get) Token: 0x06030FA4 RID: 200612 RVA: 0x006A4CE8 File Offset: 0x006A2EE8
		// (set) Token: 0x06030FA5 RID: 200613 RVA: 0x006A4CF0 File Offset: 0x006A2EF0
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x1700CFB0 RID: 53168
		// (get) Token: 0x06030FA6 RID: 200614 RVA: 0x006A4CF9 File Offset: 0x006A2EF9
		// (set) Token: 0x06030FA7 RID: 200615 RVA: 0x006A4D01 File Offset: 0x006A2F01
		public string _FocusDataPath { get; set; }

		// Token: 0x1700CFB1 RID: 53169
		// (get) Token: 0x06030FA8 RID: 200616 RVA: 0x006A4D0A File Offset: 0x006A2F0A
		// (set) Token: 0x06030FA9 RID: 200617 RVA: 0x006A4D12 File Offset: 0x006A2F12
		public byte NullMask { get; set; }

		// Token: 0x06030FAA RID: 200618 RVA: 0x006A4D1C File Offset: 0x006A2F1C
		public IFlowListInfoT()
		{
			this.Id = 0;
			this.Texts = null;
			this.Flows = null;
			this._SelectedFlowId = 0;
			this._MultiSelectedNodes = null;
			this._FilterText = null;
			this._HighlightText = null;
			this._FilterActions = null;
			this._HighlightActions = null;
			this._FilterEntityIdText = null;
			this._HighlightEntityIdText = null;
			this._HighlightDataPaths = null;
			this._FocusDataPath = null;
			this.NullMask = 0;
		}
	}
}
