using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020071F9 RID: 29177
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SceneItemGraphSelectResult : ISceneItemGraphSelectResult
	{
		// Token: 0x17009E0F RID: 40463
		// (get) Token: 0x060476B2 RID: 292530 RVA: 0x0122F5C6 File Offset: 0x0122D7C6
		// (set) Token: 0x060476B3 RID: 292531 RVA: 0x0122F5CE File Offset: 0x0122D7CE
		public int NodeId { get; set; }

		// Token: 0x17009E10 RID: 40464
		// (get) Token: 0x060476B4 RID: 292532 RVA: 0x0122F5D7 File Offset: 0x0122D7D7
		// (set) Token: 0x060476B5 RID: 292533 RVA: 0x0122F5DF File Offset: 0x0122D7DF
		[RequiredMember]
		public Vector Location { get; set; }

		// Token: 0x060476B6 RID: 292534 RVA: 0x0122F5E8 File Offset: 0x0122D7E8
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemGraphSelectResult()
		{
		}
	}
}
