using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003825 RID: 14373
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class DistanceAndRoadway : IDistanceAndRoadway
	{
		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x0602554D RID: 152909 RVA: 0x00A85535 File Offset: 0x00A83735
		// (set) Token: 0x0602554E RID: 152910 RVA: 0x00A8553D File Offset: 0x00A8373D
		[RequiredMember]
		public float Distance { get; set; }

		// Token: 0x17004CCF RID: 19663
		// (get) Token: 0x0602554F RID: 152911 RVA: 0x00A85546 File Offset: 0x00A83746
		// (set) Token: 0x06025550 RID: 152912 RVA: 0x00A8554E File Offset: 0x00A8374E
		[RequiredMember]
		public UKuroRoadway Roadway { get; set; }

		// Token: 0x06025551 RID: 152913 RVA: 0x00A85557 File Offset: 0x00A83757
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DistanceAndRoadway()
		{
		}
	}
}
