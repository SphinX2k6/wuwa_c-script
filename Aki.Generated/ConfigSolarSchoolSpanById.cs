using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2B RID: 2603
	public class ConfigSolarSchoolSpanById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D16 RID: 15638 RVA: 0x001B5E9F File Offset: 0x001B409F
		static ConfigSolarSchoolSpanById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolSpanById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolSpanById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x001B5EC0 File Offset: 0x001B40C0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolSpanById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolSpanById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolSpan"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolSpan` where Id=?")
			});
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x001B5F3F File Offset: 0x001B413F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolSpanById.LogPair = null;
			ConfigSolarSchoolSpanById.HandleId = 0;
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x001B5F4D File Offset: 0x001B414D
		public static void Init()
		{
			ConfigSolarSchoolSpanById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolSpanById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolSpan` where Id=?");
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x001B5F68 File Offset: 0x001B4168
		public static SolarSchoolSpan? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolSpanById.HandleId, ConfigSolarSchoolSpanById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSpanById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolSpan?(SolarSchoolSpan.GetRootAsSolarSchoolSpan(configBuffer));
				}
			}
			ConfigSolarSchoolSpanById.LogPair.Clear();
			ConfigSolarSchoolSpanById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolSpanById.HandleId, 1, p0Id, ConfigSolarSchoolSpanById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolSpanById.HandleId, true, ConfigSolarSchoolSpanById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolSpanById.HandleId, ConfigSolarSchoolSpanById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolSpanById.HandleId, 0, ConfigSolarSchoolSpanById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolSpanById.HandleId, ConfigSolarSchoolSpanById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolSpan rootAsSolarSchoolSpan = SolarSchoolSpan.GetRootAsSolarSchoolSpan(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSpanById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolSpanById.HandleId, ConfigSolarSchoolSpanById.LogPair);
			return new SolarSchoolSpan?(rootAsSolarSchoolSpan);
		}

		// Token: 0x04004713 RID: 18195
		private const string DB = "db_solarschool.db";

		// Token: 0x04004714 RID: 18196
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004715 RID: 18197
		private const string TABLE = "SolarSchoolSpan";

		// Token: 0x04004716 RID: 18198
		private const string COMMAND = "select BinData from `SolarSchoolSpan` where Id=?";

		// Token: 0x04004717 RID: 18199
		private const string KEY_PREFIX = "SolarSchoolSpanById";

		// Token: 0x04004718 RID: 18200
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004719 RID: 18201
		private static int HandleId;
	}
}
