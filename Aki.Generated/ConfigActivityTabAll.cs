using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000054 RID: 84
	public class ConfigActivityTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00064D7C File Offset: 0x00062F7C
		static ConfigActivityTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTabAll.CreateStaticDefaultValue), new Action(ConfigActivityTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00064D9C File Offset: 0x00062F9C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityTab"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityTab`")
			});
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00064E1B File Offset: 0x0006301B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTabAll.LogPair = null;
			ConfigActivityTabAll.HandleId = 0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00064E29 File Offset: 0x00063029
		public static void Init()
		{
			ConfigActivityTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTabAll.HandleId, "db_weeklychallenge.db", "select BinData from `ActivityTab`");
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00064E44 File Offset: 0x00063044
		[NullableContext(2)]
		public static IReadOnlyList<ActivityTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityTabAll.HandleId, ConfigActivityTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityTab> readOnlyList = (IReadOnlyList<ActivityTab>)ConfigCommon.GetConfig("ActivityTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityTab> list = new List<ActivityTab>();
			while (ConfigCommon.Step(ConfigActivityTabAll.HandleId, false, ConfigActivityTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityTabAll.HandleId, 0, ConfigActivityTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityTabAll.HandleId, ConfigActivityTabAll.LogPair);
					return null;
				}
				ActivityTab rootAsActivityTab = ActivityTab.GetRootAsActivityTab(new ByteBuffer(item2));
				list.Add(rootAsActivityTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityTabAll.HandleId, ConfigActivityTabAll.LogPair);
			return list;
		}

		// Token: 0x04000230 RID: 560
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04000231 RID: 561
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04000232 RID: 562
		private const string TABLE = "ActivityTab";

		// Token: 0x04000233 RID: 563
		private const string COMMAND = "select BinData from `ActivityTab`";

		// Token: 0x04000234 RID: 564
		private const string KEY_PREFIX = "ActivityTabAll";

		// Token: 0x04000235 RID: 565
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000236 RID: 566
		private static int HandleId;
	}
}
