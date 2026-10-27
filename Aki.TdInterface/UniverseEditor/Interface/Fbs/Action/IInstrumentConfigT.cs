using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696A RID: 26986
	public class IInstrumentConfigT
	{
		// Token: 0x1700C821 RID: 51233
		// (get) Token: 0x0602F1DC RID: 192988 RVA: 0x0066B639 File Offset: 0x00669839
		// (set) Token: 0x0602F1DD RID: 192989 RVA: 0x0066B641 File Offset: 0x00669841
		public int Id { get; set; }

		// Token: 0x1700C822 RID: 51234
		// (get) Token: 0x0602F1DE RID: 192990 RVA: 0x0066B64A File Offset: 0x0066984A
		// (set) Token: 0x0602F1DF RID: 192991 RVA: 0x0066B652 File Offset: 0x00669852
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x1700C823 RID: 51235
		// (get) Token: 0x0602F1E0 RID: 192992 RVA: 0x0066B65B File Offset: 0x0066985B
		// (set) Token: 0x0602F1E1 RID: 192993 RVA: 0x0066B663 File Offset: 0x00669863
		public IInstrumentKeyConfigsT KeyConfigs { get; set; }

		// Token: 0x0602F1E2 RID: 192994 RVA: 0x0066B66C File Offset: 0x0066986C
		public IInstrumentConfigT()
		{
			this.Id = 0;
			this.InstrumentType = EInstrumentType.ChineseZither;
			this.KeyConfigs = null;
		}
	}
}
