using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FD RID: 2045
	public class ConfigRhythmTaskByActivityIdAndTaskType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003000 RID: 12288 RVA: 0x00168957 File Offset: 0x00166B57
		static ConfigRhythmTaskByActivityIdAndTaskType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmTaskByActivityIdAndTaskType.CreateStaticDefaultValue), new Action(ConfigRhythmTaskByActivityIdAndTaskType.ResetStaticDefaultValue));
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x00168978 File Offset: 0x00166B78
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

		// Token: 0x06003002 RID: 12290 RVA: 0x001689F7 File Offset: 0x00166BF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmTaskByActivityIdAndTaskType.LogPair = null;
			ConfigRhythmTaskByActivityIdAndTaskType.HandleId = 0;
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x00168A05 File Offset: 0x00166C05
		public static void Init()
		{
			ConfigRhythmTaskByActivityIdAndTaskType.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmTaskByActivityIdAndTaskType.HandleId, "db_rhythmship.db", "select BinData from `RhythmTask` where ActivityId=? And TaskType=?");
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x00168A20 File Offset: 0x00166C20
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

		// Token: 0x040037D1 RID: 14289
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037D2 RID: 14290
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037D3 RID: 14291
		private const string TABLE = "RhythmTask";

		// Token: 0x040037D4 RID: 14292
		private const string COMMAND = "select BinData from `RhythmTask` where ActivityId=? And TaskType=?";

		// Token: 0x040037D5 RID: 14293
		private const string KEY_PREFIX = "RhythmTaskByActivityIdAndTaskType";

		// Token: 0x040037D6 RID: 14294
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037D7 RID: 14295
		private static int HandleId;
	}
}
