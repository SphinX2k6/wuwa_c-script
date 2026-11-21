using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A0 RID: 1696
	public class ConfigPhantomBattleWeekExpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027D0 RID: 10192 RVA: 0x0013E514 File Offset: 0x0013C714
		static ConfigPhantomBattleWeekExpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleWeekExpAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleWeekExpAll.ResetStaticDefaultValue));
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0013E534 File Offset: 0x0013C734
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleWeekExpAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleWeekExpAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleWeekExp"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleWeekExp`")
			});
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0013E5B3 File Offset: 0x0013C7B3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleWeekExpAll.LogPair = null;
			ConfigPhantomBattleWeekExpAll.HandleId = 0;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0013E5C1 File Offset: 0x0013C7C1
		public static void Init()
		{
			ConfigPhantomBattleWeekExpAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleWeekExpAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleWeekExp`");
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x0013E5DC File Offset: 0x0013C7DC
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleWeekExp> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleWeekExpAll.HandleId, ConfigPhantomBattleWeekExpAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleWeekExp> readOnlyList = (IReadOnlyList<PhantomBattleWeekExp>)ConfigCommon.GetConfig("PhantomBattleWeekExpAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleWeekExp> list = new List<PhantomBattleWeekExp>();
			while (ConfigCommon.Step(ConfigPhantomBattleWeekExpAll.HandleId, false, ConfigPhantomBattleWeekExpAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleWeekExpAll.HandleId, 0, ConfigPhantomBattleWeekExpAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleWeekExpAll.HandleId, ConfigPhantomBattleWeekExpAll.LogPair);
					return null;
				}
				PhantomBattleWeekExp rootAsPhantomBattleWeekExp = PhantomBattleWeekExp.GetRootAsPhantomBattleWeekExp(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleWeekExp);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleWeekExpAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleWeekExpAll.HandleId, ConfigPhantomBattleWeekExpAll.LogPair);
			return list;
		}

		// Token: 0x04002E46 RID: 11846
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E47 RID: 11847
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E48 RID: 11848
		private const string TABLE = "PhantomBattleWeekExp";

		// Token: 0x04002E49 RID: 11849
		private const string COMMAND = "select BinData from `PhantomBattleWeekExp`";

		// Token: 0x04002E4A RID: 11850
		private const string KEY_PREFIX = "PhantomBattleWeekExpAll";

		// Token: 0x04002E4B RID: 11851
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E4C RID: 11852
		private static int HandleId;
	}
}
