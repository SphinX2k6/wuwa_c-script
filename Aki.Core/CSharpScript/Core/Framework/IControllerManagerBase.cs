using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Framework
{
	// Token: 0x0200013A RID: 314
	public interface IControllerManagerBase
	{
		// Token: 0x06000B54 RID: 2900
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		List<ValueTuple<string, CustomPromise<bool>>> Preload();

		// Token: 0x06000B55 RID: 2901
		void ChangeMode();
	}
}
