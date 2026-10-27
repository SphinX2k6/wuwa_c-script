using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A6B RID: 27243
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class BoxDesc : IBoxDesc
	{
		// Token: 0x17009927 RID: 39207
		// (get) Token: 0x06043BB8 RID: 277432 RVA: 0x010944C8 File Offset: 0x010926C8
		// (set) Token: 0x06043BB9 RID: 277433 RVA: 0x010944D0 File Offset: 0x010926D0
		[RequiredMember]
		public Vector LocationOffset { get; set; }

		// Token: 0x17009928 RID: 39208
		// (get) Token: 0x06043BBA RID: 277434 RVA: 0x010944D9 File Offset: 0x010926D9
		// (set) Token: 0x06043BBB RID: 277435 RVA: 0x010944E1 File Offset: 0x010926E1
		[RequiredMember]
		public Vector HalfExtent { get; set; }

		// Token: 0x06043BBC RID: 277436 RVA: 0x010944EA File Offset: 0x010926EA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BoxDesc()
		{
		}
	}
}
