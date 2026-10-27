using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x0200634A RID: 25418
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncWeaponGridViewData : IPinballItemSyncWeaponGridViewData
	{
		// Token: 0x1700931F RID: 37663
		// (get) Token: 0x0603FF60 RID: 261984 RVA: 0x00F79CF3 File Offset: 0x00F77EF3
		// (set) Token: 0x0603FF61 RID: 261985 RVA: 0x00F79CFB File Offset: 0x00F77EFB
		public PinballWeaponData WeaponData { get; set; }

		// Token: 0x17009320 RID: 37664
		// (get) Token: 0x0603FF62 RID: 261986 RVA: 0x00F79D04 File Offset: 0x00F77F04
		// (set) Token: 0x0603FF63 RID: 261987 RVA: 0x00F79D0C File Offset: 0x00F77F0C
		public bool IsSelected { get; set; }

		// Token: 0x17009321 RID: 37665
		// (get) Token: 0x0603FF64 RID: 261988 RVA: 0x00F79D15 File Offset: 0x00F77F15
		// (set) Token: 0x0603FF65 RID: 261989 RVA: 0x00F79D1D File Offset: 0x00F77F1D
		public bool CanEquip { get; set; }

		// Token: 0x17009322 RID: 37666
		// (get) Token: 0x0603FF66 RID: 261990 RVA: 0x00F79D26 File Offset: 0x00F77F26
		// (set) Token: 0x0603FF67 RID: 261991 RVA: 0x00F79D2E File Offset: 0x00F77F2E
		public bool IsCurRoleEquip { get; set; }

		// Token: 0x17009323 RID: 37667
		// (get) Token: 0x0603FF68 RID: 261992 RVA: 0x00F79D37 File Offset: 0x00F77F37
		// (set) Token: 0x0603FF69 RID: 261993 RVA: 0x00F79D3F File Offset: 0x00F77F3F
		public int QualityId { get; set; }

		// Token: 0x17009324 RID: 37668
		// (get) Token: 0x0603FF6A RID: 261994 RVA: 0x00F79D48 File Offset: 0x00F77F48
		// (set) Token: 0x0603FF6B RID: 261995 RVA: 0x00F79D50 File Offset: 0x00F77F50
		public Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }

		// Token: 0x17009325 RID: 37669
		// (get) Token: 0x0603FF6C RID: 261996 RVA: 0x00F79D59 File Offset: 0x00F77F59
		// (set) Token: 0x0603FF6D RID: 261997 RVA: 0x00F79D61 File Offset: 0x00F77F61
		public int RoleId { get; set; }
	}
}
