using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000483 RID: 1155
	public class ConfigKeySettingByTypeIdAndInputControllerType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B1C RID: 6940 RVA: 0x000F6247 File Offset: 0x000F4447
		static ConfigKeySettingByTypeIdAndInputControllerType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingByTypeIdAndInputControllerType.CreateStaticDefaultValue), new Action(ConfigKeySettingByTypeIdAndInputControllerType.ResetStaticDefaultValue));
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000F6268 File Offset: 0x000F4468
		public static void CreateStaticDefaultValue()
		{
			ConfigKeySettingByTypeIdAndInputControllerType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeySettingByTypeIdAndInputControllerType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeySetting"),
				new ValueTuple<string, object>("语句", "select BinData from `KeySetting` where TypeId=? AND InputControllerType=?")
			});
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000F62E7 File Offset: 0x000F44E7
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingByTypeIdAndInputControllerType.LogPair = null;
			ConfigKeySettingByTypeIdAndInputControllerType.HandleId = 0;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000F62F5 File Offset: 0x000F44F5
		public static void Init()
		{
			ConfigKeySettingByTypeIdAndInputControllerType.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, "db_menu.db", "select BinData from `KeySetting` where TypeId=? AND InputControllerType=?");
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000F6310 File Offset: 0x000F4510
		[NullableContext(2)]
		public static IReadOnlyList<KeySetting> GetConfigList(int p0TypeId, int p1InputControllerType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, ConfigKeySettingByTypeIdAndInputControllerType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingByTypeIdAndInputControllerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InputControllerType);
				IReadOnlyList<KeySetting> readOnlyList = (IReadOnlyList<KeySetting>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKeySettingByTypeIdAndInputControllerType.LogPair.Clear();
			ConfigKeySettingByTypeIdAndInputControllerType.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			ConfigKeySettingByTypeIdAndInputControllerType.LogPair.Add(new ValueTuple<string, object>("InputControllerType", p1InputControllerType));
			if (!ConfigCommon.BindInt(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, 1, p0TypeId, ConfigKeySettingByTypeIdAndInputControllerType.LogPair) || !ConfigCommon.BindInt(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, 2, p1InputControllerType, ConfigKeySettingByTypeIdAndInputControllerType.LogPair))
			{
				ConfigCommon.Reset(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, ConfigKeySettingByTypeIdAndInputControllerType.LogPair);
				return null;
			}
			List<KeySetting> list = new List<KeySetting>();
			while (ConfigCommon.Step(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, false, ConfigKeySettingByTypeIdAndInputControllerType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, 0, ConfigKeySettingByTypeIdAndInputControllerType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, ConfigKeySettingByTypeIdAndInputControllerType.LogPair);
					return null;
				}
				KeySetting rootAsKeySetting = KeySetting.GetRootAsKeySetting(new ByteBuffer(item2));
				list.Add(rootAsKeySetting);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingByTypeIdAndInputControllerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InputControllerType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKeySettingByTypeIdAndInputControllerType.HandleId, ConfigKeySettingByTypeIdAndInputControllerType.LogPair);
			return list;
		}

		// Token: 0x04001F79 RID: 8057
		private const string DB = "db_menu.db";

		// Token: 0x04001F7A RID: 8058
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F7B RID: 8059
		private const string TABLE = "KeySetting";

		// Token: 0x04001F7C RID: 8060
		private const string COMMAND = "select BinData from `KeySetting` where TypeId=? AND InputControllerType=?";

		// Token: 0x04001F7D RID: 8061
		private const string KEY_PREFIX = "KeySettingByTypeIdAndInputControllerType";

		// Token: 0x04001F7E RID: 8062
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F7F RID: 8063
		private static int HandleId;
	}
}
