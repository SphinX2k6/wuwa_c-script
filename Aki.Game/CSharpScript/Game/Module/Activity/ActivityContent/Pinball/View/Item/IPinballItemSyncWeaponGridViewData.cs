using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006349 RID: 25417
	[NullableContext(1)]
	public interface IPinballItemSyncWeaponGridViewData
	{
		// Token: 0x17009318 RID: 37656
		// (get) Token: 0x0603FF52 RID: 261970
		// (set) Token: 0x0603FF53 RID: 261971
		PinballWeaponData WeaponData { get; set; }

		// Token: 0x17009319 RID: 37657
		// (get) Token: 0x0603FF54 RID: 261972
		// (set) Token: 0x0603FF55 RID: 261973
		bool IsSelected { get; set; }

		// Token: 0x1700931A RID: 37658
		// (get) Token: 0x0603FF56 RID: 261974
		// (set) Token: 0x0603FF57 RID: 261975
		bool CanEquip { get; set; }

		// Token: 0x1700931B RID: 37659
		// (get) Token: 0x0603FF58 RID: 261976
		// (set) Token: 0x0603FF59 RID: 261977
		bool IsCurRoleEquip { get; set; }

		// Token: 0x1700931C RID: 37660
		// (get) Token: 0x0603FF5A RID: 261978
		// (set) Token: 0x0603FF5B RID: 261979
		int QualityId { get; set; }

		// Token: 0x1700931D RID: 37661
		// (get) Token: 0x0603FF5C RID: 261980
		// (set) Token: 0x0603FF5D RID: 261981
		Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }

		// Token: 0x1700931E RID: 37662
		// (get) Token: 0x0603FF5E RID: 261982
		// (set) Token: 0x0603FF5F RID: 261983
		int RoleId { get; set; }
	}
}
