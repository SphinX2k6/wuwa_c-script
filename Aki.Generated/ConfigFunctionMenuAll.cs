using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035B RID: 859
	public class ConfigFunctionMenuAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001427 RID: 5159 RVA: 0x000CB6A4 File Offset: 0x000C98A4
		static ConfigFunctionMenuAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionMenuAll.CreateStaticDefaultValue), new Action(ConfigFunctionMenuAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000CB6C4 File Offset: 0x000C98C4
		public static void CreateStaticDefaultValue()
		{
			ConfigFunctionMenuAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunctionMenuAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_function.db"),
				new ValueTuple<string, object>("文件", "g.功能开启.xlsx"),
				new ValueTuple<string, object>("表名", "FunctionMenu"),
				new ValueTuple<string, object>("语句", "select BinData from `FunctionMenu`")
			});
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000CB743 File Offset: 0x000C9943
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionMenuAll.LogPair = null;
			ConfigFunctionMenuAll.HandleId = 0;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000CB751 File Offset: 0x000C9951
		public static void Init()
		{
			ConfigFunctionMenuAll.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionMenuAll.HandleId, "db_function.db", "select BinData from `FunctionMenu`");
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000CB76C File Offset: 0x000C996C
		[NullableContext(2)]
		public static IReadOnlyList<FunctionMenu> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunctionMenuAll.HandleId, ConfigFunctionMenuAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FunctionMenu> readOnlyList = (IReadOnlyList<FunctionMenu>)ConfigCommon.GetConfig("FunctionMenuAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FunctionMenu> list = new List<FunctionMenu>();
			while (ConfigCommon.Step(ConfigFunctionMenuAll.HandleId, false, ConfigFunctionMenuAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunctionMenuAll.HandleId, 0, ConfigFunctionMenuAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFunctionMenuAll.HandleId, ConfigFunctionMenuAll.LogPair);
					return null;
				}
				FunctionMenu rootAsFunctionMenu = FunctionMenu.GetRootAsFunctionMenu(new ByteBuffer(item2));
				list.Add(rootAsFunctionMenu);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FunctionMenuAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFunctionMenuAll.HandleId, ConfigFunctionMenuAll.LogPair);
			return list;
		}

		// Token: 0x04001761 RID: 5985
		private const string DB = "db_function.db";

		// Token: 0x04001762 RID: 5986
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x04001763 RID: 5987
		private const string TABLE = "FunctionMenu";

		// Token: 0x04001764 RID: 5988
		private const string COMMAND = "select BinData from `FunctionMenu`";

		// Token: 0x04001765 RID: 5989
		private const string KEY_PREFIX = "FunctionMenuAll";

		// Token: 0x04001766 RID: 5990
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001767 RID: 5991
		private static int HandleId;
	}
}
