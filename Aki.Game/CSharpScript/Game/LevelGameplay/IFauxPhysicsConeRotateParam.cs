using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AD2 RID: 23250
	public class IFauxPhysicsConeRotateParam : IFauxPhysicsRotateParam
	{
		// Token: 0x17006D02 RID: 27906
		// (get) Token: 0x06039387 RID: 234375 RVA: 0x0100673C File Offset: 0x0100493C
		// (set) Token: 0x06039388 RID: 234376 RVA: 0x01006744 File Offset: 0x01004944
		private FVector? LocalConeDirection { get; set; }

		// Token: 0x17006D03 RID: 27907
		// (get) Token: 0x06039389 RID: 234377 RVA: 0x0100674D File Offset: 0x0100494D
		// (set) Token: 0x0603938A RID: 234378 RVA: 0x01006755 File Offset: 0x01004955
		private float? ConeAngle { get; set; }

		// Token: 0x17006D04 RID: 27908
		// (get) Token: 0x0603938B RID: 234379 RVA: 0x0100675E File Offset: 0x0100495E
		// (set) Token: 0x0603938C RID: 234380 RVA: 0x01006766 File Offset: 0x01004966
		public EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x17006D05 RID: 27909
		// (get) Token: 0x0603938D RID: 234381 RVA: 0x0100676F File Offset: 0x0100496F
		// (set) Token: 0x0603938E RID: 234382 RVA: 0x01006777 File Offset: 0x01004977
		public FVector? Origin { get; set; }

		// Token: 0x17006D06 RID: 27910
		// (get) Token: 0x0603938F RID: 234383 RVA: 0x01006780 File Offset: 0x01004980
		// (set) Token: 0x06039390 RID: 234384 RVA: 0x01006788 File Offset: 0x01004988
		public FVector? RelativeOffset { get; set; }

		// Token: 0x17006D07 RID: 27911
		// (get) Token: 0x06039391 RID: 234385 RVA: 0x01006791 File Offset: 0x01004991
		// (set) Token: 0x06039392 RID: 234386 RVA: 0x01006799 File Offset: 0x01004999
		public FVector? Force { get; set; }

		// Token: 0x17006D08 RID: 27912
		// (get) Token: 0x06039393 RID: 234387 RVA: 0x010067A2 File Offset: 0x010049A2
		// (set) Token: 0x06039394 RID: 234388 RVA: 0x010067AA File Offset: 0x010049AA
		public FVector? Impulse { get; set; }

		// Token: 0x17006D09 RID: 27913
		// (get) Token: 0x06039395 RID: 234389 RVA: 0x010067B3 File Offset: 0x010049B3
		// (set) Token: 0x06039396 RID: 234390 RVA: 0x010067BB File Offset: 0x010049BB
		public FVector? Movement { get; set; }
	}
}
