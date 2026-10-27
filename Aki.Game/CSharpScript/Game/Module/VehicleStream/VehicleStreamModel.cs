using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.VehicleStream.StateMachineContainer;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048B1 RID: 18609
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class VehicleStreamModel : ModelBase
	{
		// Token: 0x06030A2F RID: 199215 RVA: 0x00B4A784 File Offset: 0x00B48984
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

		// Token: 0x06030A30 RID: 199216 RVA: 0x00B4A7D0 File Offset: 0x00B489D0
		public Dictionary<int, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam> GetAllVehicleTeam()
		{
			return this.VehicleTeamMap;
		}

		// Token: 0x06030A31 RID: 199217 RVA: 0x00B4A7D8 File Offset: 0x00B489D8
		[NullableContext(2)]
		public CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam GetVehicleTeam(int teamId)
		{
			CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam result;
			this.VehicleTeamMap.TryGetValue(teamId, out result);
			return result;
		}

		// Token: 0x06030A32 RID: 199218 RVA: 0x00B4A7F5 File Offset: 0x00B489F5
		public void AddVehicleTeam(int teamId, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam team)
		{
			this.VehicleTeamMap[teamId] = team;
		}

		// Token: 0x06030A33 RID: 199219 RVA: 0x00B4A804 File Offset: 0x00B48A04
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

		// Token: 0x06030A34 RID: 199220 RVA: 0x00B4A840 File Offset: 0x00B48A40
		[NullableContext(2)]
		public VehicleTeamMember GetVehicleTeamMember(long vehicleCreatureDataId)
		{
			VehicleTeamMember result;
			this.VehicleTeamMemberDict.TryGetValue(vehicleCreatureDataId, out result);
			return result;
		}

		// Token: 0x06030A35 RID: 199221 RVA: 0x00B4A860 File Offset: 0x00B48A60
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

		// Token: 0x06030A36 RID: 199222 RVA: 0x00B4A8BA File Offset: 0x00B48ABA
		public void OnRemoveVehicleTeamMember(long vehicleCreatureDataId)
		{
			this.VehicleTeamMemberDict.Remove(vehicleCreatureDataId);
		}

		// Token: 0x06030A37 RID: 199223 RVA: 0x00B4A8CC File Offset: 0x00B48ACC
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

		// Token: 0x06030A38 RID: 199224 RVA: 0x00B4A930 File Offset: 0x00B48B30
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

		// Token: 0x06030A39 RID: 199225 RVA: 0x00B4A984 File Offset: 0x00B48B84
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

		// Token: 0x06030A3A RID: 199226 RVA: 0x00B4AA04 File Offset: 0x00B48C04
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

		// Token: 0x06030A3B RID: 199227 RVA: 0x00B4AA3C File Offset: 0x00B48C3C
		public void ExitRoadway(int roadwayId, long vehicleCreatureDataId)
		{
			HashSet<long> hashSet;
			if (!this.VehiclesInRoadways.TryGetValue(roadwayId, out hashSet) || hashSet.Count == 0)
			{
				return;
			}
			hashSet.Remove(vehicleCreatureDataId);
		}

		// Token: 0x06030A3C RID: 199228 RVA: 0x00B4AA6C File Offset: 0x00B48C6C
		[NullableContext(2)]
		public HashSet<long> GetAllVehicleInRoadway(int roadwayId)
		{
			HashSet<long> result;
			this.VehiclesInRoadways.TryGetValue(roadwayId, out result);
			return result;
		}

		// Token: 0x06030A3D RID: 199229 RVA: 0x00B4AA8C File Offset: 0x00B48C8C
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

		// Token: 0x06030A3E RID: 199230 RVA: 0x00B4AB13 File Offset: 0x00B48D13
		public void AddWaitTransportInitVehicle(long creatureDataId, IRegisterVehicleData data)
		{
			this.WaitTransportInitVehicles[creatureDataId] = data;
		}

		// Token: 0x06030A3F RID: 199231 RVA: 0x00B4AB22 File Offset: 0x00B48D22
		public Dictionary<long, IRegisterVehicleData> GetWaitTransportInitVehicles()
		{
			return this.WaitTransportInitVehicles;
		}

		// Token: 0x06030A40 RID: 199232 RVA: 0x00B4AB2C File Offset: 0x00B48D2C
		public int GetIntersectionId(int roadwayId)
		{
			int result;
			if (!this.RoadwayId2IntersectionId.TryGetValue(roadwayId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x1700796C RID: 31084
		// (get) Token: 0x06030A41 RID: 199233 RVA: 0x00B4AB4C File Offset: 0x00B48D4C
		public static VehicleStreamModel Instance
		{
			get
			{
				return VehicleStreamModel._Instance;
			}
		}

		// Token: 0x06030A42 RID: 199234 RVA: 0x00B4AB53 File Offset: 0x00B48D53
		public static VehicleStreamModel GetOrCreateInstance()
		{
			if (VehicleStreamModel._Instance == null)
			{
				VehicleStreamModel.CreateInstance();
			}
			return VehicleStreamModel._Instance;
		}

		// Token: 0x06030A43 RID: 199235 RVA: 0x00B4AB67 File Offset: 0x00B48D67
		public static bool CreateInstance()
		{
			if (VehicleStreamModel._Instance != null)
			{
				return true;
			}
			VehicleStreamModel._Instance = new VehicleStreamModel();
			return true;
		}

		// Token: 0x06030A44 RID: 199236 RVA: 0x00B4AB7D File Offset: 0x00B48D7D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030A45 RID: 199237 RVA: 0x00B4AB7F File Offset: 0x00B48D7F
		public static void ResetStaticDefaultValue()
		{
			VehicleStreamModel._Instance = null;
		}

		// Token: 0x06030A46 RID: 199238 RVA: 0x00B4AB87 File Offset: 0x00B48D87
		static VehicleStreamModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VehicleStreamModel.CreateStaticDefaultValue), new Action(VehicleStreamModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401A22E RID: 107054
		public readonly bool EnableDebug;

		// Token: 0x0401A22F RID: 107055
		public readonly bool EnableInteractionSinglePass;

		// Token: 0x0401A230 RID: 107056
		public readonly bool EnableRotationOptimize = true;

		// Token: 0x0401A231 RID: 107057
		public bool TransportSystemInitDone;

		// Token: 0x0401A232 RID: 107058
		public readonly global::Vector SplineLocation = global::Vector.Create();

		// Token: 0x0401A233 RID: 107059
		public readonly Rotator SplineRotation = Rotator.Create();

		// Token: 0x0401A234 RID: 107060
		public readonly global::Vector BasisForwardVector = global::Vector.Create();

		// Token: 0x0401A235 RID: 107061
		public readonly global::Vector BasisUpVector = global::Vector.Create();

		// Token: 0x0401A236 RID: 107062
		public readonly global::Vector BasisRightVector = global::Vector.Create();

		// Token: 0x0401A237 RID: 107063
		public readonly global::Vector CacheVector = global::Vector.Create();

		// Token: 0x0401A238 RID: 107064
		private readonly Dictionary<int, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam> VehicleTeamMap = new Dictionary<int, CSharpScript.Game.Module.VehicleStream.StateMachineContainer.VehicleTeam>();

		// Token: 0x0401A239 RID: 107065
		private readonly Dictionary<long, VehicleTeamMember> VehicleTeamMemberDict = new Dictionary<long, VehicleTeamMember>();

		// Token: 0x0401A23A RID: 107066
		private readonly Dictionary<int, int[]> Intersections = new Dictionary<int, int[]>();

		// Token: 0x0401A23B RID: 107067
		private readonly Dictionary<int, int> RoadwayId2IntersectionId = new Dictionary<int, int>();

		// Token: 0x0401A23C RID: 107068
		private readonly Dictionary<int, int[]> CrossingRoadway = new Dictionary<int, int[]>();

		// Token: 0x0401A23D RID: 107069
		private readonly Dictionary<int, HashSet<long>> VehiclesInRoadways = new Dictionary<int, HashSet<long>>();

		// Token: 0x0401A23E RID: 107070
		private readonly Dictionary<long, IRegisterVehicleData> WaitTransportInitVehicles = new Dictionary<long, IRegisterVehicleData>();

		// Token: 0x0401A23F RID: 107071
		[Nullable(2)]
		private static VehicleStreamModel _Instance;
	}
}
