using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067E RID: 1662
	public class ConfigPhantomBattleMasterLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002704 RID: 9988 RVA: 0x0013654F File Offset: 0x0013474F
		static ConfigPhantomBattleMasterLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterLevelAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00136570 File Offset: 0x00134770
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMasterLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMasterLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMasterLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMasterLevel`")
			});
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x001365EF File Offset: 0x001347EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterLevelAll.LogPair = null;
			ConfigPhantomBattleMasterLevelAll.HandleId = 0;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x001365FD File Offset: 0x001347FD
		public static void Init()
		{
			ConfigPhantomBattleMasterLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterLevelAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterLevel`");
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00136618 File Offset: 0x00134818
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleMasterLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMasterLevelAll.HandleId, ConfigPhantomBattleMasterLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleMasterLevel> readOnlyList = (IReadOnlyList<PhantomBattleMasterLevel>)ConfigCommon.GetConfig("PhantomBattleMasterLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleMasterLevel> list = new List<PhantomBattleMasterLevel>();
			while (ConfigCommon.Step(ConfigPhantomBattleMasterLevelAll.HandleId, false, ConfigPhantomBattleMasterLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMasterLevelAll.HandleId, 0, ConfigPhantomBattleMasterLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleMasterLevelAll.HandleId, ConfigPhantomBattleMasterLevelAll.LogPair);
					return null;
				}
				PhantomBattleMasterLevel rootAsPhantomBattleMasterLevel = PhantomBattleMasterLevel.GetRootAsPhantomBattleMasterLevel(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleMasterLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleMasterLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMasterLevelAll.HandleId, ConfigPhantomBattleMasterLevelAll.LogPair);
			return list;
		}

		// Token: 0x04002D58 RID: 11608
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D59 RID: 11609
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D5A RID: 11610
		private const string TABLE = "PhantomBattleMasterLevel";

		// Token: 0x04002D5B RID: 11611
		private const string COMMAND = "select BinData from `PhantomBattleMasterLevel`";

		// Token: 0x04002D5C RID: 11612
		private const string KEY_PREFIX = "PhantomBattleMasterLevelAll";

		// Token: 0x04002D5D RID: 11613
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D5E RID: 11614
		private static int HandleId;
	}
}
