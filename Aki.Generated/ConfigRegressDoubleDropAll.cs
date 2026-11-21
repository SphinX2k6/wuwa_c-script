using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E9 RID: 2025
	public class ConfigRegressDoubleDropAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F88 RID: 12168 RVA: 0x001696E4 File Offset: 0x001678E4
		static ConfigRegressDoubleDropAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDoubleDropAll.CreateStaticDefaultValue), new Action(ConfigRegressDoubleDropAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00169704 File Offset: 0x00167904
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressDoubleDropAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressDoubleDropAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressDoubleDrop"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressDoubleDrop`")
			});
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00169783 File Offset: 0x00167983
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDoubleDropAll.LogPair = null;
			ConfigRegressDoubleDropAll.HandleId = 0;
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00169791 File Offset: 0x00167991
		public static void Init()
		{
			ConfigRegressDoubleDropAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDoubleDropAll.HandleId, "db_regressactivity.db", "select BinData from `RegressDoubleDrop`");
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x001697AC File Offset: 0x001679AC
		[NullableContext(2)]
		public static IReadOnlyList<RegressDoubleDrop> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressDoubleDropAll.HandleId, ConfigRegressDoubleDropAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressDoubleDrop> readOnlyList = (IReadOnlyList<RegressDoubleDrop>)ConfigCommon.GetConfig("RegressDoubleDropAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressDoubleDrop> list = new List<RegressDoubleDrop>();
			while (ConfigCommon.Step(ConfigRegressDoubleDropAll.HandleId, false, ConfigRegressDoubleDropAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressDoubleDropAll.HandleId, 0, ConfigRegressDoubleDropAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressDoubleDropAll.HandleId, ConfigRegressDoubleDropAll.LogPair);
					return null;
				}
				RegressDoubleDrop rootAsRegressDoubleDrop = RegressDoubleDrop.GetRootAsRegressDoubleDrop(new ByteBuffer(item2));
				list.Add(rootAsRegressDoubleDrop);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressDoubleDropAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressDoubleDropAll.HandleId, ConfigRegressDoubleDropAll.LogPair);
			return list;
		}

		// Token: 0x04003745 RID: 14149
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003746 RID: 14150
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003747 RID: 14151
		private const string TABLE = "RegressDoubleDrop";

		// Token: 0x04003748 RID: 14152
		private const string COMMAND = "select BinData from `RegressDoubleDrop`";

		// Token: 0x04003749 RID: 14153
		private const string KEY_PREFIX = "RegressDoubleDropAll";

		// Token: 0x0400374A RID: 14154
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400374B RID: 14155
		private static int HandleId;
	}
}
