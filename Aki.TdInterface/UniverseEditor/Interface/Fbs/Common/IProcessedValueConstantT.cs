using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E40 RID: 24128
	public class IProcessedValueConstantT
	{
		// Token: 0x1700B46A RID: 46186
		// (get) Token: 0x060294E0 RID: 169184 RVA: 0x005A9D1C File Offset: 0x005A7F1C
		// (set) Token: 0x060294E1 RID: 169185 RVA: 0x005A9D24 File Offset: 0x005A7F24
		public EProcessedValueType Type { get; set; }

		// Token: 0x1700B46B RID: 46187
		// (get) Token: 0x060294E2 RID: 169186 RVA: 0x005A9D2D File Offset: 0x005A7F2D
		// (set) Token: 0x060294E3 RID: 169187 RVA: 0x005A9D35 File Offset: 0x005A7F35
		public float Value { get; set; }

		// Token: 0x060294E4 RID: 169188 RVA: 0x005A9D3E File Offset: 0x005A7F3E
		public IProcessedValueConstantT()
		{
			this.Type = EProcessedValueType.Constant;
			this.Value = 0f;
		}
	}
}
