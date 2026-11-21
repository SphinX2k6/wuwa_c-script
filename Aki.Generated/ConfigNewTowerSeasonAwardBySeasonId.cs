using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000623 RID: 1571
	public class ConfigNewTowerSeasonAwardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024E2 RID: 9442 RVA: 0x0012D91C File Offset: 0x0012BB1C
		static ConfigNewTowerSeasonAwardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonAwardBySeasonId.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonAwardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0012D93C File Offset: 0x0012BB3C
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

		// Token: 0x060024E4 RID: 9444 RVA: 0x0012D9BB File Offset: 0x0012BBBB
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonAwardBySeasonId.LogPair = null;
			ConfigNewTowerSeasonAwardBySeasonId.HandleId = 0;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0012D9C9 File Offset: 0x0012BBC9
		public static void Init()
		{
			ConfigNewTowerSeasonAwardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonAwardBySeasonId.HandleId, "db_newtower.db", "select BinData from `NewTowerSeasonAward` where SeasonId=?");
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x0012D9E4 File Offset: 0x0012BBE4
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

		// Token: 0x04002ADB RID: 10971
		private const string DB = "db_newtower.db";

		// Token: 0x04002ADC RID: 10972
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002ADD RID: 10973
		private const string TABLE = "NewTowerSeasonAward";

		// Token: 0x04002ADE RID: 10974
		private const string COMMAND = "select BinData from `NewTowerSeasonAward` where SeasonId=?";

		// Token: 0x04002ADF RID: 10975
		private const string KEY_PREFIX = "NewTowerSeasonAwardBySeasonId";

		// Token: 0x04002AE0 RID: 10976
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AE1 RID: 10977
		private static int HandleId;
	}
}
