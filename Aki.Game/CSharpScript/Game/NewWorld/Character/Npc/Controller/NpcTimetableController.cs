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
	// Token: 0x0200709B RID: 28827
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class NpcTimetableController : ControllerBase
	{
		// Token: 0x060463D2 RID: 287698 RVA: 0x0119318C File Offset: 0x0119138C
		protected override bool OnInit()
		{
			GlobalConfigFromCsv? globalConfigFromCsv;
			string text = (ConfigGlobalConfigFromCsvByName.GetConfig("Schedule.MaxDelayTime", true) != null) ? globalConfigFromCsv.GetValueOrDefault().Value : null;
			this.MaxDelaySwitchTime = float.Parse(text ?? "0");
			Net.Instance.Register(ENotifyMessageId.TimeScheduleTriggerNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimeScheduleTriggerNotify));
			Net.Instance.Register(ENotifyMessageId.TimeScheduleIdleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimeScheduleEndNotify));
			return true;
		}

		// Token: 0x060463D3 RID: 287699 RVA: 0x0119320F File Offset: 0x0119140F
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.TimeScheduleTriggerNotify);
			Net.Instance.UnRegister(ENotifyMessageId.TimeScheduleIdleNotify);
			return true;
		}

		// Token: 0x060463D4 RID: 287700 RVA: 0x01193234 File Offset: 0x01191434
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

		// Token: 0x060463D5 RID: 287701 RVA: 0x0119330C File Offset: 0x0119150C
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

		// Token: 0x060463D6 RID: 287702 RVA: 0x011933C4 File Offset: 0x011915C4
		[NullableContext(2)]
		public TimetableConfigData GetTimeScheduleByCreatureId(long creatureId)
		{
			TimetableConfigData result;
			this.TimeScheduleCache.TryGetValue(creatureId, out result);
			return result;
		}

		// Token: 0x060463D7 RID: 287703 RVA: 0x011933E4 File Offset: 0x011915E4
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

		// Token: 0x060463D8 RID: 287704 RVA: 0x01193420 File Offset: 0x01191620
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

		// Token: 0x060463D9 RID: 287705 RVA: 0x011934F0 File Offset: 0x011916F0
		public void SaveTimetableSavedData(long creatureId, TimetableSavedData state)
		{
			this.TimetableSavedDataMap[creatureId] = state.DeepCopy();
		}

		// Token: 0x060463DA RID: 287706 RVA: 0x01193504 File Offset: 0x01191704
		public void ClearTimetableSavedData(long creatureId, string reason = "")
		{
			TimetableSavedData timetableSavedData;
			if (!this.TimetableSavedDataMap.TryGetValue(creatureId, out timetableSavedData))
			{
				return;
			}
			this.TimetableSavedDataMap.Remove(creatureId);
		}

		// Token: 0x060463DB RID: 287707 RVA: 0x01193530 File Offset: 0x01191730
		[NullableContext(2)]
		public TimetableSavedData GetTimetableSavedData(long creatureId)
		{
			TimetableSavedData result;
			this.TimetableSavedDataMap.TryGetValue(creatureId, out result);
			return result;
		}

		// Token: 0x060463DC RID: 287708 RVA: 0x01193550 File Offset: 0x01191750
		public bool IsInTimeSchedule(Entity entity)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			return component != null && this.TimeScheduleCache.ContainsKey(component.GetCreatureDataId());
		}

		// Token: 0x060463DD RID: 287709 RVA: 0x0119357A File Offset: 0x0119177A
		public float GetMaxDelaySwitchTime()
		{
			return this.MaxDelaySwitchTime;
		}

		// Token: 0x17009C25 RID: 39973
		// (get) Token: 0x060463DE RID: 287710 RVA: 0x01193582 File Offset: 0x01191782
		public static NpcTimetableController Instance
		{
			get
			{
				return NpcTimetableController._Instance;
			}
		}

		// Token: 0x060463DF RID: 287711 RVA: 0x01193589 File Offset: 0x01191789
		public static NpcTimetableController GetOrCreateInstance()
		{
			if (NpcTimetableController._Instance == null)
			{
				NpcTimetableController.CreateInstance();
			}
			return NpcTimetableController._Instance;
		}

		// Token: 0x060463E0 RID: 287712 RVA: 0x0119359D File Offset: 0x0119179D
		public static bool CreateInstance()
		{
			if (NpcTimetableController._Instance != null)
			{
				return true;
			}
			NpcTimetableController._Instance = new NpcTimetableController();
			return true;
		}

		// Token: 0x060463E1 RID: 287713 RVA: 0x011935B3 File Offset: 0x011917B3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060463E2 RID: 287714 RVA: 0x011935B5 File Offset: 0x011917B5
		public static void ResetStaticDefaultValue()
		{
			NpcTimetableController._Instance = null;
		}

		// Token: 0x060463E3 RID: 287715 RVA: 0x011935BD File Offset: 0x011917BD
		static NpcTimetableController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NpcTimetableController.CreateStaticDefaultValue), new Action(NpcTimetableController.ResetStaticDefaultValue));
		}

		// Token: 0x04024CEB RID: 150763
		protected float MaxDelaySwitchTime;

		// Token: 0x04024CEC RID: 150764
		protected readonly Dictionary<long, TimetableSavedData> TimetableSavedDataMap = new Dictionary<long, TimetableSavedData>();

		// Token: 0x04024CED RID: 150765
		protected readonly Dictionary<int, TimetableConfigData> TimeScheduleConfigDataMap = new Dictionary<int, TimetableConfigData>();

		// Token: 0x04024CEE RID: 150766
		protected readonly Dictionary<long, TimetableConfigData> TimeScheduleCache = new Dictionary<long, TimetableConfigData>();

		// Token: 0x04024CEF RID: 150767
		[Nullable(2)]
		private static NpcTimetableController _Instance;
	}
}
