using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000045 RID: 69
	public class ConfigActivityConditionGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0006660B File Offset: 0x0006480B
		static ConfigActivityConditionGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityConditionGroupAll.CreateStaticDefaultValue), new Action(ConfigActivityConditionGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0006662C File Offset: 0x0006482C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityConditionGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityConditionGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitycondition.db"),
				new ValueTuple<string, object>("文件", "h.活动条件.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityConditionGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityConditionGroup`")
			});
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000666AB File Offset: 0x000648AB
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityConditionGroupAll.LogPair = null;
			ConfigActivityConditionGroupAll.HandleId = 0;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000666B9 File Offset: 0x000648B9
		public static void Init()
		{
			ConfigActivityConditionGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityConditionGroupAll.HandleId, "db_activitycondition.db", "select BinData from `ActivityConditionGroup`");
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000666D4 File Offset: 0x000648D4
		[NullableContext(2)]
		public static IReadOnlyList<ActivityConditionGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityConditionGroupAll.HandleId, ConfigActivityConditionGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityConditionGroup> readOnlyList = (IReadOnlyList<ActivityConditionGroup>)ConfigCommon.GetConfig("ActivityConditionGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityConditionGroup> list = new List<ActivityConditionGroup>();
			while (ConfigCommon.Step(ConfigActivityConditionGroupAll.HandleId, false, ConfigActivityConditionGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityConditionGroupAll.HandleId, 0, ConfigActivityConditionGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityConditionGroupAll.HandleId, ConfigActivityConditionGroupAll.LogPair);
					return null;
				}
				ActivityConditionGroup rootAsActivityConditionGroup = ActivityConditionGroup.GetRootAsActivityConditionGroup(new ByteBuffer(item2));
				list.Add(rootAsActivityConditionGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityConditionGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityConditionGroupAll.HandleId, ConfigActivityConditionGroupAll.LogPair);
			return list;
		}

		// Token: 0x040001C7 RID: 455
		private const string DB = "db_activitycondition.db";

		// Token: 0x040001C8 RID: 456
		private const string FILE = "h.活动条件.xlsx";

		// Token: 0x040001C9 RID: 457
		private const string TABLE = "ActivityConditionGroup";

		// Token: 0x040001CA RID: 458
		private const string COMMAND = "select BinData from `ActivityConditionGroup`";

		// Token: 0x040001CB RID: 459
		private const string KEY_PREFIX = "ActivityConditionGroupAll";

		// Token: 0x040001CC RID: 460
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001CD RID: 461
		private static int HandleId;
	}
}
