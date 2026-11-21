using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000507 RID: 1287
	public class ConfigLongShanUiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E35 RID: 7733 RVA: 0x00107900 File Offset: 0x00105B00
		static ConfigLongShanUiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanUiConfigById.CreateStaticDefaultValue), new Action(ConfigLongShanUiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00107920 File Offset: 0x00105B20
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

		// Token: 0x06001E37 RID: 7735 RVA: 0x0010799F File Offset: 0x00105B9F
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanUiConfigById.LogPair = null;
			ConfigLongShanUiConfigById.HandleId = 0;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x001079AD File Offset: 0x00105BAD
		public static void Init()
		{
			ConfigLongShanUiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanUiConfigById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanUiConfig` where Id=?");
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x001079C8 File Offset: 0x00105BC8
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

		// Token: 0x04002315 RID: 8981
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002316 RID: 8982
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002317 RID: 8983
		private const string TABLE = "LongShanUiConfig";

		// Token: 0x04002318 RID: 8984
		private const string COMMAND = "select BinData from `LongShanUiConfig` where Id=?";

		// Token: 0x04002319 RID: 8985
		private const string KEY_PREFIX = "LongShanUiConfigById";

		// Token: 0x0400231A RID: 8986
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400231B RID: 8987
		private static int HandleId;
	}
}
