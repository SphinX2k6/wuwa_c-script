using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007037 RID: 28727
	[NullableContext(1)]
	[Nullable(0)]
	public class BasicRailMoveConfig
	{
		// Token: 0x06045F3D RID: 286525 RVA: 0x0116DC94 File Offset: 0x0116BE94
		public void UpdateFromUeData(SMotorRailMoveConfig_Basic data)
		{
			this.MaxDeltaTimeForMoveUpdate = data.MaxDeltaTimeForMoveUpdate;
			this.DefaultMoveSpeed = data.DefaultMoveSpeed;
			this.AllowUseSkillIds.Clear();
			foreach (int item in data.AllowUseSkillIds)
			{
				this.AllowUseSkillIds.Add(item);
			}
			this.AutoEnterRailCdAfterLeaveRailMove = data.AutoEnterRailCdAfterLeaveRailMove;
			this.AutoEnterRailCdAfterLeaveRail = data.AutoEnterRailCdAfterLeaveRail;
			this.ClientEventHandlers.Clear();
			foreach (KeyValuePair<FGameplayTag, SMotorRailMove_EventHandler> keyValuePair in data.ClientEventHandlers)
			{
				FGameplayTag fgameplayTag;
				SMotorRailMove_EventHandler smotorRailMove_EventHandler;
				keyValuePair.Deconstruct(out fgameplayTag, out smotorRailMove_EventHandler);
				FGameplayTag tag = fgameplayTag;
				SMotorRailMove_EventHandler smotorRailMove_EventHandler2 = smotorRailMove_EventHandler;
				if (!(smotorRailMove_EventHandler2 == null))
				{
					RailMoveEventHandler railMoveEventHandler = new RailMoveEventHandler();
					railMoveEventHandler.UpdateFromUeData(smotorRailMove_EventHandler2);
					this.ClientEventHandlers[tag.TagId()] = railMoveEventHandler;
				}
			}
			this.ModifyVehicleTagsOnEnterRail.Clear();
			foreach (KeyValuePair<FGameplayTag, bool> keyValuePair2 in data.ModifyVehicleTagsOnEnterRail)
			{
				FGameplayTag fgameplayTag;
				bool flag;
				keyValuePair2.Deconstruct(out fgameplayTag, out flag);
				FGameplayTag tag2 = fgameplayTag;
				bool value = flag;
				this.ModifyVehicleTagsOnEnterRail[tag2.TagId()] = value;
			}
			this.ModifyVehicleTagsOnLeaveRail.Clear();
			foreach (KeyValuePair<FGameplayTag, bool> keyValuePair2 in data.ModifyVehicleTagsOnLeaveRail)
			{
				FGameplayTag fgameplayTag;
				bool flag;
				keyValuePair2.Deconstruct(out fgameplayTag, out flag);
				FGameplayTag tag3 = fgameplayTag;
				bool value2 = flag;
				this.ModifyVehicleTagsOnLeaveRail[tag3.TagId()] = value2;
			}
			this.ModifyVehicleBuffsOnEnterRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in data.ModifyVehicleBuffsOnEnterRail)
			{
				bool flag;
				long num;
				keyValuePair3.Deconstruct(out num, out flag);
				long key = num;
				bool value3 = flag;
				this.ModifyVehicleBuffsOnEnterRail[key] = value3;
			}
			this.ModifyVehicleBuffsOnLeaveRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in data.ModifyVehicleBuffsOnLeaveRail)
			{
				bool flag;
				long num;
				keyValuePair3.Deconstruct(out num, out flag);
				long key2 = num;
				bool value4 = flag;
				this.ModifyVehicleBuffsOnLeaveRail[key2] = value4;
			}
			this.ModifyDriverPlayerTagsOnEnterRail.Clear();
			foreach (KeyValuePair<FGameplayTag, bool> keyValuePair2 in data.ModifyDriverPlayerTagsOnEnterRail)
			{
				FGameplayTag fgameplayTag;
				bool flag;
				keyValuePair2.Deconstruct(out fgameplayTag, out flag);
				FGameplayTag tag4 = fgameplayTag;
				bool value5 = flag;
				this.ModifyDriverPlayerTagsOnEnterRail[tag4.TagId()] = value5;
			}
			this.ModifyDriverPlayerTagsOnLeaveRail.Clear();
			foreach (KeyValuePair<FGameplayTag, bool> keyValuePair2 in data.ModifyDriverPlayerTagsOnLeaveRail)
			{
				FGameplayTag fgameplayTag;
				bool flag;
				keyValuePair2.Deconstruct(out fgameplayTag, out flag);
				FGameplayTag tag5 = fgameplayTag;
				bool value6 = flag;
				this.ModifyDriverPlayerTagsOnLeaveRail[tag5.TagId()] = value6;
			}
			this.ModifyDriverBuffsOnEnterRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in data.ModifyDriverBuffsOnEnterRail)
			{
				bool flag;
				long num;
				keyValuePair3.Deconstruct(out num, out flag);
				long key3 = num;
				bool value7 = flag;
				this.ModifyDriverBuffsOnEnterRail[key3] = value7;
			}
			this.ModifyDriverBuffsOnLeaveRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in data.ModifyDriverBuffsOnLeaveRail)
			{
				bool flag;
				long num;
				keyValuePair3.Deconstruct(out num, out flag);
				long key4 = num;
				bool value8 = flag;
				this.ModifyDriverBuffsOnLeaveRail[key4] = value8;
			}
		}

		// Token: 0x06045F3E RID: 286526 RVA: 0x0116E0F8 File Offset: 0x0116C2F8
		public void DeepCopy(BasicRailMoveConfig other)
		{
			this.MaxDeltaTimeForMoveUpdate = other.MaxDeltaTimeForMoveUpdate;
			this.DefaultMoveSpeed = other.DefaultMoveSpeed;
			this.AllowUseSkillIds.Clear();
			foreach (int item in other.AllowUseSkillIds)
			{
				this.AllowUseSkillIds.Add(item);
			}
			this.AutoEnterRailCdAfterLeaveRailMove = other.AutoEnterRailCdAfterLeaveRailMove;
			this.AutoEnterRailCdAfterLeaveRail = other.AutoEnterRailCdAfterLeaveRail;
			this.ClientEventHandlers.Clear();
			foreach (KeyValuePair<int, RailMoveEventHandler> keyValuePair in other.ClientEventHandlers)
			{
				int num;
				RailMoveEventHandler railMoveEventHandler;
				keyValuePair.Deconstruct(out num, out railMoveEventHandler);
				int key = num;
				RailMoveEventHandler other2 = railMoveEventHandler;
				RailMoveEventHandler railMoveEventHandler2 = new RailMoveEventHandler();
				railMoveEventHandler2.DeepCopy(other2);
				this.ClientEventHandlers[key] = railMoveEventHandler2;
			}
			this.ModifyVehicleTagsOnEnterRail.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair2 in other.ModifyVehicleTagsOnEnterRail)
			{
				int num;
				bool flag;
				keyValuePair2.Deconstruct(out num, out flag);
				int key2 = num;
				bool value = flag;
				this.ModifyVehicleTagsOnEnterRail[key2] = value;
			}
			this.ModifyVehicleTagsOnLeaveRail.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair2 in other.ModifyVehicleTagsOnLeaveRail)
			{
				int num;
				bool flag;
				keyValuePair2.Deconstruct(out num, out flag);
				int key3 = num;
				bool value2 = flag;
				this.ModifyVehicleTagsOnLeaveRail[key3] = value2;
			}
			this.ModifyVehicleBuffsOnEnterRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in other.ModifyVehicleBuffsOnEnterRail)
			{
				bool flag;
				long num2;
				keyValuePair3.Deconstruct(out num2, out flag);
				long key4 = num2;
				bool value3 = flag;
				this.ModifyVehicleBuffsOnEnterRail[key4] = value3;
			}
			this.ModifyVehicleBuffsOnLeaveRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in other.ModifyVehicleBuffsOnLeaveRail)
			{
				bool flag;
				long num2;
				keyValuePair3.Deconstruct(out num2, out flag);
				long key5 = num2;
				bool value4 = flag;
				this.ModifyVehicleBuffsOnLeaveRail[key5] = value4;
			}
			this.ModifyDriverPlayerTagsOnEnterRail.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair2 in other.ModifyDriverPlayerTagsOnEnterRail)
			{
				int num;
				bool flag;
				keyValuePair2.Deconstruct(out num, out flag);
				int key6 = num;
				bool value5 = flag;
				this.ModifyDriverPlayerTagsOnEnterRail[key6] = value5;
			}
			this.ModifyDriverPlayerTagsOnLeaveRail.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair2 in other.ModifyDriverPlayerTagsOnLeaveRail)
			{
				int num;
				bool flag;
				keyValuePair2.Deconstruct(out num, out flag);
				int key7 = num;
				bool value6 = flag;
				this.ModifyDriverPlayerTagsOnLeaveRail[key7] = value6;
			}
			this.ModifyDriverBuffsOnEnterRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in other.ModifyDriverBuffsOnEnterRail)
			{
				bool flag;
				long num2;
				keyValuePair3.Deconstruct(out num2, out flag);
				long key8 = num2;
				bool value7 = flag;
				this.ModifyDriverBuffsOnEnterRail[key8] = value7;
			}
			this.ModifyDriverBuffsOnLeaveRail.Clear();
			foreach (KeyValuePair<long, bool> keyValuePair3 in other.ModifyDriverBuffsOnLeaveRail)
			{
				bool flag;
				long num2;
				keyValuePair3.Deconstruct(out num2, out flag);
				long key9 = num2;
				bool value8 = flag;
				this.ModifyDriverBuffsOnLeaveRail[key9] = value8;
			}
		}

		// Token: 0x04024980 RID: 149888
		public float MaxDeltaTimeForMoveUpdate = 0.05f;

		// Token: 0x04024981 RID: 149889
		public float DefaultMoveSpeed = 1500f;

		// Token: 0x04024982 RID: 149890
		public HashSet<int> AllowUseSkillIds = new HashSet<int>();

		// Token: 0x04024983 RID: 149891
		public float AutoEnterRailCdAfterLeaveRailMove = 0.5f;

		// Token: 0x04024984 RID: 149892
		public float AutoEnterRailCdAfterLeaveRail;

		// Token: 0x04024985 RID: 149893
		public readonly Dictionary<int, RailMoveEventHandler> ClientEventHandlers = new Dictionary<int, RailMoveEventHandler>();

		// Token: 0x04024986 RID: 149894
		public readonly Dictionary<int, bool> ModifyVehicleTagsOnEnterRail = new Dictionary<int, bool>();

		// Token: 0x04024987 RID: 149895
		public readonly Dictionary<int, bool> ModifyVehicleTagsOnLeaveRail = new Dictionary<int, bool>();

		// Token: 0x04024988 RID: 149896
		public readonly Dictionary<long, bool> ModifyVehicleBuffsOnEnterRail = new Dictionary<long, bool>();

		// Token: 0x04024989 RID: 149897
		public readonly Dictionary<long, bool> ModifyVehicleBuffsOnLeaveRail = new Dictionary<long, bool>();

		// Token: 0x0402498A RID: 149898
		public readonly Dictionary<int, bool> ModifyDriverPlayerTagsOnEnterRail = new Dictionary<int, bool>();

		// Token: 0x0402498B RID: 149899
		public readonly Dictionary<int, bool> ModifyDriverPlayerTagsOnLeaveRail = new Dictionary<int, bool>();

		// Token: 0x0402498C RID: 149900
		public readonly Dictionary<long, bool> ModifyDriverBuffsOnEnterRail = new Dictionary<long, bool>();

		// Token: 0x0402498D RID: 149901
		public readonly Dictionary<long, bool> ModifyDriverBuffsOnLeaveRail = new Dictionary<long, bool>();
	}
}
