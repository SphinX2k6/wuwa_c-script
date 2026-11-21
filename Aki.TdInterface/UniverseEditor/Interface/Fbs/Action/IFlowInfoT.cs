using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E97 RID: 28311
	public class IFlowInfoT
	{
		// Token: 0x1700CF88 RID: 53128
		// (get) Token: 0x06030F18 RID: 200472 RVA: 0x006A390D File Offset: 0x006A1B0D
		// (set) Token: 0x06030F19 RID: 200473 RVA: 0x006A3915 File Offset: 0x006A1B15
		public string ObjType { get; set; }

		// Token: 0x1700CF89 RID: 53129
		// (get) Token: 0x06030F1A RID: 200474 RVA: 0x006A391E File Offset: 0x006A1B1E
		// (set) Token: 0x06030F1B RID: 200475 RVA: 0x006A3926 File Offset: 0x006A1B26
		public List<string> Children { get; set; }

		// Token: 0x1700CF8A RID: 53130
		// (get) Token: 0x06030F1C RID: 200476 RVA: 0x006A392F File Offset: 0x006A1B2F
		// (set) Token: 0x06030F1D RID: 200477 RVA: 0x006A3937 File Offset: 0x006A1B37
		public List<string> Reference { get; set; }

		// Token: 0x1700CF8B RID: 53131
		// (get) Token: 0x06030F1E RID: 200478 RVA: 0x006A3940 File Offset: 0x006A1B40
		// (set) Token: 0x06030F1F RID: 200479 RVA: 0x006A3948 File Offset: 0x006A1B48
		public List<string> WeakReference { get; set; }

		// Token: 0x1700CF8C RID: 53132
		// (get) Token: 0x06030F20 RID: 200480 RVA: 0x006A3951 File Offset: 0x006A1B51
		// (set) Token: 0x06030F21 RID: 200481 RVA: 0x006A3959 File Offset: 0x006A1B59
		public int Id { get; set; }

		// Token: 0x1700CF8D RID: 53133
		// (get) Token: 0x06030F22 RID: 200482 RVA: 0x006A3962 File Offset: 0x006A1B62
		// (set) Token: 0x06030F23 RID: 200483 RVA: 0x006A396A File Offset: 0x006A1B6A
		public string Name { get; set; }

		// Token: 0x1700CF8E RID: 53134
		// (get) Token: 0x06030F24 RID: 200484 RVA: 0x006A3973 File Offset: 0x006A1B73
		// (set) Token: 0x06030F25 RID: 200485 RVA: 0x006A397B File Offset: 0x006A1B7B
		public int DungeonId { get; set; }

		// Token: 0x1700CF8F RID: 53135
		// (get) Token: 0x06030F26 RID: 200486 RVA: 0x006A3984 File Offset: 0x006A1B84
		// (set) Token: 0x06030F27 RID: 200487 RVA: 0x006A398C File Offset: 0x006A1B8C
		public bool _Folded { get; set; }

		// Token: 0x1700CF90 RID: 53136
		// (get) Token: 0x06030F28 RID: 200488 RVA: 0x006A3995 File Offset: 0x006A1B95
		// (set) Token: 0x06030F29 RID: 200489 RVA: 0x006A399D File Offset: 0x006A1B9D
		public int _SelectedStateId { get; set; }

		// Token: 0x1700CF91 RID: 53137
		// (get) Token: 0x06030F2A RID: 200490 RVA: 0x006A39A6 File Offset: 0x006A1BA6
		// (set) Token: 0x06030F2B RID: 200491 RVA: 0x006A39AE File Offset: 0x006A1BAE
		public List<int> _SelectedStateIds { get; set; }

		// Token: 0x1700CF92 RID: 53138
		// (get) Token: 0x06030F2C RID: 200492 RVA: 0x006A39B7 File Offset: 0x006A1BB7
		// (set) Token: 0x06030F2D RID: 200493 RVA: 0x006A39BF File Offset: 0x006A1BBF
		public TVarContextUnion VarContext { get; set; }

		// Token: 0x1700CF93 RID: 53139
		// (get) Token: 0x06030F2E RID: 200494 RVA: 0x006A39C8 File Offset: 0x006A1BC8
		// (set) Token: 0x06030F2F RID: 200495 RVA: 0x006A39D0 File Offset: 0x006A1BD0
		public List<IStateInfoT> States { get; set; }

		// Token: 0x1700CF94 RID: 53140
		// (get) Token: 0x06030F30 RID: 200496 RVA: 0x006A39D9 File Offset: 0x006A1BD9
		// (set) Token: 0x06030F31 RID: 200497 RVA: 0x006A39E1 File Offset: 0x006A1BE1
		public byte NullMask { get; set; }

		// Token: 0x06030F32 RID: 200498 RVA: 0x006A39EC File Offset: 0x006A1BEC
		public IFlowInfoT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Id = 0;
			this.Name = null;
			this.DungeonId = 0;
			this._Folded = false;
			this._SelectedStateId = 0;
			this._SelectedStateIds = null;
			this.VarContext = null;
			this.States = null;
			this.NullMask = 0;
		}
	}
}
