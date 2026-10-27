using System;
using System.Runtime.CompilerServices;

// Token: 0x020011DB RID: 4571
[NullableContext(1)]
public interface IStackableChessAgent : IChessAgent
{
	// Token: 0x060079CA RID: 31178
	[NullableContext(2)]
	Vector GetStackableLocation();

	// Token: 0x060079CB RID: 31179
	[NullableContext(2)]
	Rotator GetStackableRotator(bool isSameDirection);

	// Token: 0x060079CC RID: 31180
	void AttachToTarget(IStackableChessAgent target);

	// Token: 0x060079CD RID: 31181
	void DetachFromTarget(IStackableChessAgent target);

	// Token: 0x060079CE RID: 31182
	void OnPreviousMoveStateChange(IStackableChessAgent movingAgent, bool IsMoving, bool previousIsForward, bool isSameDirection);

	// Token: 0x060079CF RID: 31183
	bool IsPerformRecursion(int type);

	// Token: 0x060079D0 RID: 31184
	void OnPreviousPerformStateChange(IStackableChessAgent agent, int type, bool isPerforming);
}
