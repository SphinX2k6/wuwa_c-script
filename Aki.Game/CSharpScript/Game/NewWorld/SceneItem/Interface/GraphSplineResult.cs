using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020062B1 RID: 25265
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GraphSplineResult : IGraphSplineResult
	{
		// Token: 0x17007372 RID: 29554
		// (get) Token: 0x0603CFC7 RID: 249799 RVA: 0x011891B2 File Offset: 0x011873B2
		// (set) Token: 0x0603CFC8 RID: 249800 RVA: 0x011891BA File Offset: 0x011873BA
		[RequiredMember]
		public EGraphSplineMode Mode { get; set; }

		// Token: 0x17007373 RID: 29555
		// (get) Token: 0x0603CFC9 RID: 249801 RVA: 0x011891C3 File Offset: 0x011873C3
		// (set) Token: 0x0603CFCA RID: 249802 RVA: 0x011891CB File Offset: 0x011873CB
		[Nullable(2)]
		public AActor Actor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007374 RID: 29556
		// (get) Token: 0x0603CFCB RID: 249803 RVA: 0x011891D4 File Offset: 0x011873D4
		// (set) Token: 0x0603CFCC RID: 249804 RVA: 0x011891DC File Offset: 0x011873DC
		[RequiredMember]
		public List<USplineComponent> SplineComponents { get; set; }

		// Token: 0x17007375 RID: 29557
		// (get) Token: 0x0603CFCD RID: 249805 RVA: 0x011891E5 File Offset: 0x011873E5
		// (set) Token: 0x0603CFCE RID: 249806 RVA: 0x011891ED File Offset: 0x011873ED
		[RequiredMember]
		public int EffectHandle { get; set; }

		// Token: 0x0603CFCF RID: 249807 RVA: 0x011891F6 File Offset: 0x011873F6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GraphSplineResult()
		{
		}
	}
}
