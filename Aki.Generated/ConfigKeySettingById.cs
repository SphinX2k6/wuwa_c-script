using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000481 RID: 1153
	public class ConfigKeySettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x000F5DC7 File Offset: 0x000F3FC7
		static ConfigKeySettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingById.CreateStaticDefaultValue), new Action(ConfigKeySettingById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000F5DE8 File Offset: 0x000F3FE8
		public static void CreateStaticDefaultValue()
		{
			ConfigKeySettingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeySettingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeySetting"),
				new ValueTuple<string, object>("语句", "select BinData from `KeySetting` where Id=?")
			});
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000F5E67 File Offset: 0x000F4067
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingById.LogPair = null;
			ConfigKeySettingById.HandleId = 0;
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000F5E75 File Offset: 0x000F4075
		public static void Init()
		{
			ConfigKeySettingById.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingById.HandleId, "db_menu.db", "select BinData from `KeySetting` where Id=?");
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000F5E90 File Offset: 0x000F4090
		public static KeySetting? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeySettingById.HandleId, ConfigKeySettingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KeySetting?(KeySetting.GetRootAsKeySetting(configBuffer));
				}
			}
			ConfigKeySettingById.LogPair.Clear();
			ConfigKeySettingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKeySettingById.HandleId, 1, p0Id, ConfigKeySettingById.LogPair) || ConfigCommon.Step(ConfigKeySettingById.HandleId, true, ConfigKeySettingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKeySettingById.HandleId, ConfigKeySettingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeySettingById.HandleId, 0, ConfigKeySettingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKeySettingById.HandleId, ConfigKeySettingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KeySetting rootAsKeySetting = KeySetting.GetRootAsKeySetting(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KeySettingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKeySettingById.HandleId, ConfigKeySettingById.LogPair);
			return new KeySetting?(rootAsKeySetting);
		}

		// Token: 0x04001F6B RID: 8043
		private const string DB = "db_menu.db";

		// Token: 0x04001F6C RID: 8044
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F6D RID: 8045
		private const string TABLE = "KeySetting";

		// Token: 0x04001F6E RID: 8046
		private const string COMMAND = "select BinData from `KeySetting` where Id=?";

		// Token: 0x04001F6F RID: 8047
		private const string KEY_PREFIX = "KeySettingById";

		// Token: 0x04001F70 RID: 8048
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F71 RID: 8049
		private static int HandleId;
	}
}
