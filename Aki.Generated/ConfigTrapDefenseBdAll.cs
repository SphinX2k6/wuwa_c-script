using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF4 RID: 2804
	public class ConfigTrapDefenseBdAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041CC RID: 16844 RVA: 0x001D0DF0 File Offset: 0x001CEFF0
		static ConfigTrapDefenseBdAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdAll.ResetStaticDefaultValue));
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x001D0E10 File Offset: 0x001CF010
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBd"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBd`")
			});
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x001D0E8F File Offset: 0x001CF08F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdAll.LogPair = null;
			ConfigTrapDefenseBdAll.HandleId = 0;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x001D0E9D File Offset: 0x001CF09D
		public static void Init()
		{
			ConfigTrapDefenseBdAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBd`");
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x001D0EB8 File Offset: 0x001CF0B8
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseBd> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdAll.HandleId, ConfigTrapDefenseBdAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseBd> readOnlyList = (IReadOnlyList<TrapDefenseBd>)ConfigCommon.GetConfig("TrapDefenseBdAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseBd> list = new List<TrapDefenseBd>();
			while (ConfigCommon.Step(ConfigTrapDefenseBdAll.HandleId, false, ConfigTrapDefenseBdAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdAll.HandleId, 0, ConfigTrapDefenseBdAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseBdAll.HandleId, ConfigTrapDefenseBdAll.LogPair);
					return null;
				}
				TrapDefenseBd rootAsTrapDefenseBd = TrapDefenseBd.GetRootAsTrapDefenseBd(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseBd);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseBdAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdAll.HandleId, ConfigTrapDefenseBdAll.LogPair);
			return list;
		}

		// Token: 0x04004C92 RID: 19602
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C93 RID: 19603
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004C94 RID: 19604
		private const string TABLE = "TrapDefenseBd";

		// Token: 0x04004C95 RID: 19605
		private const string COMMAND = "select BinData from `TrapDefenseBd`";

		// Token: 0x04004C96 RID: 19606
		private const string KEY_PREFIX = "TrapDefenseBdAll";

		// Token: 0x04004C97 RID: 19607
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C98 RID: 19608
		private static int HandleId;
	}
}
