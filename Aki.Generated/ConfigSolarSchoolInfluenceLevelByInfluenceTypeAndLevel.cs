using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E7 RID: 2535
	public class ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B7E RID: 15230 RVA: 0x001AD154 File Offset: 0x001AB354
		static ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.CreateStaticDefaultValue), new Action(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x001AD174 File Offset: 0x001AB374
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolInfluenceLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolInfluenceLevel` where InfluenceType=? AND Level=?")
			});
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x001AD1F3 File Offset: 0x001AB3F3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair = null;
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId = 0;
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x001AD201 File Offset: 0x001AB401
		public static void Init()
		{
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolInfluenceLevel` where InfluenceType=? AND Level=?");
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x001AD21C File Offset: 0x001AB41C
		public static SolarSchoolInfluenceLevel? GetConfig(int p0InfluenceType, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInfluenceLevelByInfluenceTypeAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InfluenceType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolInfluenceLevel?(SolarSchoolInfluenceLevel.GetRootAsSolarSchoolInfluenceLevel(configBuffer));
				}
			}
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair.Clear();
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair.Add(new ValueTuple<string, object>("InfluenceType", p0InfluenceType));
			ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, 1, p0InfluenceType, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, 2, p1Level, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair) || ConfigCommon.Step(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, true, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, 0, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolInfluenceLevel rootAsSolarSchoolInfluenceLevel = SolarSchoolInfluenceLevel.GetRootAsSolarSchoolInfluenceLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInfluenceLevelByInfluenceTypeAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InfluenceType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.HandleId, ConfigSolarSchoolInfluenceLevelByInfluenceTypeAndLevel.LogPair);
			return new SolarSchoolInfluenceLevel?(rootAsSolarSchoolInfluenceLevel);
		}

		// Token: 0x04004537 RID: 17719
		private const string DB = "db_solarschool.db";

		// Token: 0x04004538 RID: 17720
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x04004539 RID: 17721
		private const string TABLE = "SolarSchoolInfluenceLevel";

		// Token: 0x0400453A RID: 17722
		private const string COMMAND = "select BinData from `SolarSchoolInfluenceLevel` where InfluenceType=? AND Level=?";

		// Token: 0x0400453B RID: 17723
		private const string KEY_PREFIX = "SolarSchoolInfluenceLevelByInfluenceTypeAndLevel";

		// Token: 0x0400453C RID: 17724
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400453D RID: 17725
		private static int HandleId;
	}
}
