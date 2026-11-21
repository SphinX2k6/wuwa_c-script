using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000626 RID: 1574
	public class ConfigNewTowerSeasonSAwardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024F4 RID: 9460 RVA: 0x0012DFE4 File Offset: 0x0012C1E4
		static ConfigNewTowerSeasonSAwardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonSAwardBySeasonId.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonSAwardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0012E004 File Offset: 0x0012C204
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

		// Token: 0x060024F6 RID: 9462 RVA: 0x0012E083 File Offset: 0x0012C283
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonSAwardBySeasonId.LogPair = null;
			ConfigNewTowerSeasonSAwardBySeasonId.HandleId = 0;
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x0012E091 File Offset: 0x0012C291
		public static void Init()
		{
			ConfigNewTowerSeasonSAwardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonSAwardBySeasonId.HandleId, "db_newtower.db", "select BinData from `NewTowerSeasonSAward` where SeasonId=?");
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0012E0AC File Offset: 0x0012C2AC
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

		// Token: 0x04002AF0 RID: 10992
		private const string DB = "db_newtower.db";

		// Token: 0x04002AF1 RID: 10993
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AF2 RID: 10994
		private const string TABLE = "NewTowerSeasonSAward";

		// Token: 0x04002AF3 RID: 10995
		private const string COMMAND = "select BinData from `NewTowerSeasonSAward` where SeasonId=?";

		// Token: 0x04002AF4 RID: 10996
		private const string KEY_PREFIX = "NewTowerSeasonSAwardBySeasonId";

		// Token: 0x04002AF5 RID: 10997
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AF6 RID: 10998
		private static int HandleId;
	}
}
