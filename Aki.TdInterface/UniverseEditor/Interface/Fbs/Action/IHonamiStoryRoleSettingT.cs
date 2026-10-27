using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006931 RID: 26929
	public class IHonamiStoryRoleSettingT
	{
		// Token: 0x1700C7C9 RID: 51145
		// (get) Token: 0x0602F03A RID: 192570 RVA: 0x00668C24 File Offset: 0x00666E24
		// (set) Token: 0x0602F03B RID: 192571 RVA: 0x00668C2C File Offset: 0x00666E2C
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x1700C7CA RID: 51146
		// (get) Token: 0x0602F03C RID: 192572 RVA: 0x00668C35 File Offset: 0x00666E35
		// (set) Token: 0x0602F03D RID: 192573 RVA: 0x00668C3D File Offset: 0x00666E3D
		public int RoleId { get; set; }

		// Token: 0x0602F03E RID: 192574 RVA: 0x00668C46 File Offset: 0x00666E46
		public IHonamiStoryRoleSettingT()
		{
			this.RoleSlot = EHonamiStoryRoleSlot.None;
			this.RoleId = 0;
		}
	}
}
