using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000326 RID: 806
	public class ConfigFloroRanchCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x000C7F94 File Offset: 0x000C6194
		static ConfigFloroRanchCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000C7FB4 File Offset: 0x000C61B4
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCard"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCard`")
			});
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000C8033 File Offset: 0x000C6233
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardAll.LogPair = null;
			ConfigFloroRanchCardAll.HandleId = 0;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000C8041 File Offset: 0x000C6241
		public static void Init()
		{
			ConfigFloroRanchCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCard`");
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000C805C File Offset: 0x000C625C
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchCard> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCardAll.HandleId, ConfigFloroRanchCardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchCard> readOnlyList = (IReadOnlyList<FloroRanchCard>)ConfigCommon.GetConfig("FloroRanchCardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchCard> list = new List<FloroRanchCard>();
			while (ConfigCommon.Step(ConfigFloroRanchCardAll.HandleId, false, ConfigFloroRanchCardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCardAll.HandleId, 0, ConfigFloroRanchCardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchCardAll.HandleId, ConfigFloroRanchCardAll.LogPair);
					return null;
				}
				FloroRanchCard rootAsFloroRanchCard = FloroRanchCard.GetRootAsFloroRanchCard(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchCard);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchCardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchCardAll.HandleId, ConfigFloroRanchCardAll.LogPair);
			return list;
		}

		// Token: 0x040015EE RID: 5614
		private const string DB = "db_flororanch.db";

		// Token: 0x040015EF RID: 5615
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015F0 RID: 5616
		private const string TABLE = "FloroRanchCard";

		// Token: 0x040015F1 RID: 5617
		private const string COMMAND = "select BinData from `FloroRanchCard`";

		// Token: 0x040015F2 RID: 5618
		private const string KEY_PREFIX = "FloroRanchCardAll";

		// Token: 0x040015F3 RID: 5619
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015F4 RID: 5620
		private static int HandleId;
	}
}
