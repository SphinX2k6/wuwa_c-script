using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000873 RID: 2163
	public class ConfigRogueResSynergyTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032C4 RID: 12996 RVA: 0x0017C048 File Offset: 0x0017A248
		static ConfigRogueResSynergyTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSynergyTypeAll.CreateStaticDefaultValue), new Action(ConfigRogueResSynergyTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x0017C068 File Offset: 0x0017A268
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResSynergyTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResSynergyTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResSynergyType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResSynergyType`")
			});
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x0017C0E7 File Offset: 0x0017A2E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSynergyTypeAll.LogPair = null;
			ConfigRogueResSynergyTypeAll.HandleId = 0;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x0017C0F5 File Offset: 0x0017A2F5
		public static void Init()
		{
			ConfigRogueResSynergyTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSynergyTypeAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSynergyType`");
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x0017C110 File Offset: 0x0017A310
		[NullableContext(2)]
		public static IReadOnlyList<RogueResSynergyType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResSynergyTypeAll.HandleId, ConfigRogueResSynergyTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResSynergyType> readOnlyList = (IReadOnlyList<RogueResSynergyType>)ConfigCommon.GetConfig("RogueResSynergyTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResSynergyType> list = new List<RogueResSynergyType>();
			while (ConfigCommon.Step(ConfigRogueResSynergyTypeAll.HandleId, false, ConfigRogueResSynergyTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResSynergyTypeAll.HandleId, 0, ConfigRogueResSynergyTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResSynergyTypeAll.HandleId, ConfigRogueResSynergyTypeAll.LogPair);
					return null;
				}
				RogueResSynergyType rootAsRogueResSynergyType = RogueResSynergyType.GetRootAsRogueResSynergyType(new ByteBuffer(item2));
				list.Add(rootAsRogueResSynergyType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResSynergyTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResSynergyTypeAll.HandleId, ConfigRogueResSynergyTypeAll.LogPair);
			return list;
		}

		// Token: 0x04003B0B RID: 15115
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B0C RID: 15116
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B0D RID: 15117
		private const string TABLE = "RogueResSynergyType";

		// Token: 0x04003B0E RID: 15118
		private const string COMMAND = "select BinData from `RogueResSynergyType`";

		// Token: 0x04003B0F RID: 15119
		private const string KEY_PREFIX = "RogueResSynergyTypeAll";

		// Token: 0x04003B10 RID: 15120
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B11 RID: 15121
		private static int HandleId;
	}
}
