using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000741 RID: 1857
	public class ConfigPinballRankByTower : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B96 RID: 11158 RVA: 0x00153418 File Offset: 0x00151618
		static ConfigPinballRankByTower()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRankByTower.CreateStaticDefaultValue), new Action(ConfigPinballRankByTower.ResetStaticDefaultValue));
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00153438 File Offset: 0x00151638
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRankByTower.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRankByTower.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_活动.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRank"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRank` where Tower=?")
			});
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x001534B7 File Offset: 0x001516B7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRankByTower.LogPair = null;
			ConfigPinballRankByTower.HandleId = 0;
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x001534C5 File Offset: 0x001516C5
		public static void Init()
		{
			ConfigPinballRankByTower.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRankByTower.HandleId, "db_pinballbattle.db", "select BinData from `PinballRank` where Tower=?");
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x001534E0 File Offset: 0x001516E0
		public static PinballRank? GetConfig(int p0Tower, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRankByTower");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Tower);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRank?(PinballRank.GetRootAsPinballRank(configBuffer));
				}
			}
			ConfigPinballRankByTower.LogPair.Clear();
			ConfigPinballRankByTower.LogPair.Add(new ValueTuple<string, object>("Tower", p0Tower));
			if (!ConfigCommon.BindInt(ConfigPinballRankByTower.HandleId, 1, p0Tower, ConfigPinballRankByTower.LogPair) || ConfigCommon.Step(ConfigPinballRankByTower.HandleId, true, ConfigPinballRankByTower.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRankByTower.HandleId, 0, ConfigPinballRankByTower.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRank rootAsPinballRank = PinballRank.GetRootAsPinballRank(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRankByTower");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Tower);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair);
			return new PinballRank?(rootAsPinballRank);
		}

		// Token: 0x040032AD RID: 12973
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032AE RID: 12974
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x040032AF RID: 12975
		private const string TABLE = "PinballRank";

		// Token: 0x040032B0 RID: 12976
		private const string COMMAND = "select BinData from `PinballRank` where Tower=?";

		// Token: 0x040032B1 RID: 12977
		private const string KEY_PREFIX = "PinballRankByTower";

		// Token: 0x040032B2 RID: 12978
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032B3 RID: 12979
		private static int HandleId;
	}
}
