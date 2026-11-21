using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BFC RID: 19452
	public class IEntityBaseT
	{
		// Token: 0x170089B8 RID: 35256
		// (get) Token: 0x0601DB9C RID: 121756 RVA: 0x0042BB16 File Offset: 0x00429D16
		// (set) Token: 0x0601DB9D RID: 121757 RVA: 0x0042BB1E File Offset: 0x00429D1E
		public string ObjType { get; set; }

		// Token: 0x170089B9 RID: 35257
		// (get) Token: 0x0601DB9E RID: 121758 RVA: 0x0042BB27 File Offset: 0x00429D27
		// (set) Token: 0x0601DB9F RID: 121759 RVA: 0x0042BB2F File Offset: 0x00429D2F
		public List<string> Children { get; set; }

		// Token: 0x170089BA RID: 35258
		// (get) Token: 0x0601DBA0 RID: 121760 RVA: 0x0042BB38 File Offset: 0x00429D38
		// (set) Token: 0x0601DBA1 RID: 121761 RVA: 0x0042BB40 File Offset: 0x00429D40
		public List<string> Reference { get; set; }

		// Token: 0x170089BB RID: 35259
		// (get) Token: 0x0601DBA2 RID: 121762 RVA: 0x0042BB49 File Offset: 0x00429D49
		// (set) Token: 0x0601DBA3 RID: 121763 RVA: 0x0042BB51 File Offset: 0x00429D51
		public List<string> WeakReference { get; set; }

		// Token: 0x170089BC RID: 35260
		// (get) Token: 0x0601DBA4 RID: 121764 RVA: 0x0042BB5A File Offset: 0x00429D5A
		// (set) Token: 0x0601DBA5 RID: 121765 RVA: 0x0042BB62 File Offset: 0x00429D62
		public string Name { get; set; }

		// Token: 0x170089BD RID: 35261
		// (get) Token: 0x0601DBA6 RID: 121766 RVA: 0x0042BB6B File Offset: 0x00429D6B
		// (set) Token: 0x0601DBA7 RID: 121767 RVA: 0x0042BB73 File Offset: 0x00429D73
		public string BlueprintType { get; set; }

		// Token: 0x170089BE RID: 35262
		// (get) Token: 0x0601DBA8 RID: 121768 RVA: 0x0042BB7C File Offset: 0x00429D7C
		// (set) Token: 0x0601DBA9 RID: 121769 RVA: 0x0042BB84 File Offset: 0x00429D84
		public TComponentsDataT ComponentsData { get; set; }

		// Token: 0x170089BF RID: 35263
		// (get) Token: 0x0601DBAA RID: 121770 RVA: 0x0042BB8D File Offset: 0x00429D8D
		// (set) Token: 0x0601DBAB RID: 121771 RVA: 0x0042BB95 File Offset: 0x00429D95
		public byte NullMask { get; set; }

		// Token: 0x0601DBAC RID: 121772 RVA: 0x0042BB9E File Offset: 0x00429D9E
		public IEntityBaseT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Name = null;
			this.BlueprintType = null;
			this.ComponentsData = null;
			this.NullMask = 0;
		}
	}
}
