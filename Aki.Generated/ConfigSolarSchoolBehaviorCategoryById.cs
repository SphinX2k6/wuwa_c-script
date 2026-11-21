using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BE RID: 2494
	public class ConfigSolarSchoolBehaviorCategoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A88 RID: 14984 RVA: 0x001A7967 File Offset: 0x001A5B67
		static ConfigSolarSchoolBehaviorCategoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBehaviorCategoryById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBehaviorCategoryById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x001A7988 File Offset: 0x001A5B88
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorCategoryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBehaviorCategoryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBehaviorCategory"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBehaviorCategory` where Id=?")
			});
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x001A7A07 File Offset: 0x001A5C07
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorCategoryById.LogPair = null;
			ConfigSolarSchoolBehaviorCategoryById.HandleId = 0;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x001A7A15 File Offset: 0x001A5C15
		public static void Init()
		{
			ConfigSolarSchoolBehaviorCategoryById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBehaviorCategoryById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBehaviorCategory` where Id=?");
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x001A7A30 File Offset: 0x001A5C30
		public static SolarSchoolBehaviorCategory? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBehaviorCategoryById.HandleId, ConfigSolarSchoolBehaviorCategoryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorCategoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolBehaviorCategory?(SolarSchoolBehaviorCategory.GetRootAsSolarSchoolBehaviorCategory(configBuffer));
				}
			}
			ConfigSolarSchoolBehaviorCategoryById.LogPair.Clear();
			ConfigSolarSchoolBehaviorCategoryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolBehaviorCategoryById.HandleId, 1, p0Id, ConfigSolarSchoolBehaviorCategoryById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolBehaviorCategoryById.HandleId, true, ConfigSolarSchoolBehaviorCategoryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryById.HandleId, ConfigSolarSchoolBehaviorCategoryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBehaviorCategoryById.HandleId, 0, ConfigSolarSchoolBehaviorCategoryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryById.HandleId, ConfigSolarSchoolBehaviorCategoryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolBehaviorCategory rootAsSolarSchoolBehaviorCategory = SolarSchoolBehaviorCategory.GetRootAsSolarSchoolBehaviorCategory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorCategoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBehaviorCategoryById.HandleId, ConfigSolarSchoolBehaviorCategoryById.LogPair);
			return new SolarSchoolBehaviorCategory?(rootAsSolarSchoolBehaviorCategory);
		}

		// Token: 0x04004418 RID: 17432
		private const string DB = "db_solarschool.db";

		// Token: 0x04004419 RID: 17433
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400441A RID: 17434
		private const string TABLE = "SolarSchoolBehaviorCategory";

		// Token: 0x0400441B RID: 17435
		private const string COMMAND = "select BinData from `SolarSchoolBehaviorCategory` where Id=?";

		// Token: 0x0400441C RID: 17436
		private const string KEY_PREFIX = "SolarSchoolBehaviorCategoryById";

		// Token: 0x0400441D RID: 17437
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400441E RID: 17438
		private static int HandleId;
	}
}
