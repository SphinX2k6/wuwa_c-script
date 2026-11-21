using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000099 RID: 153
	public class ConfigAiWanderRadiusConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000396 RID: 918 RVA: 0x000715A8 File Offset: 0x0006F7A8
		static ConfigAiWanderRadiusConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiWanderRadiusConfigById.CreateStaticDefaultValue), new Action(ConfigAiWanderRadiusConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000715C8 File Offset: 0x0006F7C8
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

		// Token: 0x06000398 RID: 920 RVA: 0x00071647 File Offset: 0x0006F847
		public static void ResetStaticDefaultValue()
		{
			ConfigAiWanderRadiusConfigById.LogPair = null;
			ConfigAiWanderRadiusConfigById.HandleId = 0;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00071655 File Offset: 0x0006F855
		public static void Init()
		{
			ConfigAiWanderRadiusConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAiWanderRadiusConfigById.HandleId, "db_ai.db", "select BinData from `AiWanderRadiusConfig` where Id=?");
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00071670 File Offset: 0x0006F870
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

		// Token: 0x04000413 RID: 1043
		private const string DB = "db_ai.db";

		// Token: 0x04000414 RID: 1044
		private const string FILE = "a.AI脱战游荡.xlsx";

		// Token: 0x04000415 RID: 1045
		private const string TABLE = "AiWanderRadiusConfig";

		// Token: 0x04000416 RID: 1046
		private const string COMMAND = "select BinData from `AiWanderRadiusConfig` where Id=?";

		// Token: 0x04000417 RID: 1047
		private const string KEY_PREFIX = "AiWanderRadiusConfigById";

		// Token: 0x04000418 RID: 1048
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000419 RID: 1049
		private static int HandleId;
	}
}
