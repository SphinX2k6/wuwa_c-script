using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E3 RID: 2531
	public class ConfigSolarSchoolFunctionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B66 RID: 15206 RVA: 0x001AC8E7 File Offset: 0x001AAAE7
		static ConfigSolarSchoolFunctionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolFunctionById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolFunctionById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x001AC908 File Offset: 0x001AAB08
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolFunctionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolFunctionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolFunction"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolFunction` where Id=?")
			});
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x001AC987 File Offset: 0x001AAB87
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolFunctionById.LogPair = null;
			ConfigSolarSchoolFunctionById.HandleId = 0;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x001AC995 File Offset: 0x001AAB95
		public static void Init()
		{
			ConfigSolarSchoolFunctionById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolFunctionById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolFunction` where Id=?");
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x001AC9B0 File Offset: 0x001AABB0
		public static SolarSchoolFunction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolFunctionById.HandleId, ConfigSolarSchoolFunctionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolFunction?(SolarSchoolFunction.GetRootAsSolarSchoolFunction(configBuffer));
				}
			}
			ConfigSolarSchoolFunctionById.LogPair.Clear();
			ConfigSolarSchoolFunctionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolFunctionById.HandleId, 1, p0Id, ConfigSolarSchoolFunctionById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolFunctionById.HandleId, true, ConfigSolarSchoolFunctionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolFunctionById.HandleId, ConfigSolarSchoolFunctionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolFunctionById.HandleId, 0, ConfigSolarSchoolFunctionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolFunctionById.HandleId, ConfigSolarSchoolFunctionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolFunction rootAsSolarSchoolFunction = SolarSchoolFunction.GetRootAsSolarSchoolFunction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolFunctionById.HandleId, ConfigSolarSchoolFunctionById.LogPair);
			return new SolarSchoolFunction?(rootAsSolarSchoolFunction);
		}

		// Token: 0x0400451B RID: 17691
		private const string DB = "db_solarschool.db";

		// Token: 0x0400451C RID: 17692
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400451D RID: 17693
		private const string TABLE = "SolarSchoolFunction";

		// Token: 0x0400451E RID: 17694
		private const string COMMAND = "select BinData from `SolarSchoolFunction` where Id=?";

		// Token: 0x0400451F RID: 17695
		private const string KEY_PREFIX = "SolarSchoolFunctionById";

		// Token: 0x04004520 RID: 17696
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004521 RID: 17697
		private static int HandleId;
	}
}
