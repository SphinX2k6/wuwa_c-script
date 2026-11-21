using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080E RID: 2062
	public class ConfigRhythmShipActionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003066 RID: 12390 RVA: 0x0016E52C File Offset: 0x0016C72C
		static ConfigRhythmShipActionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipActionAll.CreateStaticDefaultValue), new Action(ConfigRhythmShipActionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0016E54C File Offset: 0x0016C74C
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipActionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipActionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipAction"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipAction`")
			});
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0016E5CB File Offset: 0x0016C7CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipActionAll.LogPair = null;
			ConfigRhythmShipActionAll.HandleId = 0;
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x0016E5D9 File Offset: 0x0016C7D9
		public static void Init()
		{
			ConfigRhythmShipActionAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipActionAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipAction`");
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x0016E5F4 File Offset: 0x0016C7F4
		[NullableContext(2)]
		public static IReadOnlyList<RhythmShipAction> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipActionAll.HandleId, ConfigRhythmShipActionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RhythmShipAction> readOnlyList = (IReadOnlyList<RhythmShipAction>)ConfigCommon.GetConfig("RhythmShipActionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RhythmShipAction> list = new List<RhythmShipAction>();
			while (ConfigCommon.Step(ConfigRhythmShipActionAll.HandleId, false, ConfigRhythmShipActionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipActionAll.HandleId, 0, ConfigRhythmShipActionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmShipActionAll.HandleId, ConfigRhythmShipActionAll.LogPair);
					return null;
				}
				RhythmShipAction rootAsRhythmShipAction = RhythmShipAction.GetRootAsRhythmShipAction(new ByteBuffer(item2));
				list.Add(rootAsRhythmShipAction);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RhythmShipActionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmShipActionAll.HandleId, ConfigRhythmShipActionAll.LogPair);
			return list;
		}

		// Token: 0x04003848 RID: 14408
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003849 RID: 14409
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400384A RID: 14410
		private const string TABLE = "RhythmShipAction";

		// Token: 0x0400384B RID: 14411
		private const string COMMAND = "select BinData from `RhythmShipAction`";

		// Token: 0x0400384C RID: 14412
		private const string KEY_PREFIX = "RhythmShipActionAll";

		// Token: 0x0400384D RID: 14413
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400384E RID: 14414
		private static int HandleId;
	}
}
