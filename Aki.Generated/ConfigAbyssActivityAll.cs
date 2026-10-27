using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200000D RID: 13
	public class ConfigAbyssActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0005BC85 File Offset: 0x00059E85
		static ConfigAbyssActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssActivityAll.CreateStaticDefaultValue), new Action(ConfigAbyssActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0005BCA4 File Offset: 0x00059EA4
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssActivity`")
			});
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0005BD23 File Offset: 0x00059F23
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssActivityAll.LogPair = null;
			ConfigAbyssActivityAll.HandleId = 0;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0005BD31 File Offset: 0x00059F31
		public static void Init()
		{
			ConfigAbyssActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssActivityAll.HandleId, "db_dangoabyss.db", "select BinData from `AbyssActivity`");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0005BD4C File Offset: 0x00059F4C
		[NullableContext(2)]
		public static IReadOnlyList<AbyssActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssActivityAll.HandleId, ConfigAbyssActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssActivity> readOnlyList = (IReadOnlyList<AbyssActivity>)ConfigCommon.GetConfig("AbyssActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssActivity> list = new List<AbyssActivity>();
			while (ConfigCommon.Step(ConfigAbyssActivityAll.HandleId, false, ConfigAbyssActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssActivityAll.HandleId, 0, ConfigAbyssActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssActivityAll.HandleId, ConfigAbyssActivityAll.LogPair);
					return null;
				}
				AbyssActivity rootAsAbyssActivity = AbyssActivity.GetRootAsAbyssActivity(new ByteBuffer(item2));
				list.Add(rootAsAbyssActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssActivityAll.HandleId, ConfigAbyssActivityAll.LogPair);
			return list;
		}

		// Token: 0x0400003F RID: 63
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000040 RID: 64
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000041 RID: 65
		private const string TABLE = "AbyssActivity";

		// Token: 0x04000042 RID: 66
		private const string COMMAND = "select BinData from `AbyssActivity`";

		// Token: 0x04000043 RID: 67
		private const string KEY_PREFIX = "AbyssActivityAll";

		// Token: 0x04000044 RID: 68
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000045 RID: 69
		private static int HandleId;
	}
}
