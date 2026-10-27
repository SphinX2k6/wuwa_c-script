using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000436 RID: 1078
	public class ConfigInfrV2LevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600194E RID: 6478 RVA: 0x000E8ADB File Offset: 0x000E6CDB
		static ConfigInfrV2LevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2LevelAll.CreateStaticDefaultValue), new Action(ConfigInfrV2LevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000E8AFC File Offset: 0x000E6CFC
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

		// Token: 0x06001950 RID: 6480 RVA: 0x000E8B7B File Offset: 0x000E6D7B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2LevelAll.LogPair = null;
			ConfigInfrV2LevelAll.HandleId = 0;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000E8B89 File Offset: 0x000E6D89
		public static void Init()
		{
			ConfigInfrV2LevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2LevelAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2Level`");
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000E8BA4 File Offset: 0x000E6DA4
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

		// Token: 0x04001D5E RID: 7518
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D5F RID: 7519
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D60 RID: 7520
		private const string TABLE = "InfrV2Level";

		// Token: 0x04001D61 RID: 7521
		private const string COMMAND = "select BinData from `InfrV2Level`";

		// Token: 0x04001D62 RID: 7522
		private const string KEY_PREFIX = "InfrV2LevelAll";

		// Token: 0x04001D63 RID: 7523
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D64 RID: 7524
		private static int HandleId;
	}
}
