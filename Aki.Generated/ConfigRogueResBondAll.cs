using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000831 RID: 2097
	public class ConfigRogueResBondAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003138 RID: 12600 RVA: 0x0016FB38 File Offset: 0x0016DD38
		static ConfigRogueResBondAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondAll.CreateStaticDefaultValue), new Action(ConfigRogueResBondAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0016FB58 File Offset: 0x0016DD58
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBond"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBond`")
			});
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x0016FBD7 File Offset: 0x0016DDD7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondAll.LogPair = null;
			ConfigRogueResBondAll.HandleId = 0;
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0016FBE5 File Offset: 0x0016DDE5
		public static void Init()
		{
			ConfigRogueResBondAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBond`");
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0016FC00 File Offset: 0x0016DE00
		[NullableContext(2)]
		public static IReadOnlyList<RogueResBond> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondAll.HandleId, ConfigRogueResBondAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResBond> readOnlyList = (IReadOnlyList<RogueResBond>)ConfigCommon.GetConfig("RogueResBondAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResBond> list = new List<RogueResBond>();
			while (ConfigCommon.Step(ConfigRogueResBondAll.HandleId, false, ConfigRogueResBondAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondAll.HandleId, 0, ConfigRogueResBondAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResBondAll.HandleId, ConfigRogueResBondAll.LogPair);
					return null;
				}
				RogueResBond rootAsRogueResBond = RogueResBond.GetRootAsRogueResBond(new ByteBuffer(item2));
				list.Add(rootAsRogueResBond);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResBondAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResBondAll.HandleId, ConfigRogueResBondAll.LogPair);
			return list;
		}

		// Token: 0x0400393D RID: 14653
		private const string DB = "db_permanentrogue.db";

		// Token: 0x0400393E RID: 14654
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x0400393F RID: 14655
		private const string TABLE = "RogueResBond";

		// Token: 0x04003940 RID: 14656
		private const string COMMAND = "select BinData from `RogueResBond`";

		// Token: 0x04003941 RID: 14657
		private const string KEY_PREFIX = "RogueResBondAll";

		// Token: 0x04003942 RID: 14658
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003943 RID: 14659
		private static int HandleId;
	}
}
