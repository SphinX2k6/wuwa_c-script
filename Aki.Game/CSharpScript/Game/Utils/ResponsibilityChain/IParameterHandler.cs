using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.ResponsibilityChain
{
	// Token: 0x0200455A RID: 17754
	[NullableContext(1)]
	public interface IParameterHandler<[Nullable(0)] T> where T : IParameterContext
	{
		// Token: 0x0602DDB7 RID: 187831
		IParameterHandler<T> SetNext(IParameterHandler<T> handler);

		// Token: 0x0602DDB8 RID: 187832
		bool Handle(T context);

		// Token: 0x0602DDB9 RID: 187833
		bool Stop(T context);
	}
}
