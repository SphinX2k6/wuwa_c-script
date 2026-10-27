using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000857 RID: 2135
	public class ConfigRogueResSynergyTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x00174D60 File Offset: 0x00172F60
		static ConfigRogueResSynergyTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSynergyTypeAll.CreateStaticDefaultValue), new Action(ConfigRogueResSynergyTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x00174D80 File Offset: 0x00172F80
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

		// Token: 0x0600321E RID: 12830 RVA: 0x00174DFF File Offset: 0x00172FFF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSynergyTypeAll.LogPair = null;
			ConfigRogueResSynergyTypeAll.HandleId = 0;
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00174E0D File Offset: 0x0017300D
		public static void Init()
		{
			ConfigRogueResSynergyTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSynergyTypeAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSynergyType`");
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00174E28 File Offset: 0x00173028
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

		// Token: 0x04003A47 RID: 14919
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A48 RID: 14920
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A49 RID: 14921
		private const string TABLE = "RogueResSynergyType";

		// Token: 0x04003A4A RID: 14922
		private const string COMMAND = "select BinData from `RogueResSynergyType`";

		// Token: 0x04003A4B RID: 14923
		private const string KEY_PREFIX = "RogueResSynergyTypeAll";

		// Token: 0x04003A4C RID: 14924
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A4D RID: 14925
		private static int HandleId;
	}
}
