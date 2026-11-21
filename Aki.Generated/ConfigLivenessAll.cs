using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F7 RID: 1271
	public class ConfigLivenessAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DD5 RID: 7637 RVA: 0x001056CC File Offset: 0x001038CC
		static ConfigLivenessAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLivenessAll.CreateStaticDefaultValue), new Action(ConfigLivenessAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x001056EC File Offset: 0x001038EC
		public static void CreateStaticDefaultValue()
		{
			ConfigLivenessAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLivenessAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_daily_activity.db"),
				new ValueTuple<string, object>("文件", "h.活跃度.xlsx"),
				new ValueTuple<string, object>("表名", "Liveness"),
				new ValueTuple<string, object>("语句", "select BinData from `Liveness`")
			});
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0010576B File Offset: 0x0010396B
		public static void ResetStaticDefaultValue()
		{
			ConfigLivenessAll.LogPair = null;
			ConfigLivenessAll.HandleId = 0;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00105779 File Offset: 0x00103979
		public static void Init()
		{
			ConfigLivenessAll.HandleId = ConfigCommon.InitDataStatement(ConfigLivenessAll.HandleId, "db_daily_activity.db", "select BinData from `Liveness`");
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00105794 File Offset: 0x00103994
		[NullableContext(2)]
		public static IReadOnlyList<Liveness> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLivenessAll.HandleId, ConfigLivenessAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Liveness> readOnlyList = (IReadOnlyList<Liveness>)ConfigCommon.GetConfig("LivenessAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Liveness> list = new List<Liveness>();
			while (ConfigCommon.Step(ConfigLivenessAll.HandleId, false, ConfigLivenessAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLivenessAll.HandleId, 0, ConfigLivenessAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLivenessAll.HandleId, ConfigLivenessAll.LogPair);
					return null;
				}
				Liveness rootAsLiveness = Liveness.GetRootAsLiveness(new ByteBuffer(item2));
				list.Add(rootAsLiveness);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LivenessAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLivenessAll.HandleId, ConfigLivenessAll.LogPair);
			return list;
		}

		// Token: 0x040022A5 RID: 8869
		private const string DB = "db_daily_activity.db";

		// Token: 0x040022A6 RID: 8870
		private const string FILE = "h.活跃度.xlsx";

		// Token: 0x040022A7 RID: 8871
		private const string TABLE = "Liveness";

		// Token: 0x040022A8 RID: 8872
		private const string COMMAND = "select BinData from `Liveness`";

		// Token: 0x040022A9 RID: 8873
		private const string KEY_PREFIX = "LivenessAll";

		// Token: 0x040022AA RID: 8874
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022AB RID: 8875
		private static int HandleId;
	}
}
