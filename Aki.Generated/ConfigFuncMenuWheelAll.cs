using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036D RID: 877
	public class ConfigFuncMenuWheelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x000D158C File Offset: 0x000CF78C
		static ConfigFuncMenuWheelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuWheelAll.CreateStaticDefaultValue), new Action(ConfigFuncMenuWheelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000D15AC File Offset: 0x000CF7AC
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

		// Token: 0x06001495 RID: 5269 RVA: 0x000D162B File Offset: 0x000CF82B
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuWheelAll.LogPair = null;
			ConfigFuncMenuWheelAll.HandleId = 0;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x000D1639 File Offset: 0x000CF839
		public static void Init()
		{
			ConfigFuncMenuWheelAll.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuWheelAll.HandleId, "db_roulette.db", "select BinData from `FuncMenuWheel`");
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000D1654 File Offset: 0x000CF854
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

		// Token: 0x040017DF RID: 6111
		private const string DB = "db_roulette.db";

		// Token: 0x040017E0 RID: 6112
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x040017E1 RID: 6113
		private const string TABLE = "FuncMenuWheel";

		// Token: 0x040017E2 RID: 6114
		private const string COMMAND = "select BinData from `FuncMenuWheel`";

		// Token: 0x040017E3 RID: 6115
		private const string KEY_PREFIX = "FuncMenuWheelAll";

		// Token: 0x040017E4 RID: 6116
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017E5 RID: 6117
		private static int HandleId;
	}
}
