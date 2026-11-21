using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003642 RID: 13890
	[NullableContext(1)]
	public interface IRoundStepExecutor
	{
		// Token: 0x06024090 RID: 147600
		UniTask Execute(ERoundStep step, IReadOnlyList<IExecutableUnit> units, int executionToken);
	}
}
