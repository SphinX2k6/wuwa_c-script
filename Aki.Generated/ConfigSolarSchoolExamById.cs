using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D6 RID: 2518
	public class ConfigSolarSchoolExamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B18 RID: 15128 RVA: 0x001AAC34 File Offset: 0x001A8E34
		static ConfigSolarSchoolExamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolExamById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolExamById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x001AAC54 File Offset: 0x001A8E54
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolExamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolExamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolExam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolExam` where Id=?")
			});
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x001AACD3 File Offset: 0x001A8ED3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolExamById.LogPair = null;
			ConfigSolarSchoolExamById.HandleId = 0;
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x001AACE1 File Offset: 0x001A8EE1
		public static void Init()
		{
			ConfigSolarSchoolExamById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolExamById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolExam` where Id=?");
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x001AACFC File Offset: 0x001A8EFC
		public static SolarSchoolExam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolExamById.HandleId, ConfigSolarSchoolExamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolExam?(SolarSchoolExam.GetRootAsSolarSchoolExam(configBuffer));
				}
			}
			ConfigSolarSchoolExamById.LogPair.Clear();
			ConfigSolarSchoolExamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolExamById.HandleId, 1, p0Id, ConfigSolarSchoolExamById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolExamById.HandleId, true, ConfigSolarSchoolExamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamById.HandleId, ConfigSolarSchoolExamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolExamById.HandleId, 0, ConfigSolarSchoolExamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamById.HandleId, ConfigSolarSchoolExamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolExam rootAsSolarSchoolExam = SolarSchoolExam.GetRootAsSolarSchoolExam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolExamById.HandleId, ConfigSolarSchoolExamById.LogPair);
			return new SolarSchoolExam?(rootAsSolarSchoolExam);
		}

		// Token: 0x040044C0 RID: 17600
		private const string DB = "db_solarschool.db";

		// Token: 0x040044C1 RID: 17601
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044C2 RID: 17602
		private const string TABLE = "SolarSchoolExam";

		// Token: 0x040044C3 RID: 17603
		private const string COMMAND = "select BinData from `SolarSchoolExam` where Id=?";

		// Token: 0x040044C4 RID: 17604
		private const string KEY_PREFIX = "SolarSchoolExamById";

		// Token: 0x040044C5 RID: 17605
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044C6 RID: 17606
		private static int HandleId;
	}
}
