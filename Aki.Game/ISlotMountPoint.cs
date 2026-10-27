using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001BC9 RID: 7113
[NullableContext(1)]
public interface ISlotMountPoint
{
	// Token: 0x0600D421 RID: 54305
	AActor GetRoleItemOwner();

	// Token: 0x0600D422 RID: 54306
	AActor GetPanelRoleItemOwner();

	// Token: 0x0600D423 RID: 54307
	[NullableContext(2)]
	AActor GetLikeItemOwner();

	// Token: 0x0600D424 RID: 54308
	[NullableContext(2)]
	AActor GetTrialRoleItemOwner();

	// Token: 0x0600D425 RID: 54309
	UUIItem GetRootItem();

	// Token: 0x0600D426 RID: 54310
	[NullableContext(2)]
	UUIItem GetChooseButtonRoot();

	// Token: 0x0600D427 RID: 54311
	[NullableContext(2)]
	AActor GetSkillBranchToggleItemOwner();

	// Token: 0x0600D428 RID: 54312
	IFormationProvider GetProvider();
}
