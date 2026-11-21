using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004816 RID: 18454
	public class IOccupationExportConfigT
	{
		// Token: 0x170080CE RID: 32974
		// (get) Token: 0x0601B4F7 RID: 111863 RVA: 0x003DEA42 File Offset: 0x003DCC42
		// (set) Token: 0x0601B4F8 RID: 111864 RVA: 0x003DEA4A File Offset: 0x003DCC4A
		public string Id { get; set; }

		// Token: 0x170080CF RID: 32975
		// (get) Token: 0x0601B4F9 RID: 111865 RVA: 0x003DEA53 File Offset: 0x003DCC53
		// (set) Token: 0x0601B4FA RID: 111866 RVA: 0x003DEA5B File Offset: 0x003DCC5B
		public string NameStringKey { get; set; }

		// Token: 0x170080D0 RID: 32976
		// (get) Token: 0x0601B4FB RID: 111867 RVA: 0x003DEA64 File Offset: 0x003DCC64
		// (set) Token: 0x0601B4FC RID: 111868 RVA: 0x003DEA6C File Offset: 0x003DCC6C
		public string Name { get; set; }

		// Token: 0x0601B4FD RID: 111869 RVA: 0x003DEA75 File Offset: 0x003DCC75
		public IOccupationExportConfigT()
		{
			this.Id = null;
			this.NameStringKey = null;
			this.Name = null;
		}
	}
}
