using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046C RID: 1132
	public class ConfigKeySettingByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A92 RID: 6802 RVA: 0x000EF8BC File Offset: 0x000EDABC
		static ConfigKeySettingByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingByTypeId.CreateStaticDefaultValue), new Action(ConfigKeySettingByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000EF8DC File Offset: 0x000EDADC
		public static void CreateStaticDefaultValue()
		{
			ConfigKeySettingByTypeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeySettingByTypeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeySetting"),
				new ValueTuple<string, object>("语句", "select BinData from `KeySetting` where TypeId=?")
			});
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000EF95B File Offset: 0x000EDB5B
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingByTypeId.LogPair = null;
			ConfigKeySettingByTypeId.HandleId = 0;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000EF969 File Offset: 0x000EDB69
		public static void Init()
		{
			ConfigKeySettingByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingByTypeId.HandleId, "db_menu.db", "select BinData from `KeySetting` where TypeId=?");
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000EF984 File Offset: 0x000EDB84
		[NullableContext(2)]
		public static IReadOnlyList<KeySetting> GetConfigList(int p0TypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeySettingByTypeId.HandleId, ConfigKeySettingByTypeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				IReadOnlyList<KeySetting> readOnlyList = (IReadOnlyList<KeySetting>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKeySettingByTypeId.LogPair.Clear();
			ConfigKeySettingByTypeId.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			if (!ConfigCommon.BindInt(ConfigKeySettingByTypeId.HandleId, 1, p0TypeId, ConfigKeySettingByTypeId.LogPair))
			{
				ConfigCommon.Reset(ConfigKeySettingByTypeId.HandleId, ConfigKeySettingByTypeId.LogPair);
				return null;
			}
			List<KeySetting> list = new List<KeySetting>();
			while (ConfigCommon.Step(ConfigKeySettingByTypeId.HandleId, false, ConfigKeySettingByTypeId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeySettingByTypeId.HandleId, 0, ConfigKeySettingByTypeId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKeySettingByTypeId.HandleId, ConfigKeySettingByTypeId.LogPair);
					return null;
				}
				KeySetting rootAsKeySetting = KeySetting.GetRootAsKeySetting(new ByteBuffer(item2));
				list.Add(rootAsKeySetting);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKeySettingByTypeId.HandleId, ConfigKeySettingByTypeId.LogPair);
			return list;
		}

		// Token: 0x04001ED8 RID: 7896
		private const string DB = "db_menu.db";

		// Token: 0x04001ED9 RID: 7897
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001EDA RID: 7898
		private const string TABLE = "KeySetting";

		// Token: 0x04001EDB RID: 7899
		private const string COMMAND = "select BinData from `KeySetting` where TypeId=?";

		// Token: 0x04001EDC RID: 7900
		private const string KEY_PREFIX = "KeySettingByTypeId";

		// Token: 0x04001EDD RID: 7901
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EDE RID: 7902
		private static int HandleId;
	}
}
