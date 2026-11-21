using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A33 RID: 2611
	public class ConfigSolarSchoolTimeSlotByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D46 RID: 15686 RVA: 0x001B6F47 File Offset: 0x001B5147
		static ConfigSolarSchoolTimeSlotByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolTimeSlotByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolTimeSlotByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x001B6F68 File Offset: 0x001B5168
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolTimeSlotByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolTimeSlotByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolTimeSlot"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolTimeSlot` where ActivityId=?")
			});
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x001B6FE7 File Offset: 0x001B51E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolTimeSlotByActivityId.LogPair = null;
			ConfigSolarSchoolTimeSlotByActivityId.HandleId = 0;
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x001B6FF5 File Offset: 0x001B51F5
		public static void Init()
		{
			ConfigSolarSchoolTimeSlotByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolTimeSlotByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolTimeSlot` where ActivityId=?");
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x001B7010 File Offset: 0x001B5210
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolTimeSlot> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolTimeSlotByActivityId.HandleId, ConfigSolarSchoolTimeSlotByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTimeSlotByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolTimeSlot> readOnlyList = (IReadOnlyList<SolarSchoolTimeSlot>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolTimeSlotByActivityId.LogPair.Clear();
			ConfigSolarSchoolTimeSlotByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolTimeSlotByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolTimeSlotByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolTimeSlotByActivityId.HandleId, ConfigSolarSchoolTimeSlotByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolTimeSlot> list = new List<SolarSchoolTimeSlot>();
			while (ConfigCommon.Step(ConfigSolarSchoolTimeSlotByActivityId.HandleId, false, ConfigSolarSchoolTimeSlotByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolTimeSlotByActivityId.HandleId, 0, ConfigSolarSchoolTimeSlotByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolTimeSlotByActivityId.HandleId, ConfigSolarSchoolTimeSlotByActivityId.LogPair);
					return null;
				}
				SolarSchoolTimeSlot rootAsSolarSchoolTimeSlot = SolarSchoolTimeSlot.GetRootAsSolarSchoolTimeSlot(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolTimeSlot);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTimeSlotByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolTimeSlotByActivityId.HandleId, ConfigSolarSchoolTimeSlotByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400474B RID: 18251
		private const string DB = "db_solarschool.db";

		// Token: 0x0400474C RID: 18252
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400474D RID: 18253
		private const string TABLE = "SolarSchoolTimeSlot";

		// Token: 0x0400474E RID: 18254
		private const string COMMAND = "select BinData from `SolarSchoolTimeSlot` where ActivityId=?";

		// Token: 0x0400474F RID: 18255
		private const string KEY_PREFIX = "SolarSchoolTimeSlotByActivityId";

		// Token: 0x04004750 RID: 18256
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004751 RID: 18257
		private static int HandleId;
	}
}
