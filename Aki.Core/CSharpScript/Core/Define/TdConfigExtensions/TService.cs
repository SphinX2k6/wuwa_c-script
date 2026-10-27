using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x02000140 RID: 320
	[NullableContext(1)]
	public interface TService
	{
		// Token: 0x06000B36 RID: 2870
		bool Invoke(string name, List<object> args, [Nullable(2)] out object result);
	}
}
