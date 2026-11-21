using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BE RID: 446
	public class ConfigCountryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x000984C8 File Offset: 0x000966C8
		static ConfigCountryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCountryAll.CreateStaticDefaultValue), new Action(ConfigCountryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000984E8 File Offset: 0x000966E8
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

		// Token: 0x06000A79 RID: 2681 RVA: 0x00098567 File Offset: 0x00096767
		public static void ResetStaticDefaultValue()
		{
			ConfigCountryAll.LogPair = null;
			ConfigCountryAll.HandleId = 0;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00098575 File Offset: 0x00096775
		public static void Init()
		{
			ConfigCountryAll.HandleId = ConfigCommon.InitDataStatement(ConfigCountryAll.HandleId, "db_influence.db", "select BinData from `Country`");
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00098590 File Offset: 0x00096790
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

		// Token: 0x04000C16 RID: 3094
		private const string DB = "db_influence.db";

		// Token: 0x04000C17 RID: 3095
		private const string FILE = "s.势力.xlsx";

		// Token: 0x04000C18 RID: 3096
		private const string TABLE = "Country";

		// Token: 0x04000C19 RID: 3097
		private const string COMMAND = "select BinData from `Country`";

		// Token: 0x04000C1A RID: 3098
		private const string KEY_PREFIX = "CountryAll";

		// Token: 0x04000C1B RID: 3099
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C1C RID: 3100
		private static int HandleId;
	}
}
