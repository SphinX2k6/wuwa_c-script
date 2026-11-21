using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000521 RID: 1313
	public class ConfigMapBlockInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ED1 RID: 7889 RVA: 0x0010AE70 File Offset: 0x00109070
		static ConfigMapBlockInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBlockInfoAll.CreateStaticDefaultValue), new Action(ConfigMapBlockInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0010AE90 File Offset: 0x00109090
		public static void CreateStaticDefaultValue()
		{
			ConfigMapBlockInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapBlockInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "MapBlockInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `MapBlockInfo`")
			});
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0010AF0F File Offset: 0x0010910F
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBlockInfoAll.LogPair = null;
			ConfigMapBlockInfoAll.HandleId = 0;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0010AF1D File Offset: 0x0010911D
		public static void Init()
		{
			ConfigMapBlockInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapBlockInfoAll.HandleId, "db_download.db", "select BinData from `MapBlockInfo`");
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0010AF38 File Offset: 0x00109138
		[NullableContext(2)]
		public static IReadOnlyList<MapBlockInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapBlockInfoAll.HandleId, ConfigMapBlockInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapBlockInfo> readOnlyList = (IReadOnlyList<MapBlockInfo>)ConfigCommon.GetConfig("MapBlockInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapBlockInfo> list = new List<MapBlockInfo>();
			while (ConfigCommon.Step(ConfigMapBlockInfoAll.HandleId, false, ConfigMapBlockInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapBlockInfoAll.HandleId, 0, ConfigMapBlockInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapBlockInfoAll.HandleId, ConfigMapBlockInfoAll.LogPair);
					return null;
				}
				MapBlockInfo rootAsMapBlockInfo = MapBlockInfo.GetRootAsMapBlockInfo(new ByteBuffer(item2));
				list.Add(rootAsMapBlockInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapBlockInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapBlockInfoAll.HandleId, ConfigMapBlockInfoAll.LogPair);
			return list;
		}

		// Token: 0x040023CB RID: 9163
		private const string DB = "db_download.db";

		// Token: 0x040023CC RID: 9164
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x040023CD RID: 9165
		private const string TABLE = "MapBlockInfo";

		// Token: 0x040023CE RID: 9166
		private const string COMMAND = "select BinData from `MapBlockInfo`";

		// Token: 0x040023CF RID: 9167
		private const string KEY_PREFIX = "MapBlockInfoAll";

		// Token: 0x040023D0 RID: 9168
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023D1 RID: 9169
		private static int HandleId;
	}
}
