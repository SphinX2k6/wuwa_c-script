using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000933 RID: 2355
	public class ConfigRoverRogueItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003745 RID: 14149 RVA: 0x00194F60 File Offset: 0x00193160
		static ConfigRoverRogueItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueItemAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00194F80 File Offset: 0x00193180
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueItem`")
			});
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00194FFF File Offset: 0x001931FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueItemAll.LogPair = null;
			ConfigRoverRogueItemAll.HandleId = 0;
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0019500D File Offset: 0x0019320D
		public static void Init()
		{
			ConfigRoverRogueItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueItemAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueItem`");
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00195028 File Offset: 0x00193228
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueItemAll.HandleId, ConfigRoverRogueItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueItem> readOnlyList = (IReadOnlyList<RoverRogueItem>)ConfigCommon.GetConfig("RoverRogueItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueItem> list = new List<RoverRogueItem>();
			while (ConfigCommon.Step(ConfigRoverRogueItemAll.HandleId, false, ConfigRoverRogueItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueItemAll.HandleId, 0, ConfigRoverRogueItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueItemAll.HandleId, ConfigRoverRogueItemAll.LogPair);
					return null;
				}
				RoverRogueItem rootAsRoverRogueItem = RoverRogueItem.GetRootAsRoverRogueItem(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueItemAll.HandleId, ConfigRoverRogueItemAll.LogPair);
			return list;
		}

		// Token: 0x0400404B RID: 16459
		private const string DB = "db_roverlike.db";

		// Token: 0x0400404C RID: 16460
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x0400404D RID: 16461
		private const string TABLE = "RoverRogueItem";

		// Token: 0x0400404E RID: 16462
		private const string COMMAND = "select BinData from `RoverRogueItem`";

		// Token: 0x0400404F RID: 16463
		private const string KEY_PREFIX = "RoverRogueItemAll";

		// Token: 0x04004050 RID: 16464
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004051 RID: 16465
		private static int HandleId;
	}
}
