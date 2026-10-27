using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000091 RID: 145
	public class ConfigAiWanderRadiusConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000366 RID: 870 RVA: 0x0006CCF4 File Offset: 0x0006AEF4
		static ConfigAiWanderRadiusConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiWanderRadiusConfigById.CreateStaticDefaultValue), new Action(ConfigAiWanderRadiusConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0006CD14 File Offset: 0x0006AF14
		public static void CreateStaticDefaultValue()
		{
			ConfigAiWanderRadiusConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiWanderRadiusConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI脱战游荡.xlsx"),
				new ValueTuple<string, object>("表名", "AiWanderRadiusConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `AiWanderRadiusConfig` where Id=?")
			});
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0006CD93 File Offset: 0x0006AF93
		public static void ResetStaticDefaultValue()
		{
			ConfigAiWanderRadiusConfigById.LogPair = null;
			ConfigAiWanderRadiusConfigById.HandleId = 0;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0006CDA1 File Offset: 0x0006AFA1
		public static void Init()
		{
			ConfigAiWanderRadiusConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAiWanderRadiusConfigById.HandleId, "db_ai.db", "select BinData from `AiWanderRadiusConfig` where Id=?");
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0006CDBC File Offset: 0x0006AFBC
		public static AiWanderRadiusConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiWanderRadiusConfigById.HandleId, ConfigAiWanderRadiusConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiWanderRadiusConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiWanderRadiusConfig?(AiWanderRadiusConfig.GetRootAsAiWanderRadiusConfig(configBuffer));
				}
			}
			ConfigAiWanderRadiusConfigById.LogPair.Clear();
			ConfigAiWanderRadiusConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiWanderRadiusConfigById.HandleId, 1, p0Id, ConfigAiWanderRadiusConfigById.LogPair) || ConfigCommon.Step(ConfigAiWanderRadiusConfigById.HandleId, true, ConfigAiWanderRadiusConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiWanderRadiusConfigById.HandleId, ConfigAiWanderRadiusConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiWanderRadiusConfigById.HandleId, 0, ConfigAiWanderRadiusConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiWanderRadiusConfigById.HandleId, ConfigAiWanderRadiusConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiWanderRadiusConfig rootAsAiWanderRadiusConfig = AiWanderRadiusConfig.GetRootAsAiWanderRadiusConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiWanderRadiusConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiWanderRadiusConfigById.HandleId, ConfigAiWanderRadiusConfigById.LogPair);
			return new AiWanderRadiusConfig?(rootAsAiWanderRadiusConfig);
		}

		// Token: 0x040003DB RID: 987
		private const string DB = "db_ai.db";

		// Token: 0x040003DC RID: 988
		private const string FILE = "a.AI脱战游荡.xlsx";

		// Token: 0x040003DD RID: 989
		private const string TABLE = "AiWanderRadiusConfig";

		// Token: 0x040003DE RID: 990
		private const string COMMAND = "select BinData from `AiWanderRadiusConfig` where Id=?";

		// Token: 0x040003DF RID: 991
		private const string KEY_PREFIX = "AiWanderRadiusConfigById";

		// Token: 0x040003E0 RID: 992
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003E1 RID: 993
		private static int HandleId;
	}
}
