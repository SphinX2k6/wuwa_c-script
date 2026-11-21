using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007778 RID: 30584
	public class ISetAssistCharacterPosT
	{
		// Token: 0x1700E024 RID: 57380
		// (get) Token: 0x06035AEF RID: 219887 RVA: 0x007319EF File Offset: 0x0072FBEF
		// (set) Token: 0x06035AF0 RID: 219888 RVA: 0x007319F7 File Offset: 0x0072FBF7
		public int Id { get; set; }

		// Token: 0x1700E025 RID: 57381
		// (get) Token: 0x06035AF1 RID: 219889 RVA: 0x00731A00 File Offset: 0x0072FC00
		// (set) Token: 0x06035AF2 RID: 219890 RVA: 0x00731A08 File Offset: 0x0072FC08
		public IPosAT Pos { get; set; }

		// Token: 0x06035AF3 RID: 219891 RVA: 0x00731A11 File Offset: 0x0072FC11
		public ISetAssistCharacterPosT()
		{
			this.Id = 0;
			this.Pos = null;
		}
	}
}
