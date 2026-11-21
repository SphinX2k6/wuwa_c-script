using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006009 RID: 24585
	public class ISunSpiritGearPerformConfigT
	{
		// Token: 0x1700B64F RID: 46671
		// (get) Token: 0x0602970A RID: 169738 RVA: 0x005A7F3A File Offset: 0x005A613A
		// (set) Token: 0x0602970B RID: 169739 RVA: 0x005A7F42 File Offset: 0x005A6142
		public ESunSpiritGearPerformType Type { get; set; }

		// Token: 0x0602970C RID: 169740 RVA: 0x005A7F4B File Offset: 0x005A614B
		public ISunSpiritGearPerformConfigT()
		{
			this.Type = ESunSpiritGearPerformType.ToGearRelativePos;
		}
	}
}
