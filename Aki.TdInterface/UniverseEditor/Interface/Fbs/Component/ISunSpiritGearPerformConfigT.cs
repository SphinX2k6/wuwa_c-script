using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FC RID: 23036
	public class ISunSpiritGearPerformConfigT
	{
		// Token: 0x1700AD17 RID: 44311
		// (get) Token: 0x06027192 RID: 160146 RVA: 0x00560F76 File Offset: 0x0055F176
		// (set) Token: 0x06027193 RID: 160147 RVA: 0x00560F7E File Offset: 0x0055F17E
		public ESunSpiritGearPerformType Type { get; set; }

		// Token: 0x06027194 RID: 160148 RVA: 0x00560F87 File Offset: 0x0055F187
		public ISunSpiritGearPerformConfigT()
		{
			this.Type = ESunSpiritGearPerformType.ToGearRelativePos;
		}
	}
}
