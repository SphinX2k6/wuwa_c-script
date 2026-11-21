using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LivingCharMeteor
{
	// Token: 0x02005C3E RID: 23614
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	internal class LivingCharMeteorActorInfo
	{
		// Token: 0x17006E78 RID: 28280
		// (get) Token: 0x06039FF9 RID: 237561 RVA: 0x010503DE File Offset: 0x0104E5DE
		// (set) Token: 0x06039FFA RID: 237562 RVA: 0x010503E6 File Offset: 0x0104E5E6
		[RequiredMember]
		public AActor Actor { get; set; }

		// Token: 0x17006E79 RID: 28281
		// (get) Token: 0x06039FFB RID: 237563 RVA: 0x010503EF File Offset: 0x0104E5EF
		// (set) Token: 0x06039FFC RID: 237564 RVA: 0x010503F7 File Offset: 0x0104E5F7
		[RequiredMember]
		public FVectorDouble Location { get; set; }

		// Token: 0x06039FFD RID: 237565 RVA: 0x01050400 File Offset: 0x0104E600
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LivingCharMeteorActorInfo()
		{
		}
	}
}
