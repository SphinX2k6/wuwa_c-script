using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006310 RID: 25360
	public class PinballRoleHeadItemData : IPinballRoleHeadItemData
	{
		// Token: 0x170092D9 RID: 37593
		// (get) Token: 0x0603FCD9 RID: 261337 RVA: 0x00F6FACF File Offset: 0x00F6DCCF
		// (set) Token: 0x0603FCDA RID: 261338 RVA: 0x00F6FAD7 File Offset: 0x00F6DCD7
		public PinballRoleConfig RoleConfig { get; set; }

		// Token: 0x170092DA RID: 37594
		// (get) Token: 0x0603FCDB RID: 261339 RVA: 0x00F6FAE0 File Offset: 0x00F6DCE0
		// (set) Token: 0x0603FCDC RID: 261340 RVA: 0x00F6FAE8 File Offset: 0x00F6DCE8
		public bool IsSelected { get; set; }

		// Token: 0x170092DB RID: 37595
		// (get) Token: 0x0603FCDD RID: 261341 RVA: 0x00F6FAF1 File Offset: 0x00F6DCF1
		// (set) Token: 0x0603FCDE RID: 261342 RVA: 0x00F6FAF9 File Offset: 0x00F6DCF9
		public bool IsLocked { get; set; }

		// Token: 0x170092DC RID: 37596
		// (get) Token: 0x0603FCDF RID: 261343 RVA: 0x00F6FB02 File Offset: 0x00F6DD02
		// (set) Token: 0x0603FCE0 RID: 261344 RVA: 0x00F6FB0A File Offset: 0x00F6DD0A
		public bool IsTrail { get; set; }

		// Token: 0x170092DD RID: 37597
		// (get) Token: 0x0603FCE1 RID: 261345 RVA: 0x00F6FB13 File Offset: 0x00F6DD13
		// (set) Token: 0x0603FCE2 RID: 261346 RVA: 0x00F6FB1B File Offset: 0x00F6DD1B
		public bool NeedRedDot { get; set; }
	}
}
