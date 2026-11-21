using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005128 RID: 20776
	public class IHasEquippedVisionT
	{
		// Token: 0x170094E4 RID: 38116
		// (get) Token: 0x06020ABB RID: 133819 RVA: 0x004871BC File Offset: 0x004853BC
		// (set) Token: 0x06020ABC RID: 133820 RVA: 0x004871C4 File Offset: 0x004853C4
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x170094E5 RID: 38117
		// (get) Token: 0x06020ABD RID: 133821 RVA: 0x004871CD File Offset: 0x004853CD
		// (set) Token: 0x06020ABE RID: 133822 RVA: 0x004871D5 File Offset: 0x004853D5
		public EHasEquippedVisionType Option { get; set; }

		// Token: 0x06020ABF RID: 133823 RVA: 0x004871DE File Offset: 0x004853DE
		public IHasEquippedVisionT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = EHasEquippedVisionType.AnyRole;
		}
	}
}
