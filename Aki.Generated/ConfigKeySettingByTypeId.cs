using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000482 RID: 1154
	public class ConfigKeySettingByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B16 RID: 6934 RVA: 0x000F6010 File Offset: 0x000F4210
		static ConfigKeySettingByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingByTypeId.CreateStaticDefaultValue), new Action(ConfigKeySettingByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x000F6030 File Offset: 0x000F4230
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

		// Token: 0x06001B18 RID: 6936 RVA: 0x000F60AF File Offset: 0x000F42AF
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingByTypeId.LogPair = null;
			ConfigKeySettingByTypeId.HandleId = 0;
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x000F60BD File Offset: 0x000F42BD
		public static void Init()
		{
			ConfigKeySettingByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingByTypeId.HandleId, "db_menu.db", "select BinData from `KeySetting` where TypeId=?");
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000F60D8 File Offset: 0x000F42D8
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

		// Token: 0x04001F72 RID: 8050
		private const string DB = "db_menu.db";

		// Token: 0x04001F73 RID: 8051
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F74 RID: 8052
		private const string TABLE = "KeySetting";

		// Token: 0x04001F75 RID: 8053
		private const string COMMAND = "select BinData from `KeySetting` where TypeId=?";

		// Token: 0x04001F76 RID: 8054
		private const string KEY_PREFIX = "KeySettingByTypeId";

		// Token: 0x04001F77 RID: 8055
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F78 RID: 8056
		private static int HandleId;
	}
}
