using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA6 RID: 2726
	public class ConfigWuWuWeekTaskByWrapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FF9 RID: 16377 RVA: 0x001C4160 File Offset: 0x001C2360
		static ConfigWuWuWeekTaskByWrapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuWeekTaskByWrapId.CreateStaticDefaultValue), new Action(ConfigWuWuWeekTaskByWrapId.ResetStaticDefaultValue));
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x001C4180 File Offset: 0x001C2380
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuWeekTaskByWrapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuWeekTaskByWrapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuWeekTask"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuWeekTask` where WrapId=?")
			});
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x001C41FF File Offset: 0x001C23FF
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuWeekTaskByWrapId.LogPair = null;
			ConfigWuWuWeekTaskByWrapId.HandleId = 0;
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x001C420D File Offset: 0x001C240D
		public static void Init()
		{
			ConfigWuWuWeekTaskByWrapId.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuWeekTaskByWrapId.HandleId, "db_wuwutask.db", "select BinData from `WuWuWeekTask` where WrapId=?");
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x001C4228 File Offset: 0x001C2428
		[NullableContext(2)]
		public static IReadOnlyList<WuWuWeekTask> GetConfigList(int p0WrapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuWeekTaskByWrapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WrapId);
				IReadOnlyList<WuWuWeekTask> readOnlyList = (IReadOnlyList<WuWuWeekTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWuWuWeekTaskByWrapId.LogPair.Clear();
			ConfigWuWuWeekTaskByWrapId.LogPair.Add(new ValueTuple<string, object>("WrapId", p0WrapId));
			if (!ConfigCommon.BindInt(ConfigWuWuWeekTaskByWrapId.HandleId, 1, p0WrapId, ConfigWuWuWeekTaskByWrapId.LogPair))
			{
				ConfigCommon.Reset(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair);
				return null;
			}
			List<WuWuWeekTask> list = new List<WuWuWeekTask>();
			while (ConfigCommon.Step(ConfigWuWuWeekTaskByWrapId.HandleId, false, ConfigWuWuWeekTaskByWrapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuWeekTaskByWrapId.HandleId, 0, ConfigWuWuWeekTaskByWrapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair);
					return null;
				}
				WuWuWeekTask rootAsWuWuWeekTask = WuWuWeekTask.GetRootAsWuWuWeekTask(new ByteBuffer(item2));
				list.Add(rootAsWuWuWeekTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuWeekTaskByWrapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WrapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair);
			return list;
		}

		// Token: 0x04004A70 RID: 19056
		private const string DB = "db_wuwutask.db";

		// Token: 0x04004A71 RID: 19057
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04004A72 RID: 19058
		private const string TABLE = "WuWuWeekTask";

		// Token: 0x04004A73 RID: 19059
		private const string COMMAND = "select BinData from `WuWuWeekTask` where WrapId=?";

		// Token: 0x04004A74 RID: 19060
		private const string KEY_PREFIX = "WuWuWeekTaskByWrapId";

		// Token: 0x04004A75 RID: 19061
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A76 RID: 19062
		private static int HandleId;
	}
}
