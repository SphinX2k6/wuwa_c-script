using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000506 RID: 1286
	public class ConfigMainRoleConfigByGender : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E2F RID: 7727 RVA: 0x00103C77 File Offset: 0x00101E77
		static ConfigMainRoleConfigByGender()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainRoleConfigByGender.CreateStaticDefaultValue), new Action(ConfigMainRoleConfigByGender.ResetStaticDefaultValue));
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00103C98 File Offset: 0x00101E98
		public static void CreateStaticDefaultValue()
		{
			ConfigMainRoleConfigByGender.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainRoleConfigByGender.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_main_role_change.db"),
				new ValueTuple<string, object>("文件", "z.主角切换.xlsx"),
				new ValueTuple<string, object>("表名", "MainRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MainRoleConfig` where Gender = ?")
			});
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00103D17 File Offset: 0x00101F17
		public static void ResetStaticDefaultValue()
		{
			ConfigMainRoleConfigByGender.LogPair = null;
			ConfigMainRoleConfigByGender.HandleId = 0;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00103D25 File Offset: 0x00101F25
		public static void Init()
		{
			ConfigMainRoleConfigByGender.HandleId = ConfigCommon.InitDataStatement(ConfigMainRoleConfigByGender.HandleId, "db_main_role_change.db", "select BinData from `MainRoleConfig` where Gender = ?");
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00103D40 File Offset: 0x00101F40
		[NullableContext(2)]
		public static IReadOnlyList<MainRoleConfig> GetConfigList(int p0Gender, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainRoleConfigByGender.HandleId, ConfigMainRoleConfigByGender.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainRoleConfigByGender");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Gender);
				IReadOnlyList<MainRoleConfig> readOnlyList = (IReadOnlyList<MainRoleConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMainRoleConfigByGender.LogPair.Clear();
			ConfigMainRoleConfigByGender.LogPair.Add(new ValueTuple<string, object>("Gender", p0Gender));
			if (!ConfigCommon.BindInt(ConfigMainRoleConfigByGender.HandleId, 1, p0Gender, ConfigMainRoleConfigByGender.LogPair))
			{
				ConfigCommon.Reset(ConfigMainRoleConfigByGender.HandleId, ConfigMainRoleConfigByGender.LogPair);
				return null;
			}
			List<MainRoleConfig> list = new List<MainRoleConfig>();
			while (ConfigCommon.Step(ConfigMainRoleConfigByGender.HandleId, false, ConfigMainRoleConfigByGender.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainRoleConfigByGender.HandleId, 0, ConfigMainRoleConfigByGender.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMainRoleConfigByGender.HandleId, ConfigMainRoleConfigByGender.LogPair);
					return null;
				}
				MainRoleConfig rootAsMainRoleConfig = MainRoleConfig.GetRootAsMainRoleConfig(new ByteBuffer(item2));
				list.Add(rootAsMainRoleConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainRoleConfigByGender");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Gender);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMainRoleConfigByGender.HandleId, ConfigMainRoleConfigByGender.LogPair);
			return list;
		}

		// Token: 0x0400230E RID: 8974
		private const string DB = "db_main_role_change.db";

		// Token: 0x0400230F RID: 8975
		private const string FILE = "z.主角切换.xlsx";

		// Token: 0x04002310 RID: 8976
		private const string TABLE = "MainRoleConfig";

		// Token: 0x04002311 RID: 8977
		private const string COMMAND = "select BinData from `MainRoleConfig` where Gender = ?";

		// Token: 0x04002312 RID: 8978
		private const string KEY_PREFIX = "MainRoleConfigByGender";

		// Token: 0x04002313 RID: 8979
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002314 RID: 8980
		private static int HandleId;
	}
}
