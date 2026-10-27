using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048AE RID: 18606
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class DistanceAndRoadway : IDistanceAndRoadway
	{
		// Token: 0x17007966 RID: 31078
		// (get) Token: 0x06030A21 RID: 199201 RVA: 0x00B4A72D File Offset: 0x00B4892D
		// (set) Token: 0x06030A22 RID: 199202 RVA: 0x00B4A735 File Offset: 0x00B48935
		[RequiredMember]
		public float Distance { get; set; }

		// Token: 0x17007967 RID: 31079
		// (get) Token: 0x06030A23 RID: 199203 RVA: 0x00B4A73E File Offset: 0x00B4893E
		// (set) Token: 0x06030A24 RID: 199204 RVA: 0x00B4A746 File Offset: 0x00B48946
		[RequiredMember]
		public UKuroRoadway Roadway { get; set; }

		// Token: 0x06030A25 RID: 199205 RVA: 0x00B4A74F File Offset: 0x00B4894F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DistanceAndRoadway()
		{
		}
	}
}
