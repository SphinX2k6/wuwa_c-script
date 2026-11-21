using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678B RID: 26507
	public class IAddEntityDecorationT
	{
		// Token: 0x1700C0BA RID: 49338
		// (get) Token: 0x0602CF28 RID: 184104 RVA: 0x00624D2F File Offset: 0x00622F2F
		// (set) Token: 0x0602CF29 RID: 184105 RVA: 0x00624D37 File Offset: 0x00622F37
		public EEntityDecorationType Type { get; set; }

		// Token: 0x1700C0BB RID: 49339
		// (get) Token: 0x0602CF2A RID: 184106 RVA: 0x00624D40 File Offset: 0x00622F40
		// (set) Token: 0x0602CF2B RID: 184107 RVA: 0x00624D48 File Offset: 0x00622F48
		public string DecorationId { get; set; }

		// Token: 0x0602CF2C RID: 184108 RVA: 0x00624D51 File Offset: 0x00622F51
		public IAddEntityDecorationT()
		{
			this.Type = EEntityDecorationType.Add;
			this.DecorationId = null;
		}
	}
}
