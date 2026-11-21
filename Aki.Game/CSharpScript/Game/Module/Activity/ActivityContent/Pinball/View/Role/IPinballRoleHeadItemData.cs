using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200528D RID: 21133
	public interface IPinballRoleHeadItemData
	{
		// Token: 0x17006636 RID: 26166
		// (get) Token: 0x06034990 RID: 215440
		// (set) Token: 0x06034991 RID: 215441
		PinballRoleConfig RoleConfig { get; set; }

		// Token: 0x17006637 RID: 26167
		// (get) Token: 0x06034992 RID: 215442
		// (set) Token: 0x06034993 RID: 215443
		bool IsSelected { get; set; }

		// Token: 0x17006638 RID: 26168
		// (get) Token: 0x06034994 RID: 215444
		// (set) Token: 0x06034995 RID: 215445
		bool IsLocked { get; set; }

		// Token: 0x17006639 RID: 26169
		// (get) Token: 0x06034996 RID: 215446
		// (set) Token: 0x06034997 RID: 215447
		bool IsTrail { get; set; }

		// Token: 0x1700663A RID: 26170
		// (get) Token: 0x06034998 RID: 215448
		// (set) Token: 0x06034999 RID: 215449
		bool NeedRedDot { get; set; }
	}
}
