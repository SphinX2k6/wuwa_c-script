using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A6D RID: 27245
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class BoxSnapshot : IBoxSnapshot
	{
		// Token: 0x1700992C RID: 39212
		// (get) Token: 0x06043BC0 RID: 277440 RVA: 0x010944F2 File Offset: 0x010926F2
		// (set) Token: 0x06043BC1 RID: 277441 RVA: 0x010944FA File Offset: 0x010926FA
		[RequiredMember]
		public Vector WorldPosition { get; set; }

		// Token: 0x1700992D RID: 39213
		// (get) Token: 0x06043BC2 RID: 277442 RVA: 0x01094503 File Offset: 0x01092703
		// (set) Token: 0x06043BC3 RID: 277443 RVA: 0x0109450B File Offset: 0x0109270B
		[RequiredMember]
		public Quat Rotation { get; set; }

		// Token: 0x1700992E RID: 39214
		// (get) Token: 0x06043BC4 RID: 277444 RVA: 0x01094514 File Offset: 0x01092714
		// (set) Token: 0x06043BC5 RID: 277445 RVA: 0x0109451C File Offset: 0x0109271C
		[RequiredMember]
		public Vector HalfExtent { get; set; }

		// Token: 0x06043BC6 RID: 277446 RVA: 0x01094525 File Offset: 0x01092725
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BoxSnapshot()
		{
		}
	}
}
