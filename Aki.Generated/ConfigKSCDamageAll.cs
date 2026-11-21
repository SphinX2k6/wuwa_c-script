using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048F RID: 1167
	public class ConfigKSCDamageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x000F7C60 File Offset: 0x000F5E60
		static ConfigKSCDamageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCDamageAll.CreateStaticDefaultValue), new Action(ConfigKSCDamageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000F7C80 File Offset: 0x000F5E80
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

		// Token: 0x06001B66 RID: 7014 RVA: 0x000F7CFF File Offset: 0x000F5EFF
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCDamageAll.LogPair = null;
			ConfigKSCDamageAll.HandleId = 0;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000F7D0D File Offset: 0x000F5F0D
		public static void Init()
		{
			ConfigKSCDamageAll.HandleId = ConfigCommon.InitDataStatement(ConfigKSCDamageAll.HandleId, "db_kscdamage.db", "select BinData from `KSCDamage`");
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000F7D28 File Offset: 0x000F5F28
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

		// Token: 0x04001FCD RID: 8141
		private const string DB = "db_kscdamage.db";

		// Token: 0x04001FCE RID: 8142
		private const string FILE = "s.SimpleCombat结算.xlsx";

		// Token: 0x04001FCF RID: 8143
		private const string TABLE = "KSCDamage";

		// Token: 0x04001FD0 RID: 8144
		private const string COMMAND = "select BinData from `KSCDamage`";

		// Token: 0x04001FD1 RID: 8145
		private const string KEY_PREFIX = "KSCDamageAll";

		// Token: 0x04001FD2 RID: 8146
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FD3 RID: 8147
		private static int HandleId;
	}
}
