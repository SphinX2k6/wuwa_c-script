using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004716 RID: 18198
	[NullableContext(1)]
	public interface IMovableFloorMoveRequest
	{
		// Token: 0x170076EB RID: 30443
		// (get) Token: 0x0602F8D3 RID: 194771
		MovableFloorController Controller { get; }

		// Token: 0x170076EC RID: 30444
		// (get) Token: 0x0602F8D4 RID: 194772
		IWuWaGoGridRelocationRequest RelocationRequest { get; }
	}
}
