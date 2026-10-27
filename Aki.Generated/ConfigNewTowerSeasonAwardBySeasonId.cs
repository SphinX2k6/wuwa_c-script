using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060B RID: 1547
	public class ConfigNewTowerSeasonAwardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002452 RID: 9298 RVA: 0x00126EA0 File Offset: 0x001250A0
		static ConfigNewTowerSeasonAwardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonAwardBySeasonId.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonAwardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00126EC0 File Offset: 0x001250C0
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonAwardBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonAwardBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeasonAward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeasonAward` where SeasonId=?")
			});
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00126F3F File Offset: 0x0012513F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonAwardBySeasonId.LogPair = null;
			ConfigNewTowerSeasonAwardBySeasonId.HandleId = 0;
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00126F4D File Offset: 0x0012514D
		public static void Init()
		{
			ConfigNewTowerSeasonAwardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonAwardBySeasonId.HandleId, "db_newtower.db", "select BinData from `NewTowerSeasonAward` where SeasonId=?");
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00126F68 File Offset: 0x00125168
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerSeasonAward> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonAwardBySeasonId.HandleId, ConfigNewTowerSeasonAwardBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonAwardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<NewTowerSeasonAward> readOnlyList = (IReadOnlyList<NewTowerSeasonAward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewTowerSeasonAwardBySeasonId.LogPair.Clear();
			ConfigNewTowerSeasonAwardBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigNewTowerSeasonAwardBySeasonId.HandleId, 1, p0SeasonId, ConfigNewTowerSeasonAwardBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonAwardBySeasonId.HandleId, ConfigNewTowerSeasonAwardBySeasonId.LogPair);
				return null;
			}
			List<NewTowerSeasonAward> list = new List<NewTowerSeasonAward>();
			while (ConfigCommon.Step(ConfigNewTowerSeasonAwardBySeasonId.HandleId, false, ConfigNewTowerSeasonAwardBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonAwardBySeasonId.HandleId, 0, ConfigNewTowerSeasonAwardBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerSeasonAwardBySeasonId.HandleId, ConfigNewTowerSeasonAwardBySeasonId.LogPair);
					return null;
				}
				NewTowerSeasonAward rootAsNewTowerSeasonAward = NewTowerSeasonAward.GetRootAsNewTowerSeasonAward(new ByteBuffer(item2));
				list.Add(rootAsNewTowerSeasonAward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonAwardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonAwardBySeasonId.HandleId, ConfigNewTowerSeasonAwardBySeasonId.LogPair);
			return list;
		}

		// Token: 0x04002A33 RID: 10803
		private const string DB = "db_newtower.db";

		// Token: 0x04002A34 RID: 10804
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A35 RID: 10805
		private const string TABLE = "NewTowerSeasonAward";

		// Token: 0x04002A36 RID: 10806
		private const string COMMAND = "select BinData from `NewTowerSeasonAward` where SeasonId=?";

		// Token: 0x04002A37 RID: 10807
		private const string KEY_PREFIX = "NewTowerSeasonAwardBySeasonId";

		// Token: 0x04002A38 RID: 10808
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A39 RID: 10809
		private static int HandleId;
	}
}
