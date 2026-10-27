using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E97 RID: 24215
	[NullableContext(2)]
	internal interface IGondolaPlotAudioHandle
	{
		// Token: 0x17008E98 RID: 36504
		// (get) Token: 0x0603D997 RID: 252311
		// (set) Token: 0x0603D998 RID: 252312
		int RoleId { get; set; }

		// Token: 0x17008E99 RID: 36505
		// (get) Token: 0x0603D999 RID: 252313
		// (set) Token: 0x0603D99A RID: 252314
		int PassengerId { get; set; }

		// Token: 0x17008E9A RID: 36506
		// (get) Token: 0x0603D99B RID: 252315
		// (set) Token: 0x0603D99C RID: 252316
		BaseActorComponent PassengerActor { get; set; }

		// Token: 0x17008E9B RID: 36507
		// (get) Token: 0x0603D99D RID: 252317
		// (set) Token: 0x0603D99E RID: 252318
		AudioHandleInfo AudioHandle { get; set; }

		// Token: 0x17008E9C RID: 36508
		// (get) Token: 0x0603D99F RID: 252319
		// (set) Token: 0x0603D9A0 RID: 252320
		PlotHandleInfo PlotHandle { get; set; }
	}
}
