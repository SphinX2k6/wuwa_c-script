using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A67 RID: 19047
	public class ICheckHonamiStoryTowerCompleteT
	{
		// Token: 0x170089EA RID: 35306
		// (get) Token: 0x0601DD70 RID: 122224 RVA: 0x0043152A File Offset: 0x0042F72A
		// (set) Token: 0x0601DD71 RID: 122225 RVA: 0x00431532 File Offset: 0x0042F732
		public ECondition Type { get; set; }

		// Token: 0x170089EB RID: 35307
		// (get) Token: 0x0601DD72 RID: 122226 RVA: 0x0043153B File Offset: 0x0042F73B
		// (set) Token: 0x0601DD73 RID: 122227 RVA: 0x00431543 File Offset: 0x0042F743
		public int ActivityId { get; set; }

		// Token: 0x170089EC RID: 35308
		// (get) Token: 0x0601DD74 RID: 122228 RVA: 0x0043154C File Offset: 0x0042F74C
		// (set) Token: 0x0601DD75 RID: 122229 RVA: 0x00431554 File Offset: 0x0042F754
		public int Floor { get; set; }

		// Token: 0x0601DD76 RID: 122230 RVA: 0x0043155D File Offset: 0x0042F75D
		public ICheckHonamiStoryTowerCompleteT()
		{
			this.Type = ECondition.CompareVar;
			this.ActivityId = 0;
			this.Floor = 0;
		}
	}
}
