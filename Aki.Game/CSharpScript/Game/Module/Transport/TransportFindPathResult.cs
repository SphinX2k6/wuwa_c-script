using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Transport
{
	// Token: 0x02004AF3 RID: 19187
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TransportFindPathResult : ITransportFindPathResult
	{
		// Token: 0x17007AEF RID: 31471
		// (get) Token: 0x06031B2A RID: 203562 RVA: 0x00B8A14E File Offset: 0x00B8834E
		// (set) Token: 0x06031B2B RID: 203563 RVA: 0x00B8A156 File Offset: 0x00B88356
		[RequiredMember]
		public FVectorDouble RoadStartPoint { get; set; }

		// Token: 0x17007AF0 RID: 31472
		// (get) Token: 0x06031B2C RID: 203564 RVA: 0x00B8A15F File Offset: 0x00B8835F
		// (set) Token: 0x06031B2D RID: 203565 RVA: 0x00B8A167 File Offset: 0x00B88367
		[RequiredMember]
		public FVectorDouble RoadEndPoint { get; set; }

		// Token: 0x17007AF1 RID: 31473
		// (get) Token: 0x06031B2E RID: 203566 RVA: 0x00B8A170 File Offset: 0x00B88370
		// (set) Token: 0x06031B2F RID: 203567 RVA: 0x00B8A178 File Offset: 0x00B88378
		[RequiredMember]
		public TArray<UKuroRoadway> Roadways { get; set; }

		// Token: 0x17007AF2 RID: 31474
		// (get) Token: 0x06031B30 RID: 203568 RVA: 0x00B8A181 File Offset: 0x00B88381
		// (set) Token: 0x06031B31 RID: 203569 RVA: 0x00B8A189 File Offset: 0x00B88389
		[Nullable(2)]
		public UAutopilotRoute AutopilotRoute { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007AF3 RID: 31475
		// (get) Token: 0x06031B32 RID: 203570 RVA: 0x00B8A192 File Offset: 0x00B88392
		// (set) Token: 0x06031B33 RID: 203571 RVA: 0x00B8A19A File Offset: 0x00B8839A
		public double? RouteLength { get; set; }

		// Token: 0x06031B34 RID: 203572 RVA: 0x00B8A1A3 File Offset: 0x00B883A3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TransportFindPathResult()
		{
		}
	}
}
