using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000834 RID: 2100
	public class ConfigRogueResBondRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600314A RID: 12618 RVA: 0x0017015C File Offset: 0x0016E35C
		static ConfigRogueResBondRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondRoleAll.CreateStaticDefaultValue), new Action(ConfigRogueResBondRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x0017017C File Offset: 0x0016E37C
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

		// Token: 0x0600314C RID: 12620 RVA: 0x001701FB File Offset: 0x0016E3FB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondRoleAll.LogPair = null;
			ConfigRogueResBondRoleAll.HandleId = 0;
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x00170209 File Offset: 0x0016E409
		public static void Init()
		{
			ConfigRogueResBondRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondRoleAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBondRole`");
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x00170224 File Offset: 0x0016E424
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

		// Token: 0x04003952 RID: 14674
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003953 RID: 14675
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003954 RID: 14676
		private const string TABLE = "RogueResBondRole";

		// Token: 0x04003955 RID: 14677
		private const string COMMAND = "select BinData from `RogueResBondRole`";

		// Token: 0x04003956 RID: 14678
		private const string KEY_PREFIX = "RogueResBondRoleAll";

		// Token: 0x04003957 RID: 14679
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003958 RID: 14680
		private static int HandleId;
	}
}
