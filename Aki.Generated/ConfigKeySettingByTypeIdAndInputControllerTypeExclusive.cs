using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046E RID: 1134
	public class ConfigKeySettingByTypeIdAndInputControllerTypeExclusive : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x000EFD83 File Offset: 0x000EDF83
		static ConfigKeySettingByTypeIdAndInputControllerTypeExclusive()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.CreateStaticDefaultValue), new Action(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.ResetStaticDefaultValue));
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000EFDA4 File Offset: 0x000EDFA4
		public static void CreateStaticDefaultValue()
		{
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeySetting"),
				new ValueTuple<string, object>("语句", "select BinData from `KeySetting` where TypeId=? AND InputControllerType=? AND ExclusiveType = ?")
			});
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000EFE23 File Offset: 0x000EE023
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair = null;
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId = 0;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000EFE31 File Offset: 0x000EE031
		public static void Init()
		{
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, "db_menu.db", "select BinData from `KeySetting` where TypeId=? AND InputControllerType=? AND ExclusiveType = ?");
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000EFE4C File Offset: 0x000EE04C
		[NullableContext(2)]
		public static IReadOnlyList<KeySetting> GetConfigList(int p0TypeId, int p1InputControllerType, int p2ExclusiveType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingByTypeIdAndInputControllerTypeExclusive");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InputControllerType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2ExclusiveType);
				IReadOnlyList<KeySetting> readOnlyList = (IReadOnlyList<KeySetting>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair.Clear();
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair.Add(new ValueTuple<string, object>("InputControllerType", p1InputControllerType));
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair.Add(new ValueTuple<string, object>("ExclusiveType", p2ExclusiveType));
			if (!ConfigCommon.BindInt(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, 1, p0TypeId, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair) || !ConfigCommon.BindInt(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, 2, p1InputControllerType, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair) || !ConfigCommon.BindInt(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, 3, p2ExclusiveType, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair))
			{
				ConfigCommon.Reset(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair);
				return null;
			}
			List<KeySetting> list = new List<KeySetting>();
			while (ConfigCommon.Step(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, false, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, 0, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair);
					return null;
				}
				KeySetting rootAsKeySetting = KeySetting.GetRootAsKeySetting(new ByteBuffer(item2));
				list.Add(rootAsKeySetting);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingByTypeIdAndInputControllerTypeExclusive");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InputControllerType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2ExclusiveType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair);
			return list;
		}

		// Token: 0x04001EE6 RID: 7910
		private const string DB = "db_menu.db";

		// Token: 0x04001EE7 RID: 7911
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001EE8 RID: 7912
		private const string TABLE = "KeySetting";

		// Token: 0x04001EE9 RID: 7913
		private const string COMMAND = "select BinData from `KeySetting` where TypeId=? AND InputControllerType=? AND ExclusiveType = ?";

		// Token: 0x04001EEA RID: 7914
		private const string KEY_PREFIX = "KeySettingByTypeIdAndInputControllerTypeExclusive";

		// Token: 0x04001EEB RID: 7915
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EEC RID: 7916
		private static int HandleId;
	}
}
