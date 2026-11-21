using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200594B RID: 22859
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class SolarSchoolConfig : ConfigBase
	{
		// Token: 0x06038530 RID: 230704 RVA: 0x00FBF110 File Offset: 0x00FBD310
		public SolarSchoolViewInfo? GetViewInfo(string viewName)
		{
			return ConfigSolarSchoolViewInfoByViewName.GetConfig(viewName, true);
		}

		// Token: 0x06038531 RID: 230705 RVA: 0x00FBF119 File Offset: 0x00FBD319
		public IReadOnlyList<SolarSchoolViewInfo> GetViewInfoList(int activityId)
		{
			return ConfigSolarSchoolViewInfoByActivityId.GetConfigList(activityId, true) ?? Array.Empty<SolarSchoolViewInfo>();
		}

		// Token: 0x06038532 RID: 230706 RVA: 0x00FBF12C File Offset: 0x00FBD32C
		public ActivityAction? GetActivityAction(int id)
		{
			ActivityAction? config = ConfigActivityActionById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取 ActivityAction 配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038533 RID: 230707 RVA: 0x00FBF184 File Offset: 0x00FBD384
		public SolarSchoolFlow? GetFlow(int id)
		{
			SolarSchoolFlow? config = ConfigSolarSchoolFlowById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取 SolarSchoolFlow 配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038534 RID: 230708 RVA: 0x00FBF1DC File Offset: 0x00FBD3DC
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolCalendar> GetCalendarListByDayIndex(int dayIndex)
		{
			IReadOnlyList<SolarSchoolCalendar> configList = ConfigSolarSchoolCalendarByDayIndex.GetConfigList(dayIndex, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取日历列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dayIndex", dayIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return configList;
		}

		// Token: 0x06038535 RID: 230709 RVA: 0x00FBF226 File Offset: 0x00FBD426
		public SolarSchoolCalendar? GetCalendarDay(int activityId, int dayIndex)
		{
			return this.FindCalendarDay(activityId, dayIndex);
		}

		// Token: 0x06038536 RID: 230710 RVA: 0x00FBF230 File Offset: 0x00FBD430
		public bool HasCalendarDay(int activityId, int dayIndex)
		{
			return this.FindCalendarDay(activityId, dayIndex) != null;
		}

		// Token: 0x06038537 RID: 230711 RVA: 0x00FBF250 File Offset: 0x00FBD450
		private unsafe SolarSchoolCalendar? FindCalendarDay(int activityId, int dayIndex)
		{
			IReadOnlyList<SolarSchoolCalendar> configList = ConfigSolarSchoolCalendarByDayIndex.GetConfigList(dayIndex, true);
			if (configList == null || configList.Count == 0)
			{
				return null;
			}
			SolarSchoolCalendar? solarSchoolCalendar = null;
			SolarSchoolCalendar? result = null;
			int num = 0;
			foreach (SolarSchoolCalendar value in configList)
			{
				if (value.ActivityId == activityId)
				{
					if (value.ConditionGroupId == 0)
					{
						num++;
						if (result == null || value.Id > result.Value.Id)
						{
							result = new SolarSchoolCalendar?(value);
						}
					}
					else if (ActivityConditionCenter.Instance.CheckGroup(value.ConditionGroupId) && (solarSchoolCalendar == null || value.Id > solarSchoolCalendar.Value.Id))
					{
						solarSchoolCalendar = new SolarSchoolCalendar?(value);
					}
				}
			}
			if (num >= 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 同一天配了多条兜底行(ConditionGroupId=0)，只有 Id 最大的会生效";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dayIndex", dayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("fallbackCount", num);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			SolarSchoolCalendar? result2 = solarSchoolCalendar;
			if (result2 == null)
			{
				return result;
			}
			return result2;
		}

		// Token: 0x06038538 RID: 230712 RVA: 0x00FBF3E0 File Offset: 0x00FBD5E0
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolBehavior> GetBehaviorListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolBehavior> configList = ConfigSolarSchoolBehaviorByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取行为列表失败(按活动)";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x06038539 RID: 230713 RVA: 0x00FBF428 File Offset: 0x00FBD628
		public List<SolarSchoolBehavior> GetBehaviorListByBehaviorId(int activityId, int behaviorId)
		{
			List<SolarSchoolBehavior> list = new List<SolarSchoolBehavior>();
			IReadOnlyList<SolarSchoolBehavior> configList = ConfigSolarSchoolBehaviorByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取行为列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return list;
			}
			foreach (SolarSchoolBehavior item in configList)
			{
				if (item.BehaviorId == behaviorId)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0603853A RID: 230714 RVA: 0x00FBF4C0 File Offset: 0x00FBD6C0
		public unsafe SolarSchoolBehavior? SelectBehaviorRow(int activityId, int behaviorId, int completedCount)
		{
			List<SolarSchoolBehavior> behaviorListByBehaviorId = this.GetBehaviorListByBehaviorId(activityId, behaviorId);
			if (behaviorListByBehaviorId.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 行为无配表行";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", behaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			SolarSchoolBehavior? result = null;
			foreach (SolarSchoolBehavior value in behaviorListByBehaviorId)
			{
				if (value.RequireCount <= completedCount && (result == null || value.Level > result.Value.Level))
				{
					result = new SolarSchoolBehavior?(value);
				}
			}
			if (result == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 行为无满足完成次数的等级行";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", completedCount);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return result;
		}

		// Token: 0x0603853B RID: 230715 RVA: 0x00FBF5FC File Offset: 0x00FBD7FC
		public unsafe SolarSchoolBehavior? GetBehaviorRowByLevel(int activityId, int behaviorId, int level)
		{
			IReadOnlyList<SolarSchoolBehavior> configList = ConfigSolarSchoolBehaviorByActivityId.GetConfigList(activityId, true);
			if (configList != null)
			{
				foreach (SolarSchoolBehavior value in configList)
				{
					if (value.BehaviorId == behaviorId && value.Level == level)
					{
						return new SolarSchoolBehavior?(value);
					}
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 行为无指定等级的配表行";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", level);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}

		// Token: 0x0603853C RID: 230716 RVA: 0x00FBF6D4 File Offset: 0x00FBD8D4
		public ESolarSchoolBehaviorType? GetBehaviorType(int activityId, int behaviorId)
		{
			IReadOnlyList<SolarSchoolBehavior> configList = ConfigSolarSchoolBehaviorByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				return null;
			}
			foreach (SolarSchoolBehavior solarSchoolBehavior in configList)
			{
				if (solarSchoolBehavior.BehaviorId == behaviorId)
				{
					return new ESolarSchoolBehaviorType?((ESolarSchoolBehaviorType)solarSchoolBehavior.BehaviorType);
				}
			}
			return null;
		}

		// Token: 0x0603853D RID: 230717 RVA: 0x00FBF750 File Offset: 0x00FBD950
		public SolarSchoolItem? GetItem(int id)
		{
			SolarSchoolItem? config = ConfigSolarSchoolItemById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取道具配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603853E RID: 230718 RVA: 0x00FBF7A0 File Offset: 0x00FBD9A0
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolItem> GetAllItems()
		{
			IReadOnlyList<SolarSchoolItem> configList = ConfigSolarSchoolItemAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 获取全部道具配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x0603853F RID: 230719 RVA: 0x00FBF7D8 File Offset: 0x00FBD9D8
		public IReadOnlyList<SolarSchoolItem> GetItemListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolItem> configList = ConfigSolarSchoolItemByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取 SolarSchoolItem 列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolItem>();
			}
			return configList;
		}

		// Token: 0x06038540 RID: 230720 RVA: 0x00FBF828 File Offset: 0x00FBDA28
		public SolarSchoolItemEffect? GetItemEffect(int id)
		{
			SolarSchoolItemEffect? config = ConfigSolarSchoolItemEffectById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取道具效果配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038541 RID: 230721 RVA: 0x00FBF878 File Offset: 0x00FBDA78
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolItemEffect> GetAllItemEffects()
		{
			IReadOnlyList<SolarSchoolItemEffect> configList = ConfigSolarSchoolItemEffectAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 获取全部道具效果配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x06038542 RID: 230722 RVA: 0x00FBF8B0 File Offset: 0x00FBDAB0
		public SolarSchoolBuff? GetBuff(int id)
		{
			SolarSchoolBuff? config = ConfigSolarSchoolBuffById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取 Buff 配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038543 RID: 230723 RVA: 0x00FBF900 File Offset: 0x00FBDB00
		public SolarSchoolBuffEffect? GetBuffEffect(int id)
		{
			SolarSchoolBuffEffect? config = ConfigSolarSchoolBuffEffectById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取 Buff 效果配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038544 RID: 230724 RVA: 0x00FBF950 File Offset: 0x00FBDB50
		public SolarSchoolRewards? GetRewards(int id)
		{
			SolarSchoolRewards? config = ConfigSolarSchoolRewardsById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取奖励组配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038545 RID: 230725 RVA: 0x00FBF9A0 File Offset: 0x00FBDBA0
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolRewards> GetAllRewardGroups()
		{
			IReadOnlyList<SolarSchoolRewards> configList = ConfigSolarSchoolRewardsAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 获取全部奖励组配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x06038546 RID: 230726 RVA: 0x00FBF9D8 File Offset: 0x00FBDBD8
		public SolarSchoolReward? GetReward(int id)
		{
			SolarSchoolReward? config = ConfigSolarSchoolRewardById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取奖励明细配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038547 RID: 230727 RVA: 0x00FBFA28 File Offset: 0x00FBDC28
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolReward> GetAllRewards()
		{
			IReadOnlyList<SolarSchoolReward> configList = ConfigSolarSchoolRewardAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 获取全部奖励明细配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return configList;
		}

		// Token: 0x06038548 RID: 230728 RVA: 0x00FBFA60 File Offset: 0x00FBDC60
		public SolarSchoolRole? GetRole(int id)
		{
			SolarSchoolRole? config = ConfigSolarSchoolRoleById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取角色配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038549 RID: 230729 RVA: 0x00FBFAB8 File Offset: 0x00FBDCB8
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolRole> GetAllRoles(int activityId, ESolarSchoolRoleClassify classify = ESolarSchoolRoleClassify.Normal)
		{
			IReadOnlyList<SolarSchoolRole> configList = ConfigSolarSchoolRoleByActivityId.GetConfigList(activityId, true);
			if (configList == null || configList.Count == 0)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 获取全部角色配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			List<SolarSchoolRole> list = new List<SolarSchoolRole>();
			foreach (SolarSchoolRole item in configList)
			{
				if (item.Classify == (int)classify)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0603854A RID: 230730 RVA: 0x00FBFB48 File Offset: 0x00FBDD48
		public SolarSchoolRoleSchedule? GetRoleSchedule(int id)
		{
			SolarSchoolRoleSchedule? config = ConfigSolarSchoolRoleScheduleById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取角色行程配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603854B RID: 230731 RVA: 0x00FBFBA0 File Offset: 0x00FBDDA0
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolRoleSchedule> GetRoleScheduleList(int activityId)
		{
			IReadOnlyList<SolarSchoolRoleSchedule> configList = ConfigSolarSchoolRoleScheduleByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取角色行程列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x0603854C RID: 230732 RVA: 0x00FBFBE8 File Offset: 0x00FBDDE8
		public SolarSchoolQuest? GetQuest(int id)
		{
			SolarSchoolQuest? config = ConfigSolarSchoolQuestById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取任务配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603854D RID: 230733 RVA: 0x00FBFC40 File Offset: 0x00FBDE40
		public SolarSchoolQuestNode? GetQuestNode(int id)
		{
			SolarSchoolQuestNode? config = ConfigSolarSchoolQuestNodeById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取任务节点配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603854E RID: 230734 RVA: 0x00FBFC98 File Offset: 0x00FBDE98
		public SolarSchoolQuestReward? GetQuestReward(int id)
		{
			SolarSchoolQuestReward? config = ConfigSolarSchoolQuestRewardById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取任务奖励配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603854F RID: 230735 RVA: 0x00FBFCF0 File Offset: 0x00FBDEF0
		public IReadOnlyList<SolarSchoolQuest> GetQuestListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolQuest> configList = ConfigSolarSchoolQuestByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取任务列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolQuest>();
			}
			return configList;
		}

		// Token: 0x06038550 RID: 230736 RVA: 0x00FBFD40 File Offset: 0x00FBDF40
		public IReadOnlyList<SolarSchoolQuestNode> GetQuestNodeListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolQuestNode> configList = ConfigSolarSchoolQuestNodeByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取任务节点列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolQuestNode>();
			}
			return configList;
		}

		// Token: 0x06038551 RID: 230737 RVA: 0x00FBFD90 File Offset: 0x00FBDF90
		public SolarSchoolQuestDisplay? GetQuestDisplay(int id)
		{
			SolarSchoolQuestDisplay? config = ConfigSolarSchoolQuestDisplayById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取任务展示配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038552 RID: 230738 RVA: 0x00FBFDE8 File Offset: 0x00FBDFE8
		public IReadOnlyList<SolarSchoolQuestDisplay> GetQuestDisplayListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolQuestDisplay> configList = ConfigSolarSchoolQuestDisplayByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取任务展示列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolQuestDisplay>();
			}
			return configList;
		}

		// Token: 0x06038553 RID: 230739 RVA: 0x00FBFE38 File Offset: 0x00FBE038
		public unsafe SolarSchoolQuestDisplay? GetQuestDisplayByDayIndex(int activityId, int dayIndex)
		{
			foreach (SolarSchoolQuestDisplay value in this.GetQuestDisplayListByActivityId(activityId))
			{
				if (dayIndex >= value.StartDayIndex && dayIndex <= value.EndDayIndex)
				{
					return new SolarSchoolQuestDisplay?(value);
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 当前天数没有对应的任务展示时间段，检查 SolarSchoolQuestDisplay 是否无缝覆盖";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dayIndex", dayIndex);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}

		// Token: 0x06038554 RID: 230740 RVA: 0x00FBFF08 File Offset: 0x00FBE108
		public SolarSchoolLocation? GetLocation(int id)
		{
			SolarSchoolLocation? config = ConfigSolarSchoolLocationById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取地点配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038555 RID: 230741 RVA: 0x00FBFF60 File Offset: 0x00FBE160
		public IReadOnlyList<SolarSchoolLocation> GetLocationListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolLocation> configList = ConfigSolarSchoolLocationByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				return Array.Empty<SolarSchoolLocation>();
			}
			return configList;
		}

		// Token: 0x06038556 RID: 230742 RVA: 0x00FBFF80 File Offset: 0x00FBE180
		public IReadOnlyList<SolarSchoolLocation> GetLocationList(int activityId, int instanceId)
		{
			IReadOnlyList<SolarSchoolLocation> configList = ConfigSolarSchoolLocationByActivityIdAndInstanceId.GetConfigList(activityId, instanceId, true);
			if (configList == null)
			{
				return Array.Empty<SolarSchoolLocation>();
			}
			return configList;
		}

		// Token: 0x06038557 RID: 230743 RVA: 0x00FBFFA0 File Offset: 0x00FBE1A0
		public SolarSchoolLocation? GetActivityHomeLocation(int activityId)
		{
			foreach (SolarSchoolLocation value in this.GetLocationListByActivityId(activityId))
			{
				if (value.IsHome)
				{
					return new SolarSchoolLocation?(value);
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 地点表未配 IsHome 的家";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06038558 RID: 230744 RVA: 0x00FC0034 File Offset: 0x00FBE234
		public SolarSchoolLocation? GetEndLocation(int activityId, int instanceId)
		{
			foreach (SolarSchoolLocation value in this.GetLocationList(activityId, instanceId))
			{
				if (value.IsEndLocation)
				{
					return new SolarSchoolLocation?(value);
				}
			}
			return null;
		}

		// Token: 0x06038559 RID: 230745 RVA: 0x00FC009C File Offset: 0x00FBE29C
		public unsafe SolarSchoolRoleFavorLevel? GetRoleFavorLevel(int roleId, int favorLevel)
		{
			IReadOnlyList<SolarSchoolRoleFavorLevel> configList = ConfigSolarSchoolRoleFavorLevelByRoleId.GetConfigList(roleId, true);
			SolarSchoolRoleFavorLevel? result = null;
			if (configList != null)
			{
				foreach (SolarSchoolRoleFavorLevel value in configList)
				{
					if (value.FavorLevel == favorLevel)
					{
						result = new SolarSchoolRoleFavorLevel?(value);
						break;
					}
				}
			}
			if (result == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取角色好感等级配置失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("favorLevel", favorLevel);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return result;
		}

		// Token: 0x0603855A RID: 230746 RVA: 0x00FC0170 File Offset: 0x00FBE370
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolRoleFavorLevel> GetRoleFavorLevelList(int roleId)
		{
			IReadOnlyList<SolarSchoolRoleFavorLevel> configList = ConfigSolarSchoolRoleFavorLevelByRoleId.GetConfigList(roleId, true);
			if (configList == null || configList.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取角色好感等级列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x0603855B RID: 230747 RVA: 0x00FC01C0 File Offset: 0x00FBE3C0
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolRoleTalk> GetRoleTalkList(int activityId, int roleId, ESolarSchoolRoleTalkType talkType)
		{
			return ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.GetConfigList(activityId, roleId, (int)talkType, true);
		}

		// Token: 0x0603855C RID: 230748 RVA: 0x00FC01CC File Offset: 0x00FBE3CC
		public SolarSchoolRoleSpine? GetRoleSpine(int id)
		{
			SolarSchoolRoleSpine? config = ConfigSolarSchoolRoleSpineById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取角色表现配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603855D RID: 230749 RVA: 0x00FC021C File Offset: 0x00FBE41C
		public SolarSchoolShop? GetShop(int id)
		{
			SolarSchoolShop? config = ConfigSolarSchoolShopById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取商店配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603855E RID: 230750 RVA: 0x00FC026C File Offset: 0x00FBE46C
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolShop> GetShopListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolShop> configList = ConfigSolarSchoolShopByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取活动商店配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x0603855F RID: 230751 RVA: 0x00FC02B4 File Offset: 0x00FBE4B4
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolShopRefresh> GetShopRefreshListByShopId(int shopId)
		{
			IReadOnlyList<SolarSchoolShopRefresh> configList = ConfigSolarSchoolShopRefreshByShopId.GetConfigList(shopId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取商店刷新配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("shopId", shopId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x06038560 RID: 230752 RVA: 0x00FC02FC File Offset: 0x00FBE4FC
		public unsafe SolarSchoolShopRefresh? GetShopRefresh(int shopId, int week)
		{
			SolarSchoolShopRefresh? config = ConfigSolarSchoolShopRefreshByShopIdAndWeek.GetConfig(shopId, week, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取商店当前周期刷新配置失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("shopId", shopId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("week", week);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return config;
		}

		// Token: 0x06038561 RID: 230753 RVA: 0x00FC037C File Offset: 0x00FBE57C
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolShopGoods> GetShopGoodsListByGroupId(int groupId)
		{
			IReadOnlyList<SolarSchoolShopGoods> configList = ConfigSolarSchoolShopGoodsByGroupId.GetConfigList(groupId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取商店商品组配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x06038562 RID: 230754 RVA: 0x00FC03C4 File Offset: 0x00FBE5C4
		public SolarSchoolSpan? GetSpan(int id)
		{
			SolarSchoolSpan? config = ConfigSolarSchoolSpanById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取区间设定配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038563 RID: 230755 RVA: 0x00FC041C File Offset: 0x00FBE61C
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolSpan> GetSpanList(int activityId)
		{
			IReadOnlyList<SolarSchoolSpan> configList = ConfigSolarSchoolSpanByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取区间设定列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return configList;
		}

		// Token: 0x06038564 RID: 230756 RVA: 0x00FC0468 File Offset: 0x00FBE668
		public SolarSchoolAttr? GetAttr(int id)
		{
			SolarSchoolAttr? config = ConfigSolarSchoolAttrById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取属性配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038565 RID: 230757 RVA: 0x00FC04C0 File Offset: 0x00FBE6C0
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolAttr> GetAttrList(int activityId)
		{
			IReadOnlyList<SolarSchoolAttr> configList = ConfigSolarSchoolAttrByActivityId.GetConfigList(activityId, true);
			if (configList == null || configList.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取属性配置列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return configList;
		}

		// Token: 0x06038566 RID: 230758 RVA: 0x00FC0514 File Offset: 0x00FBE714
		public SolarSchoolAttr? TryGetAttrByType(int activityId, int attrType)
		{
			IReadOnlyList<SolarSchoolAttr> configList = ConfigSolarSchoolAttrByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				return null;
			}
			foreach (SolarSchoolAttr value in configList)
			{
				if (value.AttrType == attrType)
				{
					return new SolarSchoolAttr?(value);
				}
			}
			return null;
		}

		// Token: 0x06038567 RID: 230759 RVA: 0x00FC058C File Offset: 0x00FBE78C
		public bool HasAvgParam(int activityId, string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				return false;
			}
			IReadOnlyList<SolarSchoolAvgParam> configList = ConfigSolarSchoolAvgParamByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				return false;
			}
			foreach (SolarSchoolAvgParam solarSchoolAvgParam in configList)
			{
				if (solarSchoolAvgParam.Key == key)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038568 RID: 230760 RVA: 0x00FC05FC File Offset: 0x00FBE7FC
		public int GetSaveSlotCount(int activityId)
		{
			SolarSchoolActivity? config = ConfigSolarSchoolActivityById.GetConfig(activityId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取 SolarSchoolActivity 配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			return config.Value.SaveSlot;
		}

		// Token: 0x06038569 RID: 230761 RVA: 0x00FC065C File Offset: 0x00FBE85C
		public IReadOnlyList<SolarSchoolAvgParam> GetAvgParamListByActivityId(int activityId)
		{
			IReadOnlyList<SolarSchoolAvgParam> configList = ConfigSolarSchoolAvgParamByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取 SolarSchoolAvgParam 列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolAvgParam>();
			}
			return configList;
		}

		// Token: 0x0603856A RID: 230762 RVA: 0x00FC06AC File Offset: 0x00FBE8AC
		public SolarSchoolParam? GetParam(int id)
		{
			SolarSchoolParam? config = ConfigSolarSchoolParamById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取活动参数配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603856B RID: 230763 RVA: 0x00FC0704 File Offset: 0x00FBE904
		public unsafe SolarSchoolInstance? GetInstance(int activityId, int instanceId)
		{
			IReadOnlyList<SolarSchoolInstance> configList = ConfigSolarSchoolInstanceByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取副本列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			foreach (SolarSchoolInstance value in configList)
			{
				if (value.Id == instanceId)
				{
					return new SolarSchoolInstance?(value);
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "[SolarSchool] 副本主表缺该 InstanceId";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("instanceId", instanceId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}

		// Token: 0x0603856C RID: 230764 RVA: 0x00FC0814 File Offset: 0x00FBEA14
		public List<SolarSchoolOptions> GetOptionList(int activityId, int instanceId, int ownerType)
		{
			List<SolarSchoolOptions> list = new List<SolarSchoolOptions>();
			IReadOnlyList<SolarSchoolOptions> configList = ConfigSolarSchoolOptionsByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取选项列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return list;
			}
			foreach (SolarSchoolOptions item in configList)
			{
				if (item.InstanceId == instanceId && item.OwnerType == ownerType)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0603856D RID: 230765 RVA: 0x00FC08B8 File Offset: 0x00FBEAB8
		public bool HasOptionRows(int activityId, int instanceId, int ownerType, int ownerId)
		{
			IReadOnlyList<SolarSchoolOptions> configList = ConfigSolarSchoolOptionsByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				return false;
			}
			foreach (SolarSchoolOptions solarSchoolOptions in configList)
			{
				if (solarSchoolOptions.InstanceId == instanceId && solarSchoolOptions.OwnerType == ownerType && solarSchoolOptions.OwnerId == ownerId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603856E RID: 230766 RVA: 0x00FC092C File Offset: 0x00FBEB2C
		public unsafe int GetParamInt(int activityId, string key, int fallback = 0)
		{
			SolarSchoolParam? config = ConfigSolarSchoolParamByActivityIdAndKey.GetConfig(activityId, key, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 活动参数缺 Key";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return fallback;
			}
			return config.Value.IntValue;
		}

		// Token: 0x0603856F RID: 230767 RVA: 0x00FC09B8 File Offset: 0x00FBEBB8
		public unsafe int GetParamNumber(int activityId, string key, int fallback = 0)
		{
			SolarSchoolParam? config = ConfigSolarSchoolParamByActivityIdAndKey.GetConfig(activityId, key, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 活动参数缺 Key";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return fallback;
			}
			return config.Value.IntValue;
		}

		// Token: 0x06038570 RID: 230768 RVA: 0x00FC0A44 File Offset: 0x00FBEC44
		[return: Nullable(2)]
		public string TryGetParamString(int activityId, string key)
		{
			SolarSchoolParam? config = ConfigSolarSchoolParamByActivityIdAndKey.GetConfig(activityId, key, true);
			if (config == null)
			{
				return null;
			}
			return config.Value.StringValue;
		}

		// Token: 0x06038571 RID: 230769 RVA: 0x00FC0A74 File Offset: 0x00FBEC74
		public int? TryGetParamInt(int activityId, string key)
		{
			SolarSchoolParam? config = ConfigSolarSchoolParamByActivityIdAndKey.GetConfig(activityId, key, true);
			if (config == null)
			{
				return null;
			}
			return new int?(config.Value.IntValue);
		}

		// Token: 0x06038572 RID: 230770 RVA: 0x00FC0AB4 File Offset: 0x00FBECB4
		public unsafe IReadOnlyList<int> GetParamIntArray(int activityId, string key)
		{
			SolarSchoolParam? config = ConfigSolarSchoolParamByActivityIdAndKey.GetConfig(activityId, key, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 活动参数缺 Key";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return Array.Empty<int>();
			}
			return config.Value.IntArrayValue();
		}

		// Token: 0x06038573 RID: 230771 RVA: 0x00FC0B44 File Offset: 0x00FBED44
		private SolarSchoolInfluence? GetInfluence(int influenceId)
		{
			SolarSchoolInfluence? config = ConfigSolarSchoolInfluenceById.GetConfig(influenceId, true);
			if (config == null)
			{
				return null;
			}
			return config;
		}

		// Token: 0x06038574 RID: 230772 RVA: 0x00FC0B70 File Offset: 0x00FBED70
		public SolarSchoolInfluence? GetInfluence(ESolarSchoolInfluence influence)
		{
			if (influence == ESolarSchoolInfluence.None || !Enum.IsDefined(typeof(ESolarSchoolInfluence), influence))
			{
				return null;
			}
			return this.GetInfluence((int)influence);
		}

		// Token: 0x06038575 RID: 230773 RVA: 0x00FC0BA8 File Offset: 0x00FBEDA8
		public SolarSchoolInfluenceLevel? GetInfluenceLevelConfig(ESolarSchoolInfluence influence, int level)
		{
			if (influence == ESolarSchoolInfluence.None || !Enum.IsDefined(typeof(ESolarSchoolInfluence), influence) || level <= 0)
			{
				return null;
			}
			return ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.GetConfig((int)influence, level, true);
		}

		// Token: 0x06038576 RID: 230774 RVA: 0x00FC0BE8 File Offset: 0x00FBEDE8
		public IReadOnlyList<SolarSchoolFunction> GetFunctionList(int activityId)
		{
			IReadOnlyList<SolarSchoolFunction> configList = ConfigSolarSchoolFunctionByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取功能解锁列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolFunction>();
			}
			return configList;
		}

		// Token: 0x06038577 RID: 230775 RVA: 0x00FC0C38 File Offset: 0x00FBEE38
		public SolarSchoolTimeSlot? GetTimeSlot(int id)
		{
			SolarSchoolTimeSlot? config = ConfigSolarSchoolTimeSlotById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取时段配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06038578 RID: 230776 RVA: 0x00FC0C90 File Offset: 0x00FBEE90
		public SolarSchoolTimeSlot? GetTimeSlot(ESolarSchoolTimeSlot slot)
		{
			if (slot != ESolarSchoolTimeSlot.None)
			{
				return this.GetTimeSlot((int)slot);
			}
			return null;
		}

		// Token: 0x06038579 RID: 230777 RVA: 0x00FC0CB4 File Offset: 0x00FBEEB4
		public SolarSchoolDatePeriod? GetDatePeriod(int activityId, int dayIndex)
		{
			IReadOnlyList<SolarSchoolDatePeriod> configList = ConfigSolarSchoolDatePeriodByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				SolarSchoolDatePeriod? result = null;
				return result;
			}
			SolarSchoolDatePeriod? result2 = null;
			foreach (SolarSchoolDatePeriod value in configList)
			{
				if (dayIndex >= value.StartDayIndex && dayIndex <= value.EndDayIndex)
				{
					return new SolarSchoolDatePeriod?(value);
				}
				if (result2 == null || value.EndDayIndex > result2.Value.EndDayIndex)
				{
					result2 = new SolarSchoolDatePeriod?(value);
				}
			}
			if (result2 != null && dayIndex > result2.Value.EndDayIndex)
			{
				return result2;
			}
			return null;
		}

		// Token: 0x0603857A RID: 230778 RVA: 0x00FC0D88 File Offset: 0x00FBEF88
		public IReadOnlyList<SolarSchoolTimeSlot> GetTimeSlotListOrdered(int activityId)
		{
			IReadOnlyList<SolarSchoolTimeSlot> configList = ConfigSolarSchoolTimeSlotByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取时段列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolTimeSlot>();
			}
			List<SolarSchoolTimeSlot> list = new List<SolarSchoolTimeSlot>(configList);
			list.Sort((SolarSchoolTimeSlot left, SolarSchoolTimeSlot right) => left.Order.CompareTo(right.Order));
			return list;
		}

		// Token: 0x0603857B RID: 230779 RVA: 0x00FC0E00 File Offset: 0x00FBF000
		public IReadOnlyList<SolarSchoolBehaviorCategory> GetBehaviorCategoryListOrdered(int activityId)
		{
			IReadOnlyList<SolarSchoolBehaviorCategory> configList = ConfigSolarSchoolBehaviorCategoryByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取行为分类列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolBehaviorCategory>();
			}
			List<SolarSchoolBehaviorCategory> list = new List<SolarSchoolBehaviorCategory>(configList);
			list.Sort((SolarSchoolBehaviorCategory left, SolarSchoolBehaviorCategory right) => left.Sort.CompareTo(right.Sort));
			return list;
		}

		// Token: 0x0603857C RID: 230780 RVA: 0x00FC0E78 File Offset: 0x00FBF078
		public SolarSchoolEventCheck? GetEventCheck(int id)
		{
			return ConfigSolarSchoolEventCheckById.GetConfig(id, true);
		}

		// Token: 0x0603857D RID: 230781 RVA: 0x00FC0E81 File Offset: 0x00FBF081
		public SolarSchoolEventProbability? GetEventProbability(int id)
		{
			return ConfigSolarSchoolEventProbabilityById.GetConfig(id, true);
		}

		// Token: 0x0603857E RID: 230782 RVA: 0x00FC0E8C File Offset: 0x00FBF08C
		public bool TryMapEventProbability(int realPercent, out int mappedPercent)
		{
			mappedPercent = realPercent;
			IReadOnlyList<SolarSchoolEventProbability> configList = ConfigSolarSchoolEventProbabilityAll.GetConfigList(true);
			if (configList == null)
			{
				return false;
			}
			foreach (SolarSchoolEventProbability solarSchoolEventProbability in configList)
			{
				if (realPercent >= solarSchoolEventProbability.ProbabilityRangeMin && realPercent < solarSchoolEventProbability.ProbabilityRangeMax)
				{
					mappedPercent = solarSchoolEventProbability.ProbabilityMapping;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603857F RID: 230783 RVA: 0x00FC0F00 File Offset: 0x00FBF100
		public SolarSchoolEventCheckOpt? GetEventCheckOpt(int id)
		{
			return ConfigSolarSchoolEventCheckOptById.GetConfig(id, true);
		}

		// Token: 0x06038580 RID: 230784 RVA: 0x00FC0F09 File Offset: 0x00FBF109
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolEventCheckOpt> GetEventCheckOptListByGroupId(int groupId)
		{
			return ConfigSolarSchoolEventCheckOptByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x06038581 RID: 230785 RVA: 0x00FC0F12 File Offset: 0x00FBF112
		public SolarSchoolAffairs? GetAffairs(int id)
		{
			return ConfigSolarSchoolAffairsById.GetConfig(id, true);
		}

		// Token: 0x06038582 RID: 230786 RVA: 0x00FC0F1B File Offset: 0x00FBF11B
		public SolarSchoolAffairsOption? GetAffairsOption(int id)
		{
			return ConfigSolarSchoolAffairsOptionById.GetConfig(id, true);
		}

		// Token: 0x06038583 RID: 230787 RVA: 0x00FC0F24 File Offset: 0x00FBF124
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolAffairsOption> GetAffairsOptionList(int groupId)
		{
			return ConfigSolarSchoolAffairsOptionByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x06038584 RID: 230788 RVA: 0x00FC0F2D File Offset: 0x00FBF12D
		public SolarSchoolForum? GetForum(int id)
		{
			return ConfigSolarSchoolForumById.GetConfig(id, true);
		}

		// Token: 0x06038585 RID: 230789 RVA: 0x00FC0F36 File Offset: 0x00FBF136
		public SolarSchoolForumPost? GetForumPost(int id)
		{
			return ConfigSolarSchoolForumPostById.GetConfig(id, true);
		}

		// Token: 0x06038586 RID: 230790 RVA: 0x00FC0F3F File Offset: 0x00FBF13F
		public SolarSchoolLetter? GetLetter(int id)
		{
			return ConfigSolarSchoolLetterById.GetConfig(id, true);
		}

		// Token: 0x06038587 RID: 230791 RVA: 0x00FC0F48 File Offset: 0x00FBF148
		public SolarSchoolLetterPage? GetLetterPage(int id)
		{
			return ConfigSolarSchoolLetterPageById.GetConfig(id, true);
		}

		// Token: 0x06038588 RID: 230792 RVA: 0x00FC0F51 File Offset: 0x00FBF151
		public SolarSchoolExam? GetExam(int id)
		{
			return ConfigSolarSchoolExamById.GetConfig(id, true);
		}

		// Token: 0x06038589 RID: 230793 RVA: 0x00FC0F5A File Offset: 0x00FBF15A
		public SolarSchoolExam? GetExamByInstanceId(int instanceId)
		{
			return ConfigSolarSchoolExamByInstanceId.GetConfig(instanceId, true);
		}

		// Token: 0x0603858A RID: 230794 RVA: 0x00FC0F63 File Offset: 0x00FBF163
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolExamScoreRank> GetExamScoreRankListByGroupId(int groupId)
		{
			return ConfigSolarSchoolExamScoreRankByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x0603858B RID: 230795 RVA: 0x00FC0F6C File Offset: 0x00FBF16C
		public SolarSchoolExamEvent? GetExamEvent(int id)
		{
			return ConfigSolarSchoolExamEventById.GetConfig(id, true);
		}

		// Token: 0x0603858C RID: 230796 RVA: 0x00FC0F75 File Offset: 0x00FBF175
		public SolarSchoolExamChoice? GetExamChoice(int id)
		{
			return ConfigSolarSchoolExamChoiceById.GetConfig(id, true);
		}

		// Token: 0x0603858D RID: 230797 RVA: 0x00FC0F7E File Offset: 0x00FBF17E
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolExamChoice> GetExamChoiceListByGroupId(int groupId)
		{
			return ConfigSolarSchoolExamChoiceByGroupId.GetConfigList(groupId, true);
		}

		// Token: 0x0603858E RID: 230798 RVA: 0x00FC0F87 File Offset: 0x00FBF187
		public SolarSchoolPopup? GetSolarSchoolPopup(int id)
		{
			return ConfigSolarSchoolPopupById.GetConfig(id, true);
		}

		// Token: 0x0603858F RID: 230799 RVA: 0x00FC0F90 File Offset: 0x00FBF190
		public IReadOnlyList<SolarSchoolEnding> GetEndingList(int activityId)
		{
			IReadOnlyList<SolarSchoolEnding> configList = ConfigSolarSchoolEndingByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取结局列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolEnding>();
			}
			return configList;
		}

		// Token: 0x06038590 RID: 230800 RVA: 0x00FC0FE0 File Offset: 0x00FBF1E0
		public IReadOnlyList<SolarSchoolEndingFlow> GetEndingFlowList(int activityId)
		{
			IReadOnlyList<SolarSchoolEndingFlow> configList = ConfigSolarSchoolEndingFlowByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 获取结局流程列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolEndingFlow>();
			}
			return configList;
		}

		// Token: 0x06038591 RID: 230801 RVA: 0x00FC1030 File Offset: 0x00FBF230
		public SolarSchoolEndingSummary? GetEndingSummary(int activityId)
		{
			SolarSchoolEndingSummary? config = ConfigSolarSchoolEndingSummaryByActivityId.GetConfig(activityId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 获取结局总结配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038592 RID: 230802 RVA: 0x00FC1080 File Offset: 0x00FBF280
		public IReadOnlyList<SolarSchoolSummaryItem> GetEndingSummaryItemList(int activityId)
		{
			IReadOnlyList<SolarSchoolSummaryItem> configList = ConfigSolarSchoolSummaryItemByActivityId.GetConfigList(activityId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 获取结局总结条目列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return Array.Empty<SolarSchoolSummaryItem>();
			}
			List<SolarSchoolSummaryItem> list = new List<SolarSchoolSummaryItem>(configList);
			list.Sort(delegate(SolarSchoolSummaryItem left, SolarSchoolSummaryItem right)
			{
				int num = left.Sort.CompareTo(right.Sort);
				if (num == 0)
				{
					return left.Id.CompareTo(right.Id);
				}
				return num;
			});
			return list;
		}

		// Token: 0x06038593 RID: 230803 RVA: 0x00FC10F8 File Offset: 0x00FBF2F8
		public SolarSchoolScratchTicketCo? GetScratchTicket(int gameplayId)
		{
			SolarSchoolScratchTicketCo? config = ConfigSolarSchoolScratchTicketCoByRoundId.GetConfig(gameplayId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.HHJ;
				string message = "[SolarSchool][ScratchTicket] 读刮卡主配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gameplayId", gameplayId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038594 RID: 230804 RVA: 0x00FC1148 File Offset: 0x00FBF348
		[NullableContext(2)]
		public IReadOnlyList<SolarSchoolScratchTicketRe> GetScratchTicketRewardList(int roundId)
		{
			IReadOnlyList<SolarSchoolScratchTicketRe> configList = ConfigSolarSchoolScratchTicketReAll.GetConfigList(true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.HHJ;
				string message = "[SolarSchool][ScratchTicket] 读刮卡奖励列表失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roundId", roundId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			List<SolarSchoolScratchTicketRe> list = new List<SolarSchoolScratchTicketRe>();
			foreach (SolarSchoolScratchTicketRe item in configList)
			{
				if (item.RoundId == roundId)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06038595 RID: 230805 RVA: 0x00FC11E0 File Offset: 0x00FBF3E0
		[NullableContext(2)]
		public string GetRewardIconPath(SolarSchoolReward reward)
		{
			ESolarSchoolRewardType rewardType = (ESolarSchoolRewardType)reward.RewardType;
			if (rewardType != ESolarSchoolRewardType.PlayerAttr)
			{
				if (rewardType != ESolarSchoolRewardType.Item)
				{
					return null;
				}
				if (this.GetItem(reward.TargetId) == null)
				{
					return null;
				}
				SolarSchoolItem? solarSchoolItem;
				return solarSchoolItem.GetValueOrDefault().Icon;
			}
			else
			{
				if (this.GetAttr(reward.TargetId) == null)
				{
					return null;
				}
				SolarSchoolAttr? solarSchoolAttr;
				return solarSchoolAttr.GetValueOrDefault().YellowIconSmall;
			}
		}

		// Token: 0x06038596 RID: 230806 RVA: 0x00FC1250 File Offset: 0x00FBF450
		public PrizeActivity? GetPrizeActivityById(int id)
		{
			PrizeActivity? config = ConfigPrizeActivityById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取一番赏活动配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06038597 RID: 230807 RVA: 0x00FC12A0 File Offset: 0x00FBF4A0
		public PrizeAwardsGroup? GetPrizeAwardsGroupById(int id)
		{
			PrizeAwardsGroup? config = ConfigPrizeAwardsGroupById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 获取一番赏奖励组配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x17006BE2 RID: 27618
		// (get) Token: 0x06038598 RID: 230808 RVA: 0x00FC12EE File Offset: 0x00FBF4EE
		public static SolarSchoolConfig Instance
		{
			get
			{
				return SolarSchoolConfig._Instance;
			}
		}

		// Token: 0x06038599 RID: 230809 RVA: 0x00FC12F5 File Offset: 0x00FBF4F5
		public static SolarSchoolConfig GetOrCreateInstance()
		{
			if (SolarSchoolConfig._Instance == null)
			{
				SolarSchoolConfig.CreateInstance();
			}
			return SolarSchoolConfig._Instance;
		}

		// Token: 0x0603859A RID: 230810 RVA: 0x00FC1309 File Offset: 0x00FBF509
		public static bool CreateInstance()
		{
			if (SolarSchoolConfig._Instance != null)
			{
				return true;
			}
			SolarSchoolConfig._Instance = new SolarSchoolConfig();
			return true;
		}

		// Token: 0x0603859B RID: 230811 RVA: 0x00FC131F File Offset: 0x00FBF51F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603859C RID: 230812 RVA: 0x00FC1321 File Offset: 0x00FBF521
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolConfig._Instance = null;
		}

		// Token: 0x0603859D RID: 230813 RVA: 0x00FC1329 File Offset: 0x00FBF529
		static SolarSchoolConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolConfig.CreateStaticDefaultValue), new Action(SolarSchoolConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401DA95 RID: 121493
		[Nullable(2)]
		private static SolarSchoolConfig _Instance;
	}
}
