using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E27 RID: 15911
	public class IBvbCustomSystemVarFloatT
	{
		// Token: 0x17006B7F RID: 27519
		// (get) Token: 0x0601568E RID: 87694 RVA: 0x003176F8 File Offset: 0x003158F8
		// (set) Token: 0x0601568F RID: 87695 RVA: 0x00317700 File Offset: 0x00315900
		public ESystemVarName Type { get; set; }

		// Token: 0x17006B80 RID: 27520
		// (get) Token: 0x06015690 RID: 87696 RVA: 0x00317709 File Offset: 0x00315909
		// (set) Token: 0x06015691 RID: 87697 RVA: 0x00317711 File Offset: 0x00315911
		public string VarName { get; set; }

		// Token: 0x17006B81 RID: 27521
		// (get) Token: 0x06015692 RID: 87698 RVA: 0x0031771A File Offset: 0x0031591A
		// (set) Token: 0x06015693 RID: 87699 RVA: 0x00317722 File Offset: 0x00315922
		public string VarParams { get; set; }

		// Token: 0x06015694 RID: 87700 RVA: 0x0031772B File Offset: 0x0031592B
		public IBvbCustomSystemVarFloatT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.VarName = null;
			this.VarParams = null;
		}
	}
}
