using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200618F RID: 24975
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeLootViewOpenParam : IRoverlikeLootViewOpenParam
	{
		// Token: 0x170091EA RID: 37354
		// (get) Token: 0x0603F1BD RID: 258493 RVA: 0x00F3F1F9 File Offset: 0x00F3D3F9
		// (set) Token: 0x0603F1BE RID: 258494 RVA: 0x00F3F201 File Offset: 0x00F3D401
		public bool IsInGame { get; set; }

		// Token: 0x170091EB RID: 37355
		// (get) Token: 0x0603F1BF RID: 258495 RVA: 0x00F3F20A File Offset: 0x00F3D40A
		// (set) Token: 0x0603F1C0 RID: 258496 RVA: 0x00F3F212 File Offset: 0x00F3D412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RoverRogueGainEntry> Loots { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170091EC RID: 37356
		// (get) Token: 0x0603F1C1 RID: 258497 RVA: 0x00F3F21B File Offset: 0x00F3D41B
		// (set) Token: 0x0603F1C2 RID: 258498 RVA: 0x00F3F223 File Offset: 0x00F3D423
		public bool? EnableUse { get; set; }

		// Token: 0x170091ED RID: 37357
		// (get) Token: 0x0603F1C3 RID: 258499 RVA: 0x00F3F22C File Offset: 0x00F3D42C
		// (set) Token: 0x0603F1C4 RID: 258500 RVA: 0x00F3F234 File Offset: 0x00F3D434
		public List<int> EquippedLootIds { get; set; }

		// Token: 0x170091EE RID: 37358
		// (get) Token: 0x0603F1C5 RID: 258501 RVA: 0x00F3F23D File Offset: 0x00F3D43D
		// (set) Token: 0x0603F1C6 RID: 258502 RVA: 0x00F3F245 File Offset: 0x00F3D445
		public Action<int, int> OnConfirmSelect { get; set; }

		// Token: 0x170091EF RID: 37359
		// (get) Token: 0x0603F1C7 RID: 258503 RVA: 0x00F3F24E File Offset: 0x00F3D44E
		// (set) Token: 0x0603F1C8 RID: 258504 RVA: 0x00F3F256 File Offset: 0x00F3D456
		public int DefaultSelectedLootId { get; set; }
	}
}
