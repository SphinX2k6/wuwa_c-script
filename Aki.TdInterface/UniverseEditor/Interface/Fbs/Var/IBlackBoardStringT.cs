using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A1C RID: 14876
	public class IBlackBoardStringT
	{
		// Token: 0x170065FA RID: 26106
		// (get) Token: 0x060141D5 RID: 82389 RVA: 0x002F16E4 File Offset: 0x002EF8E4
		// (set) Token: 0x060141D6 RID: 82390 RVA: 0x002F16EC File Offset: 0x002EF8EC
		public EBlackBoardType Type { get; set; }

		// Token: 0x170065FB RID: 26107
		// (get) Token: 0x060141D7 RID: 82391 RVA: 0x002F16F5 File Offset: 0x002EF8F5
		// (set) Token: 0x060141D8 RID: 82392 RVA: 0x002F16FD File Offset: 0x002EF8FD
		public string Key { get; set; }

		// Token: 0x170065FC RID: 26108
		// (get) Token: 0x060141D9 RID: 82393 RVA: 0x002F1706 File Offset: 0x002EF906
		// (set) Token: 0x060141DA RID: 82394 RVA: 0x002F170E File Offset: 0x002EF90E
		public string Value { get; set; }

		// Token: 0x060141DB RID: 82395 RVA: 0x002F1717 File Offset: 0x002EF917
		public IBlackBoardStringT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = null;
		}
	}
}
