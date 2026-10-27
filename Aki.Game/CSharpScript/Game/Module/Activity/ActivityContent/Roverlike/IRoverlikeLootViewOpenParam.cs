using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200618E RID: 24974
	[NullableContext(2)]
	public interface IRoverlikeLootViewOpenParam
	{
		// Token: 0x170091E4 RID: 37348
		// (get) Token: 0x0603F1B1 RID: 258481
		// (set) Token: 0x0603F1B2 RID: 258482
		bool IsInGame { get; set; }

		// Token: 0x170091E5 RID: 37349
		// (get) Token: 0x0603F1B3 RID: 258483
		// (set) Token: 0x0603F1B4 RID: 258484
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<RoverRogueGainEntry> Loots { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170091E6 RID: 37350
		// (get) Token: 0x0603F1B5 RID: 258485
		// (set) Token: 0x0603F1B6 RID: 258486
		bool? EnableUse { get; set; }

		// Token: 0x170091E7 RID: 37351
		// (get) Token: 0x0603F1B7 RID: 258487
		// (set) Token: 0x0603F1B8 RID: 258488
		List<int> EquippedLootIds { get; set; }

		// Token: 0x170091E8 RID: 37352
		// (get) Token: 0x0603F1B9 RID: 258489
		// (set) Token: 0x0603F1BA RID: 258490
		Action<int, int> OnConfirmSelect { get; set; }

		// Token: 0x170091E9 RID: 37353
		// (get) Token: 0x0603F1BB RID: 258491
		// (set) Token: 0x0603F1BC RID: 258492
		int DefaultSelectedLootId { get; set; }
	}
}
