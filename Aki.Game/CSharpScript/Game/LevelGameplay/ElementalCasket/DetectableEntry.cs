using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E7F RID: 28287
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DetectableEntry
	{
		// Token: 0x06044F09 RID: 282377 RVA: 0x01107DD5 File Offset: 0x01105FD5
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DetectableEntry()
		{
		}

		// Token: 0x04023E53 RID: 147027
		[RequiredMember]
		public EntityHandle Owner;

		// Token: 0x04023E54 RID: 147028
		[RequiredMember]
		public List<UObject> Shapes;
	}
}
