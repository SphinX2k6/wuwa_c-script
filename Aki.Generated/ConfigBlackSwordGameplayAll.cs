using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FD RID: 253
	public class ConfigBlackSwordGameplayAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x0007B45C File Offset: 0x0007965C
		static ConfigBlackSwordGameplayAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordGameplayAll.CreateStaticDefaultValue), new Action(ConfigBlackSwordGameplayAll.ResetStaticDefaultValue));
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0007B47C File Offset: 0x0007967C
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

		// Token: 0x060005F1 RID: 1521 RVA: 0x0007B4FB File Offset: 0x000796FB
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordGameplayAll.LogPair = null;
			ConfigBlackSwordGameplayAll.HandleId = 0;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0007B509 File Offset: 0x00079709
		public static void Init()
		{
			ConfigBlackSwordGameplayAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordGameplayAll.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordGameplay`");
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0007B524 File Offset: 0x00079724
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

		// Token: 0x040006CF RID: 1743
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x040006D0 RID: 1744
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x040006D1 RID: 1745
		private const string TABLE = "BlackSwordGameplay";

		// Token: 0x040006D2 RID: 1746
		private const string COMMAND = "select BinData from `BlackSwordGameplay`";

		// Token: 0x040006D3 RID: 1747
		private const string KEY_PREFIX = "BlackSwordGameplayAll";

		// Token: 0x040006D4 RID: 1748
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006D5 RID: 1749
		private static int HandleId;
	}
}
