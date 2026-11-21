using System;
using System.Runtime.CompilerServices;

// Token: 0x0200068F RID: 1679
[NullableContext(1)]
public interface IStackableChessAgent : IChessAgent
{
	// Token: 0x06004D61 RID: 19809
	[NullableContext(2)]
	Vector GetStackableLocation();

	// Token: 0x06004D62 RID: 19810
	[NullableContext(2)]
	Rotator GetStackableRotator(bool isSameDirection);

	// Token: 0x06004D63 RID: 19811
	void AttachToTarget(IStackableChessAgent target);

	// Token: 0x06004D64 RID: 19812
	void DetachFromTarget(IStackableChessAgent target);

	// Token: 0x06004D65 RID: 19813
	void OnPreviousMoveStateChange(IStackableChessAgent movingAgent, bool IsMoving, bool previousIsForward, bool isSameDirection);

	// Token: 0x06004D66 RID: 19814
	bool IsPerformRecursion(int type);

	// Token: 0x06004D67 RID: 19815
	void OnPreviousPerformStateChange(IStackableChessAgent agent, int type, bool isPerforming);
}
