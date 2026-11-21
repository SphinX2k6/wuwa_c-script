using System;
using System.Runtime.CompilerServices;

// Token: 0x02000680 RID: 1664
[NullableContext(1)]
public interface IChessAgent
{
	// Token: 0x06004CF7 RID: 19703
	void Move(Vector location, Rotator rotator, bool performIsForward, Action finishCallback);

	// Token: 0x06004CF8 RID: 19704
	void Teleport(Vector location, Rotator rotator);

	// Token: 0x06004CF9 RID: 19705
	void Perform(int type, [Nullable(2)] Vector pointLocation, Action finishCallback);

	// Token: 0x06004CFA RID: 19706
	[NullableContext(2)]
	Vector GetLocation();
}
