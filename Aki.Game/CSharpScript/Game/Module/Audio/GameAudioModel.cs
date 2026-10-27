using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E8F RID: 24207
	[NullableContext(1)]
	[Nullable(0)]
	public class GameAudioModel : ModelBase
	{
		// Token: 0x17008E91 RID: 36497
		// (get) Token: 0x0603D953 RID: 252243 RVA: 0x00EDE195 File Offset: 0x00EDC395
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

		// Token: 0x0603D954 RID: 252244 RVA: 0x00EDE1BC File Offset: 0x00EDC3BC
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

		// Token: 0x0603D955 RID: 252245 RVA: 0x00EDE27C File Offset: 0x00EDC47C
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

		// Token: 0x0603D956 RID: 252246 RVA: 0x00EDE394 File Offset: 0x00EDC594
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

		// Token: 0x0603D957 RID: 252247 RVA: 0x00EDE40C File Offset: 0x00EDC60C
		private int GetCooldownMapKey(int entityId, int modelId)
		{
			int result = entityId;
			if (modelId != 0 && GameAudioController.Instance.HasMorphAudioConfig(modelId))
			{
				result = modelId;
			}
			return result;
		}

		// Token: 0x0603D958 RID: 252248 RVA: 0x00EDE42E File Offset: 0x00EDC62E
		public void AddAllGondolaMusic(Entity entity)
		{
			this.VehicleAudioInfo.AddAllGondolaMusic(entity);
		}

		// Token: 0x0603D959 RID: 252249 RVA: 0x00EDE43C File Offset: 0x00EDC63C
		public void StopAllGondolaMusic()
		{
			this.VehicleAudioInfo.StopAllGondolaMusic();
		}

		// Token: 0x0603D95A RID: 252250 RVA: 0x00EDE449 File Offset: 0x00EDC649
		public void GondolaGetOnAudioEvent(Entity entity)
		{
			this.VehicleAudioInfo.GondolaGetOnAudioEvent(entity);
		}

		// Token: 0x0603D95B RID: 252251 RVA: 0x00EDE457 File Offset: 0x00EDC657
		public void RegisterDriveAudioEvent(int roleId, int roleCreatureId)
		{
			this.VehicleAudioInfo.RegisterDriveAudioEvent(roleId, roleCreatureId);
		}

		// Token: 0x0603D95C RID: 252252 RVA: 0x00EDE466 File Offset: 0x00EDC666
		public void RemoveDriveAudioEvent()
		{
			this.VehicleAudioInfo.RemoveDriveAudioEvent();
		}

		// Token: 0x0603D95D RID: 252253 RVA: 0x00EDE473 File Offset: 0x00EDC673
		public bool PlayRideSharingPlotAudio(EGondolaVoiceTriggeredType type)
		{
			return this.VehicleAudioInfo.PlayRideSharingPlotAudio(type);
		}

		// Token: 0x0603D95E RID: 252254 RVA: 0x00EDE481 File Offset: 0x00EDC681
		public bool CheckRideSharingState()
		{
			return this.VehicleAudioInfo.CheckRideSharingState();
		}

		// Token: 0x0603D95F RID: 252255 RVA: 0x00EDE48E File Offset: 0x00EDC68E
		public void RegisterFishingAudioEvent()
		{
			this.VehicleAudioInfo.RegisterFishingAudioEvent();
		}

		// Token: 0x0603D960 RID: 252256 RVA: 0x00EDE49B File Offset: 0x00EDC69B
		public void RemoveFishingAudioEvent()
		{
			this.VehicleAudioInfo.RemoveFishingAudioEvent();
		}

		// Token: 0x0603D961 RID: 252257 RVA: 0x00EDE4A8 File Offset: 0x00EDC6A8
		public bool PlayFishingAudio(EGondolaVoiceTriggeredType type)
		{
			return this.VehicleAudioInfo.PlayFishingAudio(type);
		}

		// Token: 0x0603D962 RID: 252258 RVA: 0x00EDE4B6 File Offset: 0x00EDC6B6
		public void RegisterMotorDriveAudioEvent(int roleId, int roleCreatureId)
		{
			this.VehicleAudioInfo.RegisterMotorDriveAudioEvent(roleId, roleCreatureId);
		}

		// Token: 0x0603D963 RID: 252259 RVA: 0x00EDE4C5 File Offset: 0x00EDC6C5
		public void RemoveMotorDriveAudioEvent()
		{
			this.VehicleAudioInfo.RemoveMotorDriveAudioEvent();
		}

		// Token: 0x0603D964 RID: 252260 RVA: 0x00EDE4D2 File Offset: 0x00EDC6D2
		public bool PlayMotorPlotAudio(EGondolaVoiceTriggeredType type)
		{
			return this.VehicleAudioInfo.PlayMotorPlotAudioDefault(type);
		}

		// Token: 0x0603D965 RID: 252261 RVA: 0x00EDE4E0 File Offset: 0x00EDC6E0
		public bool CheckMotorState()
		{
			return this.VehicleAudioInfo.CheckMotorState();
		}

		// Token: 0x17008E92 RID: 36498
		// (get) Token: 0x0603D966 RID: 252262 RVA: 0x00EDE4ED File Offset: 0x00EDC6ED
		public static GameAudioModel Instance
		{
			get
			{
				return GameAudioModel._Instance;
			}
		}

		// Token: 0x0603D967 RID: 252263 RVA: 0x00EDE4F4 File Offset: 0x00EDC6F4
		public static GameAudioModel GetOrCreateInstance()
		{
			if (GameAudioModel._Instance == null)
			{
				GameAudioModel.CreateInstance();
			}
			return GameAudioModel._Instance;
		}

		// Token: 0x0603D968 RID: 252264 RVA: 0x00EDE508 File Offset: 0x00EDC708
		public static bool CreateInstance()
		{
			if (GameAudioModel._Instance != null)
			{
				return true;
			}
			GameAudioModel._Instance = new GameAudioModel();
			return true;
		}

		// Token: 0x0603D969 RID: 252265 RVA: 0x00EDE51E File Offset: 0x00EDC71E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D96A RID: 252266 RVA: 0x00EDE520 File Offset: 0x00EDC720
		public static void ResetStaticDefaultValue()
		{
			GameAudioModel._Instance = null;
		}

		// Token: 0x0603D96B RID: 252267 RVA: 0x00EDE528 File Offset: 0x00EDC728
		static GameAudioModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameAudioModel.CreateStaticDefaultValue), new Action(GameAudioModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020237 RID: 131639
		[Nullable(2)]
		private VehicleAudioEventInfo VehicleAudioInfoInternal;

		// Token: 0x04020238 RID: 131640
		private readonly Dictionary<int, EntityCooldownProbability> EntityTagProbabilityMap = new Dictionary<int, EntityCooldownProbability>();

		// Token: 0x04020239 RID: 131641
		[Nullable(2)]
		private static GameAudioModel _Instance;
	}
}
