using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000294 RID: 660
	public class ConfigExploreActivityTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x000B11C3 File Offset: 0x000AF3C3
		static ConfigExploreActivityTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreActivityTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigExploreActivityTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000B11E4 File Offset: 0x000AF3E4
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreActivityTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreActivityTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_exploreactivity.db"),
				new ValueTuple<string, object>("文件", "t.探索度活动.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreActivityTask"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreActivityTask` where TaskId=?")
			});
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000B1263 File Offset: 0x000AF463
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreActivityTaskByTaskId.LogPair = null;
			ConfigExploreActivityTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x000B1271 File Offset: 0x000AF471
		public static void Init()
		{
			ConfigExploreActivityTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigExploreActivityTaskByTaskId.HandleId, "db_exploreactivity.db", "select BinData from `ExploreActivityTask` where TaskId=?");
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000B128C File Offset: 0x000AF48C
		public static ExploreActivityTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreActivityTaskByTaskId.HandleId, ConfigExploreActivityTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreActivityTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreActivityTask?(ExploreActivityTask.GetRootAsExploreActivityTask(configBuffer));
				}
			}
			ConfigExploreActivityTaskByTaskId.LogPair.Clear();
			ConfigExploreActivityTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigExploreActivityTaskByTaskId.HandleId, 1, p0TaskId, ConfigExploreActivityTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigExploreActivityTaskByTaskId.HandleId, true, ConfigExploreActivityTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreActivityTaskByTaskId.HandleId, ConfigExploreActivityTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreActivityTaskByTaskId.HandleId, 0, ConfigExploreActivityTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreActivityTaskByTaskId.HandleId, ConfigExploreActivityTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreActivityTask rootAsExploreActivityTask = ExploreActivityTask.GetRootAsExploreActivityTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreActivityTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreActivityTaskByTaskId.HandleId, ConfigExploreActivityTaskByTaskId.LogPair);
			return new ExploreActivityTask?(rootAsExploreActivityTask);
		}

		// Token: 0x040011F0 RID: 4592
		private const string DB = "db_exploreactivity.db";

		// Token: 0x040011F1 RID: 4593
		private const string FILE = "t.探索度活动.xlsx";

		// Token: 0x040011F2 RID: 4594
		private const string TABLE = "ExploreActivityTask";

		// Token: 0x040011F3 RID: 4595
		private const string COMMAND = "select BinData from `ExploreActivityTask` where TaskId=?";

		// Token: 0x040011F4 RID: 4596
		private const string KEY_PREFIX = "ExploreActivityTaskByTaskId";

		// Token: 0x040011F5 RID: 4597
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011F6 RID: 4598
		private static int HandleId;
	}
}
