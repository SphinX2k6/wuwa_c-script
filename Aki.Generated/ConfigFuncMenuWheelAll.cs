using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000358 RID: 856
	public class ConfigFuncMenuWheelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001415 RID: 5141 RVA: 0x000CB080 File Offset: 0x000C9280
		static ConfigFuncMenuWheelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuWheelAll.CreateStaticDefaultValue), new Action(ConfigFuncMenuWheelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000CB0A0 File Offset: 0x000C92A0
		public static void CreateStaticDefaultValue()
		{
			ConfigFuncMenuWheelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFuncMenuWheelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roulette.db"),
				new ValueTuple<string, object>("文件", "l.轮盘.xlsx"),
				new ValueTuple<string, object>("表名", "FuncMenuWheel"),
				new ValueTuple<string, object>("语句", "select BinData from `FuncMenuWheel`")
			});
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000CB11F File Offset: 0x000C931F
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuWheelAll.LogPair = null;
			ConfigFuncMenuWheelAll.HandleId = 0;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x000CB12D File Offset: 0x000C932D
		public static void Init()
		{
			ConfigFuncMenuWheelAll.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuWheelAll.HandleId, "db_roulette.db", "select BinData from `FuncMenuWheel`");
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000CB148 File Offset: 0x000C9348
		[NullableContext(2)]
		public static IReadOnlyList<FuncMenuWheel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFuncMenuWheelAll.HandleId, ConfigFuncMenuWheelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FuncMenuWheel> readOnlyList = (IReadOnlyList<FuncMenuWheel>)ConfigCommon.GetConfig("FuncMenuWheelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FuncMenuWheel> list = new List<FuncMenuWheel>();
			while (ConfigCommon.Step(ConfigFuncMenuWheelAll.HandleId, false, ConfigFuncMenuWheelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFuncMenuWheelAll.HandleId, 0, ConfigFuncMenuWheelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFuncMenuWheelAll.HandleId, ConfigFuncMenuWheelAll.LogPair);
					return null;
				}
				FuncMenuWheel rootAsFuncMenuWheel = FuncMenuWheel.GetRootAsFuncMenuWheel(new ByteBuffer(item2));
				list.Add(rootAsFuncMenuWheel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FuncMenuWheelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFuncMenuWheelAll.HandleId, ConfigFuncMenuWheelAll.LogPair);
			return list;
		}

		// Token: 0x0400174C RID: 5964
		private const string DB = "db_roulette.db";

		// Token: 0x0400174D RID: 5965
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x0400174E RID: 5966
		private const string TABLE = "FuncMenuWheel";

		// Token: 0x0400174F RID: 5967
		private const string COMMAND = "select BinData from `FuncMenuWheel`";

		// Token: 0x04001750 RID: 5968
		private const string KEY_PREFIX = "FuncMenuWheelAll";

		// Token: 0x04001751 RID: 5969
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001752 RID: 5970
		private static int HandleId;
	}
}
