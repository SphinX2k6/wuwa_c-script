using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AC RID: 940
	public class ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600160F RID: 5647 RVA: 0x000D63C7 File Offset: 0x000D45C7
		static ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.CreateStaticDefaultValue), new Action(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.ResetStaticDefaultValue));
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000D63E8 File Offset: 0x000D45E8
		public static void CreateStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gongduolapassengervoiceconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*"),
				new ValueTuple<string, object>("表名", "GongduolaPassengerVoiceConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=? And VehicleType=?")
			});
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000D6467 File Offset: 0x000D4667
		public static void ResetStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair = null;
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId = 0;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000D6475 File Offset: 0x000D4675
		public static void Init()
		{
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId = ConfigCommon.InitDataStatement(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, "db_gongduolapassengervoiceconfig.db", "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=? And VehicleType=?");
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000D6490 File Offset: 0x000D4690
		[return: Nullable(2)]
		public static IReadOnlyList<GongduolaPassengerVoiceConfig> GetConfigList(int p0RoleId, int p1TriggerType, string p2VehicleType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("GongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TriggerType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2VehicleType);
				IReadOnlyList<GongduolaPassengerVoiceConfig> readOnlyList = (IReadOnlyList<GongduolaPassengerVoiceConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair.Clear();
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair.Add(new ValueTuple<string, object>("TriggerType", p1TriggerType));
			ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair.Add(new ValueTuple<string, object>("VehicleType", p2VehicleType));
			if (!ConfigCommon.BindInt(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, 1, p0RoleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair) || !ConfigCommon.BindInt(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, 2, p1TriggerType, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair) || !ConfigCommon.BindString(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, 3, p2VehicleType, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair))
			{
				ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair);
				return null;
			}
			List<GongduolaPassengerVoiceConfig> list = new List<GongduolaPassengerVoiceConfig>();
			while (ConfigCommon.Step(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, false, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, 0, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair);
					return null;
				}
				GongduolaPassengerVoiceConfig rootAsGongduolaPassengerVoiceConfig = GongduolaPassengerVoiceConfig.GetRootAsGongduolaPassengerVoiceConfig(new ByteBuffer(item2));
				list.Add(rootAsGongduolaPassengerVoiceConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("GongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TriggerType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2VehicleType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.HandleId, ConfigGongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType.LogPair);
			return list;
		}

		// Token: 0x04001998 RID: 6552
		private const string DB = "db_gongduolapassengervoiceconfig.db";

		// Token: 0x04001999 RID: 6553
		private const string FILE = "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*";

		// Token: 0x0400199A RID: 6554
		private const string TABLE = "GongduolaPassengerVoiceConfig";

		// Token: 0x0400199B RID: 6555
		private const string COMMAND = "select BinData from `GongduolaPassengerVoiceConfig` where RoleId=? And TriggerType=? And VehicleType=?";

		// Token: 0x0400199C RID: 6556
		private const string KEY_PREFIX = "GongduolaPassengerVoiceConfigByRoleIdAndVehicleTriggerType";

		// Token: 0x0400199D RID: 6557
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400199E RID: 6558
		private static int HandleId;
	}
}
