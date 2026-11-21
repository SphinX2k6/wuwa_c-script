using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE4 RID: 28644
	public class IHonamiStoryRoleSettingT
	{
		// Token: 0x1700D1CC RID: 53708
		// (get) Token: 0x06031A0A RID: 203274 RVA: 0x006B910C File Offset: 0x006B730C
		// (set) Token: 0x06031A0B RID: 203275 RVA: 0x006B9114 File Offset: 0x006B7314
		public EHonamiStoryRoleSlot RoleSlot { get; set; }

		// Token: 0x1700D1CD RID: 53709
		// (get) Token: 0x06031A0C RID: 203276 RVA: 0x006B911D File Offset: 0x006B731D
		// (set) Token: 0x06031A0D RID: 203277 RVA: 0x006B9125 File Offset: 0x006B7325
		public int RoleId { get; set; }

		// Token: 0x06031A0E RID: 203278 RVA: 0x006B912E File Offset: 0x006B732E
		public IHonamiStoryRoleSettingT()
		{
			this.RoleSlot = EHonamiStoryRoleSlot.None;
			this.RoleId = 0;
		}
	}
}
