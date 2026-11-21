using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000367 RID: 871
	public class ConfigFormationPropertyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600146F RID: 5231 RVA: 0x000D09F7 File Offset: 0x000CEBF7
		static ConfigFormationPropertyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationPropertyAll.CreateStaticDefaultValue), new Action(ConfigFormationPropertyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000D0A18 File Offset: 0x000CEC18
		public static void CreateStaticDefaultValue()
		{
			ConfigFormationPropertyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFormationPropertyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formationproperty.db"),
				new ValueTuple<string, object>("文件", "d.队伍属性表.xlsx"),
				new ValueTuple<string, object>("表名", "FormationProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `FormationProperty`")
			});
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000D0A97 File Offset: 0x000CEC97
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationPropertyAll.LogPair = null;
			ConfigFormationPropertyAll.HandleId = 0;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000D0AA5 File Offset: 0x000CECA5
		public static void Init()
		{
			ConfigFormationPropertyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFormationPropertyAll.HandleId, "db_formationproperty.db", "select BinData from `FormationProperty`");
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000D0AC0 File Offset: 0x000CECC0
		[NullableContext(2)]
		public static IReadOnlyList<FormationProperty> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFormationPropertyAll.HandleId, ConfigFormationPropertyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FormationProperty> readOnlyList = (IReadOnlyList<FormationProperty>)ConfigCommon.GetConfig("FormationPropertyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FormationProperty> list = new List<FormationProperty>();
			while (ConfigCommon.Step(ConfigFormationPropertyAll.HandleId, false, ConfigFormationPropertyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFormationPropertyAll.HandleId, 0, ConfigFormationPropertyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFormationPropertyAll.HandleId, ConfigFormationPropertyAll.LogPair);
					return null;
				}
				FormationProperty rootAsFormationProperty = FormationProperty.GetRootAsFormationProperty(new ByteBuffer(item2));
				list.Add(rootAsFormationProperty);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FormationPropertyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFormationPropertyAll.HandleId, ConfigFormationPropertyAll.LogPair);
			return list;
		}

		// Token: 0x040017B5 RID: 6069
		private const string DB = "db_formationproperty.db";

		// Token: 0x040017B6 RID: 6070
		private const string FILE = "d.队伍属性表.xlsx";

		// Token: 0x040017B7 RID: 6071
		private const string TABLE = "FormationProperty";

		// Token: 0x040017B8 RID: 6072
		private const string COMMAND = "select BinData from `FormationProperty`";

		// Token: 0x040017B9 RID: 6073
		private const string KEY_PREFIX = "FormationPropertyAll";

		// Token: 0x040017BA RID: 6074
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017BB RID: 6075
		private static int HandleId;
	}
}
