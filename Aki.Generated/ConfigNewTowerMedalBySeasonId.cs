using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000601 RID: 1537
	public class ConfigNewTowerMedalBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002416 RID: 9238 RVA: 0x001259A8 File Offset: 0x00123BA8
		static ConfigNewTowerMedalBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerMedalBySeasonId.CreateStaticDefaultValue), new Action(ConfigNewTowerMedalBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x001259C8 File Offset: 0x00123BC8
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

		// Token: 0x06002418 RID: 9240 RVA: 0x00125A47 File Offset: 0x00123C47
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerMedalBySeasonId.LogPair = null;
			ConfigNewTowerMedalBySeasonId.HandleId = 0;
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00125A55 File Offset: 0x00123C55
		public static void Init()
		{
			ConfigNewTowerMedalBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerMedalBySeasonId.HandleId, "db_newtower.db", "select BinData from `NewTowerMedal` where SeasonId=?");
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00125A70 File Offset: 0x00123C70
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

		// Token: 0x040029ED RID: 10733
		private const string DB = "db_newtower.db";

		// Token: 0x040029EE RID: 10734
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029EF RID: 10735
		private const string TABLE = "NewTowerMedal";

		// Token: 0x040029F0 RID: 10736
		private const string COMMAND = "select BinData from `NewTowerMedal` where SeasonId=?";

		// Token: 0x040029F1 RID: 10737
		private const string KEY_PREFIX = "NewTowerMedalBySeasonId";

		// Token: 0x040029F2 RID: 10738
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029F3 RID: 10739
		private static int HandleId;
	}
}
