using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051C RID: 1308
	public class ConfigMainRoleConfigByGender : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EB3 RID: 7859 RVA: 0x0010A3CB File Offset: 0x001085CB
		static ConfigMainRoleConfigByGender()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainRoleConfigByGender.CreateStaticDefaultValue), new Action(ConfigMainRoleConfigByGender.ResetStaticDefaultValue));
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0010A3EC File Offset: 0x001085EC
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

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0010A46B File Offset: 0x0010866B
		public static void ResetStaticDefaultValue()
		{
			ConfigMainRoleConfigByGender.LogPair = null;
			ConfigMainRoleConfigByGender.HandleId = 0;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0010A479 File Offset: 0x00108679
		public static void Init()
		{
			ConfigMainRoleConfigByGender.HandleId = ConfigCommon.InitDataStatement(ConfigMainRoleConfigByGender.HandleId, "db_main_role_change.db", "select BinData from `MainRoleConfig` where Gender = ?");
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0010A494 File Offset: 0x00108694
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

		// Token: 0x040023A8 RID: 9128
		private const string DB = "db_main_role_change.db";

		// Token: 0x040023A9 RID: 9129
		private const string FILE = "z.主角切换.xlsx";

		// Token: 0x040023AA RID: 9130
		private const string TABLE = "MainRoleConfig";

		// Token: 0x040023AB RID: 9131
		private const string COMMAND = "select BinData from `MainRoleConfig` where Gender = ?";

		// Token: 0x040023AC RID: 9132
		private const string KEY_PREFIX = "MainRoleConfigByGender";

		// Token: 0x040023AD RID: 9133
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023AE RID: 9134
		private static int HandleId;
	}
}
