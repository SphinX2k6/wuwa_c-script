using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044FB RID: 17659
	public class ILevelPlayInfoMappingPunishReportT
	{
		// Token: 0x17007D28 RID: 32040
		// (get) Token: 0x0601A83B RID: 108603 RVA: 0x003C984C File Offset: 0x003C7A4C
		// (set) Token: 0x0601A83C RID: 108604 RVA: 0x003C9854 File Offset: 0x003C7A54
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x17007D29 RID: 32041
		// (get) Token: 0x0601A83D RID: 108605 RVA: 0x003C985D File Offset: 0x003C7A5D
		// (set) Token: 0x0601A83E RID: 108606 RVA: 0x003C9865 File Offset: 0x003C7A65
		public int LevelPlayId { get; set; }

		// Token: 0x17007D2A RID: 32042
		// (get) Token: 0x0601A83F RID: 108607 RVA: 0x003C986E File Offset: 0x003C7A6E
		// (set) Token: 0x0601A840 RID: 108608 RVA: 0x003C9876 File Offset: 0x003C7A76
		public List<string> Vars { get; set; }

		// Token: 0x17007D2B RID: 32043
		// (get) Token: 0x0601A841 RID: 108609 RVA: 0x003C987F File Offset: 0x003C7A7F
		// (set) Token: 0x0601A842 RID: 108610 RVA: 0x003C9887 File Offset: 0x003C7A87
		public List<int> Chests { get; set; }

		// Token: 0x17007D2C RID: 32044
		// (get) Token: 0x0601A843 RID: 108611 RVA: 0x003C9890 File Offset: 0x003C7A90
		// (set) Token: 0x0601A844 RID: 108612 RVA: 0x003C9898 File Offset: 0x003C7A98
		public byte NullMask { get; set; }

		// Token: 0x0601A845 RID: 108613 RVA: 0x003C98A1 File Offset: 0x003C7AA1
		public ILevelPlayInfoMappingPunishReportT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
			this.LevelPlayId = 0;
			this.Vars = null;
			this.Chests = null;
			this.NullMask = 0;
		}
	}
}
