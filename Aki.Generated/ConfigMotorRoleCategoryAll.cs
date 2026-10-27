using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BF RID: 1471
	public class ConfigMotorRoleCategoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002287 RID: 8839 RVA: 0x0011CCC0 File Offset: 0x0011AEC0
		static ConfigMotorRoleCategoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorRoleCategoryAll.CreateStaticDefaultValue), new Action(ConfigMotorRoleCategoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x0011CCE0 File Offset: 0x0011AEE0
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

		// Token: 0x06002289 RID: 8841 RVA: 0x0011CD5F File Offset: 0x0011AF5F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorRoleCategoryAll.LogPair = null;
			ConfigMotorRoleCategoryAll.HandleId = 0;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x0011CD6D File Offset: 0x0011AF6D
		public static void Init()
		{
			ConfigMotorRoleCategoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorRoleCategoryAll.HandleId, "db_motorcommon.db", "select BinData from `MotorRoleCategory`");
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0011CD88 File Offset: 0x0011AF88
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

		// Token: 0x0400281D RID: 10269
		private const string DB = "db_motorcommon.db";

		// Token: 0x0400281E RID: 10270
		private const string FILE = "m.摩托车共乘.xlsx";

		// Token: 0x0400281F RID: 10271
		private const string TABLE = "MotorRoleCategory";

		// Token: 0x04002820 RID: 10272
		private const string COMMAND = "select BinData from `MotorRoleCategory`";

		// Token: 0x04002821 RID: 10273
		private const string KEY_PREFIX = "MotorRoleCategoryAll";

		// Token: 0x04002822 RID: 10274
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002823 RID: 10275
		private static int HandleId;
	}
}
