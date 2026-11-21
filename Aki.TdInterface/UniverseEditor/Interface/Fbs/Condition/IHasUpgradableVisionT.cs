using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200512B RID: 20779
	public class IHasUpgradableVisionT
	{
		// Token: 0x170094E9 RID: 38121
		// (get) Token: 0x06020AD1 RID: 133841 RVA: 0x004873BC File Offset: 0x004855BC
		// (set) Token: 0x06020AD2 RID: 133842 RVA: 0x004873C4 File Offset: 0x004855C4
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x170094EA RID: 38122
		// (get) Token: 0x06020AD3 RID: 133843 RVA: 0x004873CD File Offset: 0x004855CD
		// (set) Token: 0x06020AD4 RID: 133844 RVA: 0x004873D5 File Offset: 0x004855D5
		public EHasUpgradableVisionType Option { get; set; }

		// Token: 0x06020AD5 RID: 133845 RVA: 0x004873DE File Offset: 0x004855DE
		public IHasUpgradableVisionT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = EHasUpgradableVisionType.AnyRole;
		}
	}
}
