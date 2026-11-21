using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A01 RID: 2561
	public class ConfigSolarSchoolQuestDisplayByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C1A RID: 15386 RVA: 0x001B0844 File Offset: 0x001AEA44
		static ConfigSolarSchoolQuestDisplayByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestDisplayByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestDisplayByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x001B0864 File Offset: 0x001AEA64
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestDisplayByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestDisplayByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuestDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuestDisplay` where ActivityId=?")
			});
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x001B08E3 File Offset: 0x001AEAE3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestDisplayByActivityId.LogPair = null;
			ConfigSolarSchoolQuestDisplayByActivityId.HandleId = 0;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x001B08F1 File Offset: 0x001AEAF1
		public static void Init()
		{
			ConfigSolarSchoolQuestDisplayByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuestDisplay` where ActivityId=?");
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x001B090C File Offset: 0x001AEB0C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolQuestDisplay> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, ConfigSolarSchoolQuestDisplayByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestDisplayByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolQuestDisplay> readOnlyList = (IReadOnlyList<SolarSchoolQuestDisplay>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolQuestDisplayByActivityId.LogPair.Clear();
			ConfigSolarSchoolQuestDisplayByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolQuestDisplayByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, ConfigSolarSchoolQuestDisplayByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolQuestDisplay> list = new List<SolarSchoolQuestDisplay>();
			while (ConfigCommon.Step(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, false, ConfigSolarSchoolQuestDisplayByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, 0, ConfigSolarSchoolQuestDisplayByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, ConfigSolarSchoolQuestDisplayByActivityId.LogPair);
					return null;
				}
				SolarSchoolQuestDisplay rootAsSolarSchoolQuestDisplay = SolarSchoolQuestDisplay.GetRootAsSolarSchoolQuestDisplay(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolQuestDisplay);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestDisplayByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestDisplayByActivityId.HandleId, ConfigSolarSchoolQuestDisplayByActivityId.LogPair);
			return list;
		}

		// Token: 0x040045ED RID: 17901
		private const string DB = "db_solarschool.db";

		// Token: 0x040045EE RID: 17902
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x040045EF RID: 17903
		private const string TABLE = "SolarSchoolQuestDisplay";

		// Token: 0x040045F0 RID: 17904
		private const string COMMAND = "select BinData from `SolarSchoolQuestDisplay` where ActivityId=?";

		// Token: 0x040045F1 RID: 17905
		private const string KEY_PREFIX = "SolarSchoolQuestDisplayByActivityId";

		// Token: 0x040045F2 RID: 17906
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045F3 RID: 17907
		private static int HandleId;
	}
}
