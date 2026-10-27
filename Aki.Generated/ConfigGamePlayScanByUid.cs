using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037F RID: 895
	public class ConfigGamePlayScanByUid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001500 RID: 5376 RVA: 0x000D0610 File Offset: 0x000CE810
		static ConfigGamePlayScanByUid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayScanByUid.CreateStaticDefaultValue), new Action(ConfigGamePlayScanByUid.ResetStaticDefaultValue));
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000D0630 File Offset: 0x000CE830
		public static void CreateStaticDefaultValue()
		{
			ConfigGamePlayScanByUid.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGamePlayScanByUid.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelgameplay.db"),
				new ValueTuple<string, object>("文件", "g.关卡玩法数据.xlsx"),
				new ValueTuple<string, object>("表名", "GamePlayScan"),
				new ValueTuple<string, object>("语句", "select BinData from `GamePlayScan` where UID=?")
			});
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x000D06AF File Offset: 0x000CE8AF
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayScanByUid.LogPair = null;
			ConfigGamePlayScanByUid.HandleId = 0;
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000D06BD File Offset: 0x000CE8BD
		public static void Init()
		{
			ConfigGamePlayScanByUid.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayScanByUid.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayScan` where UID=?");
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000D06D8 File Offset: 0x000CE8D8
		public static GamePlayScan? GetConfig(int p0UId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGamePlayScanByUid.HandleId, ConfigGamePlayScanByUid.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayScanByUid");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0UId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GamePlayScan?(GamePlayScan.GetRootAsGamePlayScan(configBuffer));
				}
			}
			ConfigGamePlayScanByUid.LogPair.Clear();
			ConfigGamePlayScanByUid.LogPair.Add(new ValueTuple<string, object>("UId", p0UId));
			if (!ConfigCommon.BindInt(ConfigGamePlayScanByUid.HandleId, 1, p0UId, ConfigGamePlayScanByUid.LogPair) || ConfigCommon.Step(ConfigGamePlayScanByUid.HandleId, true, ConfigGamePlayScanByUid.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGamePlayScanByUid.HandleId, ConfigGamePlayScanByUid.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGamePlayScanByUid.HandleId, 0, ConfigGamePlayScanByUid.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGamePlayScanByUid.HandleId, ConfigGamePlayScanByUid.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GamePlayScan rootAsGamePlayScan = GamePlayScan.GetRootAsGamePlayScan(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayScanByUid");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0UId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGamePlayScanByUid.HandleId, ConfigGamePlayScanByUid.LogPair);
			return new GamePlayScan?(rootAsGamePlayScan);
		}

		// Token: 0x0400185D RID: 6237
		private const string DB = "db_levelgameplay.db";

		// Token: 0x0400185E RID: 6238
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x0400185F RID: 6239
		private const string TABLE = "GamePlayScan";

		// Token: 0x04001860 RID: 6240
		private const string COMMAND = "select BinData from `GamePlayScan` where UID=?";

		// Token: 0x04001861 RID: 6241
		private const string KEY_PREFIX = "GamePlayScanByUid";

		// Token: 0x04001862 RID: 6242
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001863 RID: 6243
		private static int HandleId;
	}
}
