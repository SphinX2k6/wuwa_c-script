using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E43 RID: 24131
	public class IProcessedValueConstraintT
	{
		// Token: 0x1700B46F RID: 46191
		// (get) Token: 0x060294FB RID: 169211 RVA: 0x005AA0CB File Offset: 0x005A82CB
		// (set) Token: 0x060294FC RID: 169212 RVA: 0x005AA0D3 File Offset: 0x005A82D3
		public EProcessedValueType Type { get; set; }

		// Token: 0x1700B470 RID: 46192
		// (get) Token: 0x060294FD RID: 169213 RVA: 0x005AA0DC File Offset: 0x005A82DC
		// (set) Token: 0x060294FE RID: 169214 RVA: 0x005AA0E4 File Offset: 0x005A82E4
		public TConstraintValueUnion Value { get; set; }

		// Token: 0x060294FF RID: 169215 RVA: 0x005AA0ED File Offset: 0x005A82ED
		public IProcessedValueConstraintT()
		{
			this.Type = EProcessedValueType.Constant;
			this.Value = null;
		}
	}
}
