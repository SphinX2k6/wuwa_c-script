using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000819 RID: 2073
	public class ConfigRhythmTaskByActivityIdAndTaskType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030A8 RID: 12456 RVA: 0x0016FC3F File Offset: 0x0016DE3F
		static ConfigRhythmTaskByActivityIdAndTaskType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmTaskByActivityIdAndTaskType.CreateStaticDefaultValue), new Action(ConfigRhythmTaskByActivityIdAndTaskType.ResetStaticDefaultValue));
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0016FC60 File Offset: 0x0016DE60
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmTaskByActivityIdAndTaskType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmTaskByActivityIdAndTaskType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmTask` where ActivityId=? And TaskType=?")
			});
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x0016FCDF File Offset: 0x0016DEDF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmTaskByActivityIdAndTaskType.LogPair = null;
			ConfigRhythmTaskByActivityIdAndTaskType.HandleId = 0;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0016FCED File Offset: 0x0016DEED
		public static void Init()
		{
			ConfigRhythmTaskByActivityIdAndTaskType.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, "db_rhythmship.db", "select BinData from `RhythmTask` where ActivityId=? And TaskType=?");
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0016FD08 File Offset: 0x0016DF08
		[NullableContext(2)]
		public static IReadOnlyList<RhythmTask> GetConfigList(int p0ActivityId, int p1TaskType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, ConfigRhythmTaskByActivityIdAndTaskType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskByActivityIdAndTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TaskType);
				IReadOnlyList<RhythmTask> readOnlyList = (IReadOnlyList<RhythmTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRhythmTaskByActivityIdAndTaskType.LogPair.Clear();
			ConfigRhythmTaskByActivityIdAndTaskType.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigRhythmTaskByActivityIdAndTaskType.LogPair.Add(new ValueTuple<string, object>("TaskType", p1TaskType));
			if (!ConfigCommon.BindInt(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, 1, p0ActivityId, ConfigRhythmTaskByActivityIdAndTaskType.LogPair) || !ConfigCommon.BindInt(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, 2, p1TaskType, ConfigRhythmTaskByActivityIdAndTaskType.LogPair))
			{
				ConfigCommon.Reset(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, ConfigRhythmTaskByActivityIdAndTaskType.LogPair);
				return null;
			}
			List<RhythmTask> list = new List<RhythmTask>();
			while (ConfigCommon.Step(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, false, ConfigRhythmTaskByActivityIdAndTaskType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, 0, ConfigRhythmTaskByActivityIdAndTaskType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, ConfigRhythmTaskByActivityIdAndTaskType.LogPair);
					return null;
				}
				RhythmTask rootAsRhythmTask = RhythmTask.GetRootAsRhythmTask(new ByteBuffer(item2));
				list.Add(rootAsRhythmTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskByActivityIdAndTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TaskType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, ConfigRhythmTaskByActivityIdAndTaskType.LogPair);
			return list;
		}

		// Token: 0x04003895 RID: 14485
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003896 RID: 14486
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003897 RID: 14487
		private const string TABLE = "RhythmTask";

		// Token: 0x04003898 RID: 14488
		private const string COMMAND = "select BinData from `RhythmTask` where ActivityId=? And TaskType=?";

		// Token: 0x04003899 RID: 14489
		private const string KEY_PREFIX = "RhythmTaskByActivityIdAndTaskType";

		// Token: 0x0400389A RID: 14490
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400389B RID: 14491
		private static int HandleId;
	}
}
