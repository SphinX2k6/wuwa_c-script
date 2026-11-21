using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E6 RID: 230
	public class ConfigBabelTowerLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000565 RID: 1381 RVA: 0x0007BC68 File Offset: 0x00079E68
		static ConfigBabelTowerLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerLevelAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0007BC88 File Offset: 0x00079E88
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerLevel`")
			});
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0007BD07 File Offset: 0x00079F07
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerLevelAll.LogPair = null;
			ConfigBabelTowerLevelAll.HandleId = 0;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0007BD15 File Offset: 0x00079F15
		public static void Init()
		{
			ConfigBabelTowerLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerLevelAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerLevel`");
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0007BD30 File Offset: 0x00079F30
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerLevelAll.HandleId, ConfigBabelTowerLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerLevel> readOnlyList = (IReadOnlyList<BabelTowerLevel>)ConfigCommon.GetConfig("BabelTowerLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerLevel> list = new List<BabelTowerLevel>();
			while (ConfigCommon.Step(ConfigBabelTowerLevelAll.HandleId, false, ConfigBabelTowerLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerLevelAll.HandleId, 0, ConfigBabelTowerLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerLevelAll.HandleId, ConfigBabelTowerLevelAll.LogPair);
					return null;
				}
				BabelTowerLevel rootAsBabelTowerLevel = BabelTowerLevel.GetRootAsBabelTowerLevel(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerLevelAll.HandleId, ConfigBabelTowerLevelAll.LogPair);
			return list;
		}

		// Token: 0x0400062E RID: 1582
		private const string DB = "db_babeltower.db";

		// Token: 0x0400062F RID: 1583
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000630 RID: 1584
		private const string TABLE = "BabelTowerLevel";

		// Token: 0x04000631 RID: 1585
		private const string COMMAND = "select BinData from `BabelTowerLevel`";

		// Token: 0x04000632 RID: 1586
		private const string KEY_PREFIX = "BabelTowerLevelAll";

		// Token: 0x04000633 RID: 1587
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000634 RID: 1588
		private static int HandleId;
	}
}
