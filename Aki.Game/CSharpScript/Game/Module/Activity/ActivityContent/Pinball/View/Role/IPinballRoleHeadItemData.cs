using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200630F RID: 25359
	public interface IPinballRoleHeadItemData
	{
		// Token: 0x170092D4 RID: 37588
		// (get) Token: 0x0603FCCF RID: 261327
		// (set) Token: 0x0603FCD0 RID: 261328
		PinballRoleConfig RoleConfig { get; set; }

		// Token: 0x170092D5 RID: 37589
		// (get) Token: 0x0603FCD1 RID: 261329
		// (set) Token: 0x0603FCD2 RID: 261330
		bool IsSelected { get; set; }

		// Token: 0x170092D6 RID: 37590
		// (get) Token: 0x0603FCD3 RID: 261331
		// (set) Token: 0x0603FCD4 RID: 261332
		bool IsLocked { get; set; }

		// Token: 0x170092D7 RID: 37591
		// (get) Token: 0x0603FCD5 RID: 261333
		// (set) Token: 0x0603FCD6 RID: 261334
		bool IsTrail { get; set; }

		// Token: 0x170092D8 RID: 37592
		// (get) Token: 0x0603FCD7 RID: 261335
		// (set) Token: 0x0603FCD8 RID: 261336
		bool NeedRedDot { get; set; }
	}
}
