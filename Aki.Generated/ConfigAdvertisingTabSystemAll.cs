using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000072 RID: 114
	public class ConfigAdvertisingTabSystemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002AC RID: 684 RVA: 0x00068A20 File Offset: 0x00066C20
		static ConfigAdvertisingTabSystemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabSystemAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabSystemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00068A40 File Offset: 0x00066C40
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabSystemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabSystemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabSystem"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabSystem`")
			});
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00068ABF File Offset: 0x00066CBF
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabSystemAll.LogPair = null;
			ConfigAdvertisingTabSystemAll.HandleId = 0;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00068ACD File Offset: 0x00066CCD
		public static void Init()
		{
			ConfigAdvertisingTabSystemAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabSystemAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabSystem`");
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00068AE8 File Offset: 0x00066CE8
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabSystem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabSystemAll.HandleId, ConfigAdvertisingTabSystemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabSystem> readOnlyList = (IReadOnlyList<AdvertisingTabSystem>)ConfigCommon.GetConfig("AdvertisingTabSystemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabSystem> list = new List<AdvertisingTabSystem>();
			while (ConfigCommon.Step(ConfigAdvertisingTabSystemAll.HandleId, false, ConfigAdvertisingTabSystemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabSystemAll.HandleId, 0, ConfigAdvertisingTabSystemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabSystemAll.HandleId, ConfigAdvertisingTabSystemAll.LogPair);
					return null;
				}
				AdvertisingTabSystem rootAsAdvertisingTabSystem = AdvertisingTabSystem.GetRootAsAdvertisingTabSystem(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabSystem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabSystemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabSystemAll.HandleId, ConfigAdvertisingTabSystemAll.LogPair);
			return list;
		}

		// Token: 0x04000302 RID: 770
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000303 RID: 771
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000304 RID: 772
		private const string TABLE = "AdvertisingTabSystem";

		// Token: 0x04000305 RID: 773
		private const string COMMAND = "select BinData from `AdvertisingTabSystem`";

		// Token: 0x04000306 RID: 774
		private const string KEY_PREFIX = "AdvertisingTabSystemAll";

		// Token: 0x04000307 RID: 775
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000308 RID: 776
		private static int HandleId;
	}
}
