using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02006A97 RID: 27287
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RangeGatedBoxDesc : IRangeGatedBoxDesc, IBoxDesc
	{
		// Token: 0x1700993F RID: 39231
		// (get) Token: 0x06043CB2 RID: 277682 RVA: 0x01098013 File Offset: 0x01096213
		// (set) Token: 0x06043CB3 RID: 277683 RVA: 0x0109801B File Offset: 0x0109621B
		[RequiredMember]
		public Vector LocationOffset { get; set; }

		// Token: 0x17009940 RID: 39232
		// (get) Token: 0x06043CB4 RID: 277684 RVA: 0x01098024 File Offset: 0x01096224
		// (set) Token: 0x06043CB5 RID: 277685 RVA: 0x0109802C File Offset: 0x0109622C
		[RequiredMember]
		public Vector HalfExtent { get; set; }

		// Token: 0x17009941 RID: 39233
		// (get) Token: 0x06043CB6 RID: 277686 RVA: 0x01098035 File Offset: 0x01096235
		// (set) Token: 0x06043CB7 RID: 277687 RVA: 0x0109803D File Offset: 0x0109623D
		[RequiredMember]
		public List<Vector> PointLocationOffsets { get; set; }

		// Token: 0x17009942 RID: 39234
		// (get) Token: 0x06043CB8 RID: 277688 RVA: 0x01098046 File Offset: 0x01096246
		// (set) Token: 0x06043CB9 RID: 277689 RVA: 0x0109804E File Offset: 0x0109624E
		public int? LandingSplineEntityId { get; set; }

		// Token: 0x06043CBA RID: 277690 RVA: 0x01098057 File Offset: 0x01096257
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RangeGatedBoxDesc()
		{
		}
	}
}
