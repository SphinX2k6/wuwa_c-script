using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000671 RID: 1649
	public class ConfigPhantomBattleBadgeGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026B6 RID: 9910 RVA: 0x001380A8 File Offset: 0x001362A8
		static ConfigPhantomBattleBadgeGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeGroupAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x001380C8 File Offset: 0x001362C8
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

		// Token: 0x060026B8 RID: 9912 RVA: 0x00138147 File Offset: 0x00136347
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeGroupAll.LogPair = null;
			ConfigPhantomBattleBadgeGroupAll.HandleId = 0;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00138155 File Offset: 0x00136355
		public static void Init()
		{
			ConfigPhantomBattleBadgeGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeGroupAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeGroup`");
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00138170 File Offset: 0x00136370
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

		// Token: 0x04002CFD RID: 11517
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CFE RID: 11518
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CFF RID: 11519
		private const string TABLE = "PhantomBattleBadgeGroup";

		// Token: 0x04002D00 RID: 11520
		private const string COMMAND = "select BinData from `PhantomBattleBadgeGroup`";

		// Token: 0x04002D01 RID: 11521
		private const string KEY_PREFIX = "PhantomBattleBadgeGroupAll";

		// Token: 0x04002D02 RID: 11522
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D03 RID: 11523
		private static int HandleId;
	}
}
