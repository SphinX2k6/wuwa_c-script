using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;

// Token: 0x020008DF RID: 2271
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectViewOpenData : IPinballRoleSelectViewOpenData
{
	// Token: 0x17000CD2 RID: 3282
	// (get) Token: 0x06006547 RID: 25927 RVA: 0x001FBB8C File Offset: 0x001F9D8C
	// (set) Token: 0x06006548 RID: 25928 RVA: 0x001FBB94 File Offset: 0x001F9D94
	public PinballActivityData ActivityData { get; set; }

	// Token: 0x17000CD3 RID: 3283
	// (get) Token: 0x06006549 RID: 25929 RVA: 0x001FBB9D File Offset: 0x001F9D9D
	// (set) Token: 0x0600654A RID: 25930 RVA: 0x001FBBA5 File Offset: 0x001F9DA5
	public int SelectedRoleId { get; set; }

	// Token: 0x17000CD4 RID: 3284
	// (get) Token: 0x0600654B RID: 25931 RVA: 0x001FBBAE File Offset: 0x001F9DAE
	// (set) Token: 0x0600654C RID: 25932 RVA: 0x001FBBB6 File Offset: 0x001F9DB6
	public List<PinballRoleDataBase> RoleDataList { get; set; }

	// Token: 0x17000CD5 RID: 3285
	// (get) Token: 0x0600654D RID: 25933 RVA: 0x001FBBBF File Offset: 0x001F9DBF
	// (set) Token: 0x0600654E RID: 25934 RVA: 0x001FBBC7 File Offset: 0x001F9DC7
	[Nullable(2)]
	public int[] FormationRoleIds { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000CD6 RID: 3286
	// (get) Token: 0x0600654F RID: 25935 RVA: 0x001FBBD0 File Offset: 0x001F9DD0
	// (set) Token: 0x06006550 RID: 25936 RVA: 0x001FBBD8 File Offset: 0x001F9DD8
	public Action<int> OnSelectConfirm { get; set; }
}
