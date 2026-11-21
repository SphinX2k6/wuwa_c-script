using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A32 RID: 2610
	public class ConfigSolarSchoolTimeSlotAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D40 RID: 15680 RVA: 0x001B6DB3 File Offset: 0x001B4FB3
		static ConfigSolarSchoolTimeSlotAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolTimeSlotAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolTimeSlotAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x001B6DD4 File Offset: 0x001B4FD4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolTimeSlotAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolTimeSlotAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolTimeSlot"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolTimeSlot`")
			});
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x001B6E53 File Offset: 0x001B5053
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolTimeSlotAll.LogPair = null;
			ConfigSolarSchoolTimeSlotAll.HandleId = 0;
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x001B6E61 File Offset: 0x001B5061
		public static void Init()
		{
			ConfigSolarSchoolTimeSlotAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolTimeSlotAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolTimeSlot`");
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x001B6E7C File Offset: 0x001B507C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolTimeSlot> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolTimeSlotAll.HandleId, ConfigSolarSchoolTimeSlotAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolTimeSlot> readOnlyList = (IReadOnlyList<SolarSchoolTimeSlot>)ConfigCommon.GetConfig("SolarSchoolTimeSlotAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolTimeSlot> list = new List<SolarSchoolTimeSlot>();
			while (ConfigCommon.Step(ConfigSolarSchoolTimeSlotAll.HandleId, false, ConfigSolarSchoolTimeSlotAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolTimeSlotAll.HandleId, 0, ConfigSolarSchoolTimeSlotAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolTimeSlotAll.HandleId, ConfigSolarSchoolTimeSlotAll.LogPair);
					return null;
				}
				SolarSchoolTimeSlot rootAsSolarSchoolTimeSlot = SolarSchoolTimeSlot.GetRootAsSolarSchoolTimeSlot(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolTimeSlot);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolTimeSlotAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolTimeSlotAll.HandleId, ConfigSolarSchoolTimeSlotAll.LogPair);
			return list;
		}

		// Token: 0x04004744 RID: 18244
		private const string DB = "db_solarschool.db";

		// Token: 0x04004745 RID: 18245
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004746 RID: 18246
		private const string TABLE = "SolarSchoolTimeSlot";

		// Token: 0x04004747 RID: 18247
		private const string COMMAND = "select BinData from `SolarSchoolTimeSlot`";

		// Token: 0x04004748 RID: 18248
		private const string KEY_PREFIX = "SolarSchoolTimeSlotAll";

		// Token: 0x04004749 RID: 18249
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400474A RID: 18250
		private static int HandleId;
	}
}
