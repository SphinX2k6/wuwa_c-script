using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000850 RID: 2128
	public class ConfigRogueResBondRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031F2 RID: 12786 RVA: 0x00177444 File Offset: 0x00175644
		static ConfigRogueResBondRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondRoleAll.CreateStaticDefaultValue), new Action(ConfigRogueResBondRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00177464 File Offset: 0x00175664
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBondRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBondRole`")
			});
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x001774E3 File Offset: 0x001756E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondRoleAll.LogPair = null;
			ConfigRogueResBondRoleAll.HandleId = 0;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x001774F1 File Offset: 0x001756F1
		public static void Init()
		{
			ConfigRogueResBondRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondRoleAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBondRole`");
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0017750C File Offset: 0x0017570C
		[NullableContext(2)]
		public static IReadOnlyList<RogueResBondRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondRoleAll.HandleId, ConfigRogueResBondRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResBondRole> readOnlyList = (IReadOnlyList<RogueResBondRole>)ConfigCommon.GetConfig("RogueResBondRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResBondRole> list = new List<RogueResBondRole>();
			while (ConfigCommon.Step(ConfigRogueResBondRoleAll.HandleId, false, ConfigRogueResBondRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondRoleAll.HandleId, 0, ConfigRogueResBondRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResBondRoleAll.HandleId, ConfigRogueResBondRoleAll.LogPair);
					return null;
				}
				RogueResBondRole rootAsRogueResBondRole = RogueResBondRole.GetRootAsRogueResBondRole(new ByteBuffer(item2));
				list.Add(rootAsRogueResBondRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResBondRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResBondRoleAll.HandleId, ConfigRogueResBondRoleAll.LogPair);
			return list;
		}

		// Token: 0x04003A16 RID: 14870
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A17 RID: 14871
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A18 RID: 14872
		private const string TABLE = "RogueResBondRole";

		// Token: 0x04003A19 RID: 14873
		private const string COMMAND = "select BinData from `RogueResBondRole`";

		// Token: 0x04003A1A RID: 14874
		private const string KEY_PREFIX = "RogueResBondRoleAll";

		// Token: 0x04003A1B RID: 14875
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A1C RID: 14876
		private static int HandleId;
	}
}
