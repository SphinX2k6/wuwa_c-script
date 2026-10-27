using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C7 RID: 1991
	public class ConfigRegressBaseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EBC RID: 11964 RVA: 0x00161780 File Offset: 0x0015F980
		static ConfigRegressBaseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBaseAll.CreateStaticDefaultValue), new Action(ConfigRegressBaseAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x001617A0 File Offset: 0x0015F9A0
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

		// Token: 0x06002EBE RID: 11966 RVA: 0x0016181F File Offset: 0x0015FA1F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBaseAll.LogPair = null;
			ConfigRegressBaseAll.HandleId = 0;
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x0016182D File Offset: 0x0015FA2D
		public static void Init()
		{
			ConfigRegressBaseAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBaseAll.HandleId, "db_regressactivity.db", "select BinData from `RegressBase`");
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00161848 File Offset: 0x0015FA48
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

		// Token: 0x04003657 RID: 13911
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003658 RID: 13912
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003659 RID: 13913
		private const string TABLE = "RegressBase";

		// Token: 0x0400365A RID: 13914
		private const string COMMAND = "select BinData from `RegressBase`";

		// Token: 0x0400365B RID: 13915
		private const string KEY_PREFIX = "RegressBaseAll";

		// Token: 0x0400365C RID: 13916
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400365D RID: 13917
		private static int HandleId;
	}
}
