using System;
using UnrealEngine;

namespace CSharpScript.Core.Model
{
	// Token: 0x02000130 RID: 304
	public struct FAiSenseObject
	{
		// Token: 0x040006C6 RID: 1734
		public int AiSenseId;

		// Token: 0x040006C7 RID: 1735
		public FVector2D AiSenseHorizontalAngle;

		// Token: 0x040006C8 RID: 1736
		public FVector2D AiSenseVerticalAngle;

		// Token: 0x040006C9 RID: 1737
		public bool AiSenseCantBeBlock;

		// Token: 0x040006CA RID: 1738
		public int AiSenseBlockType;

		// Token: 0x040006CB RID: 1739
		public bool WithAngleHorizontal;

		// Token: 0x040006CC RID: 1740
		public bool WithAngleVertical;

		// Token: 0x040006CD RID: 1741
		public float SenseDistanceRangeMin;

		// Token: 0x040006CE RID: 1742
		public float SenseDistanceRangeMax;

		// Token: 0x040006CF RID: 1743
		public float SquaredWalkSenseRate;

		// Token: 0x040006D0 RID: 1744
		public float SquaredAirSenseRate;
	}
}
