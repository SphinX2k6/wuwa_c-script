using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D9 RID: 2521
	public class ConfigTetrisSettingByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B2A RID: 15146 RVA: 0x001A8693 File Offset: 0x001A6893
		static ConfigTetrisSettingByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisSettingByKey.CreateStaticDefaultValue), new Action(ConfigTetrisSettingByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x001A86B4 File Offset: 0x001A68B4
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

		// Token: 0x06003B2C RID: 15148 RVA: 0x001A8733 File Offset: 0x001A6933
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisSettingByKey.LogPair = null;
			ConfigTetrisSettingByKey.HandleId = 0;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x001A8741 File Offset: 0x001A6941
		public static void Init()
		{
			ConfigTetrisSettingByKey.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisSettingByKey.HandleId, "db_tetris.db", "select BinData from `TetrisSetting` where Key=?");
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x001A875C File Offset: 0x001A695C
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

		// Token: 0x040044D5 RID: 17621
		private const string DB = "db_tetris.db";

		// Token: 0x040044D6 RID: 17622
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044D7 RID: 17623
		private const string TABLE = "TetrisSetting";

		// Token: 0x040044D8 RID: 17624
		private const string COMMAND = "select BinData from `TetrisSetting` where Key=?";

		// Token: 0x040044D9 RID: 17625
		private const string KEY_PREFIX = "TetrisSettingByKey";

		// Token: 0x040044DA RID: 17626
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044DB RID: 17627
		private static int HandleId;
	}
}
