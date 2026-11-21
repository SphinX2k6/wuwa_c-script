using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000620 RID: 1568
	public class ConfigNewTowerScoreRewardByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x0012D308 File Offset: 0x0012B508
		static ConfigNewTowerScoreRewardByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreRewardByLevelId.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreRewardByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0012D328 File Offset: 0x0012B528
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

		// Token: 0x060024D2 RID: 9426 RVA: 0x0012D3A7 File Offset: 0x0012B5A7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreRewardByLevelId.LogPair = null;
			ConfigNewTowerScoreRewardByLevelId.HandleId = 0;
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x0012D3B5 File Offset: 0x0012B5B5
		public static void Init()
		{
			ConfigNewTowerScoreRewardByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreRewardByLevelId.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreReward` where Level=?");
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x0012D3D0 File Offset: 0x0012B5D0
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

		// Token: 0x04002AC6 RID: 10950
		private const string DB = "db_newtower.db";

		// Token: 0x04002AC7 RID: 10951
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AC8 RID: 10952
		private const string TABLE = "NewTowerScoreReward";

		// Token: 0x04002AC9 RID: 10953
		private const string COMMAND = "select BinData from `NewTowerScoreReward` where Level=?";

		// Token: 0x04002ACA RID: 10954
		private const string KEY_PREFIX = "NewTowerScoreRewardByLevelId";

		// Token: 0x04002ACB RID: 10955
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ACC RID: 10956
		private static int HandleId;
	}
}
