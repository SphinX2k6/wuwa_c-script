using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAE RID: 2734
	public class ConfigTetrisSettingByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004028 RID: 16424 RVA: 0x001C7A27 File Offset: 0x001C5C27
		static ConfigTetrisSettingByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisSettingByKey.CreateStaticDefaultValue), new Action(ConfigTetrisSettingByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x001C7A48 File Offset: 0x001C5C48
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisSettingByKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisSettingByKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "TetrisSetting"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisSetting` where Key=?")
			});
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x001C7AC7 File Offset: 0x001C5CC7
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisSettingByKey.LogPair = null;
			ConfigTetrisSettingByKey.HandleId = 0;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x001C7AD5 File Offset: 0x001C5CD5
		public static void Init()
		{
			ConfigTetrisSettingByKey.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisSettingByKey.HandleId, "db_tetris.db", "select BinData from `TetrisSetting` where Key=?");
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x001C7AF0 File Offset: 0x001C5CF0
		public static TetrisSetting? GetConfig(string p0Key, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisSettingByKey.HandleId, ConfigTetrisSettingByKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("TetrisSettingByKey#" + p0Key);
				if (configBuffer != null)
				{
					return new TetrisSetting?(TetrisSetting.GetRootAsTetrisSetting(configBuffer));
				}
			}
			ConfigTetrisSettingByKey.LogPair.Clear();
			ConfigTetrisSettingByKey.LogPair.Add(new ValueTuple<string, object>("Key", p0Key));
			if (!ConfigCommon.BindString(ConfigTetrisSettingByKey.HandleId, 1, p0Key, ConfigTetrisSettingByKey.LogPair) || ConfigCommon.Step(ConfigTetrisSettingByKey.HandleId, true, ConfigTetrisSettingByKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisSettingByKey.HandleId, ConfigTetrisSettingByKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisSettingByKey.HandleId, 0, ConfigTetrisSettingByKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisSettingByKey.HandleId, ConfigTetrisSettingByKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisSetting rootAsTetrisSetting = TetrisSetting.GetRootAsTetrisSetting(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("TetrisSettingByKey#" + p0Key, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisSettingByKey.HandleId, ConfigTetrisSettingByKey.LogPair);
			return new TetrisSetting?(rootAsTetrisSetting);
		}

		// Token: 0x04004AA8 RID: 19112
		private const string DB = "db_tetris.db";

		// Token: 0x04004AA9 RID: 19113
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004AAA RID: 19114
		private const string TABLE = "TetrisSetting";

		// Token: 0x04004AAB RID: 19115
		private const string COMMAND = "select BinData from `TetrisSetting` where Key=?";

		// Token: 0x04004AAC RID: 19116
		private const string KEY_PREFIX = "TetrisSettingByKey";

		// Token: 0x04004AAD RID: 19117
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AAE RID: 19118
		private static int HandleId;
	}
}
