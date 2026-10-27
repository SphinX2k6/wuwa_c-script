using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200476B RID: 18283
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GameplayEntityExecutionContext : IGameplayEntityExecutionContext
	{
		// Token: 0x17007762 RID: 30562
		// (get) Token: 0x0602FCB3 RID: 195763 RVA: 0x00B12AAA File Offset: 0x00B10CAA
		// (set) Token: 0x0602FCB4 RID: 195764 RVA: 0x00B12AB2 File Offset: 0x00B10CB2
		[RequiredMember]
		public WuWaGoGameModeBase GameMode { get; set; }

		// Token: 0x17007763 RID: 30563
		// (get) Token: 0x0602FCB5 RID: 195765 RVA: 0x00B12ABB File Offset: 0x00B10CBB
		// (set) Token: 0x0602FCB6 RID: 195766 RVA: 0x00B12AC3 File Offset: 0x00B10CC3
		[RequiredMember]
		public HashSet<int> ExecutingPullRodGroups { get; set; }

		// Token: 0x17007764 RID: 30564
		// (get) Token: 0x0602FCB7 RID: 195767 RVA: 0x00B12ACC File Offset: 0x00B10CCC
		// (set) Token: 0x0602FCB8 RID: 195768 RVA: 0x00B12AD4 File Offset: 0x00B10CD4
		[RequiredMember]
		public HashSet<int> PendingBowTrapPbDataIds { get; set; }

		// Token: 0x17007765 RID: 30565
		// (get) Token: 0x0602FCB9 RID: 195769 RVA: 0x00B12ADD File Offset: 0x00B10CDD
		// (set) Token: 0x0602FCBA RID: 195770 RVA: 0x00B12AE5 File Offset: 0x00B10CE5
		[RequiredMember]
		public HashSet<int> PendingMovableFloorPbDataIds { get; set; }

		// Token: 0x0602FCBB RID: 195771 RVA: 0x00B12AEE File Offset: 0x00B10CEE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GameplayEntityExecutionContext()
		{
		}
	}
}
