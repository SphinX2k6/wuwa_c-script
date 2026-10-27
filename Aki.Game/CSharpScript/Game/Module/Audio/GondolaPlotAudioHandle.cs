using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E98 RID: 24216
	[NullableContext(2)]
	[Nullable(0)]
	internal class GondolaPlotAudioHandle : IGondolaPlotAudioHandle
	{
		// Token: 0x17008E9D RID: 36509
		// (get) Token: 0x0603D9A1 RID: 252321 RVA: 0x00EDF18A File Offset: 0x00EDD38A
		// (set) Token: 0x0603D9A2 RID: 252322 RVA: 0x00EDF192 File Offset: 0x00EDD392
		public int RoleId { get; set; }

		// Token: 0x17008E9E RID: 36510
		// (get) Token: 0x0603D9A3 RID: 252323 RVA: 0x00EDF19B File Offset: 0x00EDD39B
		// (set) Token: 0x0603D9A4 RID: 252324 RVA: 0x00EDF1A3 File Offset: 0x00EDD3A3
		public int PassengerId { get; set; }

		// Token: 0x17008E9F RID: 36511
		// (get) Token: 0x0603D9A5 RID: 252325 RVA: 0x00EDF1AC File Offset: 0x00EDD3AC
		// (set) Token: 0x0603D9A6 RID: 252326 RVA: 0x00EDF1B4 File Offset: 0x00EDD3B4
		public BaseActorComponent PassengerActor { get; set; }

		// Token: 0x17008EA0 RID: 36512
		// (get) Token: 0x0603D9A7 RID: 252327 RVA: 0x00EDF1BD File Offset: 0x00EDD3BD
		// (set) Token: 0x0603D9A8 RID: 252328 RVA: 0x00EDF1C5 File Offset: 0x00EDD3C5
		public AudioHandleInfo AudioHandle { get; set; }

		// Token: 0x17008EA1 RID: 36513
		// (get) Token: 0x0603D9A9 RID: 252329 RVA: 0x00EDF1CE File Offset: 0x00EDD3CE
		// (set) Token: 0x0603D9AA RID: 252330 RVA: 0x00EDF1D6 File Offset: 0x00EDD3D6
		public PlotHandleInfo PlotHandle { get; set; }
	}
}
