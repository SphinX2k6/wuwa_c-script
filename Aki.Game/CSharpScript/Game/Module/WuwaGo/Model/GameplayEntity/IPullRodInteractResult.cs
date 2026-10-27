using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200474E RID: 18254
	[NullableContext(2)]
	public interface IPullRodInteractResult
	{
		// Token: 0x1700773A RID: 30522
		// (get) Token: 0x0602FB4E RID: 195406
		// (set) Token: 0x0602FB4F RID: 195407
		EGameplayEntityState PreviousState { get; set; }

		// Token: 0x1700773B RID: 30523
		// (get) Token: 0x0602FB50 RID: 195408
		// (set) Token: 0x0602FB51 RID: 195409
		EGameplayEntityState CurrentState { get; set; }

		// Token: 0x1700773C RID: 30524
		// (get) Token: 0x0602FB52 RID: 195410
		// (set) Token: 0x0602FB53 RID: 195411
		IWuWaGoInteractStateAction StateAction { get; set; }
	}
}
