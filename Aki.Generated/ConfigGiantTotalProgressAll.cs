using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000398 RID: 920
	public class ConfigGiantTotalProgressAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001597 RID: 5527 RVA: 0x000D3BCF File Offset: 0x000D1DCF
		static ConfigGiantTotalProgressAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantTotalProgressAll.CreateStaticDefaultValue), new Action(ConfigGiantTotalProgressAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000D3BF0 File Offset: 0x000D1DF0
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantTotalProgressAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantTotalProgressAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantTotalProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantTotalProgress`")
			});
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000D3C6F File Offset: 0x000D1E6F
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantTotalProgressAll.LogPair = null;
			ConfigGiantTotalProgressAll.HandleId = 0;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x000D3C7D File Offset: 0x000D1E7D
		public static void Init()
		{
			ConfigGiantTotalProgressAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiantTotalProgressAll.HandleId, "db_giant.db", "select BinData from `GiantTotalProgress`");
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000D3C98 File Offset: 0x000D1E98
		[NullableContext(2)]
		public static IReadOnlyList<GiantTotalProgress> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantTotalProgressAll.HandleId, ConfigGiantTotalProgressAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GiantTotalProgress> readOnlyList = (IReadOnlyList<GiantTotalProgress>)ConfigCommon.GetConfig("GiantTotalProgressAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GiantTotalProgress> list = new List<GiantTotalProgress>();
			while (ConfigCommon.Step(ConfigGiantTotalProgressAll.HandleId, false, ConfigGiantTotalProgressAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantTotalProgressAll.HandleId, 0, ConfigGiantTotalProgressAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGiantTotalProgressAll.HandleId, ConfigGiantTotalProgressAll.LogPair);
					return null;
				}
				GiantTotalProgress rootAsGiantTotalProgress = GiantTotalProgress.GetRootAsGiantTotalProgress(new ByteBuffer(item2));
				list.Add(rootAsGiantTotalProgress);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GiantTotalProgressAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGiantTotalProgressAll.HandleId, ConfigGiantTotalProgressAll.LogPair);
			return list;
		}

		// Token: 0x0400190C RID: 6412
		private const string DB = "db_giant.db";

		// Token: 0x0400190D RID: 6413
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x0400190E RID: 6414
		private const string TABLE = "GiantTotalProgress";

		// Token: 0x0400190F RID: 6415
		private const string COMMAND = "select BinData from `GiantTotalProgress`";

		// Token: 0x04001910 RID: 6416
		private const string KEY_PREFIX = "GiantTotalProgressAll";

		// Token: 0x04001911 RID: 6417
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001912 RID: 6418
		private static int HandleId;
	}
}
