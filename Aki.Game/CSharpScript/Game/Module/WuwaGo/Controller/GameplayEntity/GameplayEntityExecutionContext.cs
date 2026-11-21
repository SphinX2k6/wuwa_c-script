using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200369C RID: 13980
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GameplayEntityExecutionContext : IGameplayEntityExecutionContext
	{
		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x0602447D RID: 148605 RVA: 0x00A42A6A File Offset: 0x00A40C6A
		// (set) Token: 0x0602447E RID: 148606 RVA: 0x00A42A72 File Offset: 0x00A40C72
		[RequiredMember]
		public WuWaGoGameModeBase GameMode { get; set; }

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x0602447F RID: 148607 RVA: 0x00A42A7B File Offset: 0x00A40C7B
		// (set) Token: 0x06024480 RID: 148608 RVA: 0x00A42A83 File Offset: 0x00A40C83
		[RequiredMember]
		public HashSet<int> ExecutingPullRodGroups { get; set; }

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x06024481 RID: 148609 RVA: 0x00A42A8C File Offset: 0x00A40C8C
		// (set) Token: 0x06024482 RID: 148610 RVA: 0x00A42A94 File Offset: 0x00A40C94
		[RequiredMember]
		public HashSet<int> PendingBowTrapPbDataIds { get; set; }

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x06024483 RID: 148611 RVA: 0x00A42A9D File Offset: 0x00A40C9D
		// (set) Token: 0x06024484 RID: 148612 RVA: 0x00A42AA5 File Offset: 0x00A40CA5
		[RequiredMember]
		public HashSet<int> PendingMovableFloorPbDataIds { get; set; }

		// Token: 0x06024485 RID: 148613 RVA: 0x00A42AAE File Offset: 0x00A40CAE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GameplayEntityExecutionContext()
		{
		}
	}
}
