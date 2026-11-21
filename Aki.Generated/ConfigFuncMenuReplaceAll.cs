using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036A RID: 874
	public class ConfigFuncMenuReplaceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001481 RID: 5249 RVA: 0x000D0F67 File Offset: 0x000CF167
		static ConfigFuncMenuReplaceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuReplaceAll.CreateStaticDefaultValue), new Action(ConfigFuncMenuReplaceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x000D0F88 File Offset: 0x000CF188
		public static void CreateStaticDefaultValue()
		{
			ConfigFuncMenuReplaceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFuncMenuReplaceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roulette.db"),
				new ValueTuple<string, object>("文件", "l.轮盘.xlsx"),
				new ValueTuple<string, object>("表名", "FuncMenuReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `FuncMenuReplace`")
			});
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000D1007 File Offset: 0x000CF207
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuReplaceAll.LogPair = null;
			ConfigFuncMenuReplaceAll.HandleId = 0;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000D1015 File Offset: 0x000CF215
		public static void Init()
		{
			ConfigFuncMenuReplaceAll.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuReplaceAll.HandleId, "db_roulette.db", "select BinData from `FuncMenuReplace`");
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x000D1030 File Offset: 0x000CF230
		[NullableContext(2)]
		public static IReadOnlyList<FuncMenuReplace> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFuncMenuReplaceAll.HandleId, ConfigFuncMenuReplaceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FuncMenuReplace> readOnlyList = (IReadOnlyList<FuncMenuReplace>)ConfigCommon.GetConfig("FuncMenuReplaceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FuncMenuReplace> list = new List<FuncMenuReplace>();
			while (ConfigCommon.Step(ConfigFuncMenuReplaceAll.HandleId, false, ConfigFuncMenuReplaceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFuncMenuReplaceAll.HandleId, 0, ConfigFuncMenuReplaceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFuncMenuReplaceAll.HandleId, ConfigFuncMenuReplaceAll.LogPair);
					return null;
				}
				FuncMenuReplace rootAsFuncMenuReplace = FuncMenuReplace.GetRootAsFuncMenuReplace(new ByteBuffer(item2));
				list.Add(rootAsFuncMenuReplace);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FuncMenuReplaceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFuncMenuReplaceAll.HandleId, ConfigFuncMenuReplaceAll.LogPair);
			return list;
		}

		// Token: 0x040017CA RID: 6090
		private const string DB = "db_roulette.db";

		// Token: 0x040017CB RID: 6091
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x040017CC RID: 6092
		private const string TABLE = "FuncMenuReplace";

		// Token: 0x040017CD RID: 6093
		private const string COMMAND = "select BinData from `FuncMenuReplace`";

		// Token: 0x040017CE RID: 6094
		private const string KEY_PREFIX = "FuncMenuReplaceAll";

		// Token: 0x040017CF RID: 6095
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017D0 RID: 6096
		private static int HandleId;
	}
}
