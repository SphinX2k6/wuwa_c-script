using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030F RID: 783
	public class ConfigFlagChallengeLevelDiffShowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600125F RID: 4703 RVA: 0x000C4E38 File Offset: 0x000C3038
		static ConfigFlagChallengeLevelDiffShowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeLevelDiffShowAll.CreateStaticDefaultValue), new Action(ConfigFlagChallengeLevelDiffShowAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000C4E58 File Offset: 0x000C3058
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

		// Token: 0x06001261 RID: 4705 RVA: 0x000C4ED7 File Offset: 0x000C30D7
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeLevelDiffShowAll.LogPair = null;
			ConfigFlagChallengeLevelDiffShowAll.HandleId = 0;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000C4EE5 File Offset: 0x000C30E5
		public static void Init()
		{
			ConfigFlagChallengeLevelDiffShowAll.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeLevelDiffShowAll.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeLevelDiffShow`");
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000C4F00 File Offset: 0x000C3100
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

		// Token: 0x0400154D RID: 5453
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400154E RID: 5454
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x0400154F RID: 5455
		private const string TABLE = "FlagChallengeLevelDiffShow";

		// Token: 0x04001550 RID: 5456
		private const string COMMAND = "select BinData from `FlagChallengeLevelDiffShow`";

		// Token: 0x04001551 RID: 5457
		private const string KEY_PREFIX = "FlagChallengeLevelDiffShowAll";

		// Token: 0x04001552 RID: 5458
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001553 RID: 5459
		private static int HandleId;
	}
}
