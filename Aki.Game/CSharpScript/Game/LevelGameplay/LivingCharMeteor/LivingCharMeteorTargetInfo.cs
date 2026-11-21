using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LivingCharMeteor
{
	// Token: 0x02005C3D RID: 23613
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	internal class LivingCharMeteorTargetInfo
	{
		// Token: 0x17006E74 RID: 28276
		// (get) Token: 0x06039FF0 RID: 237552 RVA: 0x01050392 File Offset: 0x0104E592
		// (set) Token: 0x06039FF1 RID: 237553 RVA: 0x0105039A File Offset: 0x0104E59A
		[RequiredMember]
		public Entity Entity { get; set; }

		// Token: 0x17006E75 RID: 28277
		// (get) Token: 0x06039FF2 RID: 237554 RVA: 0x010503A3 File Offset: 0x0104E5A3
		// (set) Token: 0x06039FF3 RID: 237555 RVA: 0x010503AB File Offset: 0x0104E5AB
		[RequiredMember]
		public AActor Actor { get; set; }

		// Token: 0x17006E76 RID: 28278
		// (get) Token: 0x06039FF4 RID: 237556 RVA: 0x010503B4 File Offset: 0x0104E5B4
		// (set) Token: 0x06039FF5 RID: 237557 RVA: 0x010503BC File Offset: 0x0104E5BC
		public double ScreenDistSquared { get; set; }

		// Token: 0x17006E77 RID: 28279
		// (get) Token: 0x06039FF6 RID: 237558 RVA: 0x010503C5 File Offset: 0x0104E5C5
		// (set) Token: 0x06039FF7 RID: 237559 RVA: 0x010503CD File Offset: 0x0104E5CD
		public double DistanceSquared { get; set; }

		// Token: 0x06039FF8 RID: 237560 RVA: 0x010503D6 File Offset: 0x0104E5D6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LivingCharMeteorTargetInfo()
		{
		}
	}
}
