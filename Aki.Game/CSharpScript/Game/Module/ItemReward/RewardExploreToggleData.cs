using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057CB RID: 22475
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreToggleData : IRewardExploreToggle
	{
		// Token: 0x170089A4 RID: 35236
		// (get) Token: 0x06039251 RID: 234065 RVA: 0x00D900B5 File Offset: 0x00D8E2B5
		// (set) Token: 0x06039252 RID: 234066 RVA: 0x00D900BD File Offset: 0x00D8E2BD
		public string DescriptionTextId { get; set; }

		// Token: 0x170089A5 RID: 35237
		// (get) Token: 0x06039253 RID: 234067 RVA: 0x00D900C6 File Offset: 0x00D8E2C6
		// (set) Token: 0x06039254 RID: 234068 RVA: 0x00D900CE File Offset: 0x00D8E2CE
		[Nullable(2)]
		public Action<EToggleState> OnToggleClick { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
