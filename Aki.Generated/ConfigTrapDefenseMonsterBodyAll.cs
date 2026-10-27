using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A34 RID: 2612
	public class ConfigTrapDefenseMonsterBodyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D4C RID: 15692 RVA: 0x001B463F File Offset: 0x001B283F
		static ConfigTrapDefenseMonsterBodyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterBodyAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterBodyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x001B4660 File Offset: 0x001B2860
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

		// Token: 0x06003D4E RID: 15694 RVA: 0x001B46DF File Offset: 0x001B28DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterBodyAll.LogPair = null;
			ConfigTrapDefenseMonsterBodyAll.HandleId = 0;
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x001B46ED File Offset: 0x001B28ED
		public static void Init()
		{
			ConfigTrapDefenseMonsterBodyAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterBodyAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterBody`");
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x001B4708 File Offset: 0x001B2908
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

		// Token: 0x04004752 RID: 18258
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004753 RID: 18259
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004754 RID: 18260
		private const string TABLE = "TrapDefenseMonsterBody";

		// Token: 0x04004755 RID: 18261
		private const string COMMAND = "select BinData from `TrapDefenseMonsterBody`";

		// Token: 0x04004756 RID: 18262
		private const string KEY_PREFIX = "TrapDefenseMonsterBodyAll";

		// Token: 0x04004757 RID: 18263
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004758 RID: 18264
		private static int HandleId;
	}
}
