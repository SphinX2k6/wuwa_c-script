using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000818 RID: 2072
	public class ConfigRhythmTaskByActivityIdAndTaskTab : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030A2 RID: 12450 RVA: 0x0016F9AF File Offset: 0x0016DBAF
		static ConfigRhythmTaskByActivityIdAndTaskTab()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmTaskByActivityIdAndTaskTab.CreateStaticDefaultValue), new Action(ConfigRhythmTaskByActivityIdAndTaskTab.ResetStaticDefaultValue));
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x0016F9D0 File Offset: 0x0016DBD0
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmTaskByActivityIdAndTaskTab.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmTaskByActivityIdAndTaskTab.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmTask` where ActivityId=? And TaskTab=?")
			});
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x0016FA4F File Offset: 0x0016DC4F
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmTaskByActivityIdAndTaskTab.LogPair = null;
			ConfigRhythmTaskByActivityIdAndTaskTab.HandleId = 0;
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0016FA5D File Offset: 0x0016DC5D
		public static void Init()
		{
			ConfigRhythmTaskByActivityIdAndTaskTab.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, "db_rhythmship.db", "select BinData from `RhythmTask` where ActivityId=? And TaskTab=?");
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x0016FA78 File Offset: 0x0016DC78
		[NullableContext(2)]
		public static IReadOnlyList<RhythmTask> GetConfigList(int p0ActivityId, int p1TaskTab, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskByActivityIdAndTaskTab");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TaskTab);
				IReadOnlyList<RhythmTask> readOnlyList = (IReadOnlyList<RhythmTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRhythmTaskByActivityIdAndTaskTab.LogPair.Clear();
			ConfigRhythmTaskByActivityIdAndTaskTab.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigRhythmTaskByActivityIdAndTaskTab.LogPair.Add(new ValueTuple<string, object>("TaskTab", p1TaskTab));
			if (!ConfigCommon.BindInt(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, 1, p0ActivityId, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair) || !ConfigCommon.BindInt(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, 2, p1TaskTab, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair))
			{
				ConfigCommon.Reset(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair);
				return null;
			}
			List<RhythmTask> list = new List<RhythmTask>();
			while (ConfigCommon.Step(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, false, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, 0, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair);
					return null;
				}
				RhythmTask rootAsRhythmTask = RhythmTask.GetRootAsRhythmTask(new ByteBuffer(item2));
				list.Add(rootAsRhythmTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskByActivityIdAndTaskTab");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TaskTab);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmTaskByActivityIdAndTaskTab.HandleId, ConfigRhythmTaskByActivityIdAndTaskTab.LogPair);
			return list;
		}

		// Token: 0x0400388E RID: 14478
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400388F RID: 14479
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003890 RID: 14480
		private const string TABLE = "RhythmTask";

		// Token: 0x04003891 RID: 14481
		private const string COMMAND = "select BinData from `RhythmTask` where ActivityId=? And TaskTab=?";

		// Token: 0x04003892 RID: 14482
		private const string KEY_PREFIX = "RhythmTaskByActivityIdAndTaskTab";

		// Token: 0x04003893 RID: 14483
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003894 RID: 14484
		private static int HandleId;
	}
}
