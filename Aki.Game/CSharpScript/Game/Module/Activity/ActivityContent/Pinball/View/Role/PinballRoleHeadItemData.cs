using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200528E RID: 21134
	public class PinballRoleHeadItemData : IPinballRoleHeadItemData
	{
		// Token: 0x1700663B RID: 26171
		// (get) Token: 0x0603499A RID: 215450 RVA: 0x00EB6A2B File Offset: 0x00EB4C2B
		// (set) Token: 0x0603499B RID: 215451 RVA: 0x00EB6A33 File Offset: 0x00EB4C33
		public PinballRoleConfig RoleConfig { get; set; }

		// Token: 0x1700663C RID: 26172
		// (get) Token: 0x0603499C RID: 215452 RVA: 0x00EB6A3C File Offset: 0x00EB4C3C
		// (set) Token: 0x0603499D RID: 215453 RVA: 0x00EB6A44 File Offset: 0x00EB4C44
		public bool IsSelected { get; set; }

		// Token: 0x1700663D RID: 26173
		// (get) Token: 0x0603499E RID: 215454 RVA: 0x00EB6A4D File Offset: 0x00EB4C4D
		// (set) Token: 0x0603499F RID: 215455 RVA: 0x00EB6A55 File Offset: 0x00EB4C55
		public bool IsLocked { get; set; }

		// Token: 0x1700663E RID: 26174
		// (get) Token: 0x060349A0 RID: 215456 RVA: 0x00EB6A5E File Offset: 0x00EB4C5E
		// (set) Token: 0x060349A1 RID: 215457 RVA: 0x00EB6A66 File Offset: 0x00EB4C66
		public bool IsTrail { get; set; }

		// Token: 0x1700663F RID: 26175
		// (get) Token: 0x060349A2 RID: 215458 RVA: 0x00EB6A6F File Offset: 0x00EB4C6F
		// (set) Token: 0x060349A3 RID: 215459 RVA: 0x00EB6A77 File Offset: 0x00EB4C77
		public bool NeedRedDot { get; set; }
	}
}
