using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006480 RID: 25728
	public class IProcessedValueConstantT
	{
		// Token: 0x1700BDD3 RID: 48595
		// (get) Token: 0x0602BB7C RID: 179068 RVA: 0x005F2BC4 File Offset: 0x005F0DC4
		// (set) Token: 0x0602BB7D RID: 179069 RVA: 0x005F2BCC File Offset: 0x005F0DCC
		public EProcessedValueType Type { get; set; }

		// Token: 0x1700BDD4 RID: 48596
		// (get) Token: 0x0602BB7E RID: 179070 RVA: 0x005F2BD5 File Offset: 0x005F0DD5
		// (set) Token: 0x0602BB7F RID: 179071 RVA: 0x005F2BDD File Offset: 0x005F0DDD
		public float Value { get; set; }

		// Token: 0x0602BB80 RID: 179072 RVA: 0x005F2BE6 File Offset: 0x005F0DE6
		public IProcessedValueConstantT()
		{
			this.Type = EProcessedValueType.Constant;
			this.Value = 0f;
		}
	}
}
