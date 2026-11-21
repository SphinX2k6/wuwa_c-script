using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044C RID: 1100
	public class ConfigInfrV2LevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x000EF22F File Offset: 0x000ED42F
		static ConfigInfrV2LevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2LevelAll.CreateStaticDefaultValue), new Action(ConfigInfrV2LevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x000EF250 File Offset: 0x000ED450
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2LevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2LevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2Level"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2Level`")
			});
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000EF2CF File Offset: 0x000ED4CF
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2LevelAll.LogPair = null;
			ConfigInfrV2LevelAll.HandleId = 0;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000EF2DD File Offset: 0x000ED4DD
		public static void Init()
		{
			ConfigInfrV2LevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2LevelAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2Level`");
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000EF2F8 File Offset: 0x000ED4F8
		[NullableContext(2)]
		public static IReadOnlyList<InfrV2Level> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2LevelAll.HandleId, ConfigInfrV2LevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrV2Level> readOnlyList = (IReadOnlyList<InfrV2Level>)ConfigCommon.GetConfig("InfrV2LevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrV2Level> list = new List<InfrV2Level>();
			while (ConfigCommon.Step(ConfigInfrV2LevelAll.HandleId, false, ConfigInfrV2LevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2LevelAll.HandleId, 0, ConfigInfrV2LevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrV2LevelAll.HandleId, ConfigInfrV2LevelAll.LogPair);
					return null;
				}
				InfrV2Level rootAsInfrV2Level = InfrV2Level.GetRootAsInfrV2Level(new ByteBuffer(item2));
				list.Add(rootAsInfrV2Level);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrV2LevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrV2LevelAll.HandleId, ConfigInfrV2LevelAll.LogPair);
			return list;
		}

		// Token: 0x04001DF8 RID: 7672
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001DF9 RID: 7673
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001DFA RID: 7674
		private const string TABLE = "InfrV2Level";

		// Token: 0x04001DFB RID: 7675
		private const string COMMAND = "select BinData from `InfrV2Level`";

		// Token: 0x04001DFC RID: 7676
		private const string KEY_PREFIX = "InfrV2LevelAll";

		// Token: 0x04001DFD RID: 7677
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DFE RID: 7678
		private static int HandleId;
	}
}
