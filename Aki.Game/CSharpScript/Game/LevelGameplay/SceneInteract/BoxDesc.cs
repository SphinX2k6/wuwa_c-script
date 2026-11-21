using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BC8 RID: 23496
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class BoxDesc : IBoxDesc
	{
		// Token: 0x17006E0C RID: 28172
		// (get) Token: 0x06039C06 RID: 236550 RVA: 0x01038CFC File Offset: 0x01036EFC
		// (set) Token: 0x06039C07 RID: 236551 RVA: 0x01038D04 File Offset: 0x01036F04
		[RequiredMember]
		public Vector LocationOffset { get; set; }

		// Token: 0x17006E0D RID: 28173
		// (get) Token: 0x06039C08 RID: 236552 RVA: 0x01038D0D File Offset: 0x01036F0D
		// (set) Token: 0x06039C09 RID: 236553 RVA: 0x01038D15 File Offset: 0x01036F15
		[RequiredMember]
		public Vector HalfExtent { get; set; }

		// Token: 0x06039C0A RID: 236554 RVA: 0x01038D1E File Offset: 0x01036F1E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BoxDesc()
		{
		}
	}
}
