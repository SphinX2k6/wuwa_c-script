using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E74 RID: 20084
	[NullableContext(1)]
	[Nullable(0)]
	public class GameAudioModel : ModelBase
	{
		// Token: 0x17006263 RID: 25187
		// (get) Token: 0x060328E3 RID: 207075 RVA: 0x00E2F725 File Offset: 0x00E2D925
		private VehicleAudioEventInfo VehicleAudioInfo
		{
			get
			{
				if (this.VehicleAudioInfoInternal == null)
				{
					this.VehicleAudioInfoInternal = new VehicleAudioEventInfo();
					this.VehicleAudioInfoInternal.Init();
				}
				return this.VehicleAudioInfoInternal;
			}
		}

		// Token: 0x060328E4 RID: 207076 RVA: 0x00E2F74C File Offset: 0x00E2D94C
		public void CheckTimeOutCooldownRecords()
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, EntityCooldownProbability> keyValuePair in this.EntityTagProbabilityMap)
			{
				if (keyValuePair.Value.CheckTimeOutCooldownRecords())
				{
					keyValuePair.Value.Clear();
					list.Add(keyValuePair.Key);
				}
			}
			foreach (int key in list)
			{
				this.EntityTagProbabilityMap.Remove(key);
			}
		}

		// Token: 0x060328E5 RID: 207077 RVA: 0x00E2F80C File Offset: 0x00E2DA0C
		[NullableContext(2)]
		public bool CheckAudioProbabilityInfo(int entityId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<int, string> eventObj, IAudioCoolDownWithTagInfo param = null, bool update = true, bool log = true, bool checkMorph = true)
		{
			if (param == null)
			{
				return true;
			}
			CharacterMorphComponent component = EntitySystem.Instance.GetComponent<CharacterMorphComponent>(entityId);
			int? num;
			if (component == null)
			{
				num = null;
			}
			else
			{
				IMorphData morphData = component.GetMorphData(null);
				num = ((morphData != null) ? new int?(morphData.ModelId) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (checkMorph && valueOrDefault != 0 && !GameAudioController.Instance.CheckMorphAudioPlay(valueOrDefault, eventObj))
			{
				return false;
			}
			if (param.TagProbability == null || param.TagProbability.Num() == 0)
			{
				if (param.DefaultCooldownTime == 0)
				{
					return EntityCooldownProbability.GetProbability(param.DefaultProbability);
				}
				if (param.DefaultProbability == 0.0)
				{
					return false;
				}
			}
			int cooldownMapKey = this.GetCooldownMapKey(entityId, valueOrDefault);
			if (!this.EntityTagProbabilityMap.ContainsKey(cooldownMapKey))
			{
				EntityCooldownProbability entityCooldownProbability = new EntityCooldownProbability();
				entityCooldownProbability.Init(entityId, valueOrDefault);
				bool flag = entityCooldownProbability.CheckPlayAudio(eventObj, param, update, log);
				if (flag)
				{
					this.EntityTagProbabilityMap[cooldownMapKey] = entityCooldownProbability;
				}
				return flag;
			}
			return this.EntityTagProbabilityMap[cooldownMapKey].CheckPlayAudio(eventObj, param, update, log);
		}

		// Token: 0x060328E6 RID: 207078 RVA: 0x00E2F924 File Offset: 0x00E2DB24
		public void UpdateAudioCooldownRecord(int entityId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<int, string> eventObj, double probability, int cooldownTime, bool log = true)
		{
			CharacterMorphComponent component = EntitySystem.Instance.GetComponent<CharacterMorphComponent>(entityId);
			int? num;
			if (component == null)
			{
				num = null;
			}
			else
			{
				IMorphData morphData = component.GetMorphData(null);
				num = ((morphData != null) ? new int?(morphData.ModelId) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			int cooldownMapKey = this.GetCooldownMapKey(entityId, valueOrDefault);
			this.EntityTagProbabilityMap[cooldownMapKey].UpdateCooldownRecord(eventObj, probability, (double)cooldownTime, log);
		}

		// Token: 0x060328E7 RID: 207079 RVA: 0x00E2F99C File Offset: 0x00E2DB9C
		private int GetCooldownMapKey(int entityId, int modelId)
		{
			int result = entityId;
			if (modelId != 0 && GameAudioController.Instance.HasMorphAudioConfig(modelId))
			{
				result = modelId;
			}
			return result;
		}

		// Token: 0x060328E8 RID: 207080 RVA: 0x00E2F9BE File Offset: 0x00E2DBBE
		public void AddAllGondolaMusic(Entity entity)
		{
			this.VehicleAudioInfo.AddAllGondolaMusic(entity);
		}

		// Token: 0x060328E9 RID: 207081 RVA: 0x00E2F9CC File Offset: 0x00E2DBCC
		public void StopAllGondolaMusic()
		{
			this.VehicleAudioInfo.StopAllGondolaMusic();
		}

		// Token: 0x060328EA RID: 207082 RVA: 0x00E2F9D9 File Offset: 0x00E2DBD9
		public void GondolaGetOnAudioEvent(Entity entity)
		{
			this.VehicleAudioInfo.GondolaGetOnAudioEvent(entity);
		}

		// Token: 0x060328EB RID: 207083 RVA: 0x00E2F9E7 File Offset: 0x00E2DBE7
		public void RegisterDriveAudioEvent(int roleId, int roleCreatureId)
		{
			this.VehicleAudioInfo.RegisterDriveAudioEvent(roleId, roleCreatureId);
		}

		// Token: 0x060328EC RID: 207084 RVA: 0x00E2F9F6 File Offset: 0x00E2DBF6
		public void RemoveDriveAudioEvent()
		{
			this.VehicleAudioInfo.RemoveDriveAudioEvent();
		}

		// Token: 0x060328ED RID: 207085 RVA: 0x00E2FA03 File Offset: 0x00E2DC03
		public bool PlayRideSharingPlotAudio(EGondolaVoiceTriggeredType type)
		{
			return this.VehicleAudioInfo.PlayRideSharingPlotAudio(type);
		}

		// Token: 0x060328EE RID: 207086 RVA: 0x00E2FA11 File Offset: 0x00E2DC11
		public bool CheckRideSharingState()
		{
			return this.VehicleAudioInfo.CheckRideSharingState();
		}

		// Token: 0x060328EF RID: 207087 RVA: 0x00E2FA1E File Offset: 0x00E2DC1E
		public void RegisterFishingAudioEvent()
		{
			this.VehicleAudioInfo.RegisterFishingAudioEvent();
		}

		// Token: 0x060328F0 RID: 207088 RVA: 0x00E2FA2B File Offset: 0x00E2DC2B
		public void RemoveFishingAudioEvent()
		{
			this.VehicleAudioInfo.RemoveFishingAudioEvent();
		}

		// Token: 0x060328F1 RID: 207089 RVA: 0x00E2FA38 File Offset: 0x00E2DC38
		public bool PlayFishingAudio(EGondolaVoiceTriggeredType type)
		{
			return this.VehicleAudioInfo.PlayFishingAudio(type);
		}

		// Token: 0x060328F2 RID: 207090 RVA: 0x00E2FA46 File Offset: 0x00E2DC46
		public void RegisterMotorDriveAudioEvent(int roleId, int roleCreatureId)
		{
			this.VehicleAudioInfo.RegisterMotorDriveAudioEvent(roleId, roleCreatureId);
		}

		// Token: 0x060328F3 RID: 207091 RVA: 0x00E2FA55 File Offset: 0x00E2DC55
		public void RemoveMotorDriveAudioEvent()
		{
			this.VehicleAudioInfo.RemoveMotorDriveAudioEvent();
		}

		// Token: 0x060328F4 RID: 207092 RVA: 0x00E2FA62 File Offset: 0x00E2DC62
		public bool PlayMotorPlotAudio(EGondolaVoiceTriggeredType type)
		{
			return this.VehicleAudioInfo.PlayMotorPlotAudioDefault(type);
		}

		// Token: 0x060328F5 RID: 207093 RVA: 0x00E2FA70 File Offset: 0x00E2DC70
		public bool CheckMotorState()
		{
			return this.VehicleAudioInfo.CheckMotorState();
		}

		// Token: 0x17006264 RID: 25188
		// (get) Token: 0x060328F6 RID: 207094 RVA: 0x00E2FA7D File Offset: 0x00E2DC7D
		public static GameAudioModel Instance
		{
			get
			{
				return GameAudioModel._Instance;
			}
		}

		// Token: 0x060328F7 RID: 207095 RVA: 0x00E2FA84 File Offset: 0x00E2DC84
		public static GameAudioModel GetOrCreateInstance()
		{
			if (GameAudioModel._Instance == null)
			{
				GameAudioModel.CreateInstance();
			}
			return GameAudioModel._Instance;
		}

		// Token: 0x060328F8 RID: 207096 RVA: 0x00E2FA98 File Offset: 0x00E2DC98
		public static bool CreateInstance()
		{
			if (GameAudioModel._Instance != null)
			{
				return true;
			}
			GameAudioModel._Instance = new GameAudioModel();
			return true;
		}

		// Token: 0x060328F9 RID: 207097 RVA: 0x00E2FAAE File Offset: 0x00E2DCAE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060328FA RID: 207098 RVA: 0x00E2FAB0 File Offset: 0x00E2DCB0
		public static void ResetStaticDefaultValue()
		{
			GameAudioModel._Instance = null;
		}

		// Token: 0x060328FB RID: 207099 RVA: 0x00E2FAB8 File Offset: 0x00E2DCB8
		static GameAudioModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameAudioModel.CreateStaticDefaultValue), new Action(GameAudioModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401ACFE RID: 109822
		[Nullable(2)]
		private VehicleAudioEventInfo VehicleAudioInfoInternal;

		// Token: 0x0401ACFF RID: 109823
		private readonly Dictionary<int, EntityCooldownProbability> EntityTagProbabilityMap = new Dictionary<int, EntityCooldownProbability>();

		// Token: 0x0401AD00 RID: 109824
		[Nullable(2)]
		private static GameAudioModel _Instance;
	}
}
