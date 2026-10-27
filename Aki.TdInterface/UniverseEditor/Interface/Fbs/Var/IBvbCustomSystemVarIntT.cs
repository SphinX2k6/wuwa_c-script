using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A4F RID: 14927
	public class IBvbCustomSystemVarIntT
	{
		// Token: 0x17006656 RID: 26198
		// (get) Token: 0x06014390 RID: 82832 RVA: 0x002F47FC File Offset: 0x002F29FC
		// (set) Token: 0x06014391 RID: 82833 RVA: 0x002F4804 File Offset: 0x002F2A04
		public ESystemVarName Type { get; set; }

		// Token: 0x17006657 RID: 26199
		// (get) Token: 0x06014392 RID: 82834 RVA: 0x002F480D File Offset: 0x002F2A0D
		// (set) Token: 0x06014393 RID: 82835 RVA: 0x002F4815 File Offset: 0x002F2A15
		public string VarName { get; set; }

		// Token: 0x17006658 RID: 26200
		// (get) Token: 0x06014394 RID: 82836 RVA: 0x002F481E File Offset: 0x002F2A1E
		// (set) Token: 0x06014395 RID: 82837 RVA: 0x002F4826 File Offset: 0x002F2A26
		public string VarParams { get; set; }

		// Token: 0x06014396 RID: 82838 RVA: 0x002F482F File Offset: 0x002F2A2F
		public IBvbCustomSystemVarIntT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.VarName = null;
			this.VarParams = null;
		}
	}
}
