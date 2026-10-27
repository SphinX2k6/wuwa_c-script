using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F8 RID: 2296
	public class ConfigRoverRogueTalentTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035E3 RID: 13795 RVA: 0x00189ED0 File Offset: 0x001880D0
		static ConfigRoverRogueTalentTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueTalentTreeAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueTalentTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x00189EF0 File Offset: 0x001880F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueTalentTreeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueTalentTree`")
			});
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00189F6F File Offset: 0x0018816F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeAll.LogPair = null;
			ConfigRoverRogueTalentTreeAll.HandleId = 0;
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00189F7D File Offset: 0x0018817D
		public static void Init()
		{
			ConfigRoverRogueTalentTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueTalentTreeAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueTalentTree`");
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00189F98 File Offset: 0x00188198
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueTalentTree> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueTalentTreeAll.HandleId, ConfigRoverRogueTalentTreeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueTalentTree> readOnlyList = (IReadOnlyList<RoverRogueTalentTree>)ConfigCommon.GetConfig("RoverRogueTalentTreeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueTalentTree> list = new List<RoverRogueTalentTree>();
			while (ConfigCommon.Step(ConfigRoverRogueTalentTreeAll.HandleId, false, ConfigRoverRogueTalentTreeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueTalentTreeAll.HandleId, 0, ConfigRoverRogueTalentTreeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueTalentTreeAll.HandleId, ConfigRoverRogueTalentTreeAll.LogPair);
					return null;
				}
				RoverRogueTalentTree rootAsRoverRogueTalentTree = RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueTalentTree);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueTalentTreeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueTalentTreeAll.HandleId, ConfigRoverRogueTalentTreeAll.LogPair);
			return list;
		}

		// Token: 0x04003EAE RID: 16046
		private const string DB = "db_roverlike.db";

		// Token: 0x04003EAF RID: 16047
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003EB0 RID: 16048
		private const string TABLE = "RoverRogueTalentTree";

		// Token: 0x04003EB1 RID: 16049
		private const string COMMAND = "select BinData from `RoverRogueTalentTree`";

		// Token: 0x04003EB2 RID: 16050
		private const string KEY_PREFIX = "RoverRogueTalentTreeAll";

		// Token: 0x04003EB3 RID: 16051
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EB4 RID: 16052
		private static int HandleId;
	}
}
