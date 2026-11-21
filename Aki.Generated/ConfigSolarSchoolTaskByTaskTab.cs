using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A30 RID: 2608
	public class ConfigSolarSchoolTaskByTaskTab : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D34 RID: 15668 RVA: 0x001B6944 File Offset: 0x001B4B44
		static ConfigSolarSchoolTaskByTaskTab()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolTaskByTaskTab.CreateStaticDefaultValue), new Action(ConfigSolarSchoolTaskByTaskTab.ResetStaticDefaultValue));
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x001B6964 File Offset: 0x001B4B64
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolTaskByTaskTab.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolTaskByTaskTab.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolTask` where TaskTab=?")
			});
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x001B69E3 File Offset: 0x001B4BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolTaskByTaskTab.LogPair = null;
			ConfigSolarSchoolTaskByTaskTab.HandleId = 0;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x001B69F1 File Offset: 0x001B4BF1
		public static void Init()
		{
			ConfigSolarSchoolTaskByTaskTab.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolTaskByTaskTab.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolTask` where TaskTab=?");
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x001B6A0C File Offset: 0x001B4C0C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolTask> GetConfigList(int p0TaskTab, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolTaskByTaskTab.HandleId, ConfigSolarSchoolTaskByTaskTab.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTaskByTaskTab");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskTab);
				IReadOnlyList<SolarSchoolTask> readOnlyList = (IReadOnlyList<SolarSchoolTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolTaskByTaskTab.LogPair.Clear();
			ConfigSolarSchoolTaskByTaskTab.LogPair.Add(new ValueTuple<string, object>("TaskTab", p0TaskTab));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolTaskByTaskTab.HandleId, 1, p0TaskTab, ConfigSolarSchoolTaskByTaskTab.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolTaskByTaskTab.HandleId, ConfigSolarSchoolTaskByTaskTab.LogPair);
				return null;
			}
			List<SolarSchoolTask> list = new List<SolarSchoolTask>();
			while (ConfigCommon.Step(ConfigSolarSchoolTaskByTaskTab.HandleId, false, ConfigSolarSchoolTaskByTaskTab.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolTaskByTaskTab.HandleId, 0, ConfigSolarSchoolTaskByTaskTab.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolTaskByTaskTab.HandleId, ConfigSolarSchoolTaskByTaskTab.LogPair);
					return null;
				}
				SolarSchoolTask rootAsSolarSchoolTask = SolarSchoolTask.GetRootAsSolarSchoolTask(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTaskByTaskTab");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskTab);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolTaskByTaskTab.HandleId, ConfigSolarSchoolTaskByTaskTab.LogPair);
			return list;
		}

		// Token: 0x04004736 RID: 18230
		private const string DB = "db_solarschool.db";

		// Token: 0x04004737 RID: 18231
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004738 RID: 18232
		private const string TABLE = "SolarSchoolTask";

		// Token: 0x04004739 RID: 18233
		private const string COMMAND = "select BinData from `SolarSchoolTask` where TaskTab=?";

		// Token: 0x0400473A RID: 18234
		private const string KEY_PREFIX = "SolarSchoolTaskByTaskTab";

		// Token: 0x0400473B RID: 18235
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400473C RID: 18236
		private static int HandleId;
	}
}
