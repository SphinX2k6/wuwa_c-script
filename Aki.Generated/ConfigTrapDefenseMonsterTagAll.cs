using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3A RID: 2618
	public class ConfigTrapDefenseMonsterTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D70 RID: 15728 RVA: 0x001B5288 File Offset: 0x001B3488
		static ConfigTrapDefenseMonsterTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterTagAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x001B52A8 File Offset: 0x001B34A8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterTag"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterTag`")
			});
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x001B5327 File Offset: 0x001B3527
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTagAll.LogPair = null;
			ConfigTrapDefenseMonsterTagAll.HandleId = 0;
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x001B5335 File Offset: 0x001B3535
		public static void Init()
		{
			ConfigTrapDefenseMonsterTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterTagAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterTag`");
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x001B5350 File Offset: 0x001B3550
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseMonsterTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterTagAll.HandleId, ConfigTrapDefenseMonsterTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseMonsterTag> readOnlyList = (IReadOnlyList<TrapDefenseMonsterTag>)ConfigCommon.GetConfig("TrapDefenseMonsterTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseMonsterTag> list = new List<TrapDefenseMonsterTag>();
			while (ConfigCommon.Step(ConfigTrapDefenseMonsterTagAll.HandleId, false, ConfigTrapDefenseMonsterTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterTagAll.HandleId, 0, ConfigTrapDefenseMonsterTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseMonsterTagAll.HandleId, ConfigTrapDefenseMonsterTagAll.LogPair);
					return null;
				}
				TrapDefenseMonsterTag rootAsTrapDefenseMonsterTag = TrapDefenseMonsterTag.GetRootAsTrapDefenseMonsterTag(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseMonsterTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseMonsterTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterTagAll.HandleId, ConfigTrapDefenseMonsterTagAll.LogPair);
			return list;
		}

		// Token: 0x0400477C RID: 18300
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400477D RID: 18301
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x0400477E RID: 18302
		private const string TABLE = "TrapDefenseMonsterTag";

		// Token: 0x0400477F RID: 18303
		private const string COMMAND = "select BinData from `TrapDefenseMonsterTag`";

		// Token: 0x04004780 RID: 18304
		private const string KEY_PREFIX = "TrapDefenseMonsterTagAll";

		// Token: 0x04004781 RID: 18305
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004782 RID: 18306
		private static int HandleId;
	}
}
