using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D2 RID: 2258
	public class ConfigRoleMorphAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034FF RID: 13567 RVA: 0x00188425 File Offset: 0x00186625
		static ConfigRoleMorphAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphAll.CreateStaticDefaultValue), new Action(ConfigRoleMorphAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00188444 File Offset: 0x00186644
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleMorphAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleMorphAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleMorph"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleMorph`")
			});
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x001884C3 File Offset: 0x001866C3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphAll.LogPair = null;
			ConfigRoleMorphAll.HandleId = 0;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x001884D1 File Offset: 0x001866D1
		public static void Init()
		{
			ConfigRoleMorphAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphAll.HandleId, "db_role.db", "select BinData from `RoleMorph`");
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x001884EC File Offset: 0x001866EC
		[NullableContext(2)]
		public static IReadOnlyList<RoleMorph> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleMorphAll.HandleId, ConfigRoleMorphAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleMorph> readOnlyList = (IReadOnlyList<RoleMorph>)ConfigCommon.GetConfig("RoleMorphAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleMorph> list = new List<RoleMorph>();
			while (ConfigCommon.Step(ConfigRoleMorphAll.HandleId, false, ConfigRoleMorphAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleMorphAll.HandleId, 0, ConfigRoleMorphAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleMorphAll.HandleId, ConfigRoleMorphAll.LogPair);
					return null;
				}
				RoleMorph rootAsRoleMorph = RoleMorph.GetRootAsRoleMorph(new ByteBuffer(item2));
				list.Add(rootAsRoleMorph);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleMorphAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleMorphAll.HandleId, ConfigRoleMorphAll.LogPair);
			return list;
		}

		// Token: 0x04003DA4 RID: 15780
		private const string DB = "db_role.db";

		// Token: 0x04003DA5 RID: 15781
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003DA6 RID: 15782
		private const string TABLE = "RoleMorph";

		// Token: 0x04003DA7 RID: 15783
		private const string COMMAND = "select BinData from `RoleMorph`";

		// Token: 0x04003DA8 RID: 15784
		private const string KEY_PREFIX = "RoleMorphAll";

		// Token: 0x04003DA9 RID: 15785
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DAA RID: 15786
		private static int HandleId;
	}
}
