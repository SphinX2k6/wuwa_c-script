using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F0 RID: 2544
	public class ConfigSolarSchoolLetterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BB4 RID: 15284 RVA: 0x001AE3F4 File Offset: 0x001AC5F4
		static ConfigSolarSchoolLetterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolLetterById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolLetterById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x001AE414 File Offset: 0x001AC614
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolLetterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolLetterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolLetter"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolLetter` where Id=?")
			});
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x001AE493 File Offset: 0x001AC693
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolLetterById.LogPair = null;
			ConfigSolarSchoolLetterById.HandleId = 0;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x001AE4A1 File Offset: 0x001AC6A1
		public static void Init()
		{
			ConfigSolarSchoolLetterById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolLetterById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolLetter` where Id=?");
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x001AE4BC File Offset: 0x001AC6BC
		public static SolarSchoolLetter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolLetterById.HandleId, ConfigSolarSchoolLetterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolLetter?(SolarSchoolLetter.GetRootAsSolarSchoolLetter(configBuffer));
				}
			}
			ConfigSolarSchoolLetterById.LogPair.Clear();
			ConfigSolarSchoolLetterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolLetterById.HandleId, 1, p0Id, ConfigSolarSchoolLetterById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolLetterById.HandleId, true, ConfigSolarSchoolLetterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolLetterById.HandleId, ConfigSolarSchoolLetterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolLetterById.HandleId, 0, ConfigSolarSchoolLetterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolLetterById.HandleId, ConfigSolarSchoolLetterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolLetter rootAsSolarSchoolLetter = SolarSchoolLetter.GetRootAsSolarSchoolLetter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolLetterById.HandleId, ConfigSolarSchoolLetterById.LogPair);
			return new SolarSchoolLetter?(rootAsSolarSchoolLetter);
		}

		// Token: 0x04004576 RID: 17782
		private const string DB = "db_solarschool.db";

		// Token: 0x04004577 RID: 17783
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x04004578 RID: 17784
		private const string TABLE = "SolarSchoolLetter";

		// Token: 0x04004579 RID: 17785
		private const string COMMAND = "select BinData from `SolarSchoolLetter` where Id=?";

		// Token: 0x0400457A RID: 17786
		private const string KEY_PREFIX = "SolarSchoolLetterById";

		// Token: 0x0400457B RID: 17787
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400457C RID: 17788
		private static int HandleId;
	}
}
