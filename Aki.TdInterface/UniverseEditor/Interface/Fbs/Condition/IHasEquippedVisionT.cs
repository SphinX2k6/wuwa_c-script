using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C35 RID: 19509
	public class IHasEquippedVisionT
	{
		// Token: 0x17008DBB RID: 36283
		// (get) Token: 0x0601EEB7 RID: 126647 RVA: 0x004538E0 File Offset: 0x00451AE0
		// (set) Token: 0x0601EEB8 RID: 126648 RVA: 0x004538E8 File Offset: 0x00451AE8
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x17008DBC RID: 36284
		// (get) Token: 0x0601EEB9 RID: 126649 RVA: 0x004538F1 File Offset: 0x00451AF1
		// (set) Token: 0x0601EEBA RID: 126650 RVA: 0x004538F9 File Offset: 0x00451AF9
		public EHasEquippedVisionType Option { get; set; }

		// Token: 0x0601EEBB RID: 126651 RVA: 0x00453902 File Offset: 0x00451B02
		public IHasEquippedVisionT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = EHasEquippedVisionType.AnyRole;
		}
	}
}
