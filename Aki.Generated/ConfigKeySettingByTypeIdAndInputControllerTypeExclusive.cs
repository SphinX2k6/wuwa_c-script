using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000484 RID: 1156
	public class ConfigKeySettingByTypeIdAndInputControllerTypeExclusive : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x000F64D7 File Offset: 0x000F46D7
		static ConfigKeySettingByTypeIdAndInputControllerTypeExclusive()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.CreateStaticDefaultValue), new Action(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.ResetStaticDefaultValue));
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000F64F8 File Offset: 0x000F46F8
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

		// Token: 0x06001B24 RID: 6948 RVA: 0x000F6577 File Offset: 0x000F4777
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.LogPair = null;
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId = 0;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000F6585 File Offset: 0x000F4785
		public static void Init()
		{
			ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.HandleId, "db_menu.db", "select BinData from `KeySetting` where TypeId=? AND InputControllerType=? AND ExclusiveType = ?");
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x000F65A0 File Offset: 0x000F47A0
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

		// Token: 0x04001F80 RID: 8064
		private const string DB = "db_menu.db";

		// Token: 0x04001F81 RID: 8065
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F82 RID: 8066
		private const string TABLE = "KeySetting";

		// Token: 0x04001F83 RID: 8067
		private const string COMMAND = "select BinData from `KeySetting` where TypeId=? AND InputControllerType=? AND ExclusiveType = ?";

		// Token: 0x04001F84 RID: 8068
		private const string KEY_PREFIX = "KeySettingByTypeIdAndInputControllerTypeExclusive";

		// Token: 0x04001F85 RID: 8069
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F86 RID: 8070
		private static int HandleId;
	}
}
