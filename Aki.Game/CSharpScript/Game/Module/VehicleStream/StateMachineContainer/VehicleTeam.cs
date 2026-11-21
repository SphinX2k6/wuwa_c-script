using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream.StateMachineContainer
{
	// Token: 0x02003836 RID: 14390
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleTeam : StateMachineContainer
	{
		// Token: 0x060255F1 RID: 153073 RVA: 0x00A88AA7 File Offset: 0x00A86CA7
		public VehicleTeam(int teamId)
		{
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x060255F2 RID: 153074 RVA: 0x00A88AC1 File Offset: 0x00A86CC1
		public override EStateContainerType Type
		{
			get
			{
				return EStateContainerType.VehicleTeam;
			}
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x060255F3 RID: 153075 RVA: 0x00A88AC4 File Offset: 0x00A86CC4
		public override int Id
		{
			get
			{
				return this.TeamId;
			}
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x060255F4 RID: 153076 RVA: 0x00A88ACC File Offset: 0x00A86CCC
		public int TeamId { get; } = teamId;

		// Token: 0x060255F5 RID: 153077 RVA: 0x00A88AD4 File Offset: 0x00A86CD4
		[NullableContext(2)]
		public VehicleTeamMember GetVehicleMember(long creatureDataId)
		{
			VehicleTeamMember result;
			this.MemberList.TryGetValue(creatureDataId, out result);
			return result;
		}

		// Token: 0x060255F6 RID: 153078 RVA: 0x00A88AF1 File Offset: 0x00A86CF1
		public void AddVehicleMember(long creatureDataId, VehicleTeamMember member)
		{
			this.MemberList[creatureDataId] = member;
			VehicleStreamModel.Instance.OnAddVehicleTeamMember(creatureDataId, member);
		}

		// Token: 0x060255F7 RID: 153079 RVA: 0x00A88B0C File Offset: 0x00A86D0C
		public void RemoveVehicleMember(long creatureDataId)
		{
			this.MemberList.Remove(creatureDataId);
			VehicleStreamModel.Instance.OnRemoveVehicleTeamMember(creatureDataId);
		}

		// Token: 0x04014B06 RID: 84742
		private readonly Dictionary<long, VehicleTeamMember> MemberList = new Dictionary<long, VehicleTeamMember>();
	}
}
