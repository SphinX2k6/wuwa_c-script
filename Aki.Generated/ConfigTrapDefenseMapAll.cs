using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A31 RID: 2609
	public class ConfigTrapDefenseMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D3A RID: 15674 RVA: 0x001B40D0 File Offset: 0x001B22D0
		static ConfigTrapDefenseMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMapAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x001B40F0 File Offset: 0x001B22F0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMapAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMapAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMap"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMap`")
			});
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x001B416F File Offset: 0x001B236F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMapAll.LogPair = null;
			ConfigTrapDefenseMapAll.HandleId = 0;
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x001B417D File Offset: 0x001B237D
		public static void Init()
		{
			ConfigTrapDefenseMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMapAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMap`");
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x001B4198 File Offset: 0x001B2398
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseMap> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMapAll.HandleId, ConfigTrapDefenseMapAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseMap> readOnlyList = (IReadOnlyList<TrapDefenseMap>)ConfigCommon.GetConfig("TrapDefenseMapAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseMap> list = new List<TrapDefenseMap>();
			while (ConfigCommon.Step(ConfigTrapDefenseMapAll.HandleId, false, ConfigTrapDefenseMapAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMapAll.HandleId, 0, ConfigTrapDefenseMapAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseMapAll.HandleId, ConfigTrapDefenseMapAll.LogPair);
					return null;
				}
				TrapDefenseMap rootAsTrapDefenseMap = TrapDefenseMap.GetRootAsTrapDefenseMap(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseMap);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseMapAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMapAll.HandleId, ConfigTrapDefenseMapAll.LogPair);
			return list;
		}

		// Token: 0x0400473D RID: 18237
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400473E RID: 18238
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x0400473F RID: 18239
		private const string TABLE = "TrapDefenseMap";

		// Token: 0x04004740 RID: 18240
		private const string COMMAND = "select BinData from `TrapDefenseMap`";

		// Token: 0x04004741 RID: 18241
		private const string KEY_PREFIX = "TrapDefenseMapAll";

		// Token: 0x04004742 RID: 18242
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004743 RID: 18243
		private static int HandleId;
	}
}
