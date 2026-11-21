using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDE RID: 28638
	public class IHonamiStoryPluginEquipSettingT
	{
		// Token: 0x1700D1BD RID: 53693
		// (get) Token: 0x060319D2 RID: 203218 RVA: 0x006B8B8E File Offset: 0x006B6D8E
		// (set) Token: 0x060319D3 RID: 203219 RVA: 0x006B8B96 File Offset: 0x006B6D96
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x1700D1BE RID: 53694
		// (get) Token: 0x060319D4 RID: 203220 RVA: 0x006B8B9F File Offset: 0x006B6D9F
		// (set) Token: 0x060319D5 RID: 203221 RVA: 0x006B8BA7 File Offset: 0x006B6DA7
		public EHonamiStoryPluginSlot PluginSlot { get; set; }

		// Token: 0x1700D1BF RID: 53695
		// (get) Token: 0x060319D6 RID: 203222 RVA: 0x006B8BB0 File Offset: 0x006B6DB0
		// (set) Token: 0x060319D7 RID: 203223 RVA: 0x006B8BB8 File Offset: 0x006B6DB8
		public int PluginId { get; set; }

		// Token: 0x060319D8 RID: 203224 RVA: 0x006B8BC1 File Offset: 0x006B6DC1
		public IHonamiStoryPluginEquipSettingT()
		{
			this.RoleSlot = EHonamiStoryRoleSlot.None;
			this.PluginSlot = EHonamiStoryPluginSlot.None;
			this.PluginId = 0;
		}
	}
}
