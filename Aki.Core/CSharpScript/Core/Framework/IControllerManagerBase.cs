using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02000135 RID: 309
	public interface IControllerManagerBase
	{
		// Token: 0x06000AF7 RID: 2807
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		List<ValueTuple<string, CustomPromise<bool>>> Preload();

		// Token: 0x06000AF8 RID: 2808
		void ChangeMode();
	}
}
