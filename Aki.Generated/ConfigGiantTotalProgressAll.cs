using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AE RID: 942
	public class ConfigGiantTotalProgressAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600161B RID: 5659 RVA: 0x000DA323 File Offset: 0x000D8523
		static ConfigGiantTotalProgressAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantTotalProgressAll.CreateStaticDefaultValue), new Action(ConfigGiantTotalProgressAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000DA344 File Offset: 0x000D8544
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

		// Token: 0x0600161D RID: 5661 RVA: 0x000DA3C3 File Offset: 0x000D85C3
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantTotalProgressAll.LogPair = null;
			ConfigGiantTotalProgressAll.HandleId = 0;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000DA3D1 File Offset: 0x000D85D1
		public static void Init()
		{
			ConfigGiantTotalProgressAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiantTotalProgressAll.HandleId, "db_giant.db", "select BinData from `GiantTotalProgress`");
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000DA3EC File Offset: 0x000D85EC
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

		// Token: 0x040019A6 RID: 6566
		private const string DB = "db_giant.db";

		// Token: 0x040019A7 RID: 6567
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040019A8 RID: 6568
		private const string TABLE = "GiantTotalProgress";

		// Token: 0x040019A9 RID: 6569
		private const string COMMAND = "select BinData from `GiantTotalProgress`";

		// Token: 0x040019AA RID: 6570
		private const string KEY_PREFIX = "GiantTotalProgressAll";

		// Token: 0x040019AB RID: 6571
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019AC RID: 6572
		private static int HandleId;
	}
}
