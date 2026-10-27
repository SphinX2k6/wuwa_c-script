using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000565 RID: 1381
	public class ConfigMoraleKeepLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600206B RID: 8299 RVA: 0x00110AE0 File Offset: 0x0010ECE0
		static ConfigMoraleKeepLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleKeepLevelAll.CreateStaticDefaultValue), new Action(ConfigMoraleKeepLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00110B00 File Offset: 0x0010ED00
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleKeepLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleKeepLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleKeepLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleKeepLevel`")
			});
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00110B7F File Offset: 0x0010ED7F
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleKeepLevelAll.LogPair = null;
			ConfigMoraleKeepLevelAll.HandleId = 0;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00110B8D File Offset: 0x0010ED8D
		public static void Init()
		{
			ConfigMoraleKeepLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleKeepLevelAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleKeepLevel`");
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00110BA8 File Offset: 0x0010EDA8
		[NullableContext(2)]
		public static IReadOnlyList<MoraleKeepLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleKeepLevelAll.HandleId, ConfigMoraleKeepLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MoraleKeepLevel> readOnlyList = (IReadOnlyList<MoraleKeepLevel>)ConfigCommon.GetConfig("MoraleKeepLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MoraleKeepLevel> list = new List<MoraleKeepLevel>();
			while (ConfigCommon.Step(ConfigMoraleKeepLevelAll.HandleId, false, ConfigMoraleKeepLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleKeepLevelAll.HandleId, 0, ConfigMoraleKeepLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMoraleKeepLevelAll.HandleId, ConfigMoraleKeepLevelAll.LogPair);
					return null;
				}
				MoraleKeepLevel rootAsMoraleKeepLevel = MoraleKeepLevel.GetRootAsMoraleKeepLevel(new ByteBuffer(item2));
				list.Add(rootAsMoraleKeepLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MoraleKeepLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMoraleKeepLevelAll.HandleId, ConfigMoraleKeepLevelAll.LogPair);
			return list;
		}

		// Token: 0x040025A7 RID: 9639
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025A8 RID: 9640
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025A9 RID: 9641
		private const string TABLE = "MoraleKeepLevel";

		// Token: 0x040025AA RID: 9642
		private const string COMMAND = "select BinData from `MoraleKeepLevel`";

		// Token: 0x040025AB RID: 9643
		private const string KEY_PREFIX = "MoraleKeepLevelAll";

		// Token: 0x040025AC RID: 9644
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025AD RID: 9645
		private static int HandleId;
	}
}
