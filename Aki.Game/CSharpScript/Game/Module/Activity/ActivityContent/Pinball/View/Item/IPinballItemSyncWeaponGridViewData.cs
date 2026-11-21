using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C7 RID: 21191
	[NullableContext(1)]
	public interface IPinballItemSyncWeaponGridViewData
	{
		// Token: 0x1700667A RID: 26234
		// (get) Token: 0x06034C13 RID: 216083
		// (set) Token: 0x06034C14 RID: 216084
		PinballWeaponData WeaponData { get; set; }

		// Token: 0x1700667B RID: 26235
		// (get) Token: 0x06034C15 RID: 216085
		// (set) Token: 0x06034C16 RID: 216086
		bool IsSelected { get; set; }

		// Token: 0x1700667C RID: 26236
		// (get) Token: 0x06034C17 RID: 216087
		// (set) Token: 0x06034C18 RID: 216088
		bool CanEquip { get; set; }

		// Token: 0x1700667D RID: 26237
		// (get) Token: 0x06034C19 RID: 216089
		// (set) Token: 0x06034C1A RID: 216090
		bool IsCurRoleEquip { get; set; }

		// Token: 0x1700667E RID: 26238
		// (get) Token: 0x06034C1B RID: 216091
		// (set) Token: 0x06034C1C RID: 216092
		int QualityId { get; set; }

		// Token: 0x1700667F RID: 26239
		// (get) Token: 0x06034C1D RID: 216093
		// (set) Token: 0x06034C1E RID: 216094
		Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }

		// Token: 0x17006680 RID: 26240
		// (get) Token: 0x06034C1F RID: 216095
		// (set) Token: 0x06034C20 RID: 216096
		int RoleId { get; set; }
	}
}
