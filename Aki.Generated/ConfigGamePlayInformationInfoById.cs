using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000393 RID: 915
	public class ConfigGamePlayInformationInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001578 RID: 5496 RVA: 0x000D68D4 File Offset: 0x000D4AD4
		static ConfigGamePlayInformationInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayInformationInfoById.CreateStaticDefaultValue), new Action(ConfigGamePlayInformationInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000D68F4 File Offset: 0x000D4AF4
		public static void CreateStaticDefaultValue()
		{
			ConfigGamePlayInformationInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGamePlayInformationInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelgameplay.db"),
				new ValueTuple<string, object>("文件", "g.关卡玩法数据.xlsx"),
				new ValueTuple<string, object>("表名", "GamePlayInformationInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GamePlayInformationInfo` where Id=?")
			});
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x000D6973 File Offset: 0x000D4B73
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayInformationInfoById.LogPair = null;
			ConfigGamePlayInformationInfoById.HandleId = 0;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000D6981 File Offset: 0x000D4B81
		public static void Init()
		{
			ConfigGamePlayInformationInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayInformationInfoById.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayInformationInfo` where Id=?");
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000D699C File Offset: 0x000D4B9C
		public static GamePlayInformationInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGamePlayInformationInfoById.HandleId, ConfigGamePlayInformationInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayInformationInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GamePlayInformationInfo?(GamePlayInformationInfo.GetRootAsGamePlayInformationInfo(configBuffer));
				}
			}
			ConfigGamePlayInformationInfoById.LogPair.Clear();
			ConfigGamePlayInformationInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGamePlayInformationInfoById.HandleId, 1, p0Id, ConfigGamePlayInformationInfoById.LogPair) || ConfigCommon.Step(ConfigGamePlayInformationInfoById.HandleId, true, ConfigGamePlayInformationInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGamePlayInformationInfoById.HandleId, ConfigGamePlayInformationInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGamePlayInformationInfoById.HandleId, 0, ConfigGamePlayInformationInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGamePlayInformationInfoById.HandleId, ConfigGamePlayInformationInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GamePlayInformationInfo rootAsGamePlayInformationInfo = GamePlayInformationInfo.GetRootAsGamePlayInformationInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GamePlayInformationInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGamePlayInformationInfoById.HandleId, ConfigGamePlayInformationInfoById.LogPair);
			return new GamePlayInformationInfo?(rootAsGamePlayInformationInfo);
		}

		// Token: 0x040018E9 RID: 6377
		private const string DB = "db_levelgameplay.db";

		// Token: 0x040018EA RID: 6378
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x040018EB RID: 6379
		private const string TABLE = "GamePlayInformationInfo";

		// Token: 0x040018EC RID: 6380
		private const string COMMAND = "select BinData from `GamePlayInformationInfo` where Id=?";

		// Token: 0x040018ED RID: 6381
		private const string KEY_PREFIX = "GamePlayInformationInfoById";

		// Token: 0x040018EE RID: 6382
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018EF RID: 6383
		private static int HandleId;
	}
}
