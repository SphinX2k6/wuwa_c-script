using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075F RID: 1887
	public class ConfigPlayStationActivityConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C4B RID: 11339 RVA: 0x00157648 File Offset: 0x00155848
		static ConfigPlayStationActivityConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayStationActivityConfigAll.CreateStaticDefaultValue), new Action(ConfigPlayStationActivityConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00157668 File Offset: 0x00155868
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

		// Token: 0x06002C4D RID: 11341 RVA: 0x001576E7 File Offset: 0x001558E7
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayStationActivityConfigAll.LogPair = null;
			ConfigPlayStationActivityConfigAll.HandleId = 0;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x001576F5 File Offset: 0x001558F5
		public static void Init()
		{
			ConfigPlayStationActivityConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayStationActivityConfigAll.HandleId, "db_quest.db", "select BinData from `PlayStationActivityConfig`");
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00157710 File Offset: 0x00155910
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

		// Token: 0x0400337F RID: 13183
		private const string DB = "db_quest.db";

		// Token: 0x04003380 RID: 13184
		private const string FILE = "r.任务.xlsx";

		// Token: 0x04003381 RID: 13185
		private const string TABLE = "PlayStationActivityConfig";

		// Token: 0x04003382 RID: 13186
		private const string COMMAND = "select BinData from `PlayStationActivityConfig`";

		// Token: 0x04003383 RID: 13187
		private const string KEY_PREFIX = "PlayStationActivityConfigAll";

		// Token: 0x04003384 RID: 13188
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003385 RID: 13189
		private static int HandleId;
	}
}
