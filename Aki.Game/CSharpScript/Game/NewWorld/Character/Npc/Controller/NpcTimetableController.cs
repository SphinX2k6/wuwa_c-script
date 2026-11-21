using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree;
using CSharpScript.Game.NewWorld.Character.Npc.Component;
using Google.Protobuf;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x02006300 RID: 25344
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class NpcTimetableController : ControllerBase
	{
		// Token: 0x0603D4BD RID: 251069 RVA: 0x011B6298 File Offset: 0x011B4498
		protected override bool OnInit()
		{
			GlobalConfigFromCsv? globalConfigFromCsv;
			string text = (ConfigGlobalConfigFromCsvByName.GetConfig("Schedule.MaxDelayTime", true) != null) ? globalConfigFromCsv.GetValueOrDefault().Value : null;
			this.MaxDelaySwitchTime = float.Parse(text ?? "0");
			Net.Instance.Register(ENotifyMessageId.TimeScheduleTriggerNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimeScheduleTriggerNotify));
			Net.Instance.Register(ENotifyMessageId.TimeScheduleIdleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimeScheduleEndNotify));
			return true;
		}

		// Token: 0x0603D4BE RID: 251070 RVA: 0x011B631B File Offset: 0x011B451B
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.TimeScheduleTriggerNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TimeScheduleIdleNotify);
			return true;
		}

		// Token: 0x0603D4BF RID: 251071 RVA: 0x011B6340 File Offset: 0x011B4540
		[NullableContext(2)]
		protected void OnTimeScheduleTriggerNotify(IMessage msg, Net.CallbackStatus _)
		{
			TimeScheduleTriggerNotify timeScheduleTriggerNotify = (TimeScheduleTriggerNotify)msg;
			TimetableConfigData timetableConfigData = this.GetTimetableConfigData(timeScheduleTriggerNotify.TimeScheduleId);
			if (timetableConfigData == null)
			{
				return;
			}
			foreach (long num in timeScheduleTriggerNotify.EntityIds)
			{
				this.TimeScheduleCache[num] = timetableConfigData;
				this.ClearTimetableSavedData(num, "Notify");
				EntityHandle entity = CreatureModel.Instance.GetEntity(num);
				if (entity != null)
				{
					WorldEntity entity2 = entity.Entity;
					if (((entity2 != null) ? new bool?(entity2.IsInit) : null).GetValueOrDefault())
					{
						NpcTimetableComponent component = entity.Entity.GetComponent<NpcTimetableComponent>();
						if (component != null)
						{
							component.SwitchTimetable(timetableConfigData, "Notify", true);
						}
					}
				}
			}
		}

		// Token: 0x0603D4C0 RID: 251072 RVA: 0x011B6418 File Offset: 0x011B4618
		[NullableContext(2)]
		protected void OnTimeScheduleEndNotify(IMessage msg, Net.CallbackStatus _)
		{
			foreach (long num in ((TimeScheduleIdleNotify)msg).EntityIds)
			{
				this.TimeScheduleCache.Remove(num);
				this.ClearTimetableSavedData(num, "Notify");
				EntityHandle entity = CreatureModel.Instance.GetEntity(num);
				if (entity != null)
				{
					WorldEntity entity2 = entity.Entity;
					if (((entity2 != null) ? new bool?(entity2.IsInit) : null).GetValueOrDefault())
					{
						NpcTimetableComponent component = entity.Entity.GetComponent<NpcTimetableComponent>();
						if (component != null)
						{
							component.StopTimetable("Notify", true);
						}
					}
				}
			}
		}

		// Token: 0x0603D4C1 RID: 251073 RVA: 0x011B64D0 File Offset: 0x011B46D0
		[NullableContext(2)]
		public TimetableConfigData GetTimeScheduleByCreatureId(long creatureId)
		{
			TimetableConfigData result;
			this.TimeScheduleCache.TryGetValue(creatureId, out result);
			return result;
		}

		// Token: 0x0603D4C2 RID: 251074 RVA: 0x011B64F0 File Offset: 0x011B46F0
		[NullableContext(2)]
		protected TimetableConfigData GetTimetableConfigData(int scheduleId)
		{
			TimetableConfigData result;
			if (!this.TimeScheduleConfigDataMap.TryGetValue(scheduleId, out result))
			{
				TimetableConfigData timetableConfigData = this.ParseTimeScheduleFromId(scheduleId);
				if (timetableConfigData == null)
				{
					return null;
				}
				this.TimeScheduleConfigDataMap[scheduleId] = timetableConfigData;
				result = timetableConfigData;
			}
			return result;
		}

		// Token: 0x0603D4C3 RID: 251075 RVA: 0x011B652C File Offset: 0x011B472C
		[NullableContext(2)]
		protected TimetableConfigData ParseTimeScheduleFromId(int scheduleId)
		{
			RawTimeScheduleConfigData timeScheduleData = TimeScheduleConfig.Instance.GetTimeScheduleData(scheduleId);
			if (timeScheduleData == null)
			{
				return null;
			}
			TimetableConfigData timetableConfigData = new TimetableConfigData();
			RawAiBehaviorTreeConfigData aiBehaviorTreeData = AiBehaviorTreeConfig.Instance.GetAiBehaviorTreeData(timeScheduleData.BehaviorTree);
			timetableConfigData.BehaviorTreePath = (((aiBehaviorTreeData != null) ? aiBehaviorTreeData.BtPath : null) ?? "");
			ICommonBtOverride commonBtOverride;
			if (BehaviorTreeDefines.TryParseCommonBtOverride(scheduleId, timeScheduleData.CommonBtOverride, out commonBtOverride))
			{
				timetableConfigData.CommonBtOverride = commonBtOverride;
			}
			if (string.IsNullOrEmpty(timetableConfigData.BehaviorTreePath) && timetableConfigData.CommonBtOverride == null)
			{
				return null;
			}
			int num = timeScheduleData.SplineEntityUid.LastIndexOf('_');
			timetableConfigData.SplineId = int.Parse(timeScheduleData.SplineEntityUid.Substring(num + 1));
			num = timeScheduleData.StartTime.IndexOf(':');
			timetableConfigData.StartTime = int.Parse(timeScheduleData.StartTime.Substring(0, num));
			return timetableConfigData;
		}

		// Token: 0x0603D4C4 RID: 251076 RVA: 0x011B65FC File Offset: 0x011B47FC
		public void SaveTimetableSavedData(long creatureId, TimetableSavedData state)
		{
			this.TimetableSavedDataMap[creatureId] = state.DeepCopy();
		}

		// Token: 0x0603D4C5 RID: 251077 RVA: 0x011B6610 File Offset: 0x011B4810
		public void ClearTimetableSavedData(long creatureId, string reason = "")
		{
			TimetableSavedData timetableSavedData;
			if (!this.TimetableSavedDataMap.TryGetValue(creatureId, out timetableSavedData))
			{
				return;
			}
			this.TimetableSavedDataMap.Remove(creatureId);
		}

		// Token: 0x0603D4C6 RID: 251078 RVA: 0x011B663C File Offset: 0x011B483C
		[NullableContext(2)]
		public TimetableSavedData GetTimetableSavedData(long creatureId)
		{
			TimetableSavedData result;
			this.TimetableSavedDataMap.TryGetValue(creatureId, out result);
			return result;
		}

		// Token: 0x0603D4C7 RID: 251079 RVA: 0x011B665C File Offset: 0x011B485C
		public bool IsInTimeSchedule(Entity entity)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			return component != null && this.TimeScheduleCache.ContainsKey(component.GetCreatureDataId());
		}

		// Token: 0x0603D4C8 RID: 251080 RVA: 0x011B6686 File Offset: 0x011B4886
		public float GetMaxDelaySwitchTime()
		{
			return this.MaxDelaySwitchTime;
		}

		// Token: 0x17007407 RID: 29703
		// (get) Token: 0x0603D4C9 RID: 251081 RVA: 0x011B668E File Offset: 0x011B488E
		public static NpcTimetableController Instance
		{
			get
			{
				return NpcTimetableController._Instance;
			}
		}

		// Token: 0x0603D4CA RID: 251082 RVA: 0x011B6695 File Offset: 0x011B4895
		public static NpcTimetableController GetOrCreateInstance()
		{
			if (NpcTimetableController._Instance == null)
			{
				NpcTimetableController.CreateInstance();
			}
			return NpcTimetableController._Instance;
		}

		// Token: 0x0603D4CB RID: 251083 RVA: 0x011B66A9 File Offset: 0x011B48A9
		public static bool CreateInstance()
		{
			if (NpcTimetableController._Instance != null)
			{
				return true;
			}
			NpcTimetableController._Instance = new NpcTimetableController();
			return true;
		}

		// Token: 0x0603D4CC RID: 251084 RVA: 0x011B66BF File Offset: 0x011B48BF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D4CD RID: 251085 RVA: 0x011B66C1 File Offset: 0x011B48C1
		public static void ResetStaticDefaultValue()
		{
			NpcTimetableController._Instance = null;
		}

		// Token: 0x0603D4CE RID: 251086 RVA: 0x011B66C9 File Offset: 0x011B48C9
		static NpcTimetableController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NpcTimetableController.CreateStaticDefaultValue), new Action(NpcTimetableController.ResetStaticDefaultValue));
		}

		// Token: 0x0402083D RID: 133181
		protected float MaxDelaySwitchTime;

		// Token: 0x0402083E RID: 133182
		protected readonly Dictionary<long, TimetableSavedData> TimetableSavedDataMap = new Dictionary<long, TimetableSavedData>();

		// Token: 0x0402083F RID: 133183
		protected readonly Dictionary<int, TimetableConfigData> TimeScheduleConfigDataMap = new Dictionary<int, TimetableConfigData>();

		// Token: 0x04020840 RID: 133184
		protected readonly Dictionary<long, TimetableConfigData> TimeScheduleCache = new Dictionary<long, TimetableConfigData>();

		// Token: 0x04020841 RID: 133185
		[Nullable(2)]
		private static NpcTimetableController _Instance;
	}
}
