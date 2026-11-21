using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BD RID: 957
	public class ConfigGmTypeInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001675 RID: 5749 RVA: 0x000DC020 File Offset: 0x000DA220
		static ConfigGmTypeInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmTypeInfoAll.CreateStaticDefaultValue), new Action(ConfigGmTypeInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000DC040 File Offset: 0x000DA240
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

		// Token: 0x06001677 RID: 5751 RVA: 0x000DC0BF File Offset: 0x000DA2BF
		public static void ResetStaticDefaultValue()
		{
			ConfigGmTypeInfoAll.LogPair = null;
			ConfigGmTypeInfoAll.HandleId = 0;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000DC0CD File Offset: 0x000DA2CD
		public static void Init()
		{
			ConfigGmTypeInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmTypeInfoAll.HandleId, "db_gm.db", "select BinData from `GmTypeInfo`");
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000DC0E8 File Offset: 0x000DA2E8
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

		// Token: 0x04001A0F RID: 6671
		private const string DB = "db_gm.db";

		// Token: 0x04001A10 RID: 6672
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001A11 RID: 6673
		private const string TABLE = "GmTypeInfo";

		// Token: 0x04001A12 RID: 6674
		private const string COMMAND = "select BinData from `GmTypeInfo`";

		// Token: 0x04001A13 RID: 6675
		private const string KEY_PREFIX = "GmTypeInfoAll";

		// Token: 0x04001A14 RID: 6676
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A15 RID: 6677
		private static int HandleId;
	}
}
