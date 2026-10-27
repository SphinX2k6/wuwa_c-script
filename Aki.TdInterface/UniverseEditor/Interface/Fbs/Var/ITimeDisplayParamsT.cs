using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF1 RID: 15089
	public class ITimeDisplayParamsT
	{
		// Token: 0x1700677C RID: 26492
		// (get) Token: 0x060148FC RID: 84220 RVA: 0x002FE696 File Offset: 0x002FC896
		// (set) Token: 0x060148FD RID: 84221 RVA: 0x002FE69E File Offset: 0x002FC89E
		public ETimeDisplayDataSource Type { get; set; }

		// Token: 0x060148FE RID: 84222 RVA: 0x002FE6A7 File Offset: 0x002FC8A7
		public ITimeDisplayParamsT()
		{
			this.Type = ETimeDisplayDataSource.Constant;
		}
	}
}
