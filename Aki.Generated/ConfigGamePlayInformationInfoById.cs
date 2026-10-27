using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037E RID: 894
	public class ConfigGamePlayInformationInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014FA RID: 5370 RVA: 0x000D03C8 File Offset: 0x000CE5C8
		static ConfigGamePlayInformationInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayInformationInfoById.CreateStaticDefaultValue), new Action(ConfigGamePlayInformationInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000D03E8 File Offset: 0x000CE5E8
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

		// Token: 0x060014FC RID: 5372 RVA: 0x000D0467 File Offset: 0x000CE667
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayInformationInfoById.LogPair = null;
			ConfigGamePlayInformationInfoById.HandleId = 0;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000D0475 File Offset: 0x000CE675
		public static void Init()
		{
			ConfigGamePlayInformationInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayInformationInfoById.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayInformationInfo` where Id=?");
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000D0490 File Offset: 0x000CE690
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

		// Token: 0x04001856 RID: 6230
		private const string DB = "db_levelgameplay.db";

		// Token: 0x04001857 RID: 6231
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x04001858 RID: 6232
		private const string TABLE = "GamePlayInformationInfo";

		// Token: 0x04001859 RID: 6233
		private const string COMMAND = "select BinData from `GamePlayInformationInfo` where Id=?";

		// Token: 0x0400185A RID: 6234
		private const string KEY_PREFIX = "GamePlayInformationInfoById";

		// Token: 0x0400185B RID: 6235
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400185C RID: 6236
		private static int HandleId;
	}
}
