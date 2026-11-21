using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006012 RID: 24594
	public class ISunSpiritGearPerformToGearRelativePosT
	{
		// Token: 0x1700B65B RID: 46683
		// (get) Token: 0x06029744 RID: 169796 RVA: 0x005A8522 File Offset: 0x005A6722
		// (set) Token: 0x06029745 RID: 169797 RVA: 0x005A852A File Offset: 0x005A672A
		public ESunSpiritGearPerformType Type { get; set; }

		// Token: 0x06029746 RID: 169798 RVA: 0x005A8533 File Offset: 0x005A6733
		public ISunSpiritGearPerformToGearRelativePosT()
		{
			this.Type = ESunSpiritGearPerformType.ToGearRelativePos;
		}
	}
}
