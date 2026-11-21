using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006027 RID: 24615
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ElementalDebugDrawShapeInfo : IElementalDebugDrawShapeInfo
	{
		// Token: 0x17006FB6 RID: 28598
		// (get) Token: 0x0603B1D8 RID: 242136 RVA: 0x010B7BA9 File Offset: 0x010B5DA9
		// (set) Token: 0x0603B1D9 RID: 242137 RVA: 0x010B7BB1 File Offset: 0x010B5DB1
		[RequiredMember]
		public UObject Shape { get; set; }

		// Token: 0x17006FB7 RID: 28599
		// (get) Token: 0x0603B1DA RID: 242138 RVA: 0x010B7BBA File Offset: 0x010B5DBA
		// (set) Token: 0x0603B1DB RID: 242139 RVA: 0x010B7BC2 File Offset: 0x010B5DC2
		[RequiredMember]
		public EElementalFieldDebugShapeRole Role { get; set; }

		// Token: 0x0603B1DC RID: 242140 RVA: 0x010B7BCB File Offset: 0x010B5DCB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ElementalDebugDrawShapeInfo()
		{
		}
	}
}
