using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E7 RID: 743
	public class ConfigFishingActivityLimitTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x000BF82C File Offset: 0x000BDA2C
		static ConfigFishingActivityLimitTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityLimitTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigFishingActivityLimitTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000BF84C File Offset: 0x000BDA4C
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingActivityLimitTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingActivityLimitTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼大活动.xlsx"),
				new ValueTuple<string, object>("表名", "FishingActivityLimitTask"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingActivityLimitTask` where TaskId=?")
			});
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000BF8CB File Offset: 0x000BDACB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityLimitTaskByTaskId.LogPair = null;
			ConfigFishingActivityLimitTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000BF8D9 File Offset: 0x000BDAD9
		public static void Init()
		{
			ConfigFishingActivityLimitTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityLimitTaskByTaskId.HandleId, "db_fishing.db", "select BinData from `FishingActivityLimitTask` where TaskId=?");
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000BF8F4 File Offset: 0x000BDAF4
		public static FishingActivityLimitTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityLimitTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingActivityLimitTask?(FishingActivityLimitTask.GetRootAsFishingActivityLimitTask(configBuffer));
				}
			}
			ConfigFishingActivityLimitTaskByTaskId.LogPair.Clear();
			ConfigFishingActivityLimitTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigFishingActivityLimitTaskByTaskId.HandleId, 1, p0TaskId, ConfigFishingActivityLimitTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigFishingActivityLimitTaskByTaskId.HandleId, true, ConfigFishingActivityLimitTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingActivityLimitTaskByTaskId.HandleId, 0, ConfigFishingActivityLimitTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingActivityLimitTask rootAsFishingActivityLimitTask = FishingActivityLimitTask.GetRootAsFishingActivityLimitTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityLimitTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair);
			return new FishingActivityLimitTask?(rootAsFishingActivityLimitTask);
		}

		// Token: 0x04001435 RID: 5173
		private const string DB = "db_fishing.db";

		// Token: 0x04001436 RID: 5174
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x04001437 RID: 5175
		private const string TABLE = "FishingActivityLimitTask";

		// Token: 0x04001438 RID: 5176
		private const string COMMAND = "select BinData from `FishingActivityLimitTask` where TaskId=?";

		// Token: 0x04001439 RID: 5177
		private const string KEY_PREFIX = "FishingActivityLimitTaskByTaskId";

		// Token: 0x0400143A RID: 5178
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400143B RID: 5179
		private static int HandleId;
	}
}
