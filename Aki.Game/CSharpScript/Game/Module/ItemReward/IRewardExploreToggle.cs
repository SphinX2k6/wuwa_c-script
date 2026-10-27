using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057CA RID: 22474
	[NullableContext(1)]
	public interface IRewardExploreToggle
	{
		// Token: 0x170089A2 RID: 35234
		// (get) Token: 0x0603924D RID: 234061
		// (set) Token: 0x0603924E RID: 234062
		string DescriptionTextId { get; set; }

		// Token: 0x170089A3 RID: 35235
		// (get) Token: 0x0603924F RID: 234063
		// (set) Token: 0x06039250 RID: 234064
		[Nullable(2)]
		Action<EToggleState> OnToggleClick { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
