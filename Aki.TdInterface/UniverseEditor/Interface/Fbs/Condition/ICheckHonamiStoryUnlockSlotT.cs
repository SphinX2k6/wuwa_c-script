using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F33 RID: 20275
	public class ICheckHonamiStoryUnlockSlotT
	{
		// Token: 0x170090D6 RID: 37078
		// (get) Token: 0x0601F84B RID: 129099 RVA: 0x00462CA6 File Offset: 0x00460EA6
		// (set) Token: 0x0601F84C RID: 129100 RVA: 0x00462CAE File Offset: 0x00460EAE
		public ECondition Type { get; set; }

		// Token: 0x170090D7 RID: 37079
		// (get) Token: 0x0601F84D RID: 129101 RVA: 0x00462CB7 File Offset: 0x00460EB7
		// (set) Token: 0x0601F84E RID: 129102 RVA: 0x00462CBF File Offset: 0x00460EBF
		public int ActivityId { get; set; }

		// Token: 0x170090D8 RID: 37080
		// (get) Token: 0x0601F84F RID: 129103 RVA: 0x00462CC8 File Offset: 0x00460EC8
		// (set) Token: 0x0601F850 RID: 129104 RVA: 0x00462CD0 File Offset: 0x00460ED0
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x170090D9 RID: 37081
		// (get) Token: 0x0601F851 RID: 129105 RVA: 0x00462CD9 File Offset: 0x00460ED9
		// (set) Token: 0x0601F852 RID: 129106 RVA: 0x00462CE1 File Offset: 0x00460EE1
		public EHonamiStoryPluginSlot PluginSlot { get; set; }

		// Token: 0x170090DA RID: 37082
		// (get) Token: 0x0601F853 RID: 129107 RVA: 0x00462CEA File Offset: 0x00460EEA
		// (set) Token: 0x0601F854 RID: 129108 RVA: 0x00462CF2 File Offset: 0x00460EF2
		public bool IsUnlocked { get; set; }

		// Token: 0x0601F855 RID: 129109 RVA: 0x00462CFB File Offset: 0x00460EFB
		public ICheckHonamiStoryUnlockSlotT()
		{
			this.Type = ECondition.CompareVar;
			this.ActivityId = 0;
			this.RoleSlot = EHonamiStoryRoleSlot.None;
			this.PluginSlot = EHonamiStoryPluginSlot.None;
			this.IsUnlocked = false;
		}
	}
}
