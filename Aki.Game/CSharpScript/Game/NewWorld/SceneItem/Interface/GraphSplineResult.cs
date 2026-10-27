using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020071FC RID: 29180
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GraphSplineResult : IGraphSplineResult
	{
		// Token: 0x17009E15 RID: 40469
		// (get) Token: 0x060476BF RID: 292543 RVA: 0x0122F5F0 File Offset: 0x0122D7F0
		// (set) Token: 0x060476C0 RID: 292544 RVA: 0x0122F5F8 File Offset: 0x0122D7F8
		[RequiredMember]
		public EGraphSplineMode Mode { get; set; }

		// Token: 0x17009E16 RID: 40470
		// (get) Token: 0x060476C1 RID: 292545 RVA: 0x0122F601 File Offset: 0x0122D801
		// (set) Token: 0x060476C2 RID: 292546 RVA: 0x0122F609 File Offset: 0x0122D809
		[Nullable(2)]
		public AActor Actor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009E17 RID: 40471
		// (get) Token: 0x060476C3 RID: 292547 RVA: 0x0122F612 File Offset: 0x0122D812
		// (set) Token: 0x060476C4 RID: 292548 RVA: 0x0122F61A File Offset: 0x0122D81A
		[RequiredMember]
		public List<USplineComponent> SplineComponents { get; set; }

		// Token: 0x17009E18 RID: 40472
		// (get) Token: 0x060476C5 RID: 292549 RVA: 0x0122F623 File Offset: 0x0122D823
		// (set) Token: 0x060476C6 RID: 292550 RVA: 0x0122F62B File Offset: 0x0122D82B
		[RequiredMember]
		public int EffectHandle { get; set; }

		// Token: 0x060476C7 RID: 292551 RVA: 0x0122F634 File Offset: 0x0122D834
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GraphSplineResult()
		{
		}
	}
}
