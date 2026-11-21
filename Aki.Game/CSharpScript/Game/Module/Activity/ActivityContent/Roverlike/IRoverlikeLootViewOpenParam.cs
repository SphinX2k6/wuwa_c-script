using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200510C RID: 20748
	[NullableContext(2)]
	public interface IRoverlikeLootViewOpenParam
	{
		// Token: 0x17006546 RID: 25926
		// (get) Token: 0x06033E71 RID: 212593
		// (set) Token: 0x06033E72 RID: 212594
		bool IsInGame { get; set; }

		// Token: 0x17006547 RID: 25927
		// (get) Token: 0x06033E73 RID: 212595
		// (set) Token: 0x06033E74 RID: 212596
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

		// Token: 0x17006548 RID: 25928
		// (get) Token: 0x06033E75 RID: 212597
		// (set) Token: 0x06033E76 RID: 212598
		bool? EnableUse { get; set; }

		// Token: 0x17006549 RID: 25929
		// (get) Token: 0x06033E77 RID: 212599
		// (set) Token: 0x06033E78 RID: 212600
		List<int> EquippedLootIds { get; set; }

		// Token: 0x1700654A RID: 25930
		// (get) Token: 0x06033E79 RID: 212601
		// (set) Token: 0x06033E7A RID: 212602
		Action<int, int> OnConfirmSelect { get; set; }

		// Token: 0x1700654B RID: 25931
		// (get) Token: 0x06033E7B RID: 212603
		// (set) Token: 0x06033E7C RID: 212604
		int DefaultSelectedLootId { get; set; }
	}
}
