using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BBD RID: 7101
[NullableContext(1)]
public interface IFormationValidator
{
	// Token: 0x0600D3A6 RID: 54182
	bool CanJoinTeam(int roleId, int formationId);

	// Token: 0x0600D3A7 RID: 54183
	bool IsNeedRevive(int roleId, int formationId);

	// Token: 0x0600D3A8 RID: 54184
	bool CanSelectRole(int roleId, IReadOnlyList<int> selectedRoleIds);

	// Token: 0x0600D3A9 RID: 54185
	bool CanQuickSelectConfirm(IReadOnlyList<int> selectedRoleIds);

	// Token: 0x0600D3AA RID: 54186
	bool ConfirmCheck(int roleId, int formationId, int editPosition);

	// Token: 0x0600D3AB RID: 54187
	bool IsConfirmButtonEnable(int roleId, int formationId, int editPosition);

	// Token: 0x0600D3AC RID: 54188
	[NullableContext(2)]
	string GetConfirmButtonTextId(int roleId, int formationId, int editPosition);
}
