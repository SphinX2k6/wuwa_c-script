using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B5 RID: 949
	public class ConfigGivebackTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001645 RID: 5701 RVA: 0x000DB04B File Offset: 0x000D924B
		static ConfigGivebackTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGivebackTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigGivebackTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000DB06C File Offset: 0x000D926C
		public static void CreateStaticDefaultValue()
		{
			ConfigGivebackTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGivebackTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feedbackreward.db"),
				new ValueTuple<string, object>("文件", "l.老玩家回馈.xlsx"),
				new ValueTuple<string, object>("表名", "GivebackTask"),
				new ValueTuple<string, object>("语句", "select BinData from `GivebackTask` where TaskId=?")
			});
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000DB0EB File Offset: 0x000D92EB
		public static void ResetStaticDefaultValue()
		{
			ConfigGivebackTaskByTaskId.LogPair = null;
			ConfigGivebackTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000DB0F9 File Offset: 0x000D92F9
		public static void Init()
		{
			ConfigGivebackTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigGivebackTaskByTaskId.HandleId, "db_feedbackreward.db", "select BinData from `GivebackTask` where TaskId=?");
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000DB114 File Offset: 0x000D9314
		public static GivebackTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GivebackTask?(GivebackTask.GetRootAsGivebackTask(configBuffer));
				}
			}
			ConfigGivebackTaskByTaskId.LogPair.Clear();
			ConfigGivebackTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigGivebackTaskByTaskId.HandleId, 1, p0TaskId, ConfigGivebackTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigGivebackTaskByTaskId.HandleId, true, ConfigGivebackTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGivebackTaskByTaskId.HandleId, 0, ConfigGivebackTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GivebackTask rootAsGivebackTask = GivebackTask.GetRootAsGivebackTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair);
			return new GivebackTask?(rootAsGivebackTask);
		}

		// Token: 0x040019D7 RID: 6615
		private const string DB = "db_feedbackreward.db";

		// Token: 0x040019D8 RID: 6616
		private const string FILE = "l.老玩家回馈.xlsx";

		// Token: 0x040019D9 RID: 6617
		private const string TABLE = "GivebackTask";

		// Token: 0x040019DA RID: 6618
		private const string COMMAND = "select BinData from `GivebackTask` where TaskId=?";

		// Token: 0x040019DB RID: 6619
		private const string KEY_PREFIX = "GivebackTaskByTaskId";

		// Token: 0x040019DC RID: 6620
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019DD RID: 6621
		private static int HandleId;
	}
}
