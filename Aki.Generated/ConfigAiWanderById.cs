using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000098 RID: 152
	public class ConfigAiWanderById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00071360 File Offset: 0x0006F560
		static ConfigAiWanderById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiWanderById.CreateStaticDefaultValue), new Action(ConfigAiWanderById.ResetStaticDefaultValue));
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00071380 File Offset: 0x0006F580
		public static void CreateStaticDefaultValue()
		{
			ConfigAiWanderById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiWanderById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI脱战游荡.xlsx"),
				new ValueTuple<string, object>("表名", "AiWander"),
				new ValueTuple<string, object>("语句", "select BinData from `AiWander` where Id=?")
			});
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000713FF File Offset: 0x0006F5FF
		public static void ResetStaticDefaultValue()
		{
			ConfigAiWanderById.LogPair = null;
			ConfigAiWanderById.HandleId = 0;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0007140D File Offset: 0x0006F60D
		public static void Init()
		{
			ConfigAiWanderById.HandleId = ConfigCommon.InitDataStatement(ConfigAiWanderById.HandleId, "db_ai.db", "select BinData from `AiWander` where Id=?");
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00071428 File Offset: 0x0006F628
		public static AiWander? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiWanderById.HandleId, ConfigAiWanderById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiWanderById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiWander?(AiWander.GetRootAsAiWander(configBuffer));
				}
			}
			ConfigAiWanderById.LogPair.Clear();
			ConfigAiWanderById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiWanderById.HandleId, 1, p0Id, ConfigAiWanderById.LogPair) || ConfigCommon.Step(ConfigAiWanderById.HandleId, true, ConfigAiWanderById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiWanderById.HandleId, ConfigAiWanderById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiWanderById.HandleId, 0, ConfigAiWanderById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiWanderById.HandleId, ConfigAiWanderById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiWander rootAsAiWander = AiWander.GetRootAsAiWander(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiWanderById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiWanderById.HandleId, ConfigAiWanderById.LogPair);
			return new AiWander?(rootAsAiWander);
		}

		// Token: 0x0400040C RID: 1036
		private const string DB = "db_ai.db";

		// Token: 0x0400040D RID: 1037
		private const string FILE = "a.AI脱战游荡.xlsx";

		// Token: 0x0400040E RID: 1038
		private const string TABLE = "AiWander";

		// Token: 0x0400040F RID: 1039
		private const string COMMAND = "select BinData from `AiWander` where Id=?";

		// Token: 0x04000410 RID: 1040
		private const string KEY_PREFIX = "AiWanderById";

		// Token: 0x04000411 RID: 1041
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000412 RID: 1042
		private static int HandleId;
	}
}
