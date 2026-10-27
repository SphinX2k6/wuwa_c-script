using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006312 RID: 25362
	[NullableContext(1)]
	public interface IPinballRoleLevelUpButtonItemData
	{
		// Token: 0x170092DE RID: 37598
		// (get) Token: 0x0603FCF2 RID: 261362
		// (set) Token: 0x0603FCF3 RID: 261363
		int Times { get; set; }

		// Token: 0x170092DF RID: 37599
		// (get) Token: 0x0603FCF4 RID: 261364
		// (set) Token: 0x0603FCF5 RID: 261365
		bool IsToMaxLevel { get; set; }

		// Token: 0x170092E0 RID: 37600
		// (get) Token: 0x0603FCF6 RID: 261366
		// (set) Token: 0x0603FCF7 RID: 261367
		Action<int> ConfirmDelegate { get; set; }

		// Token: 0x170092E1 RID: 37601
		// (get) Token: 0x0603FCF8 RID: 261368
		// (set) Token: 0x0603FCF9 RID: 261369
		ICostData CostItemData { get; set; }
	}
}
