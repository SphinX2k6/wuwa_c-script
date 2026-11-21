using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02003442 RID: 13378
	public interface IControllerManagerBase
	{
		// Token: 0x06021F6A RID: 139114
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		List<ValueTuple<string, CustomPromise<bool>>> Preload();

		// Token: 0x06021F6B RID: 139115
		void ChangeMode();
	}
}
