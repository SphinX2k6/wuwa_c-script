using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A33 RID: 2611
	public class ConfigTrapDefenseMonsterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D46 RID: 15686 RVA: 0x001B44AC File Offset: 0x001B26AC
		static ConfigTrapDefenseMonsterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x001B44CC File Offset: 0x001B26CC
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

		// Token: 0x06003D48 RID: 15688 RVA: 0x001B454B File Offset: 0x001B274B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterAll.LogPair = null;
			ConfigTrapDefenseMonsterAll.HandleId = 0;
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x001B4559 File Offset: 0x001B2759
		public static void Init()
		{
			ConfigTrapDefenseMonsterAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonster`");
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x001B4574 File Offset: 0x001B2774
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

		// Token: 0x0400474B RID: 18251
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400474C RID: 18252
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x0400474D RID: 18253
		private const string TABLE = "TrapDefenseMonster";

		// Token: 0x0400474E RID: 18254
		private const string COMMAND = "select BinData from `TrapDefenseMonster`";

		// Token: 0x0400474F RID: 18255
		private const string KEY_PREFIX = "TrapDefenseMonsterAll";

		// Token: 0x04004750 RID: 18256
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004751 RID: 18257
		private static int HandleId;
	}
}
