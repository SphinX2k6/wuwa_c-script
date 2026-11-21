using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057E RID: 1406
	public class ConfigMoraleLevelDiffShowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002101 RID: 8449 RVA: 0x00117858 File Offset: 0x00115A58
		static ConfigMoraleLevelDiffShowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLevelDiffShowAll.CreateStaticDefaultValue), new Action(ConfigMoraleLevelDiffShowAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00117878 File Offset: 0x00115A78
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleLevelDiffShowAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleLevelDiffShowAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleLevelDiffShow"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleLevelDiffShow`")
			});
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x001178F7 File Offset: 0x00115AF7
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLevelDiffShowAll.LogPair = null;
			ConfigMoraleLevelDiffShowAll.HandleId = 0;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00117905 File Offset: 0x00115B05
		public static void Init()
		{
			ConfigMoraleLevelDiffShowAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLevelDiffShowAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleLevelDiffShow`");
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00117920 File Offset: 0x00115B20
		[NullableContext(2)]
		public static IReadOnlyList<MoraleLevelDiffShow> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleLevelDiffShowAll.HandleId, ConfigMoraleLevelDiffShowAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MoraleLevelDiffShow> readOnlyList = (IReadOnlyList<MoraleLevelDiffShow>)ConfigCommon.GetConfig("MoraleLevelDiffShowAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MoraleLevelDiffShow> list = new List<MoraleLevelDiffShow>();
			while (ConfigCommon.Step(ConfigMoraleLevelDiffShowAll.HandleId, false, ConfigMoraleLevelDiffShowAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleLevelDiffShowAll.HandleId, 0, ConfigMoraleLevelDiffShowAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMoraleLevelDiffShowAll.HandleId, ConfigMoraleLevelDiffShowAll.LogPair);
					return null;
				}
				MoraleLevelDiffShow rootAsMoraleLevelDiffShow = MoraleLevelDiffShow.GetRootAsMoraleLevelDiffShow(new ByteBuffer(item2));
				list.Add(rootAsMoraleLevelDiffShow);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MoraleLevelDiffShowAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMoraleLevelDiffShowAll.HandleId, ConfigMoraleLevelDiffShowAll.LogPair);
			return list;
		}

		// Token: 0x04002656 RID: 9814
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002657 RID: 9815
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002658 RID: 9816
		private const string TABLE = "MoraleLevelDiffShow";

		// Token: 0x04002659 RID: 9817
		private const string COMMAND = "select BinData from `MoraleLevelDiffShow`";

		// Token: 0x0400265A RID: 9818
		private const string KEY_PREFIX = "MoraleLevelDiffShowAll";

		// Token: 0x0400265B RID: 9819
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400265C RID: 9820
		private static int HandleId;
	}
}
