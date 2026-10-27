using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063B3 RID: 25523
	[NullableContext(1)]
	public interface IMowingBuffUnitData
	{
		// Token: 0x17009377 RID: 37751
		// (get) Token: 0x06040347 RID: 262983
		// (set) Token: 0x06040348 RID: 262984
		int Index { get; set; }

		// Token: 0x17009378 RID: 37752
		// (get) Token: 0x06040349 RID: 262985
		// (set) Token: 0x0604034A RID: 262986
		int BuffId { get; set; }

		// Token: 0x17009379 RID: 37753
		// (get) Token: 0x0604034B RID: 262987
		// (set) Token: 0x0604034C RID: 262988
		bool IsActive { get; set; }

		// Token: 0x1700937A RID: 37754
		// (get) Token: 0x0604034D RID: 262989
		// (set) Token: 0x0604034E RID: 262990
		bool IsChosen { get; set; }

		// Token: 0x1700937B RID: 37755
		// (get) Token: 0x0604034F RID: 262991
		// (set) Token: 0x06040350 RID: 262992
		string IconPath { get; set; }

		// Token: 0x1700937C RID: 37756
		// (get) Token: 0x06040351 RID: 262993
		// (set) Token: 0x06040352 RID: 262994
		string NameTextId { get; set; }

		// Token: 0x1700937D RID: 37757
		// (get) Token: 0x06040353 RID: 262995
		// (set) Token: 0x06040354 RID: 262996
		int ThresholdCount { get; set; }
	}
}
