using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E3 RID: 2019
	public class ConfigRegressBaseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F64 RID: 12132 RVA: 0x00168A68 File Offset: 0x00166C68
		static ConfigRegressBaseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBaseAll.CreateStaticDefaultValue), new Action(ConfigRegressBaseAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00168A88 File Offset: 0x00166C88
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressBaseAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressBaseAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressBase"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressBase`")
			});
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00168B07 File Offset: 0x00166D07
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBaseAll.LogPair = null;
			ConfigRegressBaseAll.HandleId = 0;
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00168B15 File Offset: 0x00166D15
		public static void Init()
		{
			ConfigRegressBaseAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBaseAll.HandleId, "db_regressactivity.db", "select BinData from `RegressBase`");
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00168B30 File Offset: 0x00166D30
		[NullableContext(2)]
		public static IReadOnlyList<RegressBase> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressBaseAll.HandleId, ConfigRegressBaseAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressBase> readOnlyList = (IReadOnlyList<RegressBase>)ConfigCommon.GetConfig("RegressBaseAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressBase> list = new List<RegressBase>();
			while (ConfigCommon.Step(ConfigRegressBaseAll.HandleId, false, ConfigRegressBaseAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressBaseAll.HandleId, 0, ConfigRegressBaseAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressBaseAll.HandleId, ConfigRegressBaseAll.LogPair);
					return null;
				}
				RegressBase rootAsRegressBase = RegressBase.GetRootAsRegressBase(new ByteBuffer(item2));
				list.Add(rootAsRegressBase);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressBaseAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressBaseAll.HandleId, ConfigRegressBaseAll.LogPair);
			return list;
		}

		// Token: 0x0400371B RID: 14107
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400371C RID: 14108
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400371D RID: 14109
		private const string TABLE = "RegressBase";

		// Token: 0x0400371E RID: 14110
		private const string COMMAND = "select BinData from `RegressBase`";

		// Token: 0x0400371F RID: 14111
		private const string KEY_PREFIX = "RegressBaseAll";

		// Token: 0x04003720 RID: 14112
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003721 RID: 14113
		private static int HandleId;
	}
}
