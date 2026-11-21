using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200107C RID: 4220
[NullableContext(1)]
public interface IFormationValidator
{
	// Token: 0x0600A7B8 RID: 42936
	bool CanJoinTeam(int roleId, int formationId);

	// Token: 0x0600A7B9 RID: 42937
	bool IsNeedRevive(int roleId, int formationId);

	// Token: 0x0600A7BA RID: 42938
	bool CanSelectRole(int roleId, IReadOnlyList<int> selectedRoleIds);

	// Token: 0x0600A7BB RID: 42939
	bool CanQuickSelectConfirm(IReadOnlyList<int> selectedRoleIds, int formationId);

	// Token: 0x0600A7BC RID: 42940
	bool ConfirmCheck(int roleId, int formationId, int editPosition);

	// Token: 0x0600A7BD RID: 42941
	bool IsConfirmButtonEnable(int roleId, int formationId, int editPosition);

	// Token: 0x0600A7BE RID: 42942
	[NullableContext(2)]
	string GetConfirmButtonTextId(int roleId, int formationId, int editPosition);
}
