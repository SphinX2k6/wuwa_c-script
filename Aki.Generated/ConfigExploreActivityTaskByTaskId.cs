using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A8 RID: 680
	public class ConfigExploreActivityTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FF5 RID: 4085 RVA: 0x000B7487 File Offset: 0x000B5687
		static ConfigExploreActivityTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreActivityTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigExploreActivityTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x000B74A8 File Offset: 0x000B56A8
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

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000B7527 File Offset: 0x000B5727
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreActivityTaskByTaskId.LogPair = null;
			ConfigExploreActivityTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000B7535 File Offset: 0x000B5735
		public static void Init()
		{
			ConfigExploreActivityTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigExploreActivityTaskByTaskId.HandleId, "db_exploreactivity.db", "select BinData from `ExploreActivityTask` where TaskId=?");
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000B7550 File Offset: 0x000B5750
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

		// Token: 0x0400127C RID: 4732
		private const string DB = "db_exploreactivity.db";

		// Token: 0x0400127D RID: 4733
		private const string FILE = "t.探索度活动.xlsx";

		// Token: 0x0400127E RID: 4734
		private const string TABLE = "ExploreActivityTask";

		// Token: 0x0400127F RID: 4735
		private const string COMMAND = "select BinData from `ExploreActivityTask` where TaskId=?";

		// Token: 0x04001280 RID: 4736
		private const string KEY_PREFIX = "ExploreActivityTaskByTaskId";

		// Token: 0x04001281 RID: 4737
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001282 RID: 4738
		private static int HandleId;
	}
}
