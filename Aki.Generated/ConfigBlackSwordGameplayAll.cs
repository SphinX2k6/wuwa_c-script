using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010C RID: 268
	public class ConfigBlackSwordGameplayAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x00080DC0 File Offset: 0x0007EFC0
		static ConfigBlackSwordGameplayAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordGameplayAll.CreateStaticDefaultValue), new Action(ConfigBlackSwordGameplayAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00080DE0 File Offset: 0x0007EFE0
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackSwordGameplayAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackSwordGameplayAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackswordchallenge.db"),
				new ValueTuple<string, object>("文件", "h.黑剑挑战.xlsx"),
				new ValueTuple<string, object>("表名", "BlackSwordGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackSwordGameplay`")
			});
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00080E5F File Offset: 0x0007F05F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordGameplayAll.LogPair = null;
			ConfigBlackSwordGameplayAll.HandleId = 0;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00080E6D File Offset: 0x0007F06D
		public static void Init()
		{
			ConfigBlackSwordGameplayAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordGameplayAll.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordGameplay`");
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00080E88 File Offset: 0x0007F088
		[NullableContext(2)]
		public static IReadOnlyList<BlackSwordGameplay> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackSwordGameplayAll.HandleId, ConfigBlackSwordGameplayAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BlackSwordGameplay> readOnlyList = (IReadOnlyList<BlackSwordGameplay>)ConfigCommon.GetConfig("BlackSwordGameplayAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BlackSwordGameplay> list = new List<BlackSwordGameplay>();
			while (ConfigCommon.Step(ConfigBlackSwordGameplayAll.HandleId, false, ConfigBlackSwordGameplayAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackSwordGameplayAll.HandleId, 0, ConfigBlackSwordGameplayAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlackSwordGameplayAll.HandleId, ConfigBlackSwordGameplayAll.LogPair);
					return null;
				}
				BlackSwordGameplay rootAsBlackSwordGameplay = BlackSwordGameplay.GetRootAsBlackSwordGameplay(new ByteBuffer(item2));
				list.Add(rootAsBlackSwordGameplay);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BlackSwordGameplayAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlackSwordGameplayAll.HandleId, ConfigBlackSwordGameplayAll.LogPair);
			return list;
		}

		// Token: 0x04000738 RID: 1848
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x04000739 RID: 1849
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x0400073A RID: 1850
		private const string TABLE = "BlackSwordGameplay";

		// Token: 0x0400073B RID: 1851
		private const string COMMAND = "select BinData from `BlackSwordGameplay`";

		// Token: 0x0400073C RID: 1852
		private const string KEY_PREFIX = "BlackSwordGameplayAll";

		// Token: 0x0400073D RID: 1853
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400073E RID: 1854
		private static int HandleId;
	}
}
