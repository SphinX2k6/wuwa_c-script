using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BE7 RID: 7143
[NullableContext(2)]
public interface IFormationProvider
{
	// Token: 0x0600D4B2 RID: 54450
	Vector GetRoleSkinOffset(int skinId);

	// Token: 0x0600D4B3 RID: 54451
	int ResolveSafePlayerId(int? slotPlayerId);

	// Token: 0x0600D4B4 RID: 54452
	bool IsCurrentDungeonDangoAbyss();

	// Token: 0x0600D4B5 RID: 54453
	bool IsDangoInMatch();

	// Token: 0x0600D4B6 RID: 54454
	bool ResolveSpecialTrialDeadState(int roleId);
}
