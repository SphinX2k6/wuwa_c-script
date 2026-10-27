using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000380 RID: 896
	public class ConfigGamePlayScanCompositeByUid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001506 RID: 5382 RVA: 0x000D0858 File Offset: 0x000CEA58
		static ConfigGamePlayScanCompositeByUid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayScanCompositeByUid.CreateStaticDefaultValue), new Action(ConfigGamePlayScanCompositeByUid.ResetStaticDefaultValue));
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x000D0878 File Offset: 0x000CEA78
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

		// Token: 0x06001508 RID: 5384 RVA: 0x000D08F7 File Offset: 0x000CEAF7
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayScanCompositeByUid.LogPair = null;
			ConfigGamePlayScanCompositeByUid.HandleId = 0;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000D0905 File Offset: 0x000CEB05
		public static void Init()
		{
			ConfigGamePlayScanCompositeByUid.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayScanCompositeByUid.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayScanComposite` where UID=?");
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x000D0920 File Offset: 0x000CEB20
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

		// Token: 0x04001864 RID: 6244
		private const string DB = "db_levelgameplay.db";

		// Token: 0x04001865 RID: 6245
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x04001866 RID: 6246
		private const string TABLE = "GamePlayScanComposite";

		// Token: 0x04001867 RID: 6247
		private const string COMMAND = "select BinData from `GamePlayScanComposite` where UID=?";

		// Token: 0x04001868 RID: 6248
		private const string KEY_PREFIX = "GamePlayScanCompositeByUid";

		// Token: 0x04001869 RID: 6249
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400186A RID: 6250
		private static int HandleId;
	}
}
