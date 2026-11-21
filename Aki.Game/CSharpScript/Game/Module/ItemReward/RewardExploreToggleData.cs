using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A2 RID: 18338
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreToggleData : IRewardExploreToggle
	{
		// Token: 0x17005D6D RID: 23917
		// (get) Token: 0x0602E163 RID: 188771 RVA: 0x00CDEEED File Offset: 0x00CDD0ED
		// (set) Token: 0x0602E164 RID: 188772 RVA: 0x00CDEEF5 File Offset: 0x00CDD0F5
		public string DescriptionTextId { get; set; }

		// Token: 0x17005D6E RID: 23918
		// (get) Token: 0x0602E165 RID: 188773 RVA: 0x00CDEEFE File Offset: 0x00CDD0FE
		// (set) Token: 0x0602E166 RID: 188774 RVA: 0x00CDEF06 File Offset: 0x00CDD106
		[Nullable(2)]
		public Action<EToggleState> OnToggleClick { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005D6F RID: 23919
		// (get) Token: 0x0602E167 RID: 188775 RVA: 0x00CDEF0F File Offset: 0x00CDD10F
		// (set) Token: 0x0602E168 RID: 188776 RVA: 0x00CDEF17 File Offset: 0x00CDD117
		public bool DefaultOn { get; set; }
	}
}
