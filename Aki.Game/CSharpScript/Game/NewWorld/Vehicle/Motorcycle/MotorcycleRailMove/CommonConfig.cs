using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007036 RID: 28726
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonConfig
	{
		// Token: 0x06045F3A RID: 286522 RVA: 0x0116DA88 File Offset: 0x0116BC88
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

		// Token: 0x06045F3B RID: 286523 RVA: 0x0116DB7C File Offset: 0x0116BD7C
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

		// Token: 0x0402497C RID: 149884
		public readonly Dictionary<int, bool> ModifyVehicleTagsOnEnter = new Dictionary<int, bool>();

		// Token: 0x0402497D RID: 149885
		public readonly Dictionary<int, bool> ModifyVehicleTagsOnExit = new Dictionary<int, bool>();

		// Token: 0x0402497E RID: 149886
		public bool EnableBlockingCheck;

		// Token: 0x0402497F RID: 149887
		public float MaxBlockingTimeOut;
	}
}
