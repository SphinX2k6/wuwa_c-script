using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.ResponsibilityChain
{
	// Token: 0x02003482 RID: 13442
	[NullableContext(1)]
	public interface IParameterHandler<[Nullable(0)] T> where T : IParameterContext
	{
		// Token: 0x06022499 RID: 140441
		IParameterHandler<T> SetNext(IParameterHandler<T> handler);

		// Token: 0x0602249A RID: 140442
		bool Handle(T context);

		// Token: 0x0602249B RID: 140443
		bool Stop(T context);
	}
}
