using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000090 RID: 144
	public class ConfigAiWanderById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0006CAAC File Offset: 0x0006ACAC
		static ConfigAiWanderById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiWanderById.CreateStaticDefaultValue), new Action(ConfigAiWanderById.ResetStaticDefaultValue));
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0006CACC File Offset: 0x0006ACCC
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

		// Token: 0x06000362 RID: 866 RVA: 0x0006CB4B File Offset: 0x0006AD4B
		public static void ResetStaticDefaultValue()
		{
			ConfigAiWanderById.LogPair = null;
			ConfigAiWanderById.HandleId = 0;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0006CB59 File Offset: 0x0006AD59
		public static void Init()
		{
			ConfigAiWanderById.HandleId = ConfigCommon.InitDataStatement(ConfigAiWanderById.HandleId, "db_ai.db", "select BinData from `AiWander` where Id=?");
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0006CB74 File Offset: 0x0006AD74
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

		// Token: 0x040003D4 RID: 980
		private const string DB = "db_ai.db";

		// Token: 0x040003D5 RID: 981
		private const string FILE = "a.AI脱战游荡.xlsx";

		// Token: 0x040003D6 RID: 982
		private const string TABLE = "AiWander";

		// Token: 0x040003D7 RID: 983
		private const string COMMAND = "select BinData from `AiWander` where Id=?";

		// Token: 0x040003D8 RID: 984
		private const string KEY_PREFIX = "AiWanderById";

		// Token: 0x040003D9 RID: 985
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003DA RID: 986
		private static int HandleId;
	}
}
