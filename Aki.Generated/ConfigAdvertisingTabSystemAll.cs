using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007A RID: 122
	public class ConfigAdvertisingTabSystemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002DC RID: 732 RVA: 0x0006D2D4 File Offset: 0x0006B4D4
		static ConfigAdvertisingTabSystemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabSystemAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabSystemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0006D2F4 File Offset: 0x0006B4F4
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

		// Token: 0x060002DE RID: 734 RVA: 0x0006D373 File Offset: 0x0006B573
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabSystemAll.LogPair = null;
			ConfigAdvertisingTabSystemAll.HandleId = 0;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0006D381 File Offset: 0x0006B581
		public static void Init()
		{
			ConfigAdvertisingTabSystemAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabSystemAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabSystem`");
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0006D39C File Offset: 0x0006B59C
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

		// Token: 0x0400033A RID: 826
		private const string DB = "db_advertisingpage.db";

		// Token: 0x0400033B RID: 827
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x0400033C RID: 828
		private const string TABLE = "AdvertisingTabSystem";

		// Token: 0x0400033D RID: 829
		private const string COMMAND = "select BinData from `AdvertisingTabSystem`";

		// Token: 0x0400033E RID: 830
		private const string KEY_PREFIX = "AdvertisingTabSystemAll";

		// Token: 0x0400033F RID: 831
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000340 RID: 832
		private static int HandleId;
	}
}
