using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000747 RID: 1863
	public class ConfigPlayStationActivityConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BBB RID: 11195 RVA: 0x00150BCC File Offset: 0x0014EDCC
		static ConfigPlayStationActivityConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayStationActivityConfigAll.CreateStaticDefaultValue), new Action(ConfigPlayStationActivityConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x00150BEC File Offset: 0x0014EDEC
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayStationActivityConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayStationActivityConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_quest.db"),
				new ValueTuple<string, object>("文件", "r.任务.xlsx"),
				new ValueTuple<string, object>("表名", "PlayStationActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayStationActivityConfig`")
			});
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x00150C6B File Offset: 0x0014EE6B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayStationActivityConfigAll.LogPair = null;
			ConfigPlayStationActivityConfigAll.HandleId = 0;
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x00150C79 File Offset: 0x0014EE79
		public static void Init()
		{
			ConfigPlayStationActivityConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayStationActivityConfigAll.HandleId, "db_quest.db", "select BinData from `PlayStationActivityConfig`");
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00150C94 File Offset: 0x0014EE94
		[NullableContext(2)]
		public static IReadOnlyList<PlayStationActivityConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayStationActivityConfigAll.HandleId, ConfigPlayStationActivityConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlayStationActivityConfig> readOnlyList = (IReadOnlyList<PlayStationActivityConfig>)ConfigCommon.GetConfig("PlayStationActivityConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlayStationActivityConfig> list = new List<PlayStationActivityConfig>();
			while (ConfigCommon.Step(ConfigPlayStationActivityConfigAll.HandleId, false, ConfigPlayStationActivityConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayStationActivityConfigAll.HandleId, 0, ConfigPlayStationActivityConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayStationActivityConfigAll.HandleId, ConfigPlayStationActivityConfigAll.LogPair);
					return null;
				}
				PlayStationActivityConfig rootAsPlayStationActivityConfig = PlayStationActivityConfig.GetRootAsPlayStationActivityConfig(new ByteBuffer(item2));
				list.Add(rootAsPlayStationActivityConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlayStationActivityConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayStationActivityConfigAll.HandleId, ConfigPlayStationActivityConfigAll.LogPair);
			return list;
		}

		// Token: 0x040032D7 RID: 13015
		private const string DB = "db_quest.db";

		// Token: 0x040032D8 RID: 13016
		private const string FILE = "r.任务.xlsx";

		// Token: 0x040032D9 RID: 13017
		private const string TABLE = "PlayStationActivityConfig";

		// Token: 0x040032DA RID: 13018
		private const string COMMAND = "select BinData from `PlayStationActivityConfig`";

		// Token: 0x040032DB RID: 13019
		private const string KEY_PREFIX = "PlayStationActivityConfigAll";

		// Token: 0x040032DC RID: 13020
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032DD RID: 13021
		private static int HandleId;
	}
}
