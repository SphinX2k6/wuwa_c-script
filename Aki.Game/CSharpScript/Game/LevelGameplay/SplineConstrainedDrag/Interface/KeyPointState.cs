using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02006A3A RID: 27194
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class KeyPointState : IKeyPointState
	{
		// Token: 0x17009909 RID: 39177
		// (get) Token: 0x06043A7C RID: 277116 RVA: 0x0108D31A File Offset: 0x0108B51A
		// (set) Token: 0x06043A7D RID: 277117 RVA: 0x0108D322 File Offset: 0x0108B522
		[RequiredMember]
		public IDragActorPlayKeyPointConfig Config { get; set; }

		// Token: 0x1700990A RID: 39178
		// (get) Token: 0x06043A7E RID: 277118 RVA: 0x0108D32B File Offset: 0x0108B52B
		// (set) Token: 0x06043A7F RID: 277119 RVA: 0x0108D333 File Offset: 0x0108B533
		[RequiredMember]
		public Vector Position { get; set; }

		// Token: 0x1700990B RID: 39179
		// (get) Token: 0x06043A80 RID: 277120 RVA: 0x0108D33C File Offset: 0x0108B53C
		// (set) Token: 0x06043A81 RID: 277121 RVA: 0x0108D344 File Offset: 0x0108B544
		public bool IsInside { get; set; }

		// Token: 0x06043A82 RID: 277122 RVA: 0x0108D34D File Offset: 0x0108B54D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public KeyPointState()
		{
		}
	}
}
