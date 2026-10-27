using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AB RID: 939
	public class ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x000D6138 File Offset: 0x000D4338
		static ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.CreateStaticDefaultValue), new Action(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.ResetStaticDefaultValue));
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000D6158 File Offset: 0x000D4358
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

		// Token: 0x0600160B RID: 5643 RVA: 0x000D61D7 File Offset: 0x000D43D7
		public static void ResetStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.LogPair = null;
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId = 0;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000D61E5 File Offset: 0x000D43E5
		public static void Init()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId = ConfigCommon.InitDataStatement(ConfigGongduolaPassengerVoiceConfigByRoleIdAndTriggerType.HandleId, "db_gongduolapassengervoiceconfig.db", "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=?");
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x000D6200 File Offset: 0x000D4400
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

		// Token: 0x04001991 RID: 6545
		private const string DB = "db_gongduolapassengervoiceconfig.db";

		// Token: 0x04001992 RID: 6546
		private const string FILE = "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*";

		// Token: 0x04001993 RID: 6547
		private const string TABLE = "GongduolaPassengerVoiceConfig";

		// Token: 0x04001994 RID: 6548
		private const string COMMAND = "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=?";

		// Token: 0x04001995 RID: 6549
		private const string KEY_PREFIX = "GongduolaPassengerVoiceConfigByRoleIdAndTriggerType";

		// Token: 0x04001996 RID: 6550
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001997 RID: 6551
		private static int HandleId;
	}
}
