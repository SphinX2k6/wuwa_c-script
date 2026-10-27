using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A6D RID: 19053
	public class ICheckHonamiStoryUnlockSlotT
	{
		// Token: 0x170089FA RID: 35322
		// (get) Token: 0x0601DDA8 RID: 122280 RVA: 0x00431B1A File Offset: 0x0042FD1A
		// (set) Token: 0x0601DDA9 RID: 122281 RVA: 0x00431B22 File Offset: 0x0042FD22
		public ECondition Type { get; set; }

		// Token: 0x170089FB RID: 35323
		// (get) Token: 0x0601DDAA RID: 122282 RVA: 0x00431B2B File Offset: 0x0042FD2B
		// (set) Token: 0x0601DDAB RID: 122283 RVA: 0x00431B33 File Offset: 0x0042FD33
		public int ActivityId { get; set; }

		// Token: 0x170089FC RID: 35324
		// (get) Token: 0x0601DDAC RID: 122284 RVA: 0x00431B3C File Offset: 0x0042FD3C
		// (set) Token: 0x0601DDAD RID: 122285 RVA: 0x00431B44 File Offset: 0x0042FD44
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x170089FD RID: 35325
		// (get) Token: 0x0601DDAE RID: 122286 RVA: 0x00431B4D File Offset: 0x0042FD4D
		// (set) Token: 0x0601DDAF RID: 122287 RVA: 0x00431B55 File Offset: 0x0042FD55
		public EHonamiStoryPluginSlot PluginSlot { get; set; }

		// Token: 0x170089FE RID: 35326
		// (get) Token: 0x0601DDB0 RID: 122288 RVA: 0x00431B5E File Offset: 0x0042FD5E
		// (set) Token: 0x0601DDB1 RID: 122289 RVA: 0x00431B66 File Offset: 0x0042FD66
		public bool IsUnlocked { get; set; }

		// Token: 0x0601DDB2 RID: 122290 RVA: 0x00431B6F File Offset: 0x0042FD6F
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
