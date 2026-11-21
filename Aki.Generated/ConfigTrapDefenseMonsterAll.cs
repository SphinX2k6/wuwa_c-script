using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B08 RID: 2824
	public class ConfigTrapDefenseMonsterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004244 RID: 16964 RVA: 0x001D3840 File Offset: 0x001D1A40
		static ConfigTrapDefenseMonsterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x001D3860 File Offset: 0x001D1A60
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonster`")
			});
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x001D38DF File Offset: 0x001D1ADF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterAll.LogPair = null;
			ConfigTrapDefenseMonsterAll.HandleId = 0;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x001D38ED File Offset: 0x001D1AED
		public static void Init()
		{
			ConfigTrapDefenseMonsterAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonster`");
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x001D3908 File Offset: 0x001D1B08
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseMonster> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterAll.HandleId, ConfigTrapDefenseMonsterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseMonster> readOnlyList = (IReadOnlyList<TrapDefenseMonster>)ConfigCommon.GetConfig("TrapDefenseMonsterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseMonster> list = new List<TrapDefenseMonster>();
			while (ConfigCommon.Step(ConfigTrapDefenseMonsterAll.HandleId, false, ConfigTrapDefenseMonsterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterAll.HandleId, 0, ConfigTrapDefenseMonsterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseMonsterAll.HandleId, ConfigTrapDefenseMonsterAll.LogPair);
					return null;
				}
				TrapDefenseMonster rootAsTrapDefenseMonster = TrapDefenseMonster.GetRootAsTrapDefenseMonster(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseMonster);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseMonsterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterAll.HandleId, ConfigTrapDefenseMonsterAll.LogPair);
			return list;
		}

		// Token: 0x04004D1E RID: 19742
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D1F RID: 19743
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D20 RID: 19744
		private const string TABLE = "TrapDefenseMonster";

		// Token: 0x04004D21 RID: 19745
		private const string COMMAND = "select BinData from `TrapDefenseMonster`";

		// Token: 0x04004D22 RID: 19746
		private const string KEY_PREFIX = "TrapDefenseMonsterAll";

		// Token: 0x04004D23 RID: 19747
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D24 RID: 19748
		private static int HandleId;
	}
}
