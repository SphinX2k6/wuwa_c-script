using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A7 RID: 423
	public class ConfigConnectBlockWhiteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x0009539C File Offset: 0x0009359C
		static ConfigConnectBlockWhiteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConnectBlockWhiteAll.CreateStaticDefaultValue), new Action(ConfigConnectBlockWhiteAll.ResetStaticDefaultValue));
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000953BC File Offset: 0x000935BC
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

		// Token: 0x060009EF RID: 2543 RVA: 0x0009543B File Offset: 0x0009363B
		public static void ResetStaticDefaultValue()
		{
			ConfigConnectBlockWhiteAll.LogPair = null;
			ConfigConnectBlockWhiteAll.HandleId = 0;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00095449 File Offset: 0x00093649
		public static void Init()
		{
			ConfigConnectBlockWhiteAll.HandleId = ConfigCommon.InitDataStatement(ConfigConnectBlockWhiteAll.HandleId, "db_download.db", "select BinData from `ConnectBlockWhite`");
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00095464 File Offset: 0x00093664
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

		// Token: 0x04000B75 RID: 2933
		private const string DB = "db_download.db";

		// Token: 0x04000B76 RID: 2934
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000B77 RID: 2935
		private const string TABLE = "ConnectBlockWhite";

		// Token: 0x04000B78 RID: 2936
		private const string COMMAND = "select BinData from `ConnectBlockWhite`";

		// Token: 0x04000B79 RID: 2937
		private const string KEY_PREFIX = "ConnectBlockWhiteAll";

		// Token: 0x04000B7A RID: 2938
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B7B RID: 2939
		private static int HandleId;
	}
}
