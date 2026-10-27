using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000352 RID: 850
	public class ConfigFormationPropertyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013F1 RID: 5105 RVA: 0x000CA4EB File Offset: 0x000C86EB
		static ConfigFormationPropertyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationPropertyAll.CreateStaticDefaultValue), new Action(ConfigFormationPropertyAll.ResetStaticDefaultValue));
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x000CA50C File Offset: 0x000C870C
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

		// Token: 0x060013F3 RID: 5107 RVA: 0x000CA58B File Offset: 0x000C878B
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationPropertyAll.LogPair = null;
			ConfigFormationPropertyAll.HandleId = 0;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x000CA599 File Offset: 0x000C8799
		public static void Init()
		{
			ConfigFormationPropertyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFormationPropertyAll.HandleId, "db_formationproperty.db", "select BinData from `FormationProperty`");
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x000CA5B4 File Offset: 0x000C87B4
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

		// Token: 0x04001722 RID: 5922
		private const string DB = "db_formationproperty.db";

		// Token: 0x04001723 RID: 5923
		private const string FILE = "d.队伍属性表.xlsx";

		// Token: 0x04001724 RID: 5924
		private const string TABLE = "FormationProperty";

		// Token: 0x04001725 RID: 5925
		private const string COMMAND = "select BinData from `FormationProperty`";

		// Token: 0x04001726 RID: 5926
		private const string KEY_PREFIX = "FormationPropertyAll";

		// Token: 0x04001727 RID: 5927
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001728 RID: 5928
		private static int HandleId;
	}
}
