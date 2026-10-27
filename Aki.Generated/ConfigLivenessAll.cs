using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E1 RID: 1249
	public class ConfigLivenessAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D51 RID: 7505 RVA: 0x000FEF78 File Offset: 0x000FD178
		static ConfigLivenessAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLivenessAll.CreateStaticDefaultValue), new Action(ConfigLivenessAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000FEF98 File Offset: 0x000FD198
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

		// Token: 0x06001D53 RID: 7507 RVA: 0x000FF017 File Offset: 0x000FD217
		public static void ResetStaticDefaultValue()
		{
			ConfigLivenessAll.LogPair = null;
			ConfigLivenessAll.HandleId = 0;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000FF025 File Offset: 0x000FD225
		public static void Init()
		{
			ConfigLivenessAll.HandleId = ConfigCommon.InitDataStatement(ConfigLivenessAll.HandleId, "db_daily_activity.db", "select BinData from `Liveness`");
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000FF040 File Offset: 0x000FD240
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

		// Token: 0x0400220B RID: 8715
		private const string DB = "db_daily_activity.db";

		// Token: 0x0400220C RID: 8716
		private const string FILE = "h.活跃度.xlsx";

		// Token: 0x0400220D RID: 8717
		private const string TABLE = "Liveness";

		// Token: 0x0400220E RID: 8718
		private const string COMMAND = "select BinData from `Liveness`";

		// Token: 0x0400220F RID: 8719
		private const string KEY_PREFIX = "LivenessAll";

		// Token: 0x04002210 RID: 8720
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002211 RID: 8721
		private static int HandleId;
	}
}
