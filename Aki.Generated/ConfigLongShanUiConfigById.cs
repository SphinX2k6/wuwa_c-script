using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F1 RID: 1265
	public class ConfigLongShanUiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DB1 RID: 7601 RVA: 0x001011AC File Offset: 0x000FF3AC
		static ConfigLongShanUiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanUiConfigById.CreateStaticDefaultValue), new Action(ConfigLongShanUiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x001011CC File Offset: 0x000FF3CC
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanUiConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanUiConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanUiConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanUiConfig` where Id=?")
			});
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0010124B File Offset: 0x000FF44B
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanUiConfigById.LogPair = null;
			ConfigLongShanUiConfigById.HandleId = 0;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00101259 File Offset: 0x000FF459
		public static void Init()
		{
			ConfigLongShanUiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanUiConfigById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanUiConfig` where Id=?");
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00101274 File Offset: 0x000FF474
		public static LongShanUiConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanUiConfigById.HandleId, ConfigLongShanUiConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanUiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LongShanUiConfig?(LongShanUiConfig.GetRootAsLongShanUiConfig(configBuffer));
				}
			}
			ConfigLongShanUiConfigById.LogPair.Clear();
			ConfigLongShanUiConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLongShanUiConfigById.HandleId, 1, p0Id, ConfigLongShanUiConfigById.LogPair) || ConfigCommon.Step(ConfigLongShanUiConfigById.HandleId, true, ConfigLongShanUiConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLongShanUiConfigById.HandleId, ConfigLongShanUiConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanUiConfigById.HandleId, 0, ConfigLongShanUiConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLongShanUiConfigById.HandleId, ConfigLongShanUiConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LongShanUiConfig rootAsLongShanUiConfig = LongShanUiConfig.GetRootAsLongShanUiConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanUiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLongShanUiConfigById.HandleId, ConfigLongShanUiConfigById.LogPair);
			return new LongShanUiConfig?(rootAsLongShanUiConfig);
		}

		// Token: 0x0400227B RID: 8827
		private const string DB = "db_longshanactivity.db";

		// Token: 0x0400227C RID: 8828
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x0400227D RID: 8829
		private const string TABLE = "LongShanUiConfig";

		// Token: 0x0400227E RID: 8830
		private const string COMMAND = "select BinData from `LongShanUiConfig` where Id=?";

		// Token: 0x0400227F RID: 8831
		private const string KEY_PREFIX = "LongShanUiConfigById";

		// Token: 0x04002280 RID: 8832
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002281 RID: 8833
		private static int HandleId;
	}
}
