using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000659 RID: 1625
	public class ConfigPhantomBattleBadgeGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x0013162C File Offset: 0x0012F82C
		static ConfigPhantomBattleBadgeGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeGroupAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0013164C File Offset: 0x0012F84C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadgeGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadgeGroup`")
			});
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x001316CB File Offset: 0x0012F8CB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeGroupAll.LogPair = null;
			ConfigPhantomBattleBadgeGroupAll.HandleId = 0;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x001316D9 File Offset: 0x0012F8D9
		public static void Init()
		{
			ConfigPhantomBattleBadgeGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeGroupAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeGroup`");
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x001316F4 File Offset: 0x0012F8F4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleBadgeGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeGroupAll.HandleId, ConfigPhantomBattleBadgeGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleBadgeGroup> readOnlyList = (IReadOnlyList<PhantomBattleBadgeGroup>)ConfigCommon.GetConfig("PhantomBattleBadgeGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleBadgeGroup> list = new List<PhantomBattleBadgeGroup>();
			while (ConfigCommon.Step(ConfigPhantomBattleBadgeGroupAll.HandleId, false, ConfigPhantomBattleBadgeGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeGroupAll.HandleId, 0, ConfigPhantomBattleBadgeGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleBadgeGroupAll.HandleId, ConfigPhantomBattleBadgeGroupAll.LogPair);
					return null;
				}
				PhantomBattleBadgeGroup rootAsPhantomBattleBadgeGroup = PhantomBattleBadgeGroup.GetRootAsPhantomBattleBadgeGroup(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleBadgeGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleBadgeGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeGroupAll.HandleId, ConfigPhantomBattleBadgeGroupAll.LogPair);
			return list;
		}

		// Token: 0x04002C55 RID: 11349
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C56 RID: 11350
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C57 RID: 11351
		private const string TABLE = "PhantomBattleBadgeGroup";

		// Token: 0x04002C58 RID: 11352
		private const string COMMAND = "select BinData from `PhantomBattleBadgeGroup`";

		// Token: 0x04002C59 RID: 11353
		private const string KEY_PREFIX = "PhantomBattleBadgeGroupAll";

		// Token: 0x04002C5A RID: 11354
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C5B RID: 11355
		private static int HandleId;
	}
}
