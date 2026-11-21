using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A34 RID: 2612
	public class ConfigSolarSchoolTimeSlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D4C RID: 15692 RVA: 0x001B717F File Offset: 0x001B537F
		static ConfigSolarSchoolTimeSlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolTimeSlotById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolTimeSlotById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x001B71A0 File Offset: 0x001B53A0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolTimeSlotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolTimeSlotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolTimeSlot"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolTimeSlot` where Id=?")
			});
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x001B721F File Offset: 0x001B541F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolTimeSlotById.LogPair = null;
			ConfigSolarSchoolTimeSlotById.HandleId = 0;
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x001B722D File Offset: 0x001B542D
		public static void Init()
		{
			ConfigSolarSchoolTimeSlotById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolTimeSlotById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolTimeSlot` where Id=?");
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x001B7248 File Offset: 0x001B5448
		public static SolarSchoolTimeSlot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolTimeSlotById.HandleId, ConfigSolarSchoolTimeSlotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTimeSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolTimeSlot?(SolarSchoolTimeSlot.GetRootAsSolarSchoolTimeSlot(configBuffer));
				}
			}
			ConfigSolarSchoolTimeSlotById.LogPair.Clear();
			ConfigSolarSchoolTimeSlotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolTimeSlotById.HandleId, 1, p0Id, ConfigSolarSchoolTimeSlotById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolTimeSlotById.HandleId, true, ConfigSolarSchoolTimeSlotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolTimeSlotById.HandleId, ConfigSolarSchoolTimeSlotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolTimeSlotById.HandleId, 0, ConfigSolarSchoolTimeSlotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolTimeSlotById.HandleId, ConfigSolarSchoolTimeSlotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolTimeSlot rootAsSolarSchoolTimeSlot = SolarSchoolTimeSlot.GetRootAsSolarSchoolTimeSlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTimeSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolTimeSlotById.HandleId, ConfigSolarSchoolTimeSlotById.LogPair);
			return new SolarSchoolTimeSlot?(rootAsSolarSchoolTimeSlot);
		}

		// Token: 0x04004752 RID: 18258
		private const string DB = "db_solarschool.db";

		// Token: 0x04004753 RID: 18259
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004754 RID: 18260
		private const string TABLE = "SolarSchoolTimeSlot";

		// Token: 0x04004755 RID: 18261
		private const string COMMAND = "select BinData from `SolarSchoolTimeSlot` where Id=?";

		// Token: 0x04004756 RID: 18262
		private const string KEY_PREFIX = "SolarSchoolTimeSlotById";

		// Token: 0x04004757 RID: 18263
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004758 RID: 18264
		private static int HandleId;
	}
}
