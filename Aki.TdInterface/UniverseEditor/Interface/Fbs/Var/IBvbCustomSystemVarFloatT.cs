using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A4C RID: 14924
	public class IBvbCustomSystemVarFloatT
	{
		// Token: 0x1700664F RID: 26191
		// (get) Token: 0x06014372 RID: 82802 RVA: 0x002F450C File Offset: 0x002F270C
		// (set) Token: 0x06014373 RID: 82803 RVA: 0x002F4514 File Offset: 0x002F2714
		public ESystemVarName Type { get; set; }

		// Token: 0x17006650 RID: 26192
		// (get) Token: 0x06014374 RID: 82804 RVA: 0x002F451D File Offset: 0x002F271D
		// (set) Token: 0x06014375 RID: 82805 RVA: 0x002F4525 File Offset: 0x002F2725
		public string VarName { get; set; }

		// Token: 0x17006651 RID: 26193
		// (get) Token: 0x06014376 RID: 82806 RVA: 0x002F452E File Offset: 0x002F272E
		// (set) Token: 0x06014377 RID: 82807 RVA: 0x002F4536 File Offset: 0x002F2736
		public string VarParams { get; set; }

		// Token: 0x06014378 RID: 82808 RVA: 0x002F453F File Offset: 0x002F273F
		public IBvbCustomSystemVarFloatT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.VarName = null;
			this.VarParams = null;
		}
	}
}
