using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DA RID: 2522
	public class ConfigSolarSchoolExamEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B30 RID: 15152 RVA: 0x001AB544 File Offset: 0x001A9744
		static ConfigSolarSchoolExamEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolExamEventById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolExamEventById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x001AB564 File Offset: 0x001A9764
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolExamEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolExamEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolExamEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolExamEvent` where Id=?")
			});
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x001AB5E3 File Offset: 0x001A97E3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolExamEventById.LogPair = null;
			ConfigSolarSchoolExamEventById.HandleId = 0;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x001AB5F1 File Offset: 0x001A97F1
		public static void Init()
		{
			ConfigSolarSchoolExamEventById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolExamEventById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolExamEvent` where Id=?");
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x001AB60C File Offset: 0x001A980C
		public static SolarSchoolExamEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolExamEventById.HandleId, ConfigSolarSchoolExamEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolExamEvent?(SolarSchoolExamEvent.GetRootAsSolarSchoolExamEvent(configBuffer));
				}
			}
			ConfigSolarSchoolExamEventById.LogPair.Clear();
			ConfigSolarSchoolExamEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolExamEventById.HandleId, 1, p0Id, ConfigSolarSchoolExamEventById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolExamEventById.HandleId, true, ConfigSolarSchoolExamEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamEventById.HandleId, ConfigSolarSchoolExamEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolExamEventById.HandleId, 0, ConfigSolarSchoolExamEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamEventById.HandleId, ConfigSolarSchoolExamEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolExamEvent rootAsSolarSchoolExamEvent = SolarSchoolExamEvent.GetRootAsSolarSchoolExamEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolExamEventById.HandleId, ConfigSolarSchoolExamEventById.LogPair);
			return new SolarSchoolExamEvent?(rootAsSolarSchoolExamEvent);
		}

		// Token: 0x040044DC RID: 17628
		private const string DB = "db_solarschool.db";

		// Token: 0x040044DD RID: 17629
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044DE RID: 17630
		private const string TABLE = "SolarSchoolExamEvent";

		// Token: 0x040044DF RID: 17631
		private const string COMMAND = "select BinData from `SolarSchoolExamEvent` where Id=?";

		// Token: 0x040044E0 RID: 17632
		private const string KEY_PREFIX = "SolarSchoolExamEventById";

		// Token: 0x040044E1 RID: 17633
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044E2 RID: 17634
		private static int HandleId;
	}
}
