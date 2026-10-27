using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037D RID: 893
	public class ConfigGamePlayInformationGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014F4 RID: 5364 RVA: 0x000D0181 File Offset: 0x000CE381
		static ConfigGamePlayInformationGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamePlayInformationGroupById.CreateStaticDefaultValue), new Action(ConfigGamePlayInformationGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000D01A0 File Offset: 0x000CE3A0
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

		// Token: 0x060014F6 RID: 5366 RVA: 0x000D021F File Offset: 0x000CE41F
		public static void ResetStaticDefaultValue()
		{
			ConfigGamePlayInformationGroupById.LogPair = null;
			ConfigGamePlayInformationGroupById.HandleId = 0;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000D022D File Offset: 0x000CE42D
		public static void Init()
		{
			ConfigGamePlayInformationGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigGamePlayInformationGroupById.HandleId, "db_levelgameplay.db", "select BinData from `GamePlayInformationGroup` where Id=?");
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x000D0248 File Offset: 0x000CE448
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

		// Token: 0x0400184F RID: 6223
		private const string DB = "db_levelgameplay.db";

		// Token: 0x04001850 RID: 6224
		private const string FILE = "g.关卡玩法数据.xlsx";

		// Token: 0x04001851 RID: 6225
		private const string TABLE = "GamePlayInformationGroup";

		// Token: 0x04001852 RID: 6226
		private const string COMMAND = "select BinData from `GamePlayInformationGroup` where Id=?";

		// Token: 0x04001853 RID: 6227
		private const string KEY_PREFIX = "GamePlayInformationGroupById";

		// Token: 0x04001854 RID: 6228
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001855 RID: 6229
		private static int HandleId;
	}
}
