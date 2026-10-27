using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C43 RID: 27715
	public class IOpenSystemFunctionT
	{
		// Token: 0x1700CE67 RID: 52839
		// (get) Token: 0x06030D24 RID: 199972 RVA: 0x006A1CDE File Offset: 0x0069FEDE
		// (set) Token: 0x06030D25 RID: 199973 RVA: 0x006A1CE6 File Offset: 0x0069FEE6
		public int FunctionId { get; set; }

		// Token: 0x06030D26 RID: 199974 RVA: 0x006A1CEF File Offset: 0x0069FEEF
		public IOpenSystemFunctionT()
		{
			this.FunctionId = 0;
		}
	}
}
