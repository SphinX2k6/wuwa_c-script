using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1C RID: 2588
	public class ConfigSolarSchoolRoleTalkById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CBC RID: 15548 RVA: 0x001B409C File Offset: 0x001B229C
		static ConfigSolarSchoolRoleTalkById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleTalkById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleTalkById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x001B40BC File Offset: 0x001B22BC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleTalkById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleTalk"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleTalk` where Id=?")
			});
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x001B413B File Offset: 0x001B233B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkById.LogPair = null;
			ConfigSolarSchoolRoleTalkById.HandleId = 0;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x001B4149 File Offset: 0x001B2349
		public static void Init()
		{
			ConfigSolarSchoolRoleTalkById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleTalkById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleTalk` where Id=?");
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x001B4164 File Offset: 0x001B2364
		public static SolarSchoolRoleTalk? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleTalkById.HandleId, ConfigSolarSchoolRoleTalkById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleTalkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolRoleTalk?(SolarSchoolRoleTalk.GetRootAsSolarSchoolRoleTalk(configBuffer));
				}
			}
			ConfigSolarSchoolRoleTalkById.LogPair.Clear();
			ConfigSolarSchoolRoleTalkById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleTalkById.HandleId, 1, p0Id, ConfigSolarSchoolRoleTalkById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolRoleTalkById.HandleId, true, ConfigSolarSchoolRoleTalkById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleTalkById.HandleId, ConfigSolarSchoolRoleTalkById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleTalkById.HandleId, 0, ConfigSolarSchoolRoleTalkById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleTalkById.HandleId, ConfigSolarSchoolRoleTalkById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolRoleTalk rootAsSolarSchoolRoleTalk = SolarSchoolRoleTalk.GetRootAsSolarSchoolRoleTalk(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleTalkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleTalkById.HandleId, ConfigSolarSchoolRoleTalkById.LogPair);
			return new SolarSchoolRoleTalk?(rootAsSolarSchoolRoleTalk);
		}

		// Token: 0x040046AA RID: 18090
		private const string DB = "db_solarschool.db";

		// Token: 0x040046AB RID: 18091
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x040046AC RID: 18092
		private const string TABLE = "SolarSchoolRoleTalk";

		// Token: 0x040046AD RID: 18093
		private const string COMMAND = "select BinData from `SolarSchoolRoleTalk` where Id=?";

		// Token: 0x040046AE RID: 18094
		private const string KEY_PREFIX = "SolarSchoolRoleTalkById";

		// Token: 0x040046AF RID: 18095
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046B0 RID: 18096
		private static int HandleId;
	}
}
