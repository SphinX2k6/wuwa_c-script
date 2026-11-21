using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061B7 RID: 25015
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonConfig
	{
		// Token: 0x0603C120 RID: 246048 RVA: 0x011177D0 File Offset: 0x011159D0
		public void UpdateFromUeData(SMotorRailMove_CommonConfig data)
		{
			this.ModifyVehicleTagsOnEnter.Clear();
			foreach (KeyValuePair<FGameplayTag, bool> keyValuePair in data.ModifyVehicleTagsOnEnter)
			{
				FGameplayTag fgameplayTag;
				bool flag;
				keyValuePair.Deconstruct(out fgameplayTag, out flag);
				FGameplayTag tag = fgameplayTag;
				bool value = flag;
				this.ModifyVehicleTagsOnEnter[tag.TagId()] = value;
			}
			this.ModifyVehicleTagsOnExit.Clear();
			foreach (KeyValuePair<FGameplayTag, bool> keyValuePair in data.ModifyVehicleTagsOnExit)
			{
				FGameplayTag fgameplayTag;
				bool flag;
				keyValuePair.Deconstruct(out fgameplayTag, out flag);
				FGameplayTag tag2 = fgameplayTag;
				bool value2 = flag;
				this.ModifyVehicleTagsOnExit[tag2.TagId()] = value2;
			}
			this.EnableBlockingCheck = data.EnableBlockingCheck;
			this.MaxBlockingTimeOut = data.MaxBlockingTimeOut;
		}

		// Token: 0x0603C121 RID: 246049 RVA: 0x011178D0 File Offset: 0x01115AD0
		public void DeepCopy(CommonConfig other)
		{
			this.ModifyVehicleTagsOnEnter.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair in other.ModifyVehicleTagsOnEnter)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int key = num;
				bool value = flag;
				this.ModifyVehicleTagsOnEnter[key] = value;
			}
			this.ModifyVehicleTagsOnExit.Clear();
			foreach (KeyValuePair<int, bool> keyValuePair in other.ModifyVehicleTagsOnExit)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int key2 = num;
				bool value2 = flag;
				this.ModifyVehicleTagsOnExit[key2] = value2;
			}
			this.EnableBlockingCheck = other.EnableBlockingCheck;
			this.MaxBlockingTimeOut = other.MaxBlockingTimeOut;
		}

		// Token: 0x0401FC32 RID: 130098
		public readonly Dictionary<int, bool> ModifyVehicleTagsOnEnter = new Dictionary<int, bool>();

		// Token: 0x0401FC33 RID: 130099
		public readonly Dictionary<int, bool> ModifyVehicleTagsOnExit = new Dictionary<int, bool>();

		// Token: 0x0401FC34 RID: 130100
		public bool EnableBlockingCheck;

		// Token: 0x0401FC35 RID: 130101
		public float MaxBlockingTimeOut;
	}
}
