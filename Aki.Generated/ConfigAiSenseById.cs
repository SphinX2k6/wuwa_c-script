using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000090 RID: 144
	public class ConfigAiSenseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000360 RID: 864 RVA: 0x00070170 File Offset: 0x0006E370
		static ConfigAiSenseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiSenseById.CreateStaticDefaultValue), new Action(ConfigAiSenseById.ResetStaticDefaultValue));
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00070190 File Offset: 0x0006E390
		public static void CreateStaticDefaultValue()
		{
			ConfigAiSenseById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiSenseById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI感知.xlsx"),
				new ValueTuple<string, object>("表名", "AiSense"),
				new ValueTuple<string, object>("语句", "select BinData from `AiSense` where Id=?")
			});
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0007020F File Offset: 0x0006E40F
		public static void ResetStaticDefaultValue()
		{
			ConfigAiSenseById.LogPair = null;
			ConfigAiSenseById.HandleId = 0;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0007021D File Offset: 0x0006E41D
		public static void Init()
		{
			ConfigAiSenseById.HandleId = ConfigCommon.InitDataStatement(ConfigAiSenseById.HandleId, "db_ai.db", "select BinData from `AiSense` where Id=?");
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00070238 File Offset: 0x0006E438
		public static AiSense? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiSenseById.HandleId, ConfigAiSenseById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSenseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiSense?(AiSense.GetRootAsAiSense(configBuffer));
				}
			}
			ConfigAiSenseById.LogPair.Clear();
			ConfigAiSenseById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiSenseById.HandleId, 1, p0Id, ConfigAiSenseById.LogPair) || ConfigCommon.Step(ConfigAiSenseById.HandleId, true, ConfigAiSenseById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiSenseById.HandleId, ConfigAiSenseById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiSenseById.HandleId, 0, ConfigAiSenseById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiSenseById.HandleId, ConfigAiSenseById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiSense rootAsAiSense = AiSense.GetRootAsAiSense(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSenseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiSenseById.HandleId, ConfigAiSenseById.LogPair);
			return new AiSense?(rootAsAiSense);
		}

		// Token: 0x040003D4 RID: 980
		private const string DB = "db_ai.db";

		// Token: 0x040003D5 RID: 981
		private const string FILE = "a.AI感知.xlsx";

		// Token: 0x040003D6 RID: 982
		private const string TABLE = "AiSense";

		// Token: 0x040003D7 RID: 983
		private const string COMMAND = "select BinData from `AiSense` where Id=?";

		// Token: 0x040003D8 RID: 984
		private const string KEY_PREFIX = "AiSenseById";

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
