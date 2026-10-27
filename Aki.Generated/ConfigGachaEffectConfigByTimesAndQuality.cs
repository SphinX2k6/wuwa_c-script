using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036E RID: 878
	public class ConfigGachaEffectConfigByTimesAndQuality : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x000CDF53 File Offset: 0x000CC153
		static ConfigGachaEffectConfigByTimesAndQuality()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaEffectConfigByTimesAndQuality.CreateStaticDefaultValue), new Action(ConfigGachaEffectConfigByTimesAndQuality.ResetStaticDefaultValue));
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x000CDF74 File Offset: 0x000CC174
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

		// Token: 0x0600149C RID: 5276 RVA: 0x000CDFF3 File Offset: 0x000CC1F3
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaEffectConfigByTimesAndQuality.LogPair = null;
			ConfigGachaEffectConfigByTimesAndQuality.HandleId = 0;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x000CE001 File Offset: 0x000CC201
		public static void Init()
		{
			ConfigGachaEffectConfigByTimesAndQuality.HandleId = ConfigCommon.InitDataStatement(ConfigGachaEffectConfigByTimesAndQuality.HandleId, "db_gacha.db", "select BinData from `GachaEffectConfig` where Times=? AND Quality=?");
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x000CE01C File Offset: 0x000CC21C
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

		// Token: 0x040017E6 RID: 6118
		private const string DB = "db_gacha.db";

		// Token: 0x040017E7 RID: 6119
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040017E8 RID: 6120
		private const string TABLE = "GachaEffectConfig";

		// Token: 0x040017E9 RID: 6121
		private const string COMMAND = "select BinData from `GachaEffectConfig` where Times=? AND Quality=?";

		// Token: 0x040017EA RID: 6122
		private const string KEY_PREFIX = "GachaEffectConfigByTimesAndQuality";

		// Token: 0x040017EB RID: 6123
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017EC RID: 6124
		private static int HandleId;
	}
}
