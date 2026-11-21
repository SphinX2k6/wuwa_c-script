using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FFF RID: 24575
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class FieldEntry
	{
		// Token: 0x0603B0B8 RID: 241848 RVA: 0x010B2335 File Offset: 0x010B0535
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public FieldEntry()
		{
		}

		// Token: 0x0401F108 RID: 127240
		[RequiredMember]
		public EntityHandle Owner;

		// Token: 0x0401F109 RID: 127241
		[RequiredMember]
		public UKuroFastCollisionShapeComponent Shape;

		// Token: 0x0401F10A RID: 127242
		[RequiredMember]
		public Dictionary<EntityHandle, HashSet<UObject>> Overlaps;
	}
}
