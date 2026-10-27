using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E7E RID: 28286
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class FieldEntry
	{
		// Token: 0x06044F08 RID: 282376 RVA: 0x01107DCD File Offset: 0x01105FCD
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public FieldEntry()
		{
		}

		// Token: 0x04023E50 RID: 147024
		[RequiredMember]
		public EntityHandle Owner;

		// Token: 0x04023E51 RID: 147025
		[RequiredMember]
		public UKuroFastCollisionShapeComponent Shape;

		// Token: 0x04023E52 RID: 147026
		[RequiredMember]
		public Dictionary<EntityHandle, HashSet<UObject>> Overlaps;
	}
}
