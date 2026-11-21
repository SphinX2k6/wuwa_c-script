using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0F RID: 2831
	public class ConfigTrapDefenseMonsterTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600426E RID: 17006 RVA: 0x001D461C File Offset: 0x001D281C
		static ConfigTrapDefenseMonsterTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterTagAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x001D463C File Offset: 0x001D283C
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

		// Token: 0x06004270 RID: 17008 RVA: 0x001D46BB File Offset: 0x001D28BB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTagAll.LogPair = null;
			ConfigTrapDefenseMonsterTagAll.HandleId = 0;
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x001D46C9 File Offset: 0x001D28C9
		public static void Init()
		{
			ConfigTrapDefenseMonsterTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterTagAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterTag`");
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x001D46E4 File Offset: 0x001D28E4
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

		// Token: 0x04004D4F RID: 19791
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D50 RID: 19792
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D51 RID: 19793
		private const string TABLE = "TrapDefenseMonsterTag";

		// Token: 0x04004D52 RID: 19794
		private const string COMMAND = "select BinData from `TrapDefenseMonsterTag`";

		// Token: 0x04004D53 RID: 19795
		private const string KEY_PREFIX = "TrapDefenseMonsterTagAll";

		// Token: 0x04004D54 RID: 19796
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D55 RID: 19797
		private static int HandleId;
	}
}
