using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FA RID: 762
	public class ConfigFlagChallengeLevelDiffShowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x000BE92C File Offset: 0x000BCB2C
		static ConfigFlagChallengeLevelDiffShowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeLevelDiffShowAll.CreateStaticDefaultValue), new Action(ConfigFlagChallengeLevelDiffShowAll.ResetStaticDefaultValue));
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000BE94C File Offset: 0x000BCB4C
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeLevelDiffShowAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeLevelDiffShowAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeLevelDiffShow"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeLevelDiffShow`")
			});
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000BE9CB File Offset: 0x000BCBCB
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeLevelDiffShowAll.LogPair = null;
			ConfigFlagChallengeLevelDiffShowAll.HandleId = 0;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x000BE9D9 File Offset: 0x000BCBD9
		public static void Init()
		{
			ConfigFlagChallengeLevelDiffShowAll.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeLevelDiffShowAll.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeLevelDiffShow`");
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000BE9F4 File Offset: 0x000BCBF4
		[NullableContext(2)]
		public static IReadOnlyList<FlagChallengeLevelDiffShow> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeLevelDiffShowAll.HandleId, ConfigFlagChallengeLevelDiffShowAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FlagChallengeLevelDiffShow> readOnlyList = (IReadOnlyList<FlagChallengeLevelDiffShow>)ConfigCommon.GetConfig("FlagChallengeLevelDiffShowAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FlagChallengeLevelDiffShow> list = new List<FlagChallengeLevelDiffShow>();
			while (ConfigCommon.Step(ConfigFlagChallengeLevelDiffShowAll.HandleId, false, ConfigFlagChallengeLevelDiffShowAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeLevelDiffShowAll.HandleId, 0, ConfigFlagChallengeLevelDiffShowAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagChallengeLevelDiffShowAll.HandleId, ConfigFlagChallengeLevelDiffShowAll.LogPair);
					return null;
				}
				FlagChallengeLevelDiffShow rootAsFlagChallengeLevelDiffShow = FlagChallengeLevelDiffShow.GetRootAsFlagChallengeLevelDiffShow(new ByteBuffer(item2));
				list.Add(rootAsFlagChallengeLevelDiffShow);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FlagChallengeLevelDiffShowAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagChallengeLevelDiffShowAll.HandleId, ConfigFlagChallengeLevelDiffShowAll.LogPair);
			return list;
		}

		// Token: 0x040014BA RID: 5306
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014BB RID: 5307
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014BC RID: 5308
		private const string TABLE = "FlagChallengeLevelDiffShow";

		// Token: 0x040014BD RID: 5309
		private const string COMMAND = "select BinData from `FlagChallengeLevelDiffShow`";

		// Token: 0x040014BE RID: 5310
		private const string KEY_PREFIX = "FlagChallengeLevelDiffShowAll";

		// Token: 0x040014BF RID: 5311
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014C0 RID: 5312
		private static int HandleId;
	}
}
