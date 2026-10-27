using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692B RID: 26923
	public class IHonamiStoryPluginEquipSettingT
	{
		// Token: 0x1700C7BA RID: 51130
		// (get) Token: 0x0602F002 RID: 192514 RVA: 0x006686A6 File Offset: 0x006668A6
		// (set) Token: 0x0602F003 RID: 192515 RVA: 0x006686AE File Offset: 0x006668AE
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x1700C7BB RID: 51131
		// (get) Token: 0x0602F004 RID: 192516 RVA: 0x006686B7 File Offset: 0x006668B7
		// (set) Token: 0x0602F005 RID: 192517 RVA: 0x006686BF File Offset: 0x006668BF
		public EHonamiStoryPluginSlot PluginSlot { get; set; }

		// Token: 0x1700C7BC RID: 51132
		// (get) Token: 0x0602F006 RID: 192518 RVA: 0x006686C8 File Offset: 0x006668C8
		// (set) Token: 0x0602F007 RID: 192519 RVA: 0x006686D0 File Offset: 0x006668D0
		public int PluginId { get; set; }

		// Token: 0x0602F008 RID: 192520 RVA: 0x006686D9 File Offset: 0x006668D9
		public IHonamiStoryPluginEquipSettingT()
		{
			this.RoleSlot = EHonamiStoryRoleSlot.None;
			this.PluginSlot = EHonamiStoryPluginSlot.None;
			this.PluginId = 0;
		}
	}
}
