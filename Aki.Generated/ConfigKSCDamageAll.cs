using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000479 RID: 1145
	public class ConfigKSCDamageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x000F150C File Offset: 0x000EF70C
		static ConfigKSCDamageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCDamageAll.CreateStaticDefaultValue), new Action(ConfigKSCDamageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000F152C File Offset: 0x000EF72C
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCDamageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCDamageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kscdamage.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombat结算.xlsx"),
				new ValueTuple<string, object>("表名", "KSCDamage"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCDamage`")
			});
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000F15AB File Offset: 0x000EF7AB
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCDamageAll.LogPair = null;
			ConfigKSCDamageAll.HandleId = 0;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x000F15B9 File Offset: 0x000EF7B9
		public static void Init()
		{
			ConfigKSCDamageAll.HandleId = ConfigCommon.InitDataStatement(ConfigKSCDamageAll.HandleId, "db_kscdamage.db", "select BinData from `KSCDamage`");
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000F15D4 File Offset: 0x000EF7D4
		[NullableContext(2)]
		public static IReadOnlyList<KSCDamage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCDamageAll.HandleId, ConfigKSCDamageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KSCDamage> readOnlyList = (IReadOnlyList<KSCDamage>)ConfigCommon.GetConfig("KSCDamageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KSCDamage> list = new List<KSCDamage>();
			while (ConfigCommon.Step(ConfigKSCDamageAll.HandleId, false, ConfigKSCDamageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCDamageAll.HandleId, 0, ConfigKSCDamageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKSCDamageAll.HandleId, ConfigKSCDamageAll.LogPair);
					return null;
				}
				KSCDamage rootAsKSCDamage = KSCDamage.GetRootAsKSCDamage(new ByteBuffer(item2));
				list.Add(rootAsKSCDamage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KSCDamageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKSCDamageAll.HandleId, ConfigKSCDamageAll.LogPair);
			return list;
		}

		// Token: 0x04001F33 RID: 7987
		private const string DB = "db_kscdamage.db";

		// Token: 0x04001F34 RID: 7988
		private const string FILE = "s.SimpleCombat结算.xlsx";

		// Token: 0x04001F35 RID: 7989
		private const string TABLE = "KSCDamage";

		// Token: 0x04001F36 RID: 7990
		private const string COMMAND = "select BinData from `KSCDamage`";

		// Token: 0x04001F37 RID: 7991
		private const string KEY_PREFIX = "KSCDamageAll";

		// Token: 0x04001F38 RID: 7992
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F39 RID: 7993
		private static int HandleId;
	}
}
