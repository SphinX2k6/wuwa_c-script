using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;

// Token: 0x020013FB RID: 5115
[NullableContext(1)]
public interface IPinballRoleSelectViewOpenData
{
	// Token: 0x17000C32 RID: 3122
	// (get) Token: 0x0600908A RID: 37002
	// (set) Token: 0x0600908B RID: 37003
	PinballActivityData ActivityData { get; set; }

	// Token: 0x17000C33 RID: 3123
	// (get) Token: 0x0600908C RID: 37004
	// (set) Token: 0x0600908D RID: 37005
	int SelectedRoleId { get; set; }

	// Token: 0x17000C34 RID: 3124
	// (get) Token: 0x0600908E RID: 37006
	// (set) Token: 0x0600908F RID: 37007
	List<PinballRoleDataBase> RoleDataList { get; set; }

	// Token: 0x17000C35 RID: 3125
	// (get) Token: 0x06009090 RID: 37008
	// (set) Token: 0x06009091 RID: 37009
	[Nullable(2)]
	int[] FormationRoleIds { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000C36 RID: 3126
	// (get) Token: 0x06009092 RID: 37010
	// (set) Token: 0x06009093 RID: 37011
	Action<int> OnSelectConfirm { get; set; }
}
