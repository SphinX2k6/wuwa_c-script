using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000839 RID: 2105
	public class ConfigRogueResCollectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003168 RID: 12648 RVA: 0x00170C10 File Offset: 0x0016EE10
		static ConfigRogueResCollectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionAll.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x00170C30 File Offset: 0x0016EE30
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCollectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCollectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCollection`")
			});
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x00170CAF File Offset: 0x0016EEAF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionAll.LogPair = null;
			ConfigRogueResCollectionAll.HandleId = 0;
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x00170CBD File Offset: 0x0016EEBD
		public static void Init()
		{
			ConfigRogueResCollectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection`");
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00170CD8 File Offset: 0x0016EED8
		[NullableContext(2)]
		public static IReadOnlyList<RogueResCollection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCollectionAll.HandleId, ConfigRogueResCollectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResCollection> readOnlyList = (IReadOnlyList<RogueResCollection>)ConfigCommon.GetConfig("RogueResCollectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResCollection> list = new List<RogueResCollection>();
			while (ConfigCommon.Step(ConfigRogueResCollectionAll.HandleId, false, ConfigRogueResCollectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCollectionAll.HandleId, 0, ConfigRogueResCollectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResCollectionAll.HandleId, ConfigRogueResCollectionAll.LogPair);
					return null;
				}
				RogueResCollection rootAsRogueResCollection = RogueResCollection.GetRootAsRogueResCollection(new ByteBuffer(item2));
				list.Add(rootAsRogueResCollection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResCollectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResCollectionAll.HandleId, ConfigRogueResCollectionAll.LogPair);
			return list;
		}

		// Token: 0x04003975 RID: 14709
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003976 RID: 14710
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003977 RID: 14711
		private const string TABLE = "RogueResCollection";

		// Token: 0x04003978 RID: 14712
		private const string COMMAND = "select BinData from `RogueResCollection`";

		// Token: 0x04003979 RID: 14713
		private const string KEY_PREFIX = "RogueResCollectionAll";

		// Token: 0x0400397A RID: 14714
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400397B RID: 14715
		private static int HandleId;
	}
}
