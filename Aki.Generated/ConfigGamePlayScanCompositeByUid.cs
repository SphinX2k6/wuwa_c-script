using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000395 RID: 917
	public class ConfigGamePlayScanCompositeByUid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x000D6D64 File Offset: 0x000D4F64
		static ConfigGamePlayScanCompositeByUid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayScanCompositeByUid.CreateStaticDefaultValue), new Action(ConfigGamePlayScanCompositeByUid.ResetStaticDefaultValue));
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000D6D84 File Offset: 0x000D4F84
		public static void CreateStaticDefaultValue()
		{
			ConfigGamePlayScanCompositeByUid.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGamePlayScanCompositeByUid.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelgameplay.db"),
				new ValueTuple<string, object>("文件", "g.关卡玩法数据.xlsx"),
				new ValueTuple<string, object>("表名", "GamePlayScanComposite"),
				new ValueTuple<string, object>("语句", "select BinData from `GamePlayScanComposite` where UID=?")
			});
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000D6E03 File Offset: 0x000D5003
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayScanCompositeByUid.LogPair = null;
			ConfigGamePlayScanCompositeByUid.HandleId = 0;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000D6E11 File Offset: 0x000D5011
		public static void Init()
		{
			ConfigGamePlayScanCompositeByUid.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayScanCompositeByUid.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayScanComposite` where UID=?");
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000D6E2C File Offset: 0x000D502C
		public static GamePlayScanComposite? GetConfig(int p0UId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGamePlayScanCompositeByUid.HandleId, ConfigGamePlayScanCompositeByUid.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayScanCompositeByUid");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0UId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GamePlayScanComposite?(GamePlayScanComposite.GetRootAsGamePlayScanComposite(configBuffer));
				}
			}
			ConfigGamePlayScanCompositeByUid.LogPair.Clear();
			ConfigGamePlayScanCompositeByUid.LogPair.Add(new ValueTuple<string, object>("UId", p0UId));
			if (!ConfigCommon.BindInt(ConfigGamePlayScanCompositeByUid.HandleId, 1, p0UId, ConfigGamePlayScanCompositeByUid.LogPair) || ConfigCommon.Step(ConfigGamePlayScanCompositeByUid.HandleId, true, ConfigGamePlayScanCompositeByUid.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGamePlayScanCompositeByUid.HandleId, ConfigGamePlayScanCompositeByUid.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGamePlayScanCompositeByUid.HandleId, 0, ConfigGamePlayScanCompositeByUid.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGamePlayScanCompositeByUid.HandleId, ConfigGamePlayScanCompositeByUid.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GamePlayScanComposite rootAsGamePlayScanComposite = GamePlayScanComposite.GetRootAsGamePlayScanComposite(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayScanCompositeByUid");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0UId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGamePlayScanCompositeByUid.HandleId, ConfigGamePlayScanCompositeByUid.LogPair);
			return new GamePlayScanComposite?(rootAsGamePlayScanComposite);
		}

		// Token: 0x040018F7 RID: 6391
		private const string DB = "db_levelgameplay.db";

		// Token: 0x040018F8 RID: 6392
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x040018F9 RID: 6393
		private const string TABLE = "GamePlayScanComposite";

		// Token: 0x040018FA RID: 6394
		private const string COMMAND = "select BinData from `GamePlayScanComposite` where UID=?";

		// Token: 0x040018FB RID: 6395
		private const string KEY_PREFIX = "GamePlayScanCompositeByUid";

		// Token: 0x040018FC RID: 6396
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018FD RID: 6397
		private static int HandleId;
	}
}
