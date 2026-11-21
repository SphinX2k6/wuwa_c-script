using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000394 RID: 916
	public class ConfigGamePlayScanByUid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600157E RID: 5502 RVA: 0x000D6B1C File Offset: 0x000D4D1C
		static ConfigGamePlayScanByUid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayScanByUid.CreateStaticDefaultValue), new Action(ConfigGamePlayScanByUid.ResetStaticDefaultValue));
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000D6B3C File Offset: 0x000D4D3C
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

		// Token: 0x06001580 RID: 5504 RVA: 0x000D6BBB File Offset: 0x000D4DBB
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayScanByUid.LogPair = null;
			ConfigGamePlayScanByUid.HandleId = 0;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000D6BC9 File Offset: 0x000D4DC9
		public static void Init()
		{
			ConfigGamePlayScanByUid.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayScanByUid.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayScan` where UID=?");
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000D6BE4 File Offset: 0x000D4DE4
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

		// Token: 0x040018F0 RID: 6384
		private const string DB = "db_levelgameplay.db";

		// Token: 0x040018F1 RID: 6385
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x040018F2 RID: 6386
		private const string TABLE = "GamePlayScan";

		// Token: 0x040018F3 RID: 6387
		private const string COMMAND = "select BinData from `GamePlayScan` where UID=?";

		// Token: 0x040018F4 RID: 6388
		private const string KEY_PREFIX = "GamePlayScanByUid";

		// Token: 0x040018F5 RID: 6389
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018F6 RID: 6390
		private static int HandleId;
	}
}
