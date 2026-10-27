using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream.StateMachineContainer
{
	// Token: 0x020048BF RID: 18623
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleTeam : StateMachineContainer
	{
		// Token: 0x06030AC5 RID: 199365 RVA: 0x00B4DC9F File Offset: 0x00B4BE9F
		public VehicleTeam(int teamId)
		{
		}

		// Token: 0x17007979 RID: 31097
		// (get) Token: 0x06030AC6 RID: 199366 RVA: 0x00B4DCB9 File Offset: 0x00B4BEB9
		public override EStateContainerType Type
		{
			get
			{
				return EStateContainerType.VehicleTeam;
			}
		}

		// Token: 0x1700797A RID: 31098
		// (get) Token: 0x06030AC7 RID: 199367 RVA: 0x00B4DCBC File Offset: 0x00B4BEBC
		public override int Id
		{
			get
			{
				return this.TeamId;
			}
		}

		// Token: 0x1700797B RID: 31099
		// (get) Token: 0x06030AC8 RID: 199368 RVA: 0x00B4DCC4 File Offset: 0x00B4BEC4
		public int TeamId { get; } = teamId;

		// Token: 0x06030AC9 RID: 199369 RVA: 0x00B4DCCC File Offset: 0x00B4BECC
		[NullableContext(2)]
		public VehicleTeamMember GetVehicleMember(long creatureDataId)
		{
			VehicleTeamMember result;
			this.MemberList.TryGetValue(creatureDataId, out result);
			return result;
		}

		// Token: 0x06030ACA RID: 199370 RVA: 0x00B4DCE9 File Offset: 0x00B4BEE9
		public void AddVehicleMember(long creatureDataId, VehicleTeamMember member)
		{
			this.MemberList[creatureDataId] = member;
			VehicleStreamModel.Instance.OnAddVehicleTeamMember(creatureDataId, member);
		}

		// Token: 0x06030ACB RID: 199371 RVA: 0x00B4DD04 File Offset: 0x00B4BF04
		public void RemoveVehicleMember(long creatureDataId)
		{
			this.MemberList.Remove(creatureDataId);
			VehicleStreamModel.Instance.OnRemoveVehicleTeamMember(creatureDataId);
		}

		// Token: 0x0401A293 RID: 107155
		private readonly Dictionary<long, VehicleTeamMember> MemberList = new Dictionary<long, VehicleTeamMember>();
	}
}
