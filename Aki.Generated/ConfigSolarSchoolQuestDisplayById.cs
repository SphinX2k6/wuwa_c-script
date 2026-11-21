using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A02 RID: 2562
	public class ConfigSolarSchoolQuestDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C20 RID: 15392 RVA: 0x001B0A7B File Offset: 0x001AEC7B
		static ConfigSolarSchoolQuestDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestDisplayById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x001B0A9C File Offset: 0x001AEC9C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestDisplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestDisplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuestDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuestDisplay` where Id=?")
			});
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x001B0B1B File Offset: 0x001AED1B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestDisplayById.LogPair = null;
			ConfigSolarSchoolQuestDisplayById.HandleId = 0;
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x001B0B29 File Offset: 0x001AED29
		public static void Init()
		{
			ConfigSolarSchoolQuestDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestDisplayById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuestDisplay` where Id=?");
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x001B0B44 File Offset: 0x001AED44
		public static SolarSchoolQuestDisplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestDisplayById.HandleId, ConfigSolarSchoolQuestDisplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolQuestDisplay?(SolarSchoolQuestDisplay.GetRootAsSolarSchoolQuestDisplay(configBuffer));
				}
			}
			ConfigSolarSchoolQuestDisplayById.LogPair.Clear();
			ConfigSolarSchoolQuestDisplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolQuestDisplayById.HandleId, 1, p0Id, ConfigSolarSchoolQuestDisplayById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolQuestDisplayById.HandleId, true, ConfigSolarSchoolQuestDisplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestDisplayById.HandleId, ConfigSolarSchoolQuestDisplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestDisplayById.HandleId, 0, ConfigSolarSchoolQuestDisplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestDisplayById.HandleId, ConfigSolarSchoolQuestDisplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolQuestDisplay rootAsSolarSchoolQuestDisplay = SolarSchoolQuestDisplay.GetRootAsSolarSchoolQuestDisplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestDisplayById.HandleId, ConfigSolarSchoolQuestDisplayById.LogPair);
			return new SolarSchoolQuestDisplay?(rootAsSolarSchoolQuestDisplay);
		}

		// Token: 0x040045F4 RID: 17908
		private const string DB = "db_solarschool.db";

		// Token: 0x040045F5 RID: 17909
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x040045F6 RID: 17910
		private const string TABLE = "SolarSchoolQuestDisplay";

		// Token: 0x040045F7 RID: 17911
		private const string COMMAND = "select BinData from `SolarSchoolQuestDisplay` where Id=?";

		// Token: 0x040045F8 RID: 17912
		private const string KEY_PREFIX = "SolarSchoolQuestDisplayById";

		// Token: 0x040045F9 RID: 17913
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045FA RID: 17914
		private static int HandleId;
	}
}
