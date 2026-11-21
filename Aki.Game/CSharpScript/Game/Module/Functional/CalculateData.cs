using System;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x020049FC RID: 18940
	public class CalculateData : ICalculateData
	{
		// Token: 0x17005FA0 RID: 24480
		// (get) Token: 0x0602F78A RID: 194442 RVA: 0x00D3D070 File Offset: 0x00D3B270
		// (set) Token: 0x0602F78B RID: 194443 RVA: 0x00D3D078 File Offset: 0x00D3B278
		public int TotalGridNumber { get; set; }

		// Token: 0x17005FA1 RID: 24481
		// (get) Token: 0x0602F78C RID: 194444 RVA: 0x00D3D081 File Offset: 0x00D3B281
		// (set) Token: 0x0602F78D RID: 194445 RVA: 0x00D3D089 File Offset: 0x00D3B289
		public float OffsetWidth { get; set; }

		// Token: 0x17005FA2 RID: 24482
		// (get) Token: 0x0602F78E RID: 194446 RVA: 0x00D3D092 File Offset: 0x00D3B292
		// (set) Token: 0x0602F78F RID: 194447 RVA: 0x00D3D09A File Offset: 0x00D3B29A
		public int HorizontalGridNum { get; set; }

		// Token: 0x17005FA3 RID: 24483
		// (get) Token: 0x0602F790 RID: 194448 RVA: 0x00D3D0A3 File Offset: 0x00D3B2A3
		// (set) Token: 0x0602F791 RID: 194449 RVA: 0x00D3D0AB File Offset: 0x00D3B2AB
		public int VerticalGridNum { get; set; }
	}
}
