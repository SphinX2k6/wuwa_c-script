using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000474 RID: 1140
	public class ConfigKSCBasePropertyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AC2 RID: 6850 RVA: 0x000F0B1C File Offset: 0x000EED1C
		static ConfigKSCBasePropertyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBasePropertyAll.CreateStaticDefaultValue), new Action(ConfigKSCBasePropertyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000F0B3C File Offset: 0x000EED3C
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

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000F0BBB File Offset: 0x000EEDBB
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBasePropertyAll.LogPair = null;
			ConfigKSCBasePropertyAll.HandleId = 0;
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000F0BC9 File Offset: 0x000EEDC9
		public static void Init()
		{
			ConfigKSCBasePropertyAll.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBasePropertyAll.HandleId, "db_kscproperty.db", "select BinData from `KSCBaseProperty`");
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000F0BE4 File Offset: 0x000EEDE4
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

		// Token: 0x04001F10 RID: 7952
		private const string DB = "db_kscproperty.db";

		// Token: 0x04001F11 RID: 7953
		private const string FILE = "s.SimpleCombat属性.xlsx";

		// Token: 0x04001F12 RID: 7954
		private const string TABLE = "KSCBaseProperty";

		// Token: 0x04001F13 RID: 7955
		private const string COMMAND = "select BinData from `KSCBaseProperty`";

		// Token: 0x04001F14 RID: 7956
		private const string KEY_PREFIX = "KSCBasePropertyAll";

		// Token: 0x04001F15 RID: 7957
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F16 RID: 7958
		private static int HandleId;
	}
}
