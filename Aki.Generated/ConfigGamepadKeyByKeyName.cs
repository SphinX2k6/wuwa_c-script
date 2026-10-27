using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037B RID: 891
	public class ConfigGamepadKeyByKeyName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014E8 RID: 5352 RVA: 0x000CFD40 File Offset: 0x000CDF40
		static ConfigGamepadKeyByKeyName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamepadKeyByKeyName.CreateStaticDefaultValue), new Action(ConfigGamepadKeyByKeyName.ResetStaticDefaultValue));
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x000CFD60 File Offset: 0x000CDF60
		public static void CreateStaticDefaultValue()
		{
			ConfigGamepadKeyByKeyName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGamepadKeyByKeyName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_key.db"),
				new ValueTuple<string, object>("文件", "a.按键.xlsx"),
				new ValueTuple<string, object>("表名", "GamepadKey"),
				new ValueTuple<string, object>("语句", "select BinData from `GamepadKey` where KeyName=?")
			});
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000CFDDF File Offset: 0x000CDFDF
		public static void ResetStaticDefaultValue()
		{
			ConfigGamepadKeyByKeyName.LogPair = null;
			ConfigGamepadKeyByKeyName.HandleId = 0;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000CFDED File Offset: 0x000CDFED
		public static void Init()
		{
			ConfigGamepadKeyByKeyName.HandleId = ConfigCommon.InitDataStatement(ConfigGamepadKeyByKeyName.HandleId, "db_key.db", "select BinData from `GamepadKey` where KeyName=?");
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000CFE08 File Offset: 0x000CE008
		public static GamepadKey? GetConfig(string p0KeyName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGamepadKeyByKeyName.HandleId, ConfigGamepadKeyByKeyName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("GamepadKeyByKeyName#" + p0KeyName);
				if (configBuffer != null)
				{
					return new GamepadKey?(GamepadKey.GetRootAsGamepadKey(configBuffer));
				}
			}
			ConfigGamepadKeyByKeyName.LogPair.Clear();
			ConfigGamepadKeyByKeyName.LogPair.Add(new ValueTuple<string, object>("KeyName", p0KeyName));
			if (!ConfigCommon.BindString(ConfigGamepadKeyByKeyName.HandleId, 1, p0KeyName, ConfigGamepadKeyByKeyName.LogPair) || ConfigCommon.Step(ConfigGamepadKeyByKeyName.HandleId, true, ConfigGamepadKeyByKeyName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGamepadKeyByKeyName.HandleId, ConfigGamepadKeyByKeyName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGamepadKeyByKeyName.HandleId, 0, ConfigGamepadKeyByKeyName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGamepadKeyByKeyName.HandleId, ConfigGamepadKeyByKeyName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GamepadKey rootAsGamepadKey = GamepadKey.GetRootAsGamepadKey(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("GamepadKeyByKeyName#" + p0KeyName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGamepadKeyByKeyName.HandleId, ConfigGamepadKeyByKeyName.LogPair);
			return new GamepadKey?(rootAsGamepadKey);
		}

		// Token: 0x04001841 RID: 6209
		private const string DB = "db_key.db";

		// Token: 0x04001842 RID: 6210
		private const string FILE = "a.按键.xlsx";

		// Token: 0x04001843 RID: 6211
		private const string TABLE = "GamepadKey";

		// Token: 0x04001844 RID: 6212
		private const string COMMAND = "select BinData from `GamepadKey` where KeyName=?";

		// Token: 0x04001845 RID: 6213
		private const string KEY_PREFIX = "GamepadKeyByKeyName";

		// Token: 0x04001846 RID: 6214
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001847 RID: 6215
		private static int HandleId;
	}
}
