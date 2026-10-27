using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A05 RID: 23045
	public class ISunSpiritGearPerformToGearRelativePosT
	{
		// Token: 0x1700AD23 RID: 44323
		// (get) Token: 0x060271CC RID: 160204 RVA: 0x0056155E File Offset: 0x0055F75E
		// (set) Token: 0x060271CD RID: 160205 RVA: 0x00561566 File Offset: 0x0055F766
		public ESunSpiritGearPerformType Type { get; set; }

		// Token: 0x060271CE RID: 160206 RVA: 0x0056156F File Offset: 0x0055F76F
		public ISunSpiritGearPerformToGearRelativePosT()
		{
			this.Type = ESunSpiritGearPerformType.ToGearRelativePos;
		}
	}
}
