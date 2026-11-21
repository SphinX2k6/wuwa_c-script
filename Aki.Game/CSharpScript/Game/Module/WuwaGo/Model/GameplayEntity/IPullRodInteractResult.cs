using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200367F RID: 13951
	[NullableContext(2)]
	public interface IPullRodInteractResult
	{
		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x06024318 RID: 148248
		// (set) Token: 0x06024319 RID: 148249
		EGameplayEntityState PreviousState { get; set; }

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x0602431A RID: 148250
		// (set) Token: 0x0602431B RID: 148251
		EGameplayEntityState CurrentState { get; set; }

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x0602431C RID: 148252
		// (set) Token: 0x0602431D RID: 148253
		IWuWaGoInteractStateAction StateAction { get; set; }
	}
}
