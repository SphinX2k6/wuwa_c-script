using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006483 RID: 25731
	public class IProcessedValueConstraintT
	{
		// Token: 0x1700BDD8 RID: 48600
		// (get) Token: 0x0602BB97 RID: 179095 RVA: 0x005F2F73 File Offset: 0x005F1173
		// (set) Token: 0x0602BB98 RID: 179096 RVA: 0x005F2F7B File Offset: 0x005F117B
		public EProcessedValueType Type { get; set; }

		// Token: 0x1700BDD9 RID: 48601
		// (get) Token: 0x0602BB99 RID: 179097 RVA: 0x005F2F84 File Offset: 0x005F1184
		// (set) Token: 0x0602BB9A RID: 179098 RVA: 0x005F2F8C File Offset: 0x005F118C
		public TConstraintValueUnion Value { get; set; }

		// Token: 0x0602BB9B RID: 179099 RVA: 0x005F2F95 File Offset: 0x005F1195
		public IProcessedValueConstraintT()
		{
			this.Type = EProcessedValueType.Constant;
			this.Value = null;
		}
	}
}
