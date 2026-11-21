using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030B RID: 779
	public class ConfigFlagChallengeAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x000C45DC File Offset: 0x000C27DC
		static ConfigFlagChallengeAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeAreaAll.CreateStaticDefaultValue), new Action(ConfigFlagChallengeAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000C45FC File Offset: 0x000C27FC
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeArea`")
			});
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000C467B File Offset: 0x000C287B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeAreaAll.LogPair = null;
			ConfigFlagChallengeAreaAll.HandleId = 0;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000C4689 File Offset: 0x000C2889
		public static void Init()
		{
			ConfigFlagChallengeAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeAreaAll.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeArea`");
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x000C46A4 File Offset: 0x000C28A4
		[NullableContext(2)]
		public static IReadOnlyList<FlagChallengeArea> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeAreaAll.HandleId, ConfigFlagChallengeAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FlagChallengeArea> readOnlyList = (IReadOnlyList<FlagChallengeArea>)ConfigCommon.GetConfig("FlagChallengeAreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FlagChallengeArea> list = new List<FlagChallengeArea>();
			while (ConfigCommon.Step(ConfigFlagChallengeAreaAll.HandleId, false, ConfigFlagChallengeAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeAreaAll.HandleId, 0, ConfigFlagChallengeAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagChallengeAreaAll.HandleId, ConfigFlagChallengeAreaAll.LogPair);
					return null;
				}
				FlagChallengeArea rootAsFlagChallengeArea = FlagChallengeArea.GetRootAsFlagChallengeArea(new ByteBuffer(item2));
				list.Add(rootAsFlagChallengeArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FlagChallengeAreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagChallengeAreaAll.HandleId, ConfigFlagChallengeAreaAll.LogPair);
			return list;
		}

		// Token: 0x04001531 RID: 5425
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001532 RID: 5426
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x04001533 RID: 5427
		private const string TABLE = "FlagChallengeArea";

		// Token: 0x04001534 RID: 5428
		private const string COMMAND = "select BinData from `FlagChallengeArea`";

		// Token: 0x04001535 RID: 5429
		private const string KEY_PREFIX = "FlagChallengeAreaAll";

		// Token: 0x04001536 RID: 5430
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001537 RID: 5431
		private static int HandleId;
	}
}
