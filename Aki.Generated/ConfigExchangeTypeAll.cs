using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028C RID: 652
	public class ConfigExchangeTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x000B0058 File Offset: 0x000AE258
		static ConfigExchangeTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeTypeAll.CreateStaticDefaultValue), new Action(ConfigExchangeTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000B0078 File Offset: 0x000AE278
		public static void CreateStaticDefaultValue()
		{
			ConfigExchangeTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExchangeTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "ExchangeType"),
				new ValueTuple<string, object>("语句", "select BinData from `ExchangeType`")
			});
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000B00F7 File Offset: 0x000AE2F7
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeTypeAll.LogPair = null;
			ConfigExchangeTypeAll.HandleId = 0;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000B0105 File Offset: 0x000AE305
		public static void Init()
		{
			ConfigExchangeTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeTypeAll.HandleId, "db_compose.db", "select BinData from `ExchangeType`");
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000B0120 File Offset: 0x000AE320
		[NullableContext(2)]
		public static IReadOnlyList<ExchangeType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExchangeTypeAll.HandleId, ConfigExchangeTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExchangeType> readOnlyList = (IReadOnlyList<ExchangeType>)ConfigCommon.GetConfig("ExchangeTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExchangeType> list = new List<ExchangeType>();
			while (ConfigCommon.Step(ConfigExchangeTypeAll.HandleId, false, ConfigExchangeTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExchangeTypeAll.HandleId, 0, ConfigExchangeTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExchangeTypeAll.HandleId, ConfigExchangeTypeAll.LogPair);
					return null;
				}
				ExchangeType rootAsExchangeType = ExchangeType.GetRootAsExchangeType(new ByteBuffer(item2));
				list.Add(rootAsExchangeType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExchangeTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExchangeTypeAll.HandleId, ConfigExchangeTypeAll.LogPair);
			return list;
		}

		// Token: 0x040011B8 RID: 4536
		private const string DB = "db_compose.db";

		// Token: 0x040011B9 RID: 4537
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040011BA RID: 4538
		private const string TABLE = "ExchangeType";

		// Token: 0x040011BB RID: 4539
		private const string COMMAND = "select BinData from `ExchangeType`";

		// Token: 0x040011BC RID: 4540
		private const string KEY_PREFIX = "ExchangeTypeAll";

		// Token: 0x040011BD RID: 4541
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011BE RID: 4542
		private static int HandleId;
	}
}
