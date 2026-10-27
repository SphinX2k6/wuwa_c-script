using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;

// Token: 0x0200142B RID: 5163
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectViewOpenData : IPinballRoleSelectViewOpenData
{
	// Token: 0x17000CB2 RID: 3250
	// (get) Token: 0x060091B2 RID: 37298 RVA: 0x001F3050 File Offset: 0x001F1250
	// (set) Token: 0x060091B3 RID: 37299 RVA: 0x001F3058 File Offset: 0x001F1258
	public PinballActivityData ActivityData { get; set; }

	// Token: 0x17000CB3 RID: 3251
	// (get) Token: 0x060091B4 RID: 37300 RVA: 0x001F3061 File Offset: 0x001F1261
	// (set) Token: 0x060091B5 RID: 37301 RVA: 0x001F3069 File Offset: 0x001F1269
	public int SelectedRoleId { get; set; }

	// Token: 0x17000CB4 RID: 3252
	// (get) Token: 0x060091B6 RID: 37302 RVA: 0x001F3072 File Offset: 0x001F1272
	// (set) Token: 0x060091B7 RID: 37303 RVA: 0x001F307A File Offset: 0x001F127A
	public List<PinballRoleDataBase> RoleDataList { get; set; }

	// Token: 0x17000CB5 RID: 3253
	// (get) Token: 0x060091B8 RID: 37304 RVA: 0x001F3083 File Offset: 0x001F1283
	// (set) Token: 0x060091B9 RID: 37305 RVA: 0x001F308B File Offset: 0x001F128B
	[Nullable(2)]
	public int[] FormationRoleIds { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000CB6 RID: 3254
	// (get) Token: 0x060091BA RID: 37306 RVA: 0x001F3094 File Offset: 0x001F1294
	// (set) Token: 0x060091BB RID: 37307 RVA: 0x001F309C File Offset: 0x001F129C
	public Action<int> OnSelectConfirm { get; set; }
}
