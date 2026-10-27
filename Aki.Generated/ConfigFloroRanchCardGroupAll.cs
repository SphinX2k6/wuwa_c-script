using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000313 RID: 787
	public class ConfigFloroRanchCardGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001277 RID: 4727 RVA: 0x000C1E64 File Offset: 0x000C0064
		static ConfigFloroRanchCardGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardGroupAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000C1E84 File Offset: 0x000C0084
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

		// Token: 0x06001279 RID: 4729 RVA: 0x000C1F03 File Offset: 0x000C0103
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardGroupAll.LogPair = null;
			ConfigFloroRanchCardGroupAll.HandleId = 0;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000C1F11 File Offset: 0x000C0111
		public static void Init()
		{
			ConfigFloroRanchCardGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardGroupAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCardGroup`");
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000C1F2C File Offset: 0x000C012C
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

		// Token: 0x04001569 RID: 5481
		private const string DB = "db_flororanch.db";

		// Token: 0x0400156A RID: 5482
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400156B RID: 5483
		private const string TABLE = "FloroRanchCardGroup";

		// Token: 0x0400156C RID: 5484
		private const string COMMAND = "select BinData from `FloroRanchCardGroup`";

		// Token: 0x0400156D RID: 5485
		private const string KEY_PREFIX = "FloroRanchCardGroupAll";

		// Token: 0x0400156E RID: 5486
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400156F RID: 5487
		private static int HandleId;
	}
}
