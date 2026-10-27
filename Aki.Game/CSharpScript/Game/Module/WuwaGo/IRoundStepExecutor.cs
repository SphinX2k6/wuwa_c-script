using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004712 RID: 18194
	[NullableContext(1)]
	public interface IRoundStepExecutor
	{
		// Token: 0x0602F8CA RID: 194762
		UniTask Execute(ERoundStep step, IReadOnlyList<IExecutableUnit> units, int executionToken);
	}
}
