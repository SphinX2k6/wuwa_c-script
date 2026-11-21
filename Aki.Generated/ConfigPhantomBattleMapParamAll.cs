using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000692 RID: 1682
	public class ConfigPhantomBattleMapParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600277C RID: 10108 RVA: 0x0013C76F File Offset: 0x0013A96F
		static ConfigPhantomBattleMapParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x0013C790 File Offset: 0x0013A990
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMapParamAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMapParam"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMapParam`")
			});
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x0013C80F File Offset: 0x0013AA0F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamAll.LogPair = null;
			ConfigPhantomBattleMapParamAll.HandleId = 0;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x0013C81D File Offset: 0x0013AA1D
		public static void Init()
		{
			ConfigPhantomBattleMapParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam`");
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0013C838 File Offset: 0x0013AA38
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleMapParam> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMapParamAll.HandleId, ConfigPhantomBattleMapParamAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleMapParam> readOnlyList = (IReadOnlyList<PhantomBattleMapParam>)ConfigCommon.GetConfig("PhantomBattleMapParamAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleMapParam> list = new List<PhantomBattleMapParam>();
			while (ConfigCommon.Step(ConfigPhantomBattleMapParamAll.HandleId, false, ConfigPhantomBattleMapParamAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMapParamAll.HandleId, 0, ConfigPhantomBattleMapParamAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleMapParamAll.HandleId, ConfigPhantomBattleMapParamAll.LogPair);
					return null;
				}
				PhantomBattleMapParam rootAsPhantomBattleMapParam = PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleMapParam);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleMapParamAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMapParamAll.HandleId, ConfigPhantomBattleMapParamAll.LogPair);
			return list;
		}

		// Token: 0x04002DE4 RID: 11748
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DE5 RID: 11749
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DE6 RID: 11750
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002DE7 RID: 11751
		private const string COMMAND = "select BinData from `PhantomBattleMapParam`";

		// Token: 0x04002DE8 RID: 11752
		private const string KEY_PREFIX = "PhantomBattleMapParamAll";

		// Token: 0x04002DE9 RID: 11753
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DEA RID: 11754
		private static int HandleId;
	}
}
