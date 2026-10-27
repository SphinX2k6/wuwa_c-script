using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005913 RID: 22803
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureMissionItemData
	{
		// Token: 0x17008ADB RID: 35547
		// (get) Token: 0x06039E93 RID: 237203 RVA: 0x00DC1FBA File Offset: 0x00DC01BA
		// (set) Token: 0x06039E94 RID: 237204 RVA: 0x00DC1FC2 File Offset: 0x00DC01C2
		public string DesText { get; set; }

		// Token: 0x17008ADC RID: 35548
		// (get) Token: 0x06039E95 RID: 237205 RVA: 0x00DC1FCB File Offset: 0x00DC01CB
		// (set) Token: 0x06039E96 RID: 237206 RVA: 0x00DC1FD3 File Offset: 0x00DC01D3
		public int MaxCount { get; set; }

		// Token: 0x17008ADD RID: 35549
		// (get) Token: 0x06039E97 RID: 237207 RVA: 0x00DC1FDC File Offset: 0x00DC01DC
		// (set) Token: 0x06039E98 RID: 237208 RVA: 0x00DC1FE4 File Offset: 0x00DC01E4
		public int CurrentCount { get; set; }
	}
}
