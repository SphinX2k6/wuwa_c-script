using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E8 RID: 2280
	public class ConfigRoverRogueItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003583 RID: 13699 RVA: 0x00187D40 File Offset: 0x00185F40
		static ConfigRoverRogueItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueItemAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x00187D60 File Offset: 0x00185F60
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

		// Token: 0x06003585 RID: 13701 RVA: 0x00187DDF File Offset: 0x00185FDF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueItemAll.LogPair = null;
			ConfigRoverRogueItemAll.HandleId = 0;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00187DED File Offset: 0x00185FED
		public static void Init()
		{
			ConfigRoverRogueItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueItemAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueItem`");
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00187E08 File Offset: 0x00186008
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

		// Token: 0x04003E3E RID: 15934
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E3F RID: 15935
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003E40 RID: 15936
		private const string TABLE = "RoverRogueItem";

		// Token: 0x04003E41 RID: 15937
		private const string COMMAND = "select BinData from `RoverRogueItem`";

		// Token: 0x04003E42 RID: 15938
		private const string KEY_PREFIX = "RoverRogueItemAll";

		// Token: 0x04003E43 RID: 15939
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E44 RID: 15940
		private static int HandleId;
	}
}
