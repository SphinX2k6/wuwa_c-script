using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063BF RID: 25535
	[NullableContext(1)]
	public interface IMowingBuffOverviewData
	{
		// Token: 0x170093C1 RID: 37825
		// (get) Token: 0x060403E1 RID: 263137
		// (set) Token: 0x060403E2 RID: 263138
		IMowingBuffIntroduceData IntroduceData { get; set; }

		// Token: 0x170093C2 RID: 37826
		// (get) Token: 0x060403E3 RID: 263139
		// (set) Token: 0x060403E4 RID: 263140
		IMowingBuffGridGroupData[] BuffGroupData { get; set; }
	}
}
