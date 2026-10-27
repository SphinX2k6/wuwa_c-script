using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200001F RID: 31
	public class ConfigAbyssRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0005DFE4 File Offset: 0x0005C1E4
		static ConfigAbyssRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRewardTabAll.CreateStaticDefaultValue), new Action(ConfigAbyssRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0005E004 File Offset: 0x0005C204
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRewardTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRewardTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRewardTab`")
			});
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0005E083 File Offset: 0x0005C283
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRewardTabAll.LogPair = null;
			ConfigAbyssRewardTabAll.HandleId = 0;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0005E091 File Offset: 0x0005C291
		public static void Init()
		{
			ConfigAbyssRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRewardTabAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRewardTab`");
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0005E0AC File Offset: 0x0005C2AC
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRewardTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRewardTabAll.HandleId, ConfigAbyssRewardTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssRewardTab> readOnlyList = (IReadOnlyList<AbyssRewardTab>)ConfigCommon.GetConfig("AbyssRewardTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssRewardTab> list = new List<AbyssRewardTab>();
			while (ConfigCommon.Step(ConfigAbyssRewardTabAll.HandleId, false, ConfigAbyssRewardTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRewardTabAll.HandleId, 0, ConfigAbyssRewardTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRewardTabAll.HandleId, ConfigAbyssRewardTabAll.LogPair);
					return null;
				}
				AbyssRewardTab rootAsAbyssRewardTab = AbyssRewardTab.GetRootAsAbyssRewardTab(new ByteBuffer(item2));
				list.Add(rootAsAbyssRewardTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssRewardTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRewardTabAll.HandleId, ConfigAbyssRewardTabAll.LogPair);
			return list;
		}

		// Token: 0x040000BD RID: 189
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000BE RID: 190
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000BF RID: 191
		private const string TABLE = "AbyssRewardTab";

		// Token: 0x040000C0 RID: 192
		private const string COMMAND = "select BinData from `AbyssRewardTab`";

		// Token: 0x040000C1 RID: 193
		private const string KEY_PREFIX = "AbyssRewardTabAll";

		// Token: 0x040000C2 RID: 194
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000C3 RID: 195
		private static int HandleId;
	}
}
