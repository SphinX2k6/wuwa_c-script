using System;
using System.Runtime.CompilerServices;

// Token: 0x020010A6 RID: 4262
[NullableContext(2)]
public interface IFormationProvider
{
	// Token: 0x0600A8C4 RID: 43204
	Vector GetRoleSkinOffset(int skinId);

	// Token: 0x0600A8C5 RID: 43205
	int ResolveSafePlayerId(int? slotPlayerId);

	// Token: 0x0600A8C6 RID: 43206
	bool IsCurrentDungeonDangoAbyss();

	// Token: 0x0600A8C7 RID: 43207
	bool IsDangoInMatch();

	// Token: 0x0600A8C8 RID: 43208
	bool ResolveSpecialTrialDeadState(int roleId);
}
