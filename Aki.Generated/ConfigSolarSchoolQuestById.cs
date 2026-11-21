using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A00 RID: 2560
	public class ConfigSolarSchoolQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C14 RID: 15380 RVA: 0x001B05FB File Offset: 0x001AE7FB
		static ConfigSolarSchoolQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x001B061C File Offset: 0x001AE81C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuest` where Id=?")
			});
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x001B069B File Offset: 0x001AE89B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestById.LogPair = null;
			ConfigSolarSchoolQuestById.HandleId = 0;
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x001B06A9 File Offset: 0x001AE8A9
		public static void Init()
		{
			ConfigSolarSchoolQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuest` where Id=?");
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x001B06C4 File Offset: 0x001AE8C4
		public static SolarSchoolQuest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestById.HandleId, ConfigSolarSchoolQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolQuest?(SolarSchoolQuest.GetRootAsSolarSchoolQuest(configBuffer));
				}
			}
			ConfigSolarSchoolQuestById.LogPair.Clear();
			ConfigSolarSchoolQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolQuestById.HandleId, 1, p0Id, ConfigSolarSchoolQuestById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolQuestById.HandleId, true, ConfigSolarSchoolQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestById.HandleId, ConfigSolarSchoolQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestById.HandleId, 0, ConfigSolarSchoolQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestById.HandleId, ConfigSolarSchoolQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolQuest rootAsSolarSchoolQuest = SolarSchoolQuest.GetRootAsSolarSchoolQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestById.HandleId, ConfigSolarSchoolQuestById.LogPair);
			return new SolarSchoolQuest?(rootAsSolarSchoolQuest);
		}

		// Token: 0x040045E6 RID: 17894
		private const string DB = "db_solarschool.db";

		// Token: 0x040045E7 RID: 17895
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x040045E8 RID: 17896
		private const string TABLE = "SolarSchoolQuest";

		// Token: 0x040045E9 RID: 17897
		private const string COMMAND = "select BinData from `SolarSchoolQuest` where Id=?";

		// Token: 0x040045EA RID: 17898
		private const string KEY_PREFIX = "SolarSchoolQuestById";

		// Token: 0x040045EB RID: 17899
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045EC RID: 17900
		private static int HandleId;
	}
}
