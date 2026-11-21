using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000390 RID: 912
	public class ConfigGamepadKeyByKeyName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x000D624C File Offset: 0x000D444C
		static ConfigGamepadKeyByKeyName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGamepadKeyByKeyName.CreateStaticDefaultValue), new Action(ConfigGamepadKeyByKeyName.ResetStaticDefaultValue));
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000D626C File Offset: 0x000D446C
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

		// Token: 0x06001568 RID: 5480 RVA: 0x000D62EB File Offset: 0x000D44EB
		public static void ResetStaticDefaultValue()
		{
			ConfigGamepadKeyByKeyName.LogPair = null;
			ConfigGamepadKeyByKeyName.HandleId = 0;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000D62F9 File Offset: 0x000D44F9
		public static void Init()
		{
			ConfigGamepadKeyByKeyName.HandleId = ConfigCommon.InitDataStatement(ConfigGamepadKeyByKeyName.HandleId, "db_key.db", "select BinData from `GamepadKey` where KeyName=?");
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x000D6314 File Offset: 0x000D4514
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

		// Token: 0x040018D4 RID: 6356
		private const string DB = "db_key.db";

		// Token: 0x040018D5 RID: 6357
		private const string FILE = "a.按键.xlsx";

		// Token: 0x040018D6 RID: 6358
		private const string TABLE = "GamepadKey";

		// Token: 0x040018D7 RID: 6359
		private const string COMMAND = "select BinData from `GamepadKey` where KeyName=?";

		// Token: 0x040018D8 RID: 6360
		private const string KEY_PREFIX = "GamepadKeyByKeyName";

		// Token: 0x040018D9 RID: 6361
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018DA RID: 6362
		private static int HandleId;
	}
}
