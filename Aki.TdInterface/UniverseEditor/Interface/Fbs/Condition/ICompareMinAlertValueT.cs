using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A1 RID: 20641
	public class ICompareMinAlertValueT
	{
		// Token: 0x170093D4 RID: 37844
		// (get) Token: 0x060204E0 RID: 132320 RVA: 0x004797CA File Offset: 0x004779CA
		// (set) Token: 0x060204E1 RID: 132321 RVA: 0x004797D2 File Offset: 0x004779D2
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x060204E2 RID: 132322 RVA: 0x004797DB File Offset: 0x004779DB
		public ICompareMinAlertValueT()
		{
			this.Type = EComparedAlertValueType.Min;
		}
	}
}
