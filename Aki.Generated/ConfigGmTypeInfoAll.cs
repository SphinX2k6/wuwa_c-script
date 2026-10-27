using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A7 RID: 935
	public class ConfigGmTypeInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015F1 RID: 5617 RVA: 0x000D58CC File Offset: 0x000D3ACC
		static ConfigGmTypeInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmTypeInfoAll.CreateStaticDefaultValue), new Action(ConfigGmTypeInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000D58EC File Offset: 0x000D3AEC
		public static void CreateStaticDefaultValue()
		{
			ConfigGmTypeInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmTypeInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmTypeInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GmTypeInfo`")
			});
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000D596B File Offset: 0x000D3B6B
		public static void ResetStaticDefaultValue()
		{
			ConfigGmTypeInfoAll.LogPair = null;
			ConfigGmTypeInfoAll.HandleId = 0;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x000D5979 File Offset: 0x000D3B79
		public static void Init()
		{
			ConfigGmTypeInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmTypeInfoAll.HandleId, "db_gm.db", "select BinData from `GmTypeInfo`");
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x000D5994 File Offset: 0x000D3B94
		[NullableContext(2)]
		public static IReadOnlyList<GmTypeInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmTypeInfoAll.HandleId, ConfigGmTypeInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GmTypeInfo> readOnlyList = (IReadOnlyList<GmTypeInfo>)ConfigCommon.GetConfig("GmTypeInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GmTypeInfo> list = new List<GmTypeInfo>();
			while (ConfigCommon.Step(ConfigGmTypeInfoAll.HandleId, false, ConfigGmTypeInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmTypeInfoAll.HandleId, 0, ConfigGmTypeInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGmTypeInfoAll.HandleId, ConfigGmTypeInfoAll.LogPair);
					return null;
				}
				GmTypeInfo rootAsGmTypeInfo = GmTypeInfo.GetRootAsGmTypeInfo(new ByteBuffer(item2));
				list.Add(rootAsGmTypeInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GmTypeInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGmTypeInfoAll.HandleId, ConfigGmTypeInfoAll.LogPair);
			return list;
		}

		// Token: 0x04001975 RID: 6517
		private const string DB = "db_gm.db";

		// Token: 0x04001976 RID: 6518
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001977 RID: 6519
		private const string TABLE = "GmTypeInfo";

		// Token: 0x04001978 RID: 6520
		private const string COMMAND = "select BinData from `GmTypeInfo`";

		// Token: 0x04001979 RID: 6521
		private const string KEY_PREFIX = "GmTypeInfoAll";

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
