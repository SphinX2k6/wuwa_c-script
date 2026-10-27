using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046B RID: 1131
	public class ConfigKeySettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A8C RID: 6796 RVA: 0x000EF673 File Offset: 0x000ED873
		static ConfigKeySettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeySettingById.CreateStaticDefaultValue), new Action(ConfigKeySettingById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000EF694 File Offset: 0x000ED894
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

		// Token: 0x06001A8E RID: 6798 RVA: 0x000EF713 File Offset: 0x000ED913
		public static void ResetStaticDefaultValue()
		{
			ConfigKeySettingById.LogPair = null;
			ConfigKeySettingById.HandleId = 0;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000EF721 File Offset: 0x000ED921
		public static void Init()
		{
			ConfigKeySettingById.HandleId = ConfigCommon.InitDataStatement(ConfigKeySettingById.HandleId, "db_menu.db", "select BinData from `KeySetting` where Id=?");
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000EF73C File Offset: 0x000ED93C
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

		// Token: 0x04001ED1 RID: 7889
		private const string DB = "db_menu.db";

		// Token: 0x04001ED2 RID: 7890
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001ED3 RID: 7891
		private const string TABLE = "KeySetting";

		// Token: 0x04001ED4 RID: 7892
		private const string COMMAND = "select BinData from `KeySetting` where Id=?";

		// Token: 0x04001ED5 RID: 7893
		private const string KEY_PREFIX = "KeySettingById";

		// Token: 0x04001ED6 RID: 7894
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ED7 RID: 7895
		private static int HandleId;
	}
}
