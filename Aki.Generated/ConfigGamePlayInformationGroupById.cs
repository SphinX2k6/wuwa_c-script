using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000392 RID: 914
	public class ConfigGamePlayInformationGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001572 RID: 5490 RVA: 0x000D668D File Offset: 0x000D488D
		static ConfigGamePlayInformationGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayInformationGroupById.CreateStaticDefaultValue), new Action(ConfigGamePlayInformationGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000D66AC File Offset: 0x000D48AC
		public static void CreateStaticDefaultValue()
		{
			ConfigGamePlayInformationGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGamePlayInformationGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelgameplay.db"),
				new ValueTuple<string, object>("文件", "g.关卡玩法数据.xlsx"),
				new ValueTuple<string, object>("表名", "GamePlayInformationGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `GamePlayInformationGroup` where Id=?")
			});
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000D672B File Offset: 0x000D492B
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayInformationGroupById.LogPair = null;
			ConfigGamePlayInformationGroupById.HandleId = 0;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000D6739 File Offset: 0x000D4939
		public static void Init()
		{
			ConfigGamePlayInformationGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayInformationGroupById.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayInformationGroup` where Id=?");
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000D6754 File Offset: 0x000D4954
		public static GamePlayInformationGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGamePlayInformationGroupById.HandleId, ConfigGamePlayInformationGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayInformationGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GamePlayInformationGroup?(GamePlayInformationGroup.GetRootAsGamePlayInformationGroup(configBuffer));
				}
			}
			ConfigGamePlayInformationGroupById.LogPair.Clear();
			ConfigGamePlayInformationGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGamePlayInformationGroupById.HandleId, 1, p0Id, ConfigGamePlayInformationGroupById.LogPair) || ConfigCommon.Step(ConfigGamePlayInformationGroupById.HandleId, true, ConfigGamePlayInformationGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGamePlayInformationGroupById.HandleId, ConfigGamePlayInformationGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGamePlayInformationGroupById.HandleId, 0, ConfigGamePlayInformationGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGamePlayInformationGroupById.HandleId, ConfigGamePlayInformationGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GamePlayInformationGroup rootAsGamePlayInformationGroup = GamePlayInformationGroup.GetRootAsGamePlayInformationGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayInformationGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGamePlayInformationGroupById.HandleId, ConfigGamePlayInformationGroupById.LogPair);
			return new GamePlayInformationGroup?(rootAsGamePlayInformationGroup);
		}

		// Token: 0x040018E2 RID: 6370
		private const string DB = "db_levelgameplay.db";

		// Token: 0x040018E3 RID: 6371
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x040018E4 RID: 6372
		private const string TABLE = "GamePlayInformationGroup";

		// Token: 0x040018E5 RID: 6373
		private const string COMMAND = "select BinData from `GamePlayInformationGroup` where Id=?";

		// Token: 0x040018E6 RID: 6374
		private const string KEY_PREFIX = "GamePlayInformationGroupById";

		// Token: 0x040018E7 RID: 6375
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018E8 RID: 6376
		private static int HandleId;
	}
}
