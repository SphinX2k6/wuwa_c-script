using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000195 RID: 405
	public class ConfigConnectBlockWhiteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000981 RID: 2433 RVA: 0x0008F464 File Offset: 0x0008D664
		static ConfigConnectBlockWhiteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConnectBlockWhiteAll.CreateStaticDefaultValue), new Action(ConfigConnectBlockWhiteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0008F484 File Offset: 0x0008D684
		public static void CreateStaticDefaultValue()
		{
			ConfigConnectBlockWhiteAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConnectBlockWhiteAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "ConnectBlockWhite"),
				new ValueTuple<string, object>("语句", "select BinData from `ConnectBlockWhite`")
			});
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0008F503 File Offset: 0x0008D703
		public static void ResetStaticDefaultValue()
		{
			ConfigConnectBlockWhiteAll.LogPair = null;
			ConfigConnectBlockWhiteAll.HandleId = 0;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0008F511 File Offset: 0x0008D711
		public static void Init()
		{
			ConfigConnectBlockWhiteAll.HandleId = ConfigCommon.InitDataStatement(ConfigConnectBlockWhiteAll.HandleId, "db_download.db", "select BinData from `ConnectBlockWhite`");
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0008F52C File Offset: 0x0008D72C
		[NullableContext(2)]
		public static IReadOnlyList<ConnectBlockWhite> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConnectBlockWhiteAll.HandleId, ConfigConnectBlockWhiteAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ConnectBlockWhite> readOnlyList = (IReadOnlyList<ConnectBlockWhite>)ConfigCommon.GetConfig("ConnectBlockWhiteAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ConnectBlockWhite> list = new List<ConnectBlockWhite>();
			while (ConfigCommon.Step(ConfigConnectBlockWhiteAll.HandleId, false, ConfigConnectBlockWhiteAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConnectBlockWhiteAll.HandleId, 0, ConfigConnectBlockWhiteAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigConnectBlockWhiteAll.HandleId, ConfigConnectBlockWhiteAll.LogPair);
					return null;
				}
				ConnectBlockWhite rootAsConnectBlockWhite = ConnectBlockWhite.GetRootAsConnectBlockWhite(new ByteBuffer(item2));
				list.Add(rootAsConnectBlockWhite);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ConnectBlockWhiteAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigConnectBlockWhiteAll.HandleId, ConfigConnectBlockWhiteAll.LogPair);
			return list;
		}

		// Token: 0x04000AF7 RID: 2807
		private const string DB = "db_download.db";

		// Token: 0x04000AF8 RID: 2808
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000AF9 RID: 2809
		private const string TABLE = "ConnectBlockWhite";

		// Token: 0x04000AFA RID: 2810
		private const string COMMAND = "select BinData from `ConnectBlockWhite`";

		// Token: 0x04000AFB RID: 2811
		private const string KEY_PREFIX = "ConnectBlockWhiteAll";

		// Token: 0x04000AFC RID: 2812
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AFD RID: 2813
		private static int HandleId;
	}
}
