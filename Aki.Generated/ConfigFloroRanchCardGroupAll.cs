using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000328 RID: 808
	public class ConfigFloroRanchCardGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012F5 RID: 4853 RVA: 0x000C8370 File Offset: 0x000C6570
		static ConfigFloroRanchCardGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardGroupAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000C8390 File Offset: 0x000C6590
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCardGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCardGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCardGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCardGroup`")
			});
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000C840F File Offset: 0x000C660F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardGroupAll.LogPair = null;
			ConfigFloroRanchCardGroupAll.HandleId = 0;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000C841D File Offset: 0x000C661D
		public static void Init()
		{
			ConfigFloroRanchCardGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardGroupAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCardGroup`");
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000C8438 File Offset: 0x000C6638
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchCardGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCardGroupAll.HandleId, ConfigFloroRanchCardGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchCardGroup> readOnlyList = (IReadOnlyList<FloroRanchCardGroup>)ConfigCommon.GetConfig("FloroRanchCardGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchCardGroup> list = new List<FloroRanchCardGroup>();
			while (ConfigCommon.Step(ConfigFloroRanchCardGroupAll.HandleId, false, ConfigFloroRanchCardGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCardGroupAll.HandleId, 0, ConfigFloroRanchCardGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchCardGroupAll.HandleId, ConfigFloroRanchCardGroupAll.LogPair);
					return null;
				}
				FloroRanchCardGroup rootAsFloroRanchCardGroup = FloroRanchCardGroup.GetRootAsFloroRanchCardGroup(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchCardGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchCardGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchCardGroupAll.HandleId, ConfigFloroRanchCardGroupAll.LogPair);
			return list;
		}

		// Token: 0x040015FC RID: 5628
		private const string DB = "db_flororanch.db";

		// Token: 0x040015FD RID: 5629
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015FE RID: 5630
		private const string TABLE = "FloroRanchCardGroup";

		// Token: 0x040015FF RID: 5631
		private const string COMMAND = "select BinData from `FloroRanchCardGroup`";

		// Token: 0x04001600 RID: 5632
		private const string KEY_PREFIX = "FloroRanchCardGroupAll";

		// Token: 0x04001601 RID: 5633
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001602 RID: 5634
		private static int HandleId;
	}
}
