using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000855 RID: 2133
	public class ConfigRogueResCollectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003210 RID: 12816 RVA: 0x00177EF8 File Offset: 0x001760F8
		static ConfigRogueResCollectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionAll.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x00177F18 File Offset: 0x00176118
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

		// Token: 0x06003212 RID: 12818 RVA: 0x00177F97 File Offset: 0x00176197
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionAll.LogPair = null;
			ConfigRogueResCollectionAll.HandleId = 0;
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00177FA5 File Offset: 0x001761A5
		public static void Init()
		{
			ConfigRogueResCollectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection`");
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x00177FC0 File Offset: 0x001761C0
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

		// Token: 0x04003A39 RID: 14905
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A3A RID: 14906
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A3B RID: 14907
		private const string TABLE = "RogueResCollection";

		// Token: 0x04003A3C RID: 14908
		private const string COMMAND = "select BinData from `RogueResCollection`";

		// Token: 0x04003A3D RID: 14909
		private const string KEY_PREFIX = "RogueResCollectionAll";

		// Token: 0x04003A3E RID: 14910
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A3F RID: 14911
		private static int HandleId;
	}
}
