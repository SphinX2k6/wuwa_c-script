using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020001FC RID: 508
[NullableContext(1)]
public interface ICameraControllerBase
{
	// Token: 0x0600206E RID: 8302
	void OnStart();

	// Token: 0x0600206F RID: 8303
	void OnEnd();

	// Token: 0x06002070 RID: 8304
	void Update(float deltaTime);

	// Token: 0x06002071 RID: 8305
	string Name();

	// Token: 0x06002072 RID: 8306
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	IEnumerable<ValueTuple<string, object>> MemberIter();
}
