using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006486 RID: 25734
	public class IProcessedValueTypeT
	{
		// Token: 0x1700BDDC RID: 48604
		// (get) Token: 0x0602BBAB RID: 179115 RVA: 0x005F3142 File Offset: 0x005F1342
		// (set) Token: 0x0602BBAC RID: 179116 RVA: 0x005F314A File Offset: 0x005F134A
		public EProcessedValueType Type { get; set; }

		// Token: 0x0602BBAD RID: 179117 RVA: 0x005F3153 File Offset: 0x005F1353
		public IProcessedValueTypeT()
		{
			this.Type = EProcessedValueType.Constant;
		}
	}
}
