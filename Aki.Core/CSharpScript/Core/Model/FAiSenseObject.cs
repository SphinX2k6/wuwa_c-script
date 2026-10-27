using System;
using UnrealEngine;

namespace CSharpScript.Core.Model
{
	// Token: 0x0200012F RID: 303
	public struct FAiSenseObject
	{
		// Token: 0x040006B8 RID: 1720
		public int AiSenseId;

		// Token: 0x040006B9 RID: 1721
		public FVector2D AiSenseHorizontalAngle;

		// Token: 0x040006BA RID: 1722
		public FVector2D AiSenseVerticalAngle;

		// Token: 0x040006BB RID: 1723
		public bool AiSenseCantBeBlock;

		// Token: 0x040006BC RID: 1724
		public int AiSenseBlockType;

		// Token: 0x040006BD RID: 1725
		public bool WithAngleHorizontal;

		// Token: 0x040006BE RID: 1726
		public bool WithAngleVertical;

		// Token: 0x040006BF RID: 1727
		public float SenseDistanceRangeMin;

		// Token: 0x040006C0 RID: 1728
		public float SenseDistanceRangeMax;

		// Token: 0x040006C1 RID: 1729
		public float SquaredWalkSenseRate;

		// Token: 0x040006C2 RID: 1730
		public float SquaredAirSenseRate;
	}
}
