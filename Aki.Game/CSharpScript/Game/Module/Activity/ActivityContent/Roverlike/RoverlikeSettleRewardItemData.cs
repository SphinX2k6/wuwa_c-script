using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006199 RID: 24985
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSettleRewardItemData : IRoverlikeSettleRewardItemData
	{
		// Token: 0x170091FF RID: 37375
		// (get) Token: 0x0603F1EC RID: 258540 RVA: 0x00F3F30A File Offset: 0x00F3D50A
		// (set) Token: 0x0603F1ED RID: 258541 RVA: 0x00F3F312 File Offset: 0x00F3D512
		public string IconPath { get; set; } = string.Empty;

		// Token: 0x17009200 RID: 37376
		// (get) Token: 0x0603F1EE RID: 258542 RVA: 0x00F3F31B File Offset: 0x00F3D51B
		// (set) Token: 0x0603F1EF RID: 258543 RVA: 0x00F3F323 File Offset: 0x00F3D523
		public string NameTextId { get; set; } = string.Empty;

		// Token: 0x17009201 RID: 37377
		// (get) Token: 0x0603F1F0 RID: 258544 RVA: 0x00F3F32C File Offset: 0x00F3D52C
		// (set) Token: 0x0603F1F1 RID: 258545 RVA: 0x00F3F334 File Offset: 0x00F3D534
		public int Num { get; set; }
	}
}
