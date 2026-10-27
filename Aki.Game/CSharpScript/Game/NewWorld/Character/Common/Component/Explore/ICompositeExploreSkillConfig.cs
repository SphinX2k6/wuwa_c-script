using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x0200711F RID: 28959
	[NullableContext(1)]
	public interface ICompositeExploreSkillConfig
	{
		// Token: 0x17009D23 RID: 40227
		// (get) Token: 0x06046B5E RID: 289630
		// (set) Token: 0x06046B5F RID: 289631
		string Name { get; set; }

		// Token: 0x17009D24 RID: 40228
		// (get) Token: 0x06046B60 RID: 289632
		// (set) Token: 0x06046B61 RID: 289633
		int EntrySkillId { get; set; }

		// Token: 0x17009D25 RID: 40229
		// (get) Token: 0x06046B62 RID: 289634
		// (set) Token: 0x06046B63 RID: 289635
		int ExitSkillId { get; set; }
	}
}
