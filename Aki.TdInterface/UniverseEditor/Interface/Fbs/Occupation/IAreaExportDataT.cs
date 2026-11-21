using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047EF RID: 18415
	public class IAreaExportDataT
	{
		// Token: 0x17008070 RID: 32880
		// (get) Token: 0x0601B335 RID: 111413 RVA: 0x003DAE55 File Offset: 0x003D9055
		// (set) Token: 0x0601B336 RID: 111414 RVA: 0x003DAE5D File Offset: 0x003D905D
		public string Id { get; set; }

		// Token: 0x17008071 RID: 32881
		// (get) Token: 0x0601B337 RID: 111415 RVA: 0x003DAE66 File Offset: 0x003D9066
		// (set) Token: 0x0601B338 RID: 111416 RVA: 0x003DAE6E File Offset: 0x003D906E
		public string NameStringKey { get; set; }

		// Token: 0x17008072 RID: 32882
		// (get) Token: 0x0601B339 RID: 111417 RVA: 0x003DAE77 File Offset: 0x003D9077
		// (set) Token: 0x0601B33A RID: 111418 RVA: 0x003DAE7F File Offset: 0x003D907F
		public string Name { get; set; }

		// Token: 0x17008073 RID: 32883
		// (get) Token: 0x0601B33B RID: 111419 RVA: 0x003DAE88 File Offset: 0x003D9088
		// (set) Token: 0x0601B33C RID: 111420 RVA: 0x003DAE90 File Offset: 0x003D9090
		public IAreaOccupationDataT Data { get; set; }

		// Token: 0x0601B33D RID: 111421 RVA: 0x003DAE99 File Offset: 0x003D9099
		public IAreaExportDataT()
		{
			this.Id = null;
			this.NameStringKey = null;
			this.Name = null;
			this.Data = null;
		}
	}
}
