using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;

// Token: 0x020008AF RID: 2223
[NullableContext(1)]
public interface IPinballRoleSelectViewOpenData
{
	// Token: 0x17000C52 RID: 3154
	// (get) Token: 0x0600641F RID: 25631
	// (set) Token: 0x06006420 RID: 25632
	PinballActivityData ActivityData { get; set; }

	// Token: 0x17000C53 RID: 3155
	// (get) Token: 0x06006421 RID: 25633
	// (set) Token: 0x06006422 RID: 25634
	int SelectedRoleId { get; set; }

	// Token: 0x17000C54 RID: 3156
	// (get) Token: 0x06006423 RID: 25635
	// (set) Token: 0x06006424 RID: 25636
	List<PinballRoleDataBase> RoleDataList { get; set; }

	// Token: 0x17000C55 RID: 3157
	// (get) Token: 0x06006425 RID: 25637
	// (set) Token: 0x06006426 RID: 25638
	[Nullable(2)]
	int[] FormationRoleIds { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000C56 RID: 3158
	// (get) Token: 0x06006427 RID: 25639
	// (set) Token: 0x06006428 RID: 25640
	Action<int> OnSelectConfirm { get; set; }
}
