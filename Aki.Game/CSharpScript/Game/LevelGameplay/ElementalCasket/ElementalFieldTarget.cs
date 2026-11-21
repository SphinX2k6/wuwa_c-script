using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FE1 RID: 24545
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ElementalFieldTarget
	{
		// Token: 0x17006F5E RID: 28510
		// (get) Token: 0x0603AF71 RID: 241521 RVA: 0x010AA16E File Offset: 0x010A836E
		// (set) Token: 0x0603AF72 RID: 241522 RVA: 0x010AA176 File Offset: 0x010A8376
		[RequiredMember]
		public EntityHandle Detectable { get; set; }

		// Token: 0x17006F5F RID: 28511
		// (get) Token: 0x0603AF73 RID: 241523 RVA: 0x010AA17F File Offset: 0x010A837F
		// (set) Token: 0x0603AF74 RID: 241524 RVA: 0x010AA187 File Offset: 0x010A8387
		[RequiredMember]
		public List<UObject> Shapes { get; set; }

		// Token: 0x0603AF75 RID: 241525 RVA: 0x010AA190 File Offset: 0x010A8390
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ElementalFieldTarget()
		{
		}
	}
}
