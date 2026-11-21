using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.VehicleStream.StateMachineContainer;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003828 RID: 14376
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class VehicleStreamModel : ModelBase
	{
		// Token: 0x0602555B RID: 152923 RVA: 0x00A8558C File Offset: 0x00A8378C
		protected override bool OnLeaveLevel()
		{
			this.TransportSystemInitDone = false;
			this.Intersections.Clear();
			this.RoadwayId2IntersectionId.Clear();
			this.CrossingRoadway.Clear();
			this.VehiclesInRoadways.Clear();
			this.WaitTransportInitVehicles.Clear();
			return true;
		}

		// Token: 0x0602555C RID: 152924 RVA: 0x00A855D8 File Offset: 0x00A837D8
		public Dictionary<int, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam> GetAllVehicleTeam()
		{
			return this.VehicleTeamMap;
		}

		// Token: 0x0602555D RID: 152925 RVA: 0x00A855E0 File Offset: 0x00A837E0
		[NullableContext(2)]
		public CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam GetVehicleTeam(int teamId)
		{
			CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam result;
			this.VehicleTeamMap.TryGetValue(teamId, out result);
			return result;
		}

		// Token: 0x0602555E RID: 152926 RVA: 0x00A855FD File Offset: 0x00A837FD
		public void AddVehicleTeam(int teamId, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam team)
		{
			this.VehicleTeamMap[teamId] = team;
		}

		// Token: 0x0602555F RID: 152927 RVA: 0x00A8560C File Offset: 0x00A8380C
		public bool RemoveTeamMember(long vehicleCreatureDataId)
		{
			VehicleTeamMember vehicleTeamMember = this.GetVehicleTeamMember(vehicleCreatureDataId);
			if (vehicleTeamMember == null)
			{
				return false;
			}
			CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam vehicleTeam = this.GetVehicleTeam(vehicleTeamMember.TeamId);
			if (vehicleTeam != null)
			{
				vehicleTeam.RemoveVehicleMember(vehicleCreatureDataId);
			}
			vehicleTeamMember.Destroy();
			return true;
		}

		// Token: 0x06025560 RID: 152928 RVA: 0x00A85648 File Offset: 0x00A83848
		[NullableContext(2)]
		public VehicleTeamMember GetVehicleTeamMember(long vehicleCreatureDataId)
		{
			VehicleTeamMember result;
			this.VehicleTeamMemberDict.TryGetValue(vehicleCreatureDataId, out result);
			return result;
		}

		// Token: 0x06025561 RID: 152929 RVA: 0x00A85668 File Offset: 0x00A83868
		public void OnAddVehicleTeamMember(long vehicleCreatureDataId, VehicleTeamMember member)
		{
			VehicleTeamMember vehicleTeamMember;
			if (this.VehicleTeamMemberDict.TryGetValue(vehicleCreatureDataId, out vehicleTeamMember))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VehicleStream;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[VehicleStream]VehicleStreamModel.OnAddVehicleTeamMember:同一个载具重复添加";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("vehicleCreatureDataId", vehicleCreatureDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.VehicleTeamMemberDict[vehicleCreatureDataId] = member;
		}

		// Token: 0x06025562 RID: 152930 RVA: 0x00A856C2 File Offset: 0x00A838C2
		public void OnRemoveVehicleTeamMember(long vehicleCreatureDataId)
		{
			this.VehicleTeamMemberDict.Remove(vehicleCreatureDataId);
		}

		// Token: 0x06025563 RID: 152931 RVA: 0x00A856D4 File Offset: 0x00A838D4
		public bool AddIntersection(int intersectionId, TArray<int> inRoadways)
		{
			if (this.Intersections.ContainsKey(intersectionId))
			{
				return false;
			}
			int[] array = new int[inRoadways.Num()];
			for (int i = 0; i < inRoadways.Num(); i++)
			{
				int num = inRoadways[i];
				this.RoadwayId2IntersectionId[num] = intersectionId;
				array[i] = num;
			}
			this.Intersections[intersectionId] = array;
			return true;
		}

		// Token: 0x06025564 RID: 152932 RVA: 0x00A85738 File Offset: 0x00A83938
		public bool RecordCrossingRoadways(int roadwayId, TArray<int> inCrossingRoadways)
		{
			if (this.CrossingRoadway.ContainsKey(roadwayId))
			{
				return false;
			}
			int[] array = new int[inCrossingRoadways.Num()];
			for (int i = 0; i < inCrossingRoadways.Num(); i++)
			{
				int num = inCrossingRoadways[i];
				array[i] = num;
			}
			this.CrossingRoadway[roadwayId] = array;
			return true;
		}

		// Token: 0x06025565 RID: 152933 RVA: 0x00A8578C File Offset: 0x00A8398C
		[NullableContext(2)]
		public global::Vector GetRelativePosition(int teamConfigId, int teamMemberIndex)
		{
			if (teamConfigId <= 0)
			{
				return null;
			}
			Aki.Config.VehicleTeam? config = ConfigVehicleTeamById.GetConfig(teamConfigId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VehicleStream;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[VehicleStream]VehicleStreamModel.GetRelativePosition:找不到车队配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", teamConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return global::Vector.Create((config != null) ? config.GetValueOrDefault().PositionList(teamMemberIndex) : null);
		}

		// Token: 0x06025566 RID: 152934 RVA: 0x00A8580C File Offset: 0x00A83A0C
		public void EnterRoadway(int roadwayId, long vehicleCreatureDataId)
		{
			HashSet<long> hashSet;
			if (!this.VehiclesInRoadways.TryGetValue(roadwayId, out hashSet))
			{
				hashSet = new HashSet<long>();
				this.VehiclesInRoadways[roadwayId] = hashSet;
			}
			hashSet.Add(vehicleCreatureDataId);
		}

		// Token: 0x06025567 RID: 152935 RVA: 0x00A85844 File Offset: 0x00A83A44
		public void ExitRoadway(int roadwayId, long vehicleCreatureDataId)
		{
			HashSet<long> hashSet;
			if (!this.VehiclesInRoadways.TryGetValue(roadwayId, out hashSet) || hashSet.Count == 0)
			{
				return;
			}
			hashSet.Remove(vehicleCreatureDataId);
		}

		// Token: 0x06025568 RID: 152936 RVA: 0x00A85874 File Offset: 0x00A83A74
		[NullableContext(2)]
		public HashSet<long> GetAllVehicleInRoadway(int roadwayId)
		{
			HashSet<long> result;
			this.VehiclesInRoadways.TryGetValue(roadwayId, out result);
			return result;
		}

		// Token: 0x06025569 RID: 152937 RVA: 0x00A85894 File Offset: 0x00A83A94
		public bool CheckIntersectionRoadwayOccupied(int inRoadwayId)
		{
			HashSet<long> hashSet;
			if (this.EnableInteractionSinglePass && this.VehiclesInRoadways.TryGetValue(inRoadwayId, out hashSet) && hashSet.Count > 0)
			{
				return true;
			}
			int intersectionId = this.GetIntersectionId(inRoadwayId);
			int[] array;
			if (!this.Intersections.TryGetValue(intersectionId, out array))
			{
				return false;
			}
			foreach (int num in array)
			{
				HashSet<long> hashSet2;
				if (num != inRoadwayId && this.VehiclesInRoadways.TryGetValue(num, out hashSet2) && hashSet2.Count > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602556A RID: 152938 RVA: 0x00A8591B File Offset: 0x00A83B1B
		public void AddWaitTransportInitVehicle(long creatureDataId, IRegisterVehicleData data)
		{
			this.WaitTransportInitVehicles[creatureDataId] = data;
		}

		// Token: 0x0602556B RID: 152939 RVA: 0x00A8592A File Offset: 0x00A83B2A
		public Dictionary<long, IRegisterVehicleData> GetWaitTransportInitVehicles()
		{
			return this.WaitTransportInitVehicles;
		}

		// Token: 0x0602556C RID: 152940 RVA: 0x00A85934 File Offset: 0x00A83B34
		public int GetIntersectionId(int roadwayId)
		{
			int result;
			if (!this.RoadwayId2IntersectionId.TryGetValue(roadwayId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x0602556D RID: 152941 RVA: 0x00A85954 File Offset: 0x00A83B54
		public static VehicleStreamModel Instance
		{
			get
			{
				return VehicleStreamModel._Instance;
			}
		}

		// Token: 0x0602556E RID: 152942 RVA: 0x00A8595B File Offset: 0x00A83B5B
		public static VehicleStreamModel GetOrCreateInstance()
		{
			if (VehicleStreamModel._Instance == null)
			{
				VehicleStreamModel.CreateInstance();
			}
			return VehicleStreamModel._Instance;
		}

		// Token: 0x0602556F RID: 152943 RVA: 0x00A8596F File Offset: 0x00A83B6F
		public static bool CreateInstance()
		{
			if (VehicleStreamModel._Instance != null)
			{
				return true;
			}
			VehicleStreamModel._Instance = new VehicleStreamModel();
			return true;
		}

		// Token: 0x06025570 RID: 152944 RVA: 0x00A85985 File Offset: 0x00A83B85
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025571 RID: 152945 RVA: 0x00A85987 File Offset: 0x00A83B87
		public static void ResetStaticDefaultValue()
		{
			VehicleStreamModel._Instance = null;
		}

		// Token: 0x06025572 RID: 152946 RVA: 0x00A8598F File Offset: 0x00A83B8F
		static VehicleStreamModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VehicleStreamModel.CreateStaticDefaultValue), new Action(VehicleStreamModel.ResetStaticDefaultValue));
		}

		// Token: 0x04014AA1 RID: 84641
		public readonly bool EnableDebug;

		// Token: 0x04014AA2 RID: 84642
		public readonly bool EnableInteractionSinglePass;

		// Token: 0x04014AA3 RID: 84643
		public readonly bool EnableRotationOptimize = true;

		// Token: 0x04014AA4 RID: 84644
		public bool TransportSystemInitDone;

		// Token: 0x04014AA5 RID: 84645
		public readonly global::Vector SplineLocation = global::Vector.Create();

		// Token: 0x04014AA6 RID: 84646
		public readonly Rotator SplineRotation = Rotator.Create();

		// Token: 0x04014AA7 RID: 84647
		public readonly global::Vector BasisForwardVector = global::Vector.Create();

		// Token: 0x04014AA8 RID: 84648
		public readonly global::Vector BasisUpVector = global::Vector.Create();

		// Token: 0x04014AA9 RID: 84649
		public readonly global::Vector BasisRightVector = global::Vector.Create();

		// Token: 0x04014AAA RID: 84650
		public readonly global::Vector CacheVector = global::Vector.Create();

		// Token: 0x04014AAB RID: 84651
		private readonly Dictionary<int, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam> VehicleTeamMap = new Dictionary<int, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam>();

		// Token: 0x04014AAC RID: 84652
		private readonly Dictionary<long, VehicleTeamMember> VehicleTeamMemberDict = new Dictionary<long, VehicleTeamMember>();

		// Token: 0x04014AAD RID: 84653
		private readonly Dictionary<int, int[]> Intersections = new Dictionary<int, int[]>();

		// Token: 0x04014AAE RID: 84654
		private readonly Dictionary<int, int> RoadwayId2IntersectionId = new Dictionary<int, int>();

		// Token: 0x04014AAF RID: 84655
		private readonly Dictionary<int, int[]> CrossingRoadway = new Dictionary<int, int[]>();

		// Token: 0x04014AB0 RID: 84656
		private readonly Dictionary<int, HashSet<long>> VehiclesInRoadways = new Dictionary<int, HashSet<long>>();

		// Token: 0x04014AB1 RID: 84657
		private readonly Dictionary<long, IRegisterVehicleData> WaitTransportInitVehicles = new Dictionary<long, IRegisterVehicleData>();

		// Token: 0x04014AB2 RID: 84658
		[Nullable(2)]
		private static VehicleStreamModel _Instance;
	}
}
