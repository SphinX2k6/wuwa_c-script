using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B6 RID: 2230
	public class ConfigRoleMorphAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003457 RID: 13399 RVA: 0x0018113D File Offset: 0x0017F33D
		static ConfigRoleMorphAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphAll.CreateStaticDefaultValue), new Action(ConfigRoleMorphAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x0018115C File Offset: 0x0017F35C
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

		// Token: 0x06003459 RID: 13401 RVA: 0x001811DB File Offset: 0x0017F3DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphAll.LogPair = null;
			ConfigRoleMorphAll.HandleId = 0;
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x001811E9 File Offset: 0x0017F3E9
		public static void Init()
		{
			ConfigRoleMorphAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphAll.HandleId, "db_role.db", "select BinData from `RoleMorph`");
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00181204 File Offset: 0x0017F404
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

		// Token: 0x04003CE0 RID: 15584
		private const string DB = "db_role.db";

		// Token: 0x04003CE1 RID: 15585
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003CE2 RID: 15586
		private const string TABLE = "RoleMorph";

		// Token: 0x04003CE3 RID: 15587
		private const string COMMAND = "select BinData from `RoleMorph`";

		// Token: 0x04003CE4 RID: 15588
		private const string KEY_PREFIX = "RoleMorphAll";

		// Token: 0x04003CE5 RID: 15589
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CE6 RID: 15590
		private static int HandleId;
	}
}
