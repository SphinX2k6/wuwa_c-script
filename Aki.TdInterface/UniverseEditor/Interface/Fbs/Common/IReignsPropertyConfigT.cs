using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E58 RID: 24152
	public class IReignsPropertyConfigT
	{
		// Token: 0x1700B49D RID: 46237
		// (get) Token: 0x060295D1 RID: 169425 RVA: 0x005ABB2C File Offset: 0x005A9D2C
		// (set) Token: 0x060295D2 RID: 169426 RVA: 0x005ABB34 File Offset: 0x005A9D34
		public int Id { get; set; }

		// Token: 0x1700B49E RID: 46238
		// (get) Token: 0x060295D3 RID: 169427 RVA: 0x005ABB3D File Offset: 0x005A9D3D
		// (set) Token: 0x060295D4 RID: 169428 RVA: 0x005ABB45 File Offset: 0x005A9D45
		public int BaseValue { get; set; }

		// Token: 0x1700B49F RID: 46239
		// (get) Token: 0x060295D5 RID: 169429 RVA: 0x005ABB4E File Offset: 0x005A9D4E
		// (set) Token: 0x060295D6 RID: 169430 RVA: 0x005ABB56 File Offset: 0x005A9D56
		public int MaxValue { get; set; }

		// Token: 0x1700B4A0 RID: 46240
		// (get) Token: 0x060295D7 RID: 169431 RVA: 0x005ABB5F File Offset: 0x005A9D5F
		// (set) Token: 0x060295D8 RID: 169432 RVA: 0x005ABB67 File Offset: 0x005A9D67
		public bool IsDefaultEnable { get; set; }

		// Token: 0x060295D9 RID: 169433 RVA: 0x005ABB70 File Offset: 0x005A9D70
		public IReignsPropertyConfigT()
		{
			this.Id = 0;
			this.BaseValue = 0;
			this.MaxValue = 0;
			this.IsDefaultEnable = false;
		}
	}
}
