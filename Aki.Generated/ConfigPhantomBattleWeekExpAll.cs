using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000688 RID: 1672
	public class ConfigPhantomBattleWeekExpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x00137A98 File Offset: 0x00135C98
		static ConfigPhantomBattleWeekExpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleWeekExpAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleWeekExpAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00137AB8 File Offset: 0x00135CB8
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

		// Token: 0x06002742 RID: 10050 RVA: 0x00137B37 File Offset: 0x00135D37
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleWeekExpAll.LogPair = null;
			ConfigPhantomBattleWeekExpAll.HandleId = 0;
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00137B45 File Offset: 0x00135D45
		public static void Init()
		{
			ConfigPhantomBattleWeekExpAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleWeekExpAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleWeekExp`");
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00137B60 File Offset: 0x00135D60
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

		// Token: 0x04002D9E RID: 11678
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D9F RID: 11679
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DA0 RID: 11680
		private const string TABLE = "PhantomBattleWeekExp";

		// Token: 0x04002DA1 RID: 11681
		private const string COMMAND = "select BinData from `PhantomBattleWeekExp`";

		// Token: 0x04002DA2 RID: 11682
		private const string KEY_PREFIX = "PhantomBattleWeekExpAll";

		// Token: 0x04002DA3 RID: 11683
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DA4 RID: 11684
		private static int HandleId;
	}
}
