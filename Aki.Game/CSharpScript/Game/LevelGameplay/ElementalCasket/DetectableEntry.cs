using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006000 RID: 24576
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DetectableEntry
	{
		// Token: 0x0603B0B9 RID: 241849 RVA: 0x010B233D File Offset: 0x010B053D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DetectableEntry()
		{
		}

		// Token: 0x0401F10B RID: 127243
		[RequiredMember]
		public EntityHandle Owner;

		// Token: 0x0401F10C RID: 127244
		[RequiredMember]
		public List<UObject> Shapes;
	}
}
