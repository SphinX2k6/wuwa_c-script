using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LivingCharMeteor
{
	// Token: 0x02006AC6 RID: 27334
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	internal class LivingCharMeteorActorInfo
	{
		// Token: 0x17009975 RID: 39285
		// (get) Token: 0x06043EB0 RID: 278192 RVA: 0x010A6D2E File Offset: 0x010A4F2E
		// (set) Token: 0x06043EB1 RID: 278193 RVA: 0x010A6D36 File Offset: 0x010A4F36
		[RequiredMember]
		public AActor Actor { get; set; }

		// Token: 0x17009976 RID: 39286
		// (get) Token: 0x06043EB2 RID: 278194 RVA: 0x010A6D3F File Offset: 0x010A4F3F
		// (set) Token: 0x06043EB3 RID: 278195 RVA: 0x010A6D47 File Offset: 0x010A4F47
		[RequiredMember]
		public FVectorDouble Location { get; set; }

		// Token: 0x06043EB4 RID: 278196 RVA: 0x010A6D50 File Offset: 0x010A4F50
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LivingCharMeteorActorInfo()
		{
		}
	}
}
