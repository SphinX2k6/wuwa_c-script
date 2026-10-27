using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006EA7 RID: 28327
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ElementalDebugDrawShapeInfo : IElementalDebugDrawShapeInfo
	{
		// Token: 0x17009A7F RID: 39551
		// (get) Token: 0x06045037 RID: 282679 RVA: 0x0110DACD File Offset: 0x0110BCCD
		// (set) Token: 0x06045038 RID: 282680 RVA: 0x0110DAD5 File Offset: 0x0110BCD5
		[RequiredMember]
		public UObject Shape { get; set; }

		// Token: 0x17009A80 RID: 39552
		// (get) Token: 0x06045039 RID: 282681 RVA: 0x0110DADE File Offset: 0x0110BCDE
		// (set) Token: 0x0604503A RID: 282682 RVA: 0x0110DAE6 File Offset: 0x0110BCE6
		[RequiredMember]
		public EElementalFieldDebugShapeRole Role { get; set; }

		// Token: 0x0604503B RID: 282683 RVA: 0x0110DAEF File Offset: 0x0110BCEF
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ElementalDebugDrawShapeInfo()
		{
		}
	}
}
