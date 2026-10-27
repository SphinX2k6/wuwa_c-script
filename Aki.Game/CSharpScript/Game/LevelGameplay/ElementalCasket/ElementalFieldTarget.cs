using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E60 RID: 28256
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ElementalFieldTarget
	{
		// Token: 0x17009A49 RID: 39497
		// (get) Token: 0x06044DE4 RID: 282084 RVA: 0x010FFC0E File Offset: 0x010FDE0E
		// (set) Token: 0x06044DE5 RID: 282085 RVA: 0x010FFC16 File Offset: 0x010FDE16
		[RequiredMember]
		public EntityHandle Detectable { get; set; }

		// Token: 0x17009A4A RID: 39498
		// (get) Token: 0x06044DE6 RID: 282086 RVA: 0x010FFC1F File Offset: 0x010FDE1F
		// (set) Token: 0x06044DE7 RID: 282087 RVA: 0x010FFC27 File Offset: 0x010FDE27
		[RequiredMember]
		public List<UObject> Shapes { get; set; }

		// Token: 0x06044DE8 RID: 282088 RVA: 0x010FFC30 File Offset: 0x010FDE30
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ElementalFieldTarget()
		{
		}
	}
}
