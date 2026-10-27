using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Movement;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004707 RID: 18183
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoGridRelocationRequest : IWuWaGoGridRelocationRequest, IWuWaGoGridRelocationContext
	{
		// Token: 0x170076B2 RID: 30386
		// (get) Token: 0x0602F86B RID: 194667 RVA: 0x00B0376A File Offset: 0x00B0196A
		// (set) Token: 0x0602F86C RID: 194668 RVA: 0x00B03772 File Offset: 0x00B01972
		[RequiredMember]
		public WuWaGoGrid Grid { get; set; }

		// Token: 0x170076B3 RID: 30387
		// (get) Token: 0x0602F86D RID: 194669 RVA: 0x00B0377B File Offset: 0x00B0197B
		// (set) Token: 0x0602F86E RID: 194670 RVA: 0x00B03783 File Offset: 0x00B01983
		[RequiredMember]
		public Vector StartCoordinate { get; set; }

		// Token: 0x170076B4 RID: 30388
		// (get) Token: 0x0602F86F RID: 194671 RVA: 0x00B0378C File Offset: 0x00B0198C
		// (set) Token: 0x0602F870 RID: 194672 RVA: 0x00B03794 File Offset: 0x00B01994
		[RequiredMember]
		public Vector TargetCoordinate { get; set; }

		// Token: 0x170076B5 RID: 30389
		// (get) Token: 0x0602F871 RID: 194673 RVA: 0x00B0379D File Offset: 0x00B0199D
		// (set) Token: 0x0602F872 RID: 194674 RVA: 0x00B037A5 File Offset: 0x00B019A5
		[RequiredMember]
		public WuWaGoGridController GridController { get; set; }

		// Token: 0x170076B6 RID: 30390
		// (get) Token: 0x0602F873 RID: 194675 RVA: 0x00B037AE File Offset: 0x00B019AE
		// (set) Token: 0x0602F874 RID: 194676 RVA: 0x00B037B6 File Offset: 0x00B019B6
		[RequiredMember]
		public string OldKey { get; set; }

		// Token: 0x170076B7 RID: 30391
		// (get) Token: 0x0602F875 RID: 194677 RVA: 0x00B037BF File Offset: 0x00B019BF
		// (set) Token: 0x0602F876 RID: 194678 RVA: 0x00B037C7 File Offset: 0x00B019C7
		[RequiredMember]
		public string TargetKey { get; set; }

		// Token: 0x170076B8 RID: 30392
		// (get) Token: 0x0602F877 RID: 194679 RVA: 0x00B037D0 File Offset: 0x00B019D0
		// (set) Token: 0x0602F878 RID: 194680 RVA: 0x00B037D8 File Offset: 0x00B019D8
		[RequiredMember]
		public IReadOnlyList<IWuWaGoGridMoveParticipant> Participants { get; set; }

		// Token: 0x0602F879 RID: 194681 RVA: 0x00B037E1 File Offset: 0x00B019E1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoGridRelocationRequest()
		{
		}
	}
}
