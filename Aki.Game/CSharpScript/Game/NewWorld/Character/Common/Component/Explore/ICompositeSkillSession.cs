using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02007121 RID: 28961
	[NullableContext(1)]
	public interface ICompositeSkillSession
	{
		// Token: 0x17009D29 RID: 40233
		// (get) Token: 0x06046B6B RID: 289643
		// (set) Token: 0x06046B6C RID: 289644
		ICompositeExploreSkillConfig Config { get; set; }

		// Token: 0x17009D2A RID: 40234
		// (get) Token: 0x06046B6D RID: 289645
		// (set) Token: 0x06046B6E RID: 289646
		bool EnterSent { get; set; }

		// Token: 0x17009D2B RID: 40235
		// (get) Token: 0x06046B6F RID: 289647
		// (set) Token: 0x06046B70 RID: 289648
		double CreatedTime { get; set; }
	}
}
