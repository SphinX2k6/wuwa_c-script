using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000696 RID: 1686
	public class ConfigPhantomBattleMasterLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002794 RID: 10132 RVA: 0x0013CFCB File Offset: 0x0013B1CB
		static ConfigPhantomBattleMasterLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterLevelAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x0013CFEC File Offset: 0x0013B1EC
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

		// Token: 0x06002796 RID: 10134 RVA: 0x0013D06B File Offset: 0x0013B26B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterLevelAll.LogPair = null;
			ConfigPhantomBattleMasterLevelAll.HandleId = 0;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x0013D079 File Offset: 0x0013B279
		public static void Init()
		{
			ConfigPhantomBattleMasterLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterLevelAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterLevel`");
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x0013D094 File Offset: 0x0013B294
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

		// Token: 0x04002E00 RID: 11776
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E01 RID: 11777
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E02 RID: 11778
		private const string TABLE = "PhantomBattleMasterLevel";

		// Token: 0x04002E03 RID: 11779
		private const string COMMAND = "select BinData from `PhantomBattleMasterLevel`";

		// Token: 0x04002E04 RID: 11780
		private const string KEY_PREFIX = "PhantomBattleMasterLevelAll";

		// Token: 0x04002E05 RID: 11781
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E06 RID: 11782
		private static int HandleId;
	}
}
