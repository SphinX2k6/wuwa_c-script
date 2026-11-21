using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A7 RID: 935
	public class ConfigGiantEntrustAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015F0 RID: 5616 RVA: 0x000D932C File Offset: 0x000D752C
		static ConfigGiantEntrustAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantEntrustAll.CreateStaticDefaultValue), new Action(ConfigGiantEntrustAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000D934C File Offset: 0x000D754C
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

		// Token: 0x060015F2 RID: 5618 RVA: 0x000D93CB File Offset: 0x000D75CB
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantEntrustAll.LogPair = null;
			ConfigGiantEntrustAll.HandleId = 0;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000D93D9 File Offset: 0x000D75D9
		public static void Init()
		{
			ConfigGiantEntrustAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiantEntrustAll.HandleId, "db_giant.db", "select BinData from `GiantEntrust`");
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x000D93F4 File Offset: 0x000D75F4
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

		// Token: 0x04001975 RID: 6517
		private const string DB = "db_giant.db";

		// Token: 0x04001976 RID: 6518
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x04001977 RID: 6519
		private const string TABLE = "GiantEntrust";

		// Token: 0x04001978 RID: 6520
		private const string COMMAND = "select BinData from `GiantEntrust`";

		// Token: 0x04001979 RID: 6521
		private const string KEY_PREFIX = "GiantEntrustAll";

		// Token: 0x0400197A RID: 6522
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400197B RID: 6523
		private static int HandleId;
	}
}
