using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044FE RID: 17662
	public class ILevelPlayInfoMappingSoaringChallengeT
	{
		// Token: 0x17007D32 RID: 32050
		// (get) Token: 0x0601A861 RID: 108641 RVA: 0x003C9CCB File Offset: 0x003C7ECB
		// (set) Token: 0x0601A862 RID: 108642 RVA: 0x003C9CD3 File Offset: 0x003C7ED3
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x17007D33 RID: 32051
		// (get) Token: 0x0601A863 RID: 108643 RVA: 0x003C9CDC File Offset: 0x003C7EDC
		// (set) Token: 0x0601A864 RID: 108644 RVA: 0x003C9CE4 File Offset: 0x003C7EE4
		public int LevelPlayId { get; set; }

		// Token: 0x17007D34 RID: 32052
		// (get) Token: 0x0601A865 RID: 108645 RVA: 0x003C9CED File Offset: 0x003C7EED
		// (set) Token: 0x0601A866 RID: 108646 RVA: 0x003C9CF5 File Offset: 0x003C7EF5
		public List<string> Vars { get; set; }

		// Token: 0x17007D35 RID: 32053
		// (get) Token: 0x0601A867 RID: 108647 RVA: 0x003C9CFE File Offset: 0x003C7EFE
		// (set) Token: 0x0601A868 RID: 108648 RVA: 0x003C9D06 File Offset: 0x003C7F06
		public byte NullMask { get; set; }

		// Token: 0x0601A869 RID: 108649 RVA: 0x003C9D0F File Offset: 0x003C7F0F
		public ILevelPlayInfoMappingSoaringChallengeT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
			this.LevelPlayId = 0;
			this.Vars = null;
			this.NullMask = 0;
		}
	}
}
