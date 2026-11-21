using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D6 RID: 1494
	public class ConfigMotorRoleCategoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002311 RID: 8977 RVA: 0x001235A8 File Offset: 0x001217A8
		static ConfigMotorRoleCategoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorRoleCategoryAll.CreateStaticDefaultValue), new Action(ConfigMotorRoleCategoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x001235C8 File Offset: 0x001217C8
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorRoleCategoryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorRoleCategoryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorcommon.db"),
				new ValueTuple<string, object>("文件", "m.摩托车共乘.xlsx"),
				new ValueTuple<string, object>("表名", "MotorRoleCategory"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorRoleCategory`")
			});
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00123647 File Offset: 0x00121847
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorRoleCategoryAll.LogPair = null;
			ConfigMotorRoleCategoryAll.HandleId = 0;
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00123655 File Offset: 0x00121855
		public static void Init()
		{
			ConfigMotorRoleCategoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorRoleCategoryAll.HandleId, "db_motorcommon.db", "select BinData from `MotorRoleCategory`");
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00123670 File Offset: 0x00121870
		[NullableContext(2)]
		public static IReadOnlyList<MotorRoleCategory> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorRoleCategoryAll.HandleId, ConfigMotorRoleCategoryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorRoleCategory> readOnlyList = (IReadOnlyList<MotorRoleCategory>)ConfigCommon.GetConfig("MotorRoleCategoryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorRoleCategory> list = new List<MotorRoleCategory>();
			while (ConfigCommon.Step(ConfigMotorRoleCategoryAll.HandleId, false, ConfigMotorRoleCategoryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorRoleCategoryAll.HandleId, 0, ConfigMotorRoleCategoryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorRoleCategoryAll.HandleId, ConfigMotorRoleCategoryAll.LogPair);
					return null;
				}
				MotorRoleCategory rootAsMotorRoleCategory = MotorRoleCategory.GetRootAsMotorRoleCategory(new ByteBuffer(item2));
				list.Add(rootAsMotorRoleCategory);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorRoleCategoryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorRoleCategoryAll.HandleId, ConfigMotorRoleCategoryAll.LogPair);
			return list;
		}

		// Token: 0x040028BE RID: 10430
		private const string DB = "db_motorcommon.db";

		// Token: 0x040028BF RID: 10431
		private const string FILE = "m.摩托车共乘.xlsx";

		// Token: 0x040028C0 RID: 10432
		private const string TABLE = "MotorRoleCategory";

		// Token: 0x040028C1 RID: 10433
		private const string COMMAND = "select BinData from `MotorRoleCategory`";

		// Token: 0x040028C2 RID: 10434
		private const string KEY_PREFIX = "MotorRoleCategoryAll";

		// Token: 0x040028C3 RID: 10435
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028C4 RID: 10436
		private static int HandleId;
	}
}
