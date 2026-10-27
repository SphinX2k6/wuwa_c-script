using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050B RID: 1291
	public class ConfigMapBlockInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E4D RID: 7757 RVA: 0x0010471C File Offset: 0x0010291C
		static ConfigMapBlockInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBlockInfoAll.CreateStaticDefaultValue), new Action(ConfigMapBlockInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0010473C File Offset: 0x0010293C
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

		// Token: 0x06001E4F RID: 7759 RVA: 0x001047BB File Offset: 0x001029BB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBlockInfoAll.LogPair = null;
			ConfigMapBlockInfoAll.HandleId = 0;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x001047C9 File Offset: 0x001029C9
		public static void Init()
		{
			ConfigMapBlockInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapBlockInfoAll.HandleId, "db_download.db", "select BinData from `MapBlockInfo`");
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x001047E4 File Offset: 0x001029E4
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

		// Token: 0x04002331 RID: 9009
		private const string DB = "db_download.db";

		// Token: 0x04002332 RID: 9010
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04002333 RID: 9011
		private const string TABLE = "MapBlockInfo";

		// Token: 0x04002334 RID: 9012
		private const string COMMAND = "select BinData from `MapBlockInfo`";

		// Token: 0x04002335 RID: 9013
		private const string KEY_PREFIX = "MapBlockInfoAll";

		// Token: 0x04002336 RID: 9014
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002337 RID: 9015
		private static int HandleId;
	}
}
