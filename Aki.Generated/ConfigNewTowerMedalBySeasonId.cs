using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000619 RID: 1561
	public class ConfigNewTowerMedalBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024A6 RID: 9382 RVA: 0x0012C424 File Offset: 0x0012A624
		static ConfigNewTowerMedalBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerMedalBySeasonId.CreateStaticDefaultValue), new Action(ConfigNewTowerMedalBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0012C444 File Offset: 0x0012A644
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerMedalBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerMedalBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerMedal"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerMedal` where SeasonId=?")
			});
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0012C4C3 File Offset: 0x0012A6C3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerMedalBySeasonId.LogPair = null;
			ConfigNewTowerMedalBySeasonId.HandleId = 0;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0012C4D1 File Offset: 0x0012A6D1
		public static void Init()
		{
			ConfigNewTowerMedalBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerMedalBySeasonId.HandleId, "db_newtower.db", "select BinData from `NewTowerMedal` where SeasonId=?");
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0012C4EC File Offset: 0x0012A6EC
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerMedal> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerMedalBySeasonId.HandleId, ConfigNewTowerMedalBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerMedalBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<NewTowerMedal> readOnlyList = (IReadOnlyList<NewTowerMedal>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewTowerMedalBySeasonId.LogPair.Clear();
			ConfigNewTowerMedalBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigNewTowerMedalBySeasonId.HandleId, 1, p0SeasonId, ConfigNewTowerMedalBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewTowerMedalBySeasonId.HandleId, ConfigNewTowerMedalBySeasonId.LogPair);
				return null;
			}
			List<NewTowerMedal> list = new List<NewTowerMedal>();
			while (ConfigCommon.Step(ConfigNewTowerMedalBySeasonId.HandleId, false, ConfigNewTowerMedalBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerMedalBySeasonId.HandleId, 0, ConfigNewTowerMedalBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerMedalBySeasonId.HandleId, ConfigNewTowerMedalBySeasonId.LogPair);
					return null;
				}
				NewTowerMedal rootAsNewTowerMedal = NewTowerMedal.GetRootAsNewTowerMedal(new ByteBuffer(item2));
				list.Add(rootAsNewTowerMedal);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerMedalBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerMedalBySeasonId.HandleId, ConfigNewTowerMedalBySeasonId.LogPair);
			return list;
		}

		// Token: 0x04002A95 RID: 10901
		private const string DB = "db_newtower.db";

		// Token: 0x04002A96 RID: 10902
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A97 RID: 10903
		private const string TABLE = "NewTowerMedal";

		// Token: 0x04002A98 RID: 10904
		private const string COMMAND = "select BinData from `NewTowerMedal` where SeasonId=?";

		// Token: 0x04002A99 RID: 10905
		private const string KEY_PREFIX = "NewTowerMedalBySeasonId";

		// Token: 0x04002A9A RID: 10906
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A9B RID: 10907
		private static int HandleId;
	}
}
