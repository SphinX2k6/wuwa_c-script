using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000608 RID: 1544
	public class ConfigNewTowerScoreRewardByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002440 RID: 9280 RVA: 0x0012688C File Offset: 0x00124A8C
		static ConfigNewTowerScoreRewardByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreRewardByLevelId.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreRewardByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x001268AC File Offset: 0x00124AAC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerScoreRewardByLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerScoreRewardByLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerScoreReward` where Level=?")
			});
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0012692B File Offset: 0x00124B2B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreRewardByLevelId.LogPair = null;
			ConfigNewTowerScoreRewardByLevelId.HandleId = 0;
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00126939 File Offset: 0x00124B39
		public static void Init()
		{
			ConfigNewTowerScoreRewardByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreRewardByLevelId.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreReward` where Level=?");
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00126954 File Offset: 0x00124B54
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerScoreReward> GetConfigList(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerScoreRewardByLevelId.HandleId, ConfigNewTowerScoreRewardByLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerScoreRewardByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				IReadOnlyList<NewTowerScoreReward> readOnlyList = (IReadOnlyList<NewTowerScoreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewTowerScoreRewardByLevelId.LogPair.Clear();
			ConfigNewTowerScoreRewardByLevelId.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigNewTowerScoreRewardByLevelId.HandleId, 1, p0Level, ConfigNewTowerScoreRewardByLevelId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewTowerScoreRewardByLevelId.HandleId, ConfigNewTowerScoreRewardByLevelId.LogPair);
				return null;
			}
			List<NewTowerScoreReward> list = new List<NewTowerScoreReward>();
			while (ConfigCommon.Step(ConfigNewTowerScoreRewardByLevelId.HandleId, false, ConfigNewTowerScoreRewardByLevelId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerScoreRewardByLevelId.HandleId, 0, ConfigNewTowerScoreRewardByLevelId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerScoreRewardByLevelId.HandleId, ConfigNewTowerScoreRewardByLevelId.LogPair);
					return null;
				}
				NewTowerScoreReward rootAsNewTowerScoreReward = NewTowerScoreReward.GetRootAsNewTowerScoreReward(new ByteBuffer(item2));
				list.Add(rootAsNewTowerScoreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerScoreRewardByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerScoreRewardByLevelId.HandleId, ConfigNewTowerScoreRewardByLevelId.LogPair);
			return list;
		}

		// Token: 0x04002A1E RID: 10782
		private const string DB = "db_newtower.db";

		// Token: 0x04002A1F RID: 10783
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A20 RID: 10784
		private const string TABLE = "NewTowerScoreReward";

		// Token: 0x04002A21 RID: 10785
		private const string COMMAND = "select BinData from `NewTowerScoreReward` where Level=?";

		// Token: 0x04002A22 RID: 10786
		private const string KEY_PREFIX = "NewTowerScoreRewardByLevelId";

		// Token: 0x04002A23 RID: 10787
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A24 RID: 10788
		private static int HandleId;
	}
}
