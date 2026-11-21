using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063DE RID: 25566
	public class IElementalBoxConfigT
	{
		// Token: 0x1700BCE8 RID: 48360
		// (get) Token: 0x0602B6EA RID: 177898 RVA: 0x005EB0F4 File Offset: 0x005E92F4
		// (set) Token: 0x0602B6EB RID: 177899 RVA: 0x005EB0FC File Offset: 0x005E92FC
		public int Id { get; set; }

		// Token: 0x1700BCE9 RID: 48361
		// (get) Token: 0x0602B6EC RID: 177900 RVA: 0x005EB105 File Offset: 0x005E9305
		// (set) Token: 0x0602B6ED RID: 177901 RVA: 0x005EB10D File Offset: 0x005E930D
		public string Desc { get; set; }

		// Token: 0x1700BCEA RID: 48362
		// (get) Token: 0x0602B6EE RID: 177902 RVA: 0x005EB116 File Offset: 0x005E9316
		// (set) Token: 0x0602B6EF RID: 177903 RVA: 0x005EB11E File Offset: 0x005E931E
		public EElementalType ElementalType { get; set; }

		// Token: 0x1700BCEB RID: 48363
		// (get) Token: 0x0602B6F0 RID: 177904 RVA: 0x005EB127 File Offset: 0x005E9327
		// (set) Token: 0x0602B6F1 RID: 177905 RVA: 0x005EB12F File Offset: 0x005E932F
		public int Priority { get; set; }

		// Token: 0x1700BCEC RID: 48364
		// (get) Token: 0x0602B6F2 RID: 177906 RVA: 0x005EB138 File Offset: 0x005E9338
		// (set) Token: 0x0602B6F3 RID: 177907 RVA: 0x005EB140 File Offset: 0x005E9340
		public string InitState { get; set; }

		// Token: 0x1700BCED RID: 48365
		// (get) Token: 0x0602B6F4 RID: 177908 RVA: 0x005EB149 File Offset: 0x005E9349
		// (set) Token: 0x0602B6F5 RID: 177909 RVA: 0x005EB151 File Offset: 0x005E9351
		public string CustomBoxPrefab { get; set; }

		// Token: 0x0602B6F6 RID: 177910 RVA: 0x005EB15A File Offset: 0x005E935A
		public IElementalBoxConfigT()
		{
			this.Id = 0;
			this.Desc = null;
			this.ElementalType = EElementalType.Fire;
			this.Priority = 0;
			this.InitState = null;
			this.CustomBoxPrefab = null;
		}
	}
}
