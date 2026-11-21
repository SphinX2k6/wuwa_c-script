using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003823 RID: 14371
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RegisterVehicleData : IRegisterVehicleData
	{
		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x06025538 RID: 152888 RVA: 0x00A854A5 File Offset: 0x00A836A5
		// (set) Token: 0x06025539 RID: 152889 RVA: 0x00A854AD File Offset: 0x00A836AD
		[RequiredMember]
		public int VehiclePbDataId { get; set; }

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x0602553A RID: 152890 RVA: 0x00A854B6 File Offset: 0x00A836B6
		// (set) Token: 0x0602553B RID: 152891 RVA: 0x00A854BE File Offset: 0x00A836BE
		[RequiredMember]
		public int StartRoadId { get; set; }

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x0602553C RID: 152892 RVA: 0x00A854C7 File Offset: 0x00A836C7
		// (set) Token: 0x0602553D RID: 152893 RVA: 0x00A854CF File Offset: 0x00A836CF
		[RequiredMember]
		public int StartRoadIndex { get; set; }

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x0602553E RID: 152894 RVA: 0x00A854D8 File Offset: 0x00A836D8
		// (set) Token: 0x0602553F RID: 152895 RVA: 0x00A854E0 File Offset: 0x00A836E0
		[RequiredMember]
		public int DestRoadId { get; set; }

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x06025540 RID: 152896 RVA: 0x00A854E9 File Offset: 0x00A836E9
		// (set) Token: 0x06025541 RID: 152897 RVA: 0x00A854F1 File Offset: 0x00A836F1
		[RequiredMember]
		public int DestIndex { get; set; }

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x06025542 RID: 152898 RVA: 0x00A854FA File Offset: 0x00A836FA
		// (set) Token: 0x06025543 RID: 152899 RVA: 0x00A85502 File Offset: 0x00A83702
		[RequiredMember]
		public Vector ActorLocation { get; set; }

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x06025544 RID: 152900 RVA: 0x00A8550B File Offset: 0x00A8370B
		// (set) Token: 0x06025545 RID: 152901 RVA: 0x00A85513 File Offset: 0x00A83713
		[RequiredMember]
		public Rotator ActorRotator { get; set; }

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x06025546 RID: 152902 RVA: 0x00A8551C File Offset: 0x00A8371C
		// (set) Token: 0x06025547 RID: 152903 RVA: 0x00A85524 File Offset: 0x00A83724
		[RequiredMember]
		public ITrafficNavigationConfig BaseConfig { get; set; }

		// Token: 0x06025548 RID: 152904 RVA: 0x00A8552D File Offset: 0x00A8372D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RegisterVehicleData()
		{
		}
	}
}
