using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C8 RID: 17352
	public class IPhotographSubTargetAnyRoleT
	{
		// Token: 0x17007783 RID: 30595
		// (get) Token: 0x06018A23 RID: 100899 RVA: 0x00383835 File Offset: 0x00381A35
		// (set) Token: 0x06018A24 RID: 100900 RVA: 0x0038383D File Offset: 0x00381A3D
		public EPhotographSubTargetType Type { get; set; }

		// Token: 0x17007784 RID: 30596
		// (get) Token: 0x06018A25 RID: 100901 RVA: 0x00383846 File Offset: 0x00381A46
		// (set) Token: 0x06018A26 RID: 100902 RVA: 0x0038384E File Offset: 0x00381A4E
		public EOnCameraCheckType OnCameraCheckType { get; set; }

		// Token: 0x17007785 RID: 30597
		// (get) Token: 0x06018A27 RID: 100903 RVA: 0x00383857 File Offset: 0x00381A57
		// (set) Token: 0x06018A28 RID: 100904 RVA: 0x0038385F File Offset: 0x00381A5F
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06018A29 RID: 100905 RVA: 0x00383868 File Offset: 0x00381A68
		public IPhotographSubTargetAnyRoleT()
		{
			this.Type = EPhotographSubTargetType.SpecificRole;
			this.OnCameraCheckType = EOnCameraCheckType.All;
			this.Condition = null;
		}
	}
}
