using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048AC RID: 18604
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RegisterVehicleData : IRegisterVehicleData
	{
		// Token: 0x1700795C RID: 31068
		// (get) Token: 0x06030A0C RID: 199180 RVA: 0x00B4A69D File Offset: 0x00B4889D
		// (set) Token: 0x06030A0D RID: 199181 RVA: 0x00B4A6A5 File Offset: 0x00B488A5
		[RequiredMember]
		public int VehiclePbDataId { get; set; }

		// Token: 0x1700795D RID: 31069
		// (get) Token: 0x06030A0E RID: 199182 RVA: 0x00B4A6AE File Offset: 0x00B488AE
		// (set) Token: 0x06030A0F RID: 199183 RVA: 0x00B4A6B6 File Offset: 0x00B488B6
		[RequiredMember]
		public int StartRoadId { get; set; }

		// Token: 0x1700795E RID: 31070
		// (get) Token: 0x06030A10 RID: 199184 RVA: 0x00B4A6BF File Offset: 0x00B488BF
		// (set) Token: 0x06030A11 RID: 199185 RVA: 0x00B4A6C7 File Offset: 0x00B488C7
		[RequiredMember]
		public int StartRoadIndex { get; set; }

		// Token: 0x1700795F RID: 31071
		// (get) Token: 0x06030A12 RID: 199186 RVA: 0x00B4A6D0 File Offset: 0x00B488D0
		// (set) Token: 0x06030A13 RID: 199187 RVA: 0x00B4A6D8 File Offset: 0x00B488D8
		[RequiredMember]
		public int DestRoadId { get; set; }

		// Token: 0x17007960 RID: 31072
		// (get) Token: 0x06030A14 RID: 199188 RVA: 0x00B4A6E1 File Offset: 0x00B488E1
		// (set) Token: 0x06030A15 RID: 199189 RVA: 0x00B4A6E9 File Offset: 0x00B488E9
		[RequiredMember]
		public int DestIndex { get; set; }

		// Token: 0x17007961 RID: 31073
		// (get) Token: 0x06030A16 RID: 199190 RVA: 0x00B4A6F2 File Offset: 0x00B488F2
		// (set) Token: 0x06030A17 RID: 199191 RVA: 0x00B4A6FA File Offset: 0x00B488FA
		[RequiredMember]
		public Vector ActorLocation { get; set; }

		// Token: 0x17007962 RID: 31074
		// (get) Token: 0x06030A18 RID: 199192 RVA: 0x00B4A703 File Offset: 0x00B48903
		// (set) Token: 0x06030A19 RID: 199193 RVA: 0x00B4A70B File Offset: 0x00B4890B
		[RequiredMember]
		public Rotator ActorRotator { get; set; }

		// Token: 0x17007963 RID: 31075
		// (get) Token: 0x06030A1A RID: 199194 RVA: 0x00B4A714 File Offset: 0x00B48914
		// (set) Token: 0x06030A1B RID: 199195 RVA: 0x00B4A71C File Offset: 0x00B4891C
		[RequiredMember]
		public ITrafficNavigationConfig BaseConfig { get; set; }

		// Token: 0x06030A1C RID: 199196 RVA: 0x00B4A725 File Offset: 0x00B48925
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RegisterVehicleData()
		{
		}
	}
}
