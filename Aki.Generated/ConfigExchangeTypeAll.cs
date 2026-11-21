using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A0 RID: 672
	public class ConfigExchangeTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x000B631C File Offset: 0x000B451C
		static ConfigExchangeTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExchangeTypeAll.CreateStaticDefaultValue), new Action(ConfigExchangeTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000B633C File Offset: 0x000B453C
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

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000B63BB File Offset: 0x000B45BB
		public static void ResetStaticDefaultValue()
		{
			ConfigExchangeTypeAll.LogPair = null;
			ConfigExchangeTypeAll.HandleId = 0;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000B63C9 File Offset: 0x000B45C9
		public static void Init()
		{
			ConfigExchangeTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigExchangeTypeAll.HandleId, "db_compose.db", "select BinData from `ExchangeType`");
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000B63E4 File Offset: 0x000B45E4
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

		// Token: 0x04001244 RID: 4676
		private const string DB = "db_compose.db";

		// Token: 0x04001245 RID: 4677
		private const string FILE = "h.合成.xlsx";

		// Token: 0x04001246 RID: 4678
		private const string TABLE = "ExchangeType";

		// Token: 0x04001247 RID: 4679
		private const string COMMAND = "select BinData from `ExchangeType`";

		// Token: 0x04001248 RID: 4680
		private const string KEY_PREFIX = "ExchangeTypeAll";

		// Token: 0x04001249 RID: 4681
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400124A RID: 4682
		private static int HandleId;
	}
}
