using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D7 RID: 2519
	public class ConfigSolarSchoolExamByInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B1E RID: 15134 RVA: 0x001AAE7C File Offset: 0x001A907C
		static ConfigSolarSchoolExamByInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolExamByInstanceId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolExamByInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x001AAE9C File Offset: 0x001A909C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolExamByInstanceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolExamByInstanceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolExam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolExam` where InstanceId=?")
			});
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x001AAF1B File Offset: 0x001A911B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolExamByInstanceId.LogPair = null;
			ConfigSolarSchoolExamByInstanceId.HandleId = 0;
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x001AAF29 File Offset: 0x001A9129
		public static void Init()
		{
			ConfigSolarSchoolExamByInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolExamByInstanceId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolExam` where InstanceId=?");
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x001AAF44 File Offset: 0x001A9144
		public static SolarSchoolExam? GetConfig(int p0InstanceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolExamByInstanceId.HandleId, ConfigSolarSchoolExamByInstanceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamByInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolExam?(SolarSchoolExam.GetRootAsSolarSchoolExam(configBuffer));
				}
			}
			ConfigSolarSchoolExamByInstanceId.LogPair.Clear();
			ConfigSolarSchoolExamByInstanceId.LogPair.Add(new ValueTuple<string, object>("InstanceId", p0InstanceId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolExamByInstanceId.HandleId, 1, p0InstanceId, ConfigSolarSchoolExamByInstanceId.LogPair) || ConfigCommon.Step(ConfigSolarSchoolExamByInstanceId.HandleId, true, ConfigSolarSchoolExamByInstanceId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamByInstanceId.HandleId, ConfigSolarSchoolExamByInstanceId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolExamByInstanceId.HandleId, 0, ConfigSolarSchoolExamByInstanceId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamByInstanceId.HandleId, ConfigSolarSchoolExamByInstanceId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolExam rootAsSolarSchoolExam = SolarSchoolExam.GetRootAsSolarSchoolExam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamByInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolExamByInstanceId.HandleId, ConfigSolarSchoolExamByInstanceId.LogPair);
			return new SolarSchoolExam?(rootAsSolarSchoolExam);
		}

		// Token: 0x040044C7 RID: 17607
		private const string DB = "db_solarschool.db";

		// Token: 0x040044C8 RID: 17608
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044C9 RID: 17609
		private const string TABLE = "SolarSchoolExam";

		// Token: 0x040044CA RID: 17610
		private const string COMMAND = "select BinData from `SolarSchoolExam` where InstanceId=?";

		// Token: 0x040044CB RID: 17611
		private const string KEY_PREFIX = "SolarSchoolExamByInstanceId";

		// Token: 0x040044CC RID: 17612
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044CD RID: 17613
		private static int HandleId;
	}
}
