using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048A RID: 1162
	public class ConfigKSCBasePropertyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B46 RID: 6982 RVA: 0x000F7270 File Offset: 0x000F5470
		static ConfigKSCBasePropertyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBasePropertyAll.CreateStaticDefaultValue), new Action(ConfigKSCBasePropertyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x000F7290 File Offset: 0x000F5490
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCBasePropertyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCBasePropertyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kscproperty.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombat属性.xlsx"),
				new ValueTuple<string, object>("表名", "KSCBaseProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCBaseProperty`")
			});
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x000F730F File Offset: 0x000F550F
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBasePropertyAll.LogPair = null;
			ConfigKSCBasePropertyAll.HandleId = 0;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x000F731D File Offset: 0x000F551D
		public static void Init()
		{
			ConfigKSCBasePropertyAll.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBasePropertyAll.HandleId, "db_kscproperty.db", "select BinData from `KSCBaseProperty`");
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000F7338 File Offset: 0x000F5538
		[NullableContext(2)]
		public static IReadOnlyList<KSCBaseProperty> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCBasePropertyAll.HandleId, ConfigKSCBasePropertyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KSCBaseProperty> readOnlyList = (IReadOnlyList<KSCBaseProperty>)ConfigCommon.GetConfig("KSCBasePropertyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KSCBaseProperty> list = new List<KSCBaseProperty>();
			while (ConfigCommon.Step(ConfigKSCBasePropertyAll.HandleId, false, ConfigKSCBasePropertyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCBasePropertyAll.HandleId, 0, ConfigKSCBasePropertyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKSCBasePropertyAll.HandleId, ConfigKSCBasePropertyAll.LogPair);
					return null;
				}
				KSCBaseProperty rootAsKSCBaseProperty = KSCBaseProperty.GetRootAsKSCBaseProperty(new ByteBuffer(item2));
				list.Add(rootAsKSCBaseProperty);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KSCBasePropertyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKSCBasePropertyAll.HandleId, ConfigKSCBasePropertyAll.LogPair);
			return list;
		}

		// Token: 0x04001FAA RID: 8106
		private const string DB = "db_kscproperty.db";

		// Token: 0x04001FAB RID: 8107
		private const string FILE = "s.SimpleCombat属性.xlsx";

		// Token: 0x04001FAC RID: 8108
		private const string TABLE = "KSCBaseProperty";

		// Token: 0x04001FAD RID: 8109
		private const string COMMAND = "select BinData from `KSCBaseProperty`";

		// Token: 0x04001FAE RID: 8110
		private const string KEY_PREFIX = "KSCBasePropertyAll";

		// Token: 0x04001FAF RID: 8111
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FB0 RID: 8112
		private static int HandleId;
	}
}
