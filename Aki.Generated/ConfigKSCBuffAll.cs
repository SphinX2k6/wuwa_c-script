using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048D RID: 1165
	public class ConfigKSCBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B58 RID: 7000 RVA: 0x000F7883 File Offset: 0x000F5A83
		static ConfigKSCBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBuffAll.CreateStaticDefaultValue), new Action(ConfigKSCBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000F78A4 File Offset: 0x000F5AA4
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tdbuff.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombatBuff.xlsx"),
				new ValueTuple<string, object>("表名", "KSCBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCBuff`")
			});
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000F7923 File Offset: 0x000F5B23
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBuffAll.LogPair = null;
			ConfigKSCBuffAll.HandleId = 0;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x000F7931 File Offset: 0x000F5B31
		public static void Init()
		{
			ConfigKSCBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBuffAll.HandleId, "db_tdbuff.db", "select BinData from `KSCBuff`");
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000F794C File Offset: 0x000F5B4C
		[NullableContext(2)]
		public static IReadOnlyList<KSCBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCBuffAll.HandleId, ConfigKSCBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KSCBuff> readOnlyList = (IReadOnlyList<KSCBuff>)ConfigCommon.GetConfig("KSCBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KSCBuff> list = new List<KSCBuff>();
			while (ConfigCommon.Step(ConfigKSCBuffAll.HandleId, false, ConfigKSCBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCBuffAll.HandleId, 0, ConfigKSCBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKSCBuffAll.HandleId, ConfigKSCBuffAll.LogPair);
					return null;
				}
				KSCBuff rootAsKSCBuff = KSCBuff.GetRootAsKSCBuff(new ByteBuffer(item2));
				list.Add(rootAsKSCBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KSCBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKSCBuffAll.HandleId, ConfigKSCBuffAll.LogPair);
			return list;
		}

		// Token: 0x04001FBF RID: 8127
		private const string DB = "db_tdbuff.db";

		// Token: 0x04001FC0 RID: 8128
		private const string FILE = "s.SimpleCombatBuff.xlsx";

		// Token: 0x04001FC1 RID: 8129
		private const string TABLE = "KSCBuff";

		// Token: 0x04001FC2 RID: 8130
		private const string COMMAND = "select BinData from `KSCBuff`";

		// Token: 0x04001FC3 RID: 8131
		private const string KEY_PREFIX = "KSCBuffAll";

		// Token: 0x04001FC4 RID: 8132
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FC5 RID: 8133
		private static int HandleId;
	}
}
