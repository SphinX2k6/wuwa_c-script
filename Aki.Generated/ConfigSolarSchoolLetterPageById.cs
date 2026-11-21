using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F1 RID: 2545
	public class ConfigSolarSchoolLetterPageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BBA RID: 15290 RVA: 0x001AE63C File Offset: 0x001AC83C
		static ConfigSolarSchoolLetterPageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolLetterPageById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolLetterPageById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x001AE65C File Offset: 0x001AC85C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolLetterPageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolLetterPageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolLetterPage"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolLetterPage` where Id=?")
			});
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x001AE6DB File Offset: 0x001AC8DB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolLetterPageById.LogPair = null;
			ConfigSolarSchoolLetterPageById.HandleId = 0;
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x001AE6E9 File Offset: 0x001AC8E9
		public static void Init()
		{
			ConfigSolarSchoolLetterPageById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolLetterPageById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolLetterPage` where Id=?");
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x001AE704 File Offset: 0x001AC904
		public static SolarSchoolLetterPage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolLetterPageById.HandleId, ConfigSolarSchoolLetterPageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLetterPageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolLetterPage?(SolarSchoolLetterPage.GetRootAsSolarSchoolLetterPage(configBuffer));
				}
			}
			ConfigSolarSchoolLetterPageById.LogPair.Clear();
			ConfigSolarSchoolLetterPageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolLetterPageById.HandleId, 1, p0Id, ConfigSolarSchoolLetterPageById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolLetterPageById.HandleId, true, ConfigSolarSchoolLetterPageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolLetterPageById.HandleId, ConfigSolarSchoolLetterPageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolLetterPageById.HandleId, 0, ConfigSolarSchoolLetterPageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolLetterPageById.HandleId, ConfigSolarSchoolLetterPageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolLetterPage rootAsSolarSchoolLetterPage = SolarSchoolLetterPage.GetRootAsSolarSchoolLetterPage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLetterPageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolLetterPageById.HandleId, ConfigSolarSchoolLetterPageById.LogPair);
			return new SolarSchoolLetterPage?(rootAsSolarSchoolLetterPage);
		}

		// Token: 0x0400457D RID: 17789
		private const string DB = "db_solarschool.db";

		// Token: 0x0400457E RID: 17790
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x0400457F RID: 17791
		private const string TABLE = "SolarSchoolLetterPage";

		// Token: 0x04004580 RID: 17792
		private const string COMMAND = "select BinData from `SolarSchoolLetterPage` where Id=?";

		// Token: 0x04004581 RID: 17793
		private const string KEY_PREFIX = "SolarSchoolLetterPageById";

		// Token: 0x04004582 RID: 17794
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004583 RID: 17795
		private static int HandleId;
	}
}
