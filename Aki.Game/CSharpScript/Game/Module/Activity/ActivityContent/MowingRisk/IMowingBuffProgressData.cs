using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063B5 RID: 25525
	[NullableContext(1)]
	public interface IMowingBuffProgressData
	{
		// Token: 0x17009385 RID: 37765
		// (get) Token: 0x06040364 RID: 263012
		// (set) Token: 0x06040365 RID: 263013
		int ArtifactId { get; set; }

		// Token: 0x17009386 RID: 37766
		// (get) Token: 0x06040366 RID: 263014
		// (set) Token: 0x06040367 RID: 263015
		int CurBasicBuffCount { get; set; }

		// Token: 0x17009387 RID: 37767
		// (get) Token: 0x06040368 RID: 263016
		// (set) Token: 0x06040369 RID: 263017
		int MaxBasicBuffCount { get; set; }

		// Token: 0x17009388 RID: 37768
		// (get) Token: 0x0604036A RID: 263018
		// (set) Token: 0x0604036B RID: 263019
		string CountTextId { get; set; }

		// Token: 0x17009389 RID: 37769
		// (get) Token: 0x0604036C RID: 263020
		// (set) Token: 0x0604036D RID: 263021
		string[] CountTextArgs { get; set; }

		// Token: 0x1700938A RID: 37770
		// (get) Token: 0x0604036E RID: 263022
		// (set) Token: 0x0604036F RID: 263023
		float ProgressPercentage { get; set; }

		// Token: 0x1700938B RID: 37771
		// (get) Token: 0x06040370 RID: 263024
		// (set) Token: 0x06040371 RID: 263025
		IMowingBuffUnitData[] SuperBuffList { get; set; }

		// Token: 0x1700938C RID: 37772
		// (get) Token: 0x06040372 RID: 263026
		// (set) Token: 0x06040373 RID: 263027
		IMowingBuffIntroduceData IntroduceData { get; set; }
	}
}
