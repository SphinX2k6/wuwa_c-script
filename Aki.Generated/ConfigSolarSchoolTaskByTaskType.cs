using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A31 RID: 2609
	public class ConfigSolarSchoolTaskByTaskType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D3A RID: 15674 RVA: 0x001B6B7B File Offset: 0x001B4D7B
		static ConfigSolarSchoolTaskByTaskType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolTaskByTaskType.CreateStaticDefaultValue), new Action(ConfigSolarSchoolTaskByTaskType.ResetStaticDefaultValue));
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x001B6B9C File Offset: 0x001B4D9C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolTaskByTaskType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolTaskByTaskType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolTask` where TaskType=?")
			});
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x001B6C1B File Offset: 0x001B4E1B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolTaskByTaskType.LogPair = null;
			ConfigSolarSchoolTaskByTaskType.HandleId = 0;
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x001B6C29 File Offset: 0x001B4E29
		public static void Init()
		{
			ConfigSolarSchoolTaskByTaskType.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolTaskByTaskType.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolTask` where TaskType=?");
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x001B6C44 File Offset: 0x001B4E44
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolTask> GetConfigList(int p0TaskType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolTaskByTaskType.HandleId, ConfigSolarSchoolTaskByTaskType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				IReadOnlyList<SolarSchoolTask> readOnlyList = (IReadOnlyList<SolarSchoolTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolTaskByTaskType.LogPair.Clear();
			ConfigSolarSchoolTaskByTaskType.LogPair.Add(new ValueTuple<string, object>("TaskType", p0TaskType));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolTaskByTaskType.HandleId, 1, p0TaskType, ConfigSolarSchoolTaskByTaskType.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolTaskByTaskType.HandleId, ConfigSolarSchoolTaskByTaskType.LogPair);
				return null;
			}
			List<SolarSchoolTask> list = new List<SolarSchoolTask>();
			while (ConfigCommon.Step(ConfigSolarSchoolTaskByTaskType.HandleId, false, ConfigSolarSchoolTaskByTaskType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolTaskByTaskType.HandleId, 0, ConfigSolarSchoolTaskByTaskType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolTaskByTaskType.HandleId, ConfigSolarSchoolTaskByTaskType.LogPair);
					return null;
				}
				SolarSchoolTask rootAsSolarSchoolTask = SolarSchoolTask.GetRootAsSolarSchoolTask(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolTaskByTaskType.HandleId, ConfigSolarSchoolTaskByTaskType.LogPair);
			return list;
		}

		// Token: 0x0400473D RID: 18237
		private const string DB = "db_solarschool.db";

		// Token: 0x0400473E RID: 18238
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x0400473F RID: 18239
		private const string TABLE = "SolarSchoolTask";

		// Token: 0x04004740 RID: 18240
		private const string COMMAND = "select BinData from `SolarSchoolTask` where TaskType=?";

		// Token: 0x04004741 RID: 18241
		private const string KEY_PREFIX = "SolarSchoolTaskByTaskType";

		// Token: 0x04004742 RID: 18242
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004743 RID: 18243
		private static int HandleId;
	}
}
