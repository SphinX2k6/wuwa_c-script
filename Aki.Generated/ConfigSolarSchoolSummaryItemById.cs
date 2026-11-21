using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2D RID: 2605
	public class ConfigSolarSchoolSummaryItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D22 RID: 15650 RVA: 0x001B631F File Offset: 0x001B451F
		static ConfigSolarSchoolSummaryItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolSummaryItemById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolSummaryItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x001B6340 File Offset: 0x001B4540
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolSummaryItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolSummaryItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolSummaryItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolSummaryItem` where Id=?")
			});
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x001B63BF File Offset: 0x001B45BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolSummaryItemById.LogPair = null;
			ConfigSolarSchoolSummaryItemById.HandleId = 0;
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x001B63CD File Offset: 0x001B45CD
		public static void Init()
		{
			ConfigSolarSchoolSummaryItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolSummaryItemById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolSummaryItem` where Id=?");
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x001B63E8 File Offset: 0x001B45E8
		public static SolarSchoolSummaryItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolSummaryItemById.HandleId, ConfigSolarSchoolSummaryItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSummaryItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolSummaryItem?(SolarSchoolSummaryItem.GetRootAsSolarSchoolSummaryItem(configBuffer));
				}
			}
			ConfigSolarSchoolSummaryItemById.LogPair.Clear();
			ConfigSolarSchoolSummaryItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolSummaryItemById.HandleId, 1, p0Id, ConfigSolarSchoolSummaryItemById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolSummaryItemById.HandleId, true, ConfigSolarSchoolSummaryItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolSummaryItemById.HandleId, ConfigSolarSchoolSummaryItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolSummaryItemById.HandleId, 0, ConfigSolarSchoolSummaryItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolSummaryItemById.HandleId, ConfigSolarSchoolSummaryItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolSummaryItem rootAsSolarSchoolSummaryItem = SolarSchoolSummaryItem.GetRootAsSolarSchoolSummaryItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSummaryItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolSummaryItemById.HandleId, ConfigSolarSchoolSummaryItemById.LogPair);
			return new SolarSchoolSummaryItem?(rootAsSolarSchoolSummaryItem);
		}

		// Token: 0x04004721 RID: 18209
		private const string DB = "db_solarschool.db";

		// Token: 0x04004722 RID: 18210
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004723 RID: 18211
		private const string TABLE = "SolarSchoolSummaryItem";

		// Token: 0x04004724 RID: 18212
		private const string COMMAND = "select BinData from `SolarSchoolSummaryItem` where Id=?";

		// Token: 0x04004725 RID: 18213
		private const string KEY_PREFIX = "SolarSchoolSummaryItemById";

		// Token: 0x04004726 RID: 18214
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004727 RID: 18215
		private static int HandleId;
	}
}
