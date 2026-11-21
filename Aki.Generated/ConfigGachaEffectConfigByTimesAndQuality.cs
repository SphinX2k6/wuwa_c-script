using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000383 RID: 899
	public class ConfigGachaEffectConfigByTimesAndQuality : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001518 RID: 5400 RVA: 0x000D445F File Offset: 0x000D265F
		static ConfigGachaEffectConfigByTimesAndQuality()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaEffectConfigByTimesAndQuality.CreateStaticDefaultValue), new Action(ConfigGachaEffectConfigByTimesAndQuality.ResetStaticDefaultValue));
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x000D4480 File Offset: 0x000D2680
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaEffectConfigByTimesAndQuality.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaEffectConfigByTimesAndQuality.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaEffectConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaEffectConfig` where Times=? AND Quality=?")
			});
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000D44FF File Offset: 0x000D26FF
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaEffectConfigByTimesAndQuality.LogPair = null;
			ConfigGachaEffectConfigByTimesAndQuality.HandleId = 0;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000D450D File Offset: 0x000D270D
		public static void Init()
		{
			ConfigGachaEffectConfigByTimesAndQuality.HandleId = ConfigCommon.InitDataStatement(ConfigGachaEffectConfigByTimesAndQuality.HandleId, "db_gacha.db", "select BinData from `GachaEffectConfig` where Times=? AND Quality=?");
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000D4528 File Offset: 0x000D2728
		public static GachaEffectConfig? GetConfig(int p0Times, int p1Quality, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaEffectConfigByTimesAndQuality.HandleId, ConfigGachaEffectConfigByTimesAndQuality.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("GachaEffectConfigByTimesAndQuality");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Times);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Quality);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaEffectConfig?(GachaEffectConfig.GetRootAsGachaEffectConfig(configBuffer));
				}
			}
			ConfigGachaEffectConfigByTimesAndQuality.LogPair.Clear();
			ConfigGachaEffectConfigByTimesAndQuality.LogPair.Add(new ValueTuple<string, object>("Times", p0Times));
			ConfigGachaEffectConfigByTimesAndQuality.LogPair.Add(new ValueTuple<string, object>("Quality", p1Quality));
			if (!ConfigCommon.BindInt(ConfigGachaEffectConfigByTimesAndQuality.HandleId, 1, p0Times, ConfigGachaEffectConfigByTimesAndQuality.LogPair) || !ConfigCommon.BindInt(ConfigGachaEffectConfigByTimesAndQuality.HandleId, 2, p1Quality, ConfigGachaEffectConfigByTimesAndQuality.LogPair) || ConfigCommon.Step(ConfigGachaEffectConfigByTimesAndQuality.HandleId, true, ConfigGachaEffectConfigByTimesAndQuality.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaEffectConfigByTimesAndQuality.HandleId, ConfigGachaEffectConfigByTimesAndQuality.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaEffectConfigByTimesAndQuality.HandleId, 0, ConfigGachaEffectConfigByTimesAndQuality.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaEffectConfigByTimesAndQuality.HandleId, ConfigGachaEffectConfigByTimesAndQuality.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaEffectConfig rootAsGachaEffectConfig = GachaEffectConfig.GetRootAsGachaEffectConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("GachaEffectConfigByTimesAndQuality");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Times);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Quality);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaEffectConfigByTimesAndQuality.HandleId, ConfigGachaEffectConfigByTimesAndQuality.LogPair);
			return new GachaEffectConfig?(rootAsGachaEffectConfig);
		}

		// Token: 0x04001879 RID: 6265
		private const string DB = "db_gacha.db";

		// Token: 0x0400187A RID: 6266
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x0400187B RID: 6267
		private const string TABLE = "GachaEffectConfig";

		// Token: 0x0400187C RID: 6268
		private const string COMMAND = "select BinData from `GachaEffectConfig` where Times=? AND Quality=?";

		// Token: 0x0400187D RID: 6269
		private const string KEY_PREFIX = "GachaEffectConfigByTimesAndQuality";

		// Token: 0x0400187E RID: 6270
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400187F RID: 6271
		private static int HandleId;
	}
}
