using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F2 RID: 17650
	public class ILevelPlayInfoMappingBaseT
	{
		// Token: 0x17007D14 RID: 32020
		// (get) Token: 0x0601A7D3 RID: 108499 RVA: 0x003C8B3A File Offset: 0x003C6D3A
		// (set) Token: 0x0601A7D4 RID: 108500 RVA: 0x003C8B42 File Offset: 0x003C6D42
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x0601A7D5 RID: 108501 RVA: 0x003C8B4B File Offset: 0x003C6D4B
		public ILevelPlayInfoMappingBaseT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
		}
	}
}
