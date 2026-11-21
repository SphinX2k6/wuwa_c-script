using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A1 RID: 18337
	[NullableContext(1)]
	public interface IRewardExploreToggle
	{
		// Token: 0x17005D6A RID: 23914
		// (get) Token: 0x0602E15D RID: 188765
		// (set) Token: 0x0602E15E RID: 188766
		string DescriptionTextId { get; set; }

		// Token: 0x17005D6B RID: 23915
		// (get) Token: 0x0602E15F RID: 188767
		// (set) Token: 0x0602E160 RID: 188768
		[Nullable(2)]
		Action<EToggleState> OnToggleClick { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005D6C RID: 23916
		// (get) Token: 0x0602E161 RID: 188769
		// (set) Token: 0x0602E162 RID: 188770
		bool DefaultOn { get; set; }
	}
}
