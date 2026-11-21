using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C32 RID: 19506
	public class IEntityPrefabT
	{
		// Token: 0x17008A48 RID: 35400
		// (get) Token: 0x0601DE16 RID: 122390 RVA: 0x00430B73 File Offset: 0x0042ED73
		// (set) Token: 0x0601DE17 RID: 122391 RVA: 0x00430B7B File Offset: 0x0042ED7B
		public string ObjType { get; set; }

		// Token: 0x17008A49 RID: 35401
		// (get) Token: 0x0601DE18 RID: 122392 RVA: 0x00430B84 File Offset: 0x0042ED84
		// (set) Token: 0x0601DE19 RID: 122393 RVA: 0x00430B8C File Offset: 0x0042ED8C
		public List<string> Children { get; set; }

		// Token: 0x17008A4A RID: 35402
		// (get) Token: 0x0601DE1A RID: 122394 RVA: 0x00430B95 File Offset: 0x0042ED95
		// (set) Token: 0x0601DE1B RID: 122395 RVA: 0x00430B9D File Offset: 0x0042ED9D
		public List<string> Reference { get; set; }

		// Token: 0x17008A4B RID: 35403
		// (get) Token: 0x0601DE1C RID: 122396 RVA: 0x00430BA6 File Offset: 0x0042EDA6
		// (set) Token: 0x0601DE1D RID: 122397 RVA: 0x00430BAE File Offset: 0x0042EDAE
		public List<string> WeakReference { get; set; }

		// Token: 0x17008A4C RID: 35404
		// (get) Token: 0x0601DE1E RID: 122398 RVA: 0x00430BB7 File Offset: 0x0042EDB7
		// (set) Token: 0x0601DE1F RID: 122399 RVA: 0x00430BBF File Offset: 0x0042EDBF
		public int PrefabId { get; set; }

		// Token: 0x17008A4D RID: 35405
		// (get) Token: 0x0601DE20 RID: 122400 RVA: 0x00430BC8 File Offset: 0x0042EDC8
		// (set) Token: 0x0601DE21 RID: 122401 RVA: 0x00430BD0 File Offset: 0x0042EDD0
		public string Name { get; set; }

		// Token: 0x17008A4E RID: 35406
		// (get) Token: 0x0601DE22 RID: 122402 RVA: 0x00430BD9 File Offset: 0x0042EDD9
		// (set) Token: 0x0601DE23 RID: 122403 RVA: 0x00430BE1 File Offset: 0x0042EDE1
		public List<IEntityPrefabElementT> Entities { get; set; }

		// Token: 0x17008A4F RID: 35407
		// (get) Token: 0x0601DE24 RID: 122404 RVA: 0x00430BEA File Offset: 0x0042EDEA
		// (set) Token: 0x0601DE25 RID: 122405 RVA: 0x00430BF2 File Offset: 0x0042EDF2
		public string BpPath { get; set; }

		// Token: 0x17008A50 RID: 35408
		// (get) Token: 0x0601DE26 RID: 122406 RVA: 0x00430BFB File Offset: 0x0042EDFB
		// (set) Token: 0x0601DE27 RID: 122407 RVA: 0x00430C03 File Offset: 0x0042EE03
		public int _SelectedEntityId { get; set; }

		// Token: 0x17008A51 RID: 35409
		// (get) Token: 0x0601DE28 RID: 122408 RVA: 0x00430C0C File Offset: 0x0042EE0C
		// (set) Token: 0x0601DE29 RID: 122409 RVA: 0x00430C14 File Offset: 0x0042EE14
		public byte NullMask { get; set; }

		// Token: 0x0601DE2A RID: 122410 RVA: 0x00430C20 File Offset: 0x0042EE20
		public IEntityPrefabT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.PrefabId = 0;
			this.Name = null;
			this.Entities = null;
			this.BpPath = null;
			this._SelectedEntityId = 0;
			this.NullMask = 0;
		}
	}
}
