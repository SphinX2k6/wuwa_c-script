using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000921 RID: 2337
	public class ConfigSheriffZoneAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036D9 RID: 14041 RVA: 0x0018F770 File Offset: 0x0018D970
		static ConfigSheriffZoneAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffZoneAll.CreateStaticDefaultValue), new Action(ConfigSheriffZoneAll.ResetStaticDefaultValue));
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x0018F790 File Offset: 0x0018D990
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

		// Token: 0x060036DB RID: 14043 RVA: 0x0018F80F File Offset: 0x0018DA0F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffZoneAll.LogPair = null;
			ConfigSheriffZoneAll.HandleId = 0;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x0018F81D File Offset: 0x0018DA1D
		public static void Init()
		{
			ConfigSheriffZoneAll.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffZoneAll.HandleId, "db_sheriff.db", "select BinData from `SheriffZone`");
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x0018F838 File Offset: 0x0018DA38
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

		// Token: 0x04003FCD RID: 16333
		private const string DB = "db_sheriff.db";

		// Token: 0x04003FCE RID: 16334
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003FCF RID: 16335
		private const string TABLE = "SheriffZone";

		// Token: 0x04003FD0 RID: 16336
		private const string COMMAND = "select BinData from `SheriffZone`";

		// Token: 0x04003FD1 RID: 16337
		private const string KEY_PREFIX = "SheriffZoneAll";

		// Token: 0x04003FD2 RID: 16338
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FD3 RID: 16339
		private static int HandleId;
	}
}
