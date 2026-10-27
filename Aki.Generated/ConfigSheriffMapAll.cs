using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000918 RID: 2328
	public class ConfigSheriffMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036A3 RID: 13987 RVA: 0x0018E3BC File Offset: 0x0018C5BC
		static ConfigSheriffMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffMapAll.CreateStaticDefaultValue), new Action(ConfigSheriffMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x0018E3DC File Offset: 0x0018C5DC
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffMapAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffMapAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffMap"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffMap`")
			});
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x0018E45B File Offset: 0x0018C65B
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffMapAll.LogPair = null;
			ConfigSheriffMapAll.HandleId = 0;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x0018E469 File Offset: 0x0018C669
		public static void Init()
		{
			ConfigSheriffMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffMapAll.HandleId, "db_sheriff.db", "select BinData from `SheriffMap`");
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x0018E484 File Offset: 0x0018C684
		[NullableContext(2)]
		public static IReadOnlyList<SheriffMap> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffMapAll.HandleId, ConfigSheriffMapAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SheriffMap> readOnlyList = (IReadOnlyList<SheriffMap>)ConfigCommon.GetConfig("SheriffMapAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SheriffMap> list = new List<SheriffMap>();
			while (ConfigCommon.Step(ConfigSheriffMapAll.HandleId, false, ConfigSheriffMapAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffMapAll.HandleId, 0, ConfigSheriffMapAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffMapAll.HandleId, ConfigSheriffMapAll.LogPair);
					return null;
				}
				SheriffMap rootAsSheriffMap = SheriffMap.GetRootAsSheriffMap(new ByteBuffer(item2));
				list.Add(rootAsSheriffMap);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SheriffMapAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffMapAll.HandleId, ConfigSheriffMapAll.LogPair);
			return list;
		}

		// Token: 0x04003F8E RID: 16270
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F8F RID: 16271
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F90 RID: 16272
		private const string TABLE = "SheriffMap";

		// Token: 0x04003F91 RID: 16273
		private const string COMMAND = "select BinData from `SheriffMap`";

		// Token: 0x04003F92 RID: 16274
		private const string KEY_PREFIX = "SheriffMapAll";

		// Token: 0x04003F93 RID: 16275
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F94 RID: 16276
		private static int HandleId;
	}
}
