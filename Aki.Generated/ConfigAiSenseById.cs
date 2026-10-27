using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000088 RID: 136
	public class ConfigAiSenseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000330 RID: 816 RVA: 0x0006B8BC File Offset: 0x00069ABC
		static ConfigAiSenseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiSenseById.CreateStaticDefaultValue), new Action(ConfigAiSenseById.ResetStaticDefaultValue));
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0006B8DC File Offset: 0x00069ADC
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

		// Token: 0x06000332 RID: 818 RVA: 0x0006B95B File Offset: 0x00069B5B
		public static void ResetStaticDefaultValue()
		{
			ConfigAiSenseById.LogPair = null;
			ConfigAiSenseById.HandleId = 0;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0006B969 File Offset: 0x00069B69
		public static void Init()
		{
			ConfigAiSenseById.HandleId = ConfigCommon.InitDataStatement(ConfigAiSenseById.HandleId, "db_ai.db", "select BinData from `AiSense` where Id=?");
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0006B984 File Offset: 0x00069B84
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

		// Token: 0x0400039C RID: 924
		private const string DB = "db_ai.db";

		// Token: 0x0400039D RID: 925
		private const string FILE = "a.AI感知.xlsx";

		// Token: 0x0400039E RID: 926
		private const string TABLE = "AiSense";

		// Token: 0x0400039F RID: 927
		private const string COMMAND = "select BinData from `AiSense` where Id=?";

		// Token: 0x040003A0 RID: 928
		private const string KEY_PREFIX = "AiSenseById";

		// Token: 0x040003A1 RID: 929
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003A2 RID: 930
		private static int HandleId;
	}
}
