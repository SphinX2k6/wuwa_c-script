using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BCA RID: 23498
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class BoxSnapshot : IBoxSnapshot
	{
		// Token: 0x17006E11 RID: 28177
		// (get) Token: 0x06039C0E RID: 236558 RVA: 0x01038D26 File Offset: 0x01036F26
		// (set) Token: 0x06039C0F RID: 236559 RVA: 0x01038D2E File Offset: 0x01036F2E
		[RequiredMember]
		public Vector WorldPosition { get; set; }

		// Token: 0x17006E12 RID: 28178
		// (get) Token: 0x06039C10 RID: 236560 RVA: 0x01038D37 File Offset: 0x01036F37
		// (set) Token: 0x06039C11 RID: 236561 RVA: 0x01038D3F File Offset: 0x01036F3F
		[RequiredMember]
		public Quat Rotation { get; set; }

		// Token: 0x17006E13 RID: 28179
		// (get) Token: 0x06039C12 RID: 236562 RVA: 0x01038D48 File Offset: 0x01036F48
		// (set) Token: 0x06039C13 RID: 236563 RVA: 0x01038D50 File Offset: 0x01036F50
		[RequiredMember]
		public Vector HalfExtent { get; set; }

		// Token: 0x06039C14 RID: 236564 RVA: 0x01038D59 File Offset: 0x01036F59
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BoxSnapshot()
		{
		}
	}
}
