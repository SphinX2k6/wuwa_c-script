using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C1 RID: 961
	public class ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x000DC88C File Offset: 0x000DAA8C
		static ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.CreateStaticDefaultValue), new Action(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.ResetStaticDefaultValue));
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x000DC8AC File Offset: 0x000DAAAC
		public static void CreateStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gongduolapassengervoiceconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*"),
				new ValueTuple<string, object>("表名", "GongduolaPassengerVoiceConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=?")
			});
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000DC92B File Offset: 0x000DAB2B
		public static void ResetStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair = null;
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId = 0;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000DC939 File Offset: 0x000DAB39
		public static void Init()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId = ConfigCommon.InitDataStatement(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, "db_gongduolapassengervoiceconfig.db", "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=?");
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000DC954 File Offset: 0x000DAB54
		[NullableContext(2)]
		public static IReadOnlyList<GongduolaPassengerVoiceConfig> GetConfigList(int p0RoleId, int p1TriggerType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("GongduolaPassengerVoiceConfigByRoleIdAndTriggerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TriggerType);
				IReadOnlyList<GongduolaPassengerVoiceConfig> readOnlyList = (IReadOnlyList<GongduolaPassengerVoiceConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair.Clear();
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair.Add(new ValueTuple<string, object>("TriggerType", p1TriggerType));
			if (!ConfigCommon.BindInt(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, 1, p0RoleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair) || !ConfigCommon.BindInt(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, 2, p1TriggerType, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair))
			{
				ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair);
				return null;
			}
			List<GongduolaPassengerVoiceConfig> list = new List<GongduolaPassengerVoiceConfig>();
			while (ConfigCommon.Step(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, false, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, 0, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair);
					return null;
				}
				GongduolaPassengerVoiceConfig rootAsGongduolaPassengerVoiceConfig = GongduolaPassengerVoiceConfig.GetRootAsGongduolaPassengerVoiceConfig(new ByteBuffer(item2));
				list.Add(rootAsGongduolaPassengerVoiceConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("GongduolaPassengerVoiceConfigByRoleIdAndTriggerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TriggerType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair);
			return list;
		}

		// Token: 0x04001A2B RID: 6699
		private const string DB = "db_gongduolapassengervoiceconfig.db";

		// Token: 0x04001A2C RID: 6700
		private const string FILE = "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*";

		// Token: 0x04001A2D RID: 6701
		private const string TABLE = "GongduolaPassengerVoiceConfig";

		// Token: 0x04001A2E RID: 6702
		private const string COMMAND = "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=?";

		// Token: 0x04001A2F RID: 6703
		private const string KEY_PREFIX = "GongduolaPassengerVoiceConfigByRoleIdAndTriggerType";

		// Token: 0x04001A30 RID: 6704
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A31 RID: 6705
		private static int HandleId;
	}
}
