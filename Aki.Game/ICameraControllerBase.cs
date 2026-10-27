using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020001F8 RID: 504
[NullableContext(1)]
public interface ICameraControllerBase
{
	// Token: 0x06001FC0 RID: 8128
	void OnStart();

	// Token: 0x06001FC1 RID: 8129
	void OnEnd();

	// Token: 0x06001FC2 RID: 8130
	void Update(float deltaTime);

	// Token: 0x06001FC3 RID: 8131
	string Name();

	// Token: 0x06001FC4 RID: 8132
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	IEnumerable<ValueTuple<string, object>> MemberIter();
}
