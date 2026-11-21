using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Movement;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003637 RID: 13879
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoGridRelocationRequest : IWuWaGoGridRelocationRequest, IWuWaGoGridRelocationContext
	{
		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x06024031 RID: 147505 RVA: 0x00A3343A File Offset: 0x00A3163A
		// (set) Token: 0x06024032 RID: 147506 RVA: 0x00A33442 File Offset: 0x00A31642
		[RequiredMember]
		public WuWaGoGrid Grid { get; set; }

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x06024033 RID: 147507 RVA: 0x00A3344B File Offset: 0x00A3164B
		// (set) Token: 0x06024034 RID: 147508 RVA: 0x00A33453 File Offset: 0x00A31653
		[RequiredMember]
		public Vector StartCoordinate { get; set; }

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x06024035 RID: 147509 RVA: 0x00A3345C File Offset: 0x00A3165C
		// (set) Token: 0x06024036 RID: 147510 RVA: 0x00A33464 File Offset: 0x00A31664
		[RequiredMember]
		public Vector TargetCoordinate { get; set; }

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x06024037 RID: 147511 RVA: 0x00A3346D File Offset: 0x00A3166D
		// (set) Token: 0x06024038 RID: 147512 RVA: 0x00A33475 File Offset: 0x00A31675
		[RequiredMember]
		public WuWaGoGridController GridController { get; set; }

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x06024039 RID: 147513 RVA: 0x00A3347E File Offset: 0x00A3167E
		// (set) Token: 0x0602403A RID: 147514 RVA: 0x00A33486 File Offset: 0x00A31686
		[RequiredMember]
		public string OldKey { get; set; }

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x0602403B RID: 147515 RVA: 0x00A3348F File Offset: 0x00A3168F
		// (set) Token: 0x0602403C RID: 147516 RVA: 0x00A33497 File Offset: 0x00A31697
		[RequiredMember]
		public string TargetKey { get; set; }

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x0602403D RID: 147517 RVA: 0x00A334A0 File Offset: 0x00A316A0
		// (set) Token: 0x0602403E RID: 147518 RVA: 0x00A334A8 File Offset: 0x00A316A8
		[RequiredMember]
		public IReadOnlyList<IWuWaGoGridMoveParticipant> Participants { get; set; }

		// Token: 0x0602403F RID: 147519 RVA: 0x00A334B1 File Offset: 0x00A316B1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoGridRelocationRequest()
		{
		}
	}
}
