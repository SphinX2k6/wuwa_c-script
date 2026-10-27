using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006603 RID: 26115
	[NullableContext(1)]
	public interface IFishingHandBookItemData
	{
		// Token: 0x170095EE RID: 38382
		// (get) Token: 0x06041735 RID: 268085
		// (set) Token: 0x06041736 RID: 268086
		int Id { get; set; }

		// Token: 0x170095EF RID: 38383
		// (get) Token: 0x06041737 RID: 268087
		// (set) Token: 0x06041738 RID: 268088
		int Type { get; set; }

		// Token: 0x170095F0 RID: 38384
		// (get) Token: 0x06041739 RID: 268089
		// (set) Token: 0x0604173A RID: 268090
		int Time { get; set; }

		// Token: 0x170095F1 RID: 38385
		// (get) Token: 0x0604173B RID: 268091
		// (set) Token: 0x0604173C RID: 268092
		List<int> Tech { get; set; }

		// Token: 0x170095F2 RID: 38386
		// (get) Token: 0x0604173D RID: 268093
		// (set) Token: 0x0604173E RID: 268094
		List<int> Area { get; set; }

		// Token: 0x170095F3 RID: 38387
		// (get) Token: 0x0604173F RID: 268095
		// (set) Token: 0x06041740 RID: 268096
		int HandBookId { get; set; }
	}
}
