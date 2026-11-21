using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096C RID: 2412
	public class ConfigSheriffZoneAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600389B RID: 14491 RVA: 0x0019C990 File Offset: 0x0019AB90
		static ConfigSheriffZoneAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffZoneAll.CreateStaticDefaultValue), new Action(ConfigSheriffZoneAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x0019C9B0 File Offset: 0x0019ABB0
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffZoneAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffZoneAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffZone"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffZone`")
			});
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0019CA2F File Offset: 0x0019AC2F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffZoneAll.LogPair = null;
			ConfigSheriffZoneAll.HandleId = 0;
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x0019CA3D File Offset: 0x0019AC3D
		public static void Init()
		{
			ConfigSheriffZoneAll.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffZoneAll.HandleId, "db_sheriff.db", "select BinData from `SheriffZone`");
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0019CA58 File Offset: 0x0019AC58
		[NullableContext(2)]
		public static IReadOnlyList<SheriffZone> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffZoneAll.HandleId, ConfigSheriffZoneAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SheriffZone> readOnlyList = (IReadOnlyList<SheriffZone>)ConfigCommon.GetConfig("SheriffZoneAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SheriffZone> list = new List<SheriffZone>();
			while (ConfigCommon.Step(ConfigSheriffZoneAll.HandleId, false, ConfigSheriffZoneAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffZoneAll.HandleId, 0, ConfigSheriffZoneAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffZoneAll.HandleId, ConfigSheriffZoneAll.LogPair);
					return null;
				}
				SheriffZone rootAsSheriffZone = SheriffZone.GetRootAsSheriffZone(new ByteBuffer(item2));
				list.Add(rootAsSheriffZone);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SheriffZoneAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffZoneAll.HandleId, ConfigSheriffZoneAll.LogPair);
			return list;
		}

		// Token: 0x040041DA RID: 16858
		private const string DB = "db_sheriff.db";

		// Token: 0x040041DB RID: 16859
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041DC RID: 16860
		private const string TABLE = "SheriffZone";

		// Token: 0x040041DD RID: 16861
		private const string COMMAND = "select BinData from `SheriffZone`";

		// Token: 0x040041DE RID: 16862
		private const string KEY_PREFIX = "SheriffZoneAll";

		// Token: 0x040041DF RID: 16863
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041E0 RID: 16864
		private static int HandleId;
	}
}
