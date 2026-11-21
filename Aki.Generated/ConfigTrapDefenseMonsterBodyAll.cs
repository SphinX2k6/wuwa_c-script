using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B09 RID: 2825
	public class ConfigTrapDefenseMonsterBodyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600424A RID: 16970 RVA: 0x001D39D3 File Offset: 0x001D1BD3
		static ConfigTrapDefenseMonsterBodyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterBodyAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterBodyAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x001D39F4 File Offset: 0x001D1BF4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterBodyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterBodyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterBody"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterBody`")
			});
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x001D3A73 File Offset: 0x001D1C73
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterBodyAll.LogPair = null;
			ConfigTrapDefenseMonsterBodyAll.HandleId = 0;
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x001D3A81 File Offset: 0x001D1C81
		public static void Init()
		{
			ConfigTrapDefenseMonsterBodyAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterBodyAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterBody`");
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x001D3A9C File Offset: 0x001D1C9C
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseMonsterBody> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterBodyAll.HandleId, ConfigTrapDefenseMonsterBodyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseMonsterBody> readOnlyList = (IReadOnlyList<TrapDefenseMonsterBody>)ConfigCommon.GetConfig("TrapDefenseMonsterBodyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseMonsterBody> list = new List<TrapDefenseMonsterBody>();
			while (ConfigCommon.Step(ConfigTrapDefenseMonsterBodyAll.HandleId, false, ConfigTrapDefenseMonsterBodyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterBodyAll.HandleId, 0, ConfigTrapDefenseMonsterBodyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseMonsterBodyAll.HandleId, ConfigTrapDefenseMonsterBodyAll.LogPair);
					return null;
				}
				TrapDefenseMonsterBody rootAsTrapDefenseMonsterBody = TrapDefenseMonsterBody.GetRootAsTrapDefenseMonsterBody(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseMonsterBody);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseMonsterBodyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterBodyAll.HandleId, ConfigTrapDefenseMonsterBodyAll.LogPair);
			return list;
		}

		// Token: 0x04004D25 RID: 19749
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D26 RID: 19750
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D27 RID: 19751
		private const string TABLE = "TrapDefenseMonsterBody";

		// Token: 0x04004D28 RID: 19752
		private const string COMMAND = "select BinData from `TrapDefenseMonsterBody`";

		// Token: 0x04004D29 RID: 19753
		private const string KEY_PREFIX = "TrapDefenseMonsterBodyAll";

		// Token: 0x04004D2A RID: 19754
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D2B RID: 19755
		private static int HandleId;
	}
}
