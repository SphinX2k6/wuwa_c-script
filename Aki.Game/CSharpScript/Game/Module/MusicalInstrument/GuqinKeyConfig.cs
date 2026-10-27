using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005368 RID: 21352
	[NullableContext(1)]
	[Nullable(0)]
	public class GuqinKeyConfig
	{
		// Token: 0x1700834E RID: 33614
		// (get) Token: 0x060368F0 RID: 223472 RVA: 0x00CEB7A8 File Offset: 0x00CE99A8
		// (set) Token: 0x060368F1 RID: 223473 RVA: 0x00CEB7B0 File Offset: 0x00CE99B0
		public string FundamentalToneAudioEvent { get; set; } = "";

		// Token: 0x1700834F RID: 33615
		// (get) Token: 0x060368F2 RID: 223474 RVA: 0x00CEB7B9 File Offset: 0x00CE99B9
		// (set) Token: 0x060368F3 RID: 223475 RVA: 0x00CEB7C1 File Offset: 0x00CE99C1
		public string OverToneAudioEvent { get; set; } = "";

		// Token: 0x17008350 RID: 33616
		// (get) Token: 0x060368F4 RID: 223476 RVA: 0x00CEB7CA File Offset: 0x00CE99CA
		// (set) Token: 0x060368F5 RID: 223477 RVA: 0x00CEB7D2 File Offset: 0x00CE99D2
		public string KeyIconPath { get; set; } = "";
	}
}
