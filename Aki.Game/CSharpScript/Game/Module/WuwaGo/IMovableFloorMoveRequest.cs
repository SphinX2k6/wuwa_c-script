using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003646 RID: 13894
	[NullableContext(1)]
	public interface IMovableFloorMoveRequest
	{
		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x06024099 RID: 147609
		MovableFloorController Controller { get; }

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x0602409A RID: 147610
		IWuWaGoGridRelocationRequest RelocationRequest { get; }
	}
}
