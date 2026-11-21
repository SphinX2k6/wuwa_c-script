using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001088 RID: 4232
[NullableContext(1)]
public interface ISlotMountPoint
{
	// Token: 0x0600A833 RID: 43059
	AActor GetRoleItemOwner();

	// Token: 0x0600A834 RID: 43060
	AActor GetPanelRoleItemOwner();

	// Token: 0x0600A835 RID: 43061
	[NullableContext(2)]
	AActor GetLikeItemOwner();

	// Token: 0x0600A836 RID: 43062
	[NullableContext(2)]
	AActor GetTrialRoleItemOwner();

	// Token: 0x0600A837 RID: 43063
	UUIItem GetRootItem();

	// Token: 0x0600A838 RID: 43064
	[NullableContext(2)]
	UUIItem GetChooseButtonRoot();

	// Token: 0x0600A839 RID: 43065
	[NullableContext(2)]
	AActor GetSkillBranchToggleItemOwner();

	// Token: 0x0600A83A RID: 43066
	IFormationProvider GetProvider();
}
