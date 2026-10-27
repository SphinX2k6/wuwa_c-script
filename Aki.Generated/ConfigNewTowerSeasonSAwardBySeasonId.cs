using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060E RID: 1550
	public class ConfigNewTowerSeasonSAwardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002464 RID: 9316 RVA: 0x00127568 File Offset: 0x00125768
		static ConfigNewTowerSeasonSAwardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonSAwardBySeasonId.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonSAwardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00127588 File Offset: 0x00125788
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonSAwardBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonSAwardBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeasonSAward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeasonSAward` where SeasonId=?")
			});
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00127607 File Offset: 0x00125807
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonSAwardBySeasonId.LogPair = null;
			ConfigNewTowerSeasonSAwardBySeasonId.HandleId = 0;
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00127615 File Offset: 0x00125815
		public static void Init()
		{
			ConfigNewTowerSeasonSAwardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, "db_newtower.db", "select BinData from `NewTowerSeasonSAward` where SeasonId=?");
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00127630 File Offset: 0x00125830
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerSeasonSAward> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, ConfigNewTowerSeasonSAwardBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonSAwardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<NewTowerSeasonSAward> readOnlyList = (IReadOnlyList<NewTowerSeasonSAward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewTowerSeasonSAwardBySeasonId.LogPair.Clear();
			ConfigNewTowerSeasonSAwardBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, 1, p0SeasonId, ConfigNewTowerSeasonSAwardBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, ConfigNewTowerSeasonSAwardBySeasonId.LogPair);
				return null;
			}
			List<NewTowerSeasonSAward> list = new List<NewTowerSeasonSAward>();
			while (ConfigCommon.Step(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, false, ConfigNewTowerSeasonSAwardBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, 0, ConfigNewTowerSeasonSAwardBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, ConfigNewTowerSeasonSAwardBySeasonId.LogPair);
					return null;
				}
				NewTowerSeasonSAward rootAsNewTowerSeasonSAward = NewTowerSeasonSAward.GetRootAsNewTowerSeasonSAward(new ByteBuffer(item2));
				list.Add(rootAsNewTowerSeasonSAward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonSAwardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, ConfigNewTowerSeasonSAwardBySeasonId.LogPair);
			return list;
		}

		// Token: 0x04002A48 RID: 10824
		private const string DB = "db_newtower.db";

		// Token: 0x04002A49 RID: 10825
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A4A RID: 10826
		private const string TABLE = "NewTowerSeasonSAward";

		// Token: 0x04002A4B RID: 10827
		private const string COMMAND = "select BinData from `NewTowerSeasonSAward` where SeasonId=?";

		// Token: 0x04002A4C RID: 10828
		private const string KEY_PREFIX = "NewTowerSeasonSAwardBySeasonId";

		// Token: 0x04002A4D RID: 10829
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A4E RID: 10830
		private static int HandleId;
	}
}
