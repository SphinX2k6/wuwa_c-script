using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681A RID: 26650
	public class IFlowListInfoT
	{
		// Token: 0x1700C5EB RID: 50667
		// (get) Token: 0x0602E734 RID: 190260 RVA: 0x00657134 File Offset: 0x00655334
		// (set) Token: 0x0602E735 RID: 190261 RVA: 0x0065713C File Offset: 0x0065533C
		public int Id { get; set; }

		// Token: 0x1700C5EC RID: 50668
		// (get) Token: 0x0602E736 RID: 190262 RVA: 0x00657145 File Offset: 0x00655345
		// (set) Token: 0x0602E737 RID: 190263 RVA: 0x0065714D File Offset: 0x0065534D
		public List<Record_Int_IFlowTextConfigT> Texts { get; set; }

		// Token: 0x1700C5ED RID: 50669
		// (get) Token: 0x0602E738 RID: 190264 RVA: 0x00657156 File Offset: 0x00655356
		// (set) Token: 0x0602E739 RID: 190265 RVA: 0x0065715E File Offset: 0x0065535E
		public List<IFlowInfoT> Flows { get; set; }

		// Token: 0x1700C5EE RID: 50670
		// (get) Token: 0x0602E73A RID: 190266 RVA: 0x00657167 File Offset: 0x00655367
		// (set) Token: 0x0602E73B RID: 190267 RVA: 0x0065716F File Offset: 0x0065536F
		public int _SelectedFlowId { get; set; }

		// Token: 0x1700C5EF RID: 50671
		// (get) Token: 0x0602E73C RID: 190268 RVA: 0x00657178 File Offset: 0x00655378
		// (set) Token: 0x0602E73D RID: 190269 RVA: 0x00657180 File Offset: 0x00655380
		public string _FilterText { get; set; }

		// Token: 0x1700C5F0 RID: 50672
		// (get) Token: 0x0602E73E RID: 190270 RVA: 0x00657189 File Offset: 0x00655389
		// (set) Token: 0x0602E73F RID: 190271 RVA: 0x00657191 File Offset: 0x00655391
		public string _HighlightText { get; set; }

		// Token: 0x1700C5F1 RID: 50673
		// (get) Token: 0x0602E740 RID: 190272 RVA: 0x0065719A File Offset: 0x0065539A
		// (set) Token: 0x0602E741 RID: 190273 RVA: 0x006571A2 File Offset: 0x006553A2
		public List<EAction> _FilterActions { get; set; }

		// Token: 0x1700C5F2 RID: 50674
		// (get) Token: 0x0602E742 RID: 190274 RVA: 0x006571AB File Offset: 0x006553AB
		// (set) Token: 0x0602E743 RID: 190275 RVA: 0x006571B3 File Offset: 0x006553B3
		public List<EAction> _HighlightActions { get; set; }

		// Token: 0x1700C5F3 RID: 50675
		// (get) Token: 0x0602E744 RID: 190276 RVA: 0x006571BC File Offset: 0x006553BC
		// (set) Token: 0x0602E745 RID: 190277 RVA: 0x006571C4 File Offset: 0x006553C4
		public string _FilterEntityIdText { get; set; }

		// Token: 0x1700C5F4 RID: 50676
		// (get) Token: 0x0602E746 RID: 190278 RVA: 0x006571CD File Offset: 0x006553CD
		// (set) Token: 0x0602E747 RID: 190279 RVA: 0x006571D5 File Offset: 0x006553D5
		public string _HighlightEntityIdText { get; set; }

		// Token: 0x1700C5F5 RID: 50677
		// (get) Token: 0x0602E748 RID: 190280 RVA: 0x006571DE File Offset: 0x006553DE
		// (set) Token: 0x0602E749 RID: 190281 RVA: 0x006571E6 File Offset: 0x006553E6
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x1700C5F6 RID: 50678
		// (get) Token: 0x0602E74A RID: 190282 RVA: 0x006571EF File Offset: 0x006553EF
		// (set) Token: 0x0602E74B RID: 190283 RVA: 0x006571F7 File Offset: 0x006553F7
		public string _FocusDataPath { get; set; }

		// Token: 0x1700C5F7 RID: 50679
		// (get) Token: 0x0602E74C RID: 190284 RVA: 0x00657200 File Offset: 0x00655400
		// (set) Token: 0x0602E74D RID: 190285 RVA: 0x00657208 File Offset: 0x00655408
		public byte NullMask { get; set; }

		// Token: 0x0602E74E RID: 190286 RVA: 0x00657214 File Offset: 0x00655414
		public IFlowListInfoT()
		{
			this.Id = 0;
			this.Texts = null;
			this.Flows = null;
			this._SelectedFlowId = 0;
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
