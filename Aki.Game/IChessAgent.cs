using System;
using System.Runtime.CompilerServices;

// Token: 0x020011CC RID: 4556
[NullableContext(1)]
public interface IChessAgent
{
	// Token: 0x06007960 RID: 31072
	void Move(Vector location, Rotator rotator, bool performIsForward, Action finishCallback);

	// Token: 0x06007961 RID: 31073
	void Teleport(Vector location, Rotator rotator);

	// Token: 0x06007962 RID: 31074
	void Perform(int type, [Nullable(2)] Vector pointLocation, Action finishCallback);

	// Token: 0x06007963 RID: 31075
	[NullableContext(2)]
	Vector GetLocation();
}
