using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000391 RID: 913
	public class ConfigGiantEntrustAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600156C RID: 5484 RVA: 0x000D2BD8 File Offset: 0x000D0DD8
		static ConfigGiantEntrustAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantEntrustAll.CreateStaticDefaultValue), new Action(ConfigGiantEntrustAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000D2BF8 File Offset: 0x000D0DF8
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantEntrustAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantEntrustAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantEntrust"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantEntrust`")
			});
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000D2C77 File Offset: 0x000D0E77
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantEntrustAll.LogPair = null;
			ConfigGiantEntrustAll.HandleId = 0;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000D2C85 File Offset: 0x000D0E85
		public static void Init()
		{
			ConfigGiantEntrustAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiantEntrustAll.HandleId, "db_giant.db", "select BinData from `GiantEntrust`");
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000D2CA0 File Offset: 0x000D0EA0
		[NullableContext(2)]
		public static IReadOnlyList<GiantEntrust> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantEntrustAll.HandleId, ConfigGiantEntrustAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GiantEntrust> readOnlyList = (IReadOnlyList<GiantEntrust>)ConfigCommon.GetConfig("GiantEntrustAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GiantEntrust> list = new List<GiantEntrust>();
			while (ConfigCommon.Step(ConfigGiantEntrustAll.HandleId, false, ConfigGiantEntrustAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantEntrustAll.HandleId, 0, ConfigGiantEntrustAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGiantEntrustAll.HandleId, ConfigGiantEntrustAll.LogPair);
					return null;
				}
				GiantEntrust rootAsGiantEntrust = GiantEntrust.GetRootAsGiantEntrust(new ByteBuffer(item2));
				list.Add(rootAsGiantEntrust);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GiantEntrustAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGiantEntrustAll.HandleId, ConfigGiantEntrustAll.LogPair);
			return list;
		}

		// Token: 0x040018DB RID: 6363
		private const string DB = "db_giant.db";

		// Token: 0x040018DC RID: 6364
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040018DD RID: 6365
		private const string TABLE = "GiantEntrust";

		// Token: 0x040018DE RID: 6366
		private const string COMMAND = "select BinData from `GiantEntrust`";

		// Token: 0x040018DF RID: 6367
		private const string KEY_PREFIX = "GiantEntrustAll";

		// Token: 0x040018E0 RID: 6368
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018E1 RID: 6369
		private static int HandleId;
	}
}
