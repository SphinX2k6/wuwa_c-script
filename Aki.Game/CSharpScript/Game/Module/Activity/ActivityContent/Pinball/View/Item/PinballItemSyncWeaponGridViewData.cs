using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C8 RID: 21192
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncWeaponGridViewData : IPinballItemSyncWeaponGridViewData
	{
		// Token: 0x17006681 RID: 26241
		// (get) Token: 0x06034C21 RID: 216097 RVA: 0x00EC0C53 File Offset: 0x00EBEE53
		// (set) Token: 0x06034C22 RID: 216098 RVA: 0x00EC0C5B File Offset: 0x00EBEE5B
		public PinballWeaponData WeaponData { get; set; }

		// Token: 0x17006682 RID: 26242
		// (get) Token: 0x06034C23 RID: 216099 RVA: 0x00EC0C64 File Offset: 0x00EBEE64
		// (set) Token: 0x06034C24 RID: 216100 RVA: 0x00EC0C6C File Offset: 0x00EBEE6C
		public bool IsSelected { get; set; }

		// Token: 0x17006683 RID: 26243
		// (get) Token: 0x06034C25 RID: 216101 RVA: 0x00EC0C75 File Offset: 0x00EBEE75
		// (set) Token: 0x06034C26 RID: 216102 RVA: 0x00EC0C7D File Offset: 0x00EBEE7D
		public bool CanEquip { get; set; }

		// Token: 0x17006684 RID: 26244
		// (get) Token: 0x06034C27 RID: 216103 RVA: 0x00EC0C86 File Offset: 0x00EBEE86
		// (set) Token: 0x06034C28 RID: 216104 RVA: 0x00EC0C8E File Offset: 0x00EBEE8E
		public bool IsCurRoleEquip { get; set; }

		// Token: 0x17006685 RID: 26245
		// (get) Token: 0x06034C29 RID: 216105 RVA: 0x00EC0C97 File Offset: 0x00EBEE97
		// (set) Token: 0x06034C2A RID: 216106 RVA: 0x00EC0C9F File Offset: 0x00EBEE9F
		public int QualityId { get; set; }

		// Token: 0x17006686 RID: 26246
		// (get) Token: 0x06034C2B RID: 216107 RVA: 0x00EC0CA8 File Offset: 0x00EBEEA8
		// (set) Token: 0x06034C2C RID: 216108 RVA: 0x00EC0CB0 File Offset: 0x00EBEEB0
		public Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }

		// Token: 0x17006687 RID: 26247
		// (get) Token: 0x06034C2D RID: 216109 RVA: 0x00EC0CB9 File Offset: 0x00EBEEB9
		// (set) Token: 0x06034C2E RID: 216110 RVA: 0x00EC0CC1 File Offset: 0x00EBEEC1
		public int RoleId { get; set; }
	}
}
