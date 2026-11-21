using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FF RID: 2559
	public class ConfigSolarSchoolQuestByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C0E RID: 15374 RVA: 0x001B03C3 File Offset: 0x001AE5C3
		static ConfigSolarSchoolQuestByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x001B03E4 File Offset: 0x001AE5E4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuest` where ActivityId=?")
			});
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x001B0463 File Offset: 0x001AE663
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestByActivityId.LogPair = null;
			ConfigSolarSchoolQuestByActivityId.HandleId = 0;
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x001B0471 File Offset: 0x001AE671
		public static void Init()
		{
			ConfigSolarSchoolQuestByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuest` where ActivityId=?");
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x001B048C File Offset: 0x001AE68C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolQuest> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestByActivityId.HandleId, ConfigSolarSchoolQuestByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolQuest> readOnlyList = (IReadOnlyList<SolarSchoolQuest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolQuestByActivityId.LogPair.Clear();
			ConfigSolarSchoolQuestByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolQuestByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolQuestByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestByActivityId.HandleId, ConfigSolarSchoolQuestByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolQuest> list = new List<SolarSchoolQuest>();
			while (ConfigCommon.Step(ConfigSolarSchoolQuestByActivityId.HandleId, false, ConfigSolarSchoolQuestByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestByActivityId.HandleId, 0, ConfigSolarSchoolQuestByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolQuestByActivityId.HandleId, ConfigSolarSchoolQuestByActivityId.LogPair);
					return null;
				}
				SolarSchoolQuest rootAsSolarSchoolQuest = SolarSchoolQuest.GetRootAsSolarSchoolQuest(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolQuest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestByActivityId.HandleId, ConfigSolarSchoolQuestByActivityId.LogPair);
			return list;
		}

		// Token: 0x040045DF RID: 17887
		private const string DB = "db_solarschool.db";

		// Token: 0x040045E0 RID: 17888
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x040045E1 RID: 17889
		private const string TABLE = "SolarSchoolQuest";

		// Token: 0x040045E2 RID: 17890
		private const string COMMAND = "select BinData from `SolarSchoolQuest` where ActivityId=?";

		// Token: 0x040045E3 RID: 17891
		private const string KEY_PREFIX = "SolarSchoolQuestByActivityId";

		// Token: 0x040045E4 RID: 17892
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045E5 RID: 17893
		private static int HandleId;
	}
}
