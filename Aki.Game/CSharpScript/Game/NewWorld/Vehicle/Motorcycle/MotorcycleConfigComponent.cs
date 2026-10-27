using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Data;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x0200702F RID: 28719
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleConfigComponent : EntityComponent
	{
		// Token: 0x17009BD6 RID: 39894
		// (get) Token: 0x06045EA5 RID: 286373 RVA: 0x01166610 File Offset: 0x01164810
		private bool HasConfigData
		{
			get
			{
				TsBaseVehicle motorActor = this.MotorActor;
				return motorActor is BP_Motor_BaseVehicle_C || motorActor is BP_Motor_BaseVehicle_MINI_BugFinder_C || motorActor is BP_Motor_BaseVehicle_Photo_C;
			}
		}

		// Token: 0x06045EA6 RID: 286374 RVA: 0x01166644 File Offset: 0x01164844
		private void GetConfigDataByKeyName(FName name, ref SMotorConfigs config)
		{
			TsBaseVehicle motorActor = this.MotorActor;
			BP_Motor_BaseVehicle_C bp_Motor_BaseVehicle_C = motorActor as BP_Motor_BaseVehicle_C;
			if (bp_Motor_BaseVehicle_C != null)
			{
				bp_Motor_BaseVehicle_C.GetConfigDataByKeyName(name, ref config);
				return;
			}
			BP_Motor_BaseVehicle_MINI_BugFinder_C bp_Motor_BaseVehicle_MINI_BugFinder_C = motorActor as BP_Motor_BaseVehicle_MINI_BugFinder_C;
			if (bp_Motor_BaseVehicle_MINI_BugFinder_C != null)
			{
				bp_Motor_BaseVehicle_MINI_BugFinder_C.GetConfigDataByKeyName(name, ref config);
				return;
			}
			BP_Motor_BaseVehicle_Photo_C bp_Motor_BaseVehicle_Photo_C = motorActor as BP_Motor_BaseVehicle_Photo_C;
			if (bp_Motor_BaseVehicle_Photo_C == null)
			{
				return;
			}
			bp_Motor_BaseVehicle_Photo_C.GetConfigDataByKeyName(name, ref config);
		}

		// Token: 0x06045EA7 RID: 286375 RVA: 0x01166694 File Offset: 0x01164894
		protected unsafe override bool OnStart()
		{
			this.TagComp = base.Entity.GetComponent<VehicleTagComponent>();
			if (this.TagComp == null)
			{
				return false;
			}
			VehicleActorComponent component = base.Entity.GetComponent<VehicleActorComponent>();
			this.MotorActor = ((component != null) ? component.Actor : null);
			if (!this.HasConfigData)
			{
				return false;
			}
			this.ConfigHelper = this.MotorActor.VehicleMovementComponent.MotorConfigHelper;
			if (this.ConfigHelper == null)
			{
				this.ConfigHelper = new UKuroConfigHelper(this.MotorActor.VehicleMovementComponent, "MotorConfigHelper", EObjectFlags.RF_NoFlags);
				this.MotorActor.VehicleMovementComponent.MotorConfigHelper = this.ConfigHelper;
			}
			TArray<FName> tarray = new TArray<FName>();
			UKuroVehicleMovementComponent vehicleMovementComponent = this.MotorActor.VehicleMovementComponent;
			UDataTableFunctionLibrary.GetDataTableRowNames((vehicleMovementComponent != null) ? vehicleMovementComponent.MotorConfigDataTable : null, ref tarray);
			int num = tarray.Num();
			this.TagIdToConfigParams.Clear();
			for (int i = 0; i < num; i++)
			{
				FName fname = tarray.Get(i);
				SMotorConfigs smotorConfigs = new SMotorConfigs();
				this.GetConfigDataByKeyName(fname, ref smotorConfigs);
				if (fname == MotorcycleConfigComponent.baseName)
				{
					this.ConfigHelper.InitBase(this.MotorActor.VehicleMovementComponent, smotorConfigs.Configs);
				}
				else
				{
					MotorcycleConfigComponent.MotorConfigParams motorConfigParams = new MotorcycleConfigComponent.MotorConfigParams(fname, smotorConfigs, this.TagComp, this.ConfigHelper);
					TArray<FGameplayTag> gameplayTags = smotorConfigs.ActivateTags.GameplayTags;
					int num2 = gameplayTags.Num();
					for (int j = 0; j < num2; j++)
					{
						FGameplayTag fgameplayTag = gameplayTags.Get(j);
						if (!(fgameplayTag.TagName == "None"))
						{
							List<MotorcycleConfigComponent.MotorConfigParams> valueOrDefault = this.TagIdToConfigParams.GetValueOrDefault(fgameplayTag.TagId());
							if (valueOrDefault != null)
							{
								valueOrDefault.Add(motorConfigParams);
							}
							else
							{
								Dictionary<int, List<MotorcycleConfigComponent.MotorConfigParams>> tagIdToConfigParams = this.TagIdToConfigParams;
								int key = fgameplayTag.TagId();
								int num3 = 1;
								List<MotorcycleConfigComponent.MotorConfigParams> list = new List<MotorcycleConfigComponent.MotorConfigParams>(num3);
								CollectionsMarshal.SetCount<MotorcycleConfigComponent.MotorConfigParams>(list, num3);
								Span<MotorcycleConfigComponent.MotorConfigParams> span = CollectionsMarshal.AsSpan<MotorcycleConfigComponent.MotorConfigParams>(list);
								int num4 = 0;
								*span[num4] = motorConfigParams;
								tagIdToConfigParams.Add(key, list);
							}
						}
					}
					motorConfigParams.TryActivate();
				}
			}
			foreach (KeyValuePair<int, List<MotorcycleConfigComponent.MotorConfigParams>> keyValuePair in this.TagIdToConfigParams)
			{
				int num4;
				List<MotorcycleConfigComponent.MotorConfigParams> list2;
				keyValuePair.Deconstruct(out num4, out list2);
				int tagId = num4;
				this.TagComp.AddTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged), null);
			}
			BaseVehiclePerformComponent component2 = base.Entity.GetComponent<BaseVehiclePerformComponent>();
			object obj;
			if (component2 == null)
			{
				obj = null;
			}
			else
			{
				VehicleConfig config = component2.Config;
				obj = ((config != null) ? config.Asset : null);
			}
			BP_MotorConfig_C bp_MotorConfig_C = obj as BP_MotorConfig_C;
			if (bp_MotorConfig_C == null)
			{
				return true;
			}
			UDataTable configDataTable = bp_MotorConfig_C.ConfigDataTable;
			if (configDataTable != null)
			{
				this.MotorActor.VehicleMovementComponent.MotorConfigDataTable = configDataTable;
			}
			return true;
		}

		// Token: 0x06045EA8 RID: 286376 RVA: 0x0116694C File Offset: 0x01164B4C
		protected override bool OnEnd()
		{
			foreach (KeyValuePair<int, List<MotorcycleConfigComponent.MotorConfigParams>> keyValuePair in this.TagIdToConfigParams)
			{
				int num;
				List<MotorcycleConfigComponent.MotorConfigParams> list;
				keyValuePair.Deconstruct(out num, out list);
				int tagId = num;
				this.TagComp.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged));
			}
			return true;
		}

		// Token: 0x06045EA9 RID: 286377 RVA: 0x011669C0 File Offset: 0x01164BC0
		private void OnTagChanged(int tagId, bool tagExist)
		{
			if (this.MotorActor == null)
			{
				return;
			}
			List<MotorcycleConfigComponent.MotorConfigParams> valueOrDefault = this.TagIdToConfigParams.GetValueOrDefault(tagId);
			if (valueOrDefault == null)
			{
				return;
			}
			if (tagExist)
			{
				using (List<MotorcycleConfigComponent.MotorConfigParams>.Enumerator enumerator = valueOrDefault.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						MotorcycleConfigComponent.MotorConfigParams motorConfigParams = enumerator.Current;
						motorConfigParams.TryActivate();
					}
					return;
				}
			}
			foreach (MotorcycleConfigComponent.MotorConfigParams motorConfigParams2 in valueOrDefault)
			{
				motorConfigParams2.Inactivate();
			}
		}

		// Token: 0x06045EAA RID: 286378 RVA: 0x01166A64 File Offset: 0x01164C64
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleConfigComponent motorcycleConfigComponent = (MotorcycleConfigComponent)componentTemplate;
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (motorcycleConfigComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MotorActor"))
			{
				if (motorcycleConfigComponent.MotorActor == null)
				{
					this.MotorActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseVehicle>(this.MotorActor), "MotorActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ConfigHelper"))
			{
				if (motorcycleConfigComponent.ConfigHelper == null)
				{
					this.ConfigHelper = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroConfigHelper>(this.ConfigHelper), "ConfigHelper"))
				{
					return false;
				}
			}
			return !base.CanResetComponentProperty("TagIdToConfigParams") || motorcycleConfigComponent.TagIdToConfigParams == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, List<MotorcycleConfigComponent.MotorConfigParams>>>(this.TagIdToConfigParams), "TagIdToConfigParams");
		}

		// Token: 0x040248F2 RID: 149746
		[StaticVariableRuleIgnore]
		private static readonly FName baseName = new FName("Base");

		// Token: 0x040248F3 RID: 149747
		private VehicleTagComponent TagComp;

		// Token: 0x040248F4 RID: 149748
		private TsBaseVehicle MotorActor;

		// Token: 0x040248F5 RID: 149749
		private UKuroConfigHelper ConfigHelper;

		// Token: 0x040248F6 RID: 149750
		[Nullable(1)]
		private readonly Dictionary<int, List<MotorcycleConfigComponent.MotorConfigParams>> TagIdToConfigParams = new Dictionary<int, List<MotorcycleConfigComponent.MotorConfigParams>>();

		// Token: 0x0200CE20 RID: 52768
		[NullableContext(1)]
		[Nullable(0)]
		public class MotorConfigParams
		{
			// Token: 0x06051DDC RID: 335324 RVA: 0x0163F1B4 File Offset: 0x0163D3B4
			public static void ConvertVarNames([Nullable(new byte[]
			{
				1,
				0
			})] TArray<TEnumAsByte<EMotorPropertyName>> varNames, TArray<int> @out)
			{
				@out.Empty(true);
				int num = varNames.Num();
				for (int i = 0; i < num; i++)
				{
					@out.Add((int)varNames.Get(i));
				}
			}

			// Token: 0x06051DDD RID: 335325 RVA: 0x0163F1F0 File Offset: 0x0163D3F0
			public MotorConfigParams(FName name, SMotorConfigs config, VehicleTagComponent tagComp, UKuroConfigHelper motorConfigHelper)
			{
				this.Name = name;
				this.Config = config;
				this.TagComp = tagComp;
				this.MotorConfigHelper = motorConfigHelper;
				TArray<FGameplayTag> gameplayTags = config.ActivateTags.GameplayTags;
				for (int i = gameplayTags.Num() - 1; i >= 0; i--)
				{
					this.Tags.Add(gameplayTags.Get(i).TagId());
				}
				MotorcycleConfigComponent.MotorConfigParams.ConvertVarNames(config.VarNames, this.VarInt);
			}

			// Token: 0x06051DDE RID: 335326 RVA: 0x0163F280 File Offset: 0x0163D480
			public void TryActivate()
			{
				if (this.Activated)
				{
					return;
				}
				foreach (int tagId in this.Tags)
				{
					if (!this.TagComp.HasTag(tagId))
					{
						return;
					}
				}
				this.Activated = true;
				this.MotorConfigHelper.AddSubConfigByNumber(this.Name, this.Config.Priority, this.VarInt, this.Config.Configs);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "MotorConfig AddSubConfig";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Name);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}

			// Token: 0x06051DDF RID: 335327 RVA: 0x0163F34C File Offset: 0x0163D54C
			public void Inactivate()
			{
				if (!this.Activated)
				{
					return;
				}
				this.Activated = false;
				this.MotorConfigHelper.RemoveSubConfig(this.Name);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "MotorConfig RemoveSubConfig";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Name);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}

			// Token: 0x0403E15A RID: 254298
			private bool Activated;

			// Token: 0x0403E15B RID: 254299
			private readonly List<int> Tags = new List<int>();

			// Token: 0x0403E15C RID: 254300
			private readonly TArray<int> VarInt = new TArray<int>();

			// Token: 0x0403E15D RID: 254301
			public FName Name;

			// Token: 0x0403E15E RID: 254302
			private readonly SMotorConfigs Config;

			// Token: 0x0403E15F RID: 254303
			private readonly VehicleTagComponent TagComp;

			// Token: 0x0403E160 RID: 254304
			private readonly UKuroConfigHelper MotorConfigHelper;
		}
	}
}
