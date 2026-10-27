using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AC RID: 428
	public class ConfigCountryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x00092590 File Offset: 0x00090790
		static ConfigCountryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCountryAll.CreateStaticDefaultValue), new Action(ConfigCountryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000925B0 File Offset: 0x000907B0
		public static void CreateStaticDefaultValue()
		{
			ConfigCountryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCountryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_influence.db"),
				new ValueTuple<string, object>("文件", "s.势力.xlsx"),
				new ValueTuple<string, object>("表名", "Country"),
				new ValueTuple<string, object>("语句", "select BinData from `Country`")
			});
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0009262F File Offset: 0x0009082F
		public static void ResetStaticDefaultValue()
		{
			ConfigCountryAll.LogPair = null;
			ConfigCountryAll.HandleId = 0;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0009263D File Offset: 0x0009083D
		public static void Init()
		{
			ConfigCountryAll.HandleId = ConfigCommon.InitDataStatement(ConfigCountryAll.HandleId, "db_influence.db", "select BinData from `Country`");
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00092658 File Offset: 0x00090858
		[NullableContext(2)]
		public static IReadOnlyList<Country> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCountryAll.HandleId, ConfigCountryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Country> readOnlyList = (IReadOnlyList<Country>)ConfigCommon.GetConfig("CountryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Country> list = new List<Country>();
			while (ConfigCommon.Step(ConfigCountryAll.HandleId, false, ConfigCountryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCountryAll.HandleId, 0, ConfigCountryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCountryAll.HandleId, ConfigCountryAll.LogPair);
					return null;
				}
				Country rootAsCountry = Country.GetRootAsCountry(new ByteBuffer(item2));
				list.Add(rootAsCountry);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CountryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCountryAll.HandleId, ConfigCountryAll.LogPair);
			return list;
		}

		// Token: 0x04000B98 RID: 2968
		private const string DB = "db_influence.db";

		// Token: 0x04000B99 RID: 2969
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04000B9A RID: 2970
		private const string TABLE = "Country";

		// Token: 0x04000B9B RID: 2971
		private const string COMMAND = "select BinData from `Country`";

		// Token: 0x04000B9C RID: 2972
		private const string KEY_PREFIX = "CountryAll";

		// Token: 0x04000B9D RID: 2973
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B9E RID: 2974
		private static int HandleId;
	}
}
