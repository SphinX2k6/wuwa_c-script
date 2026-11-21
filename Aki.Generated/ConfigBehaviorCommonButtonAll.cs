using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FC RID: 252
	public class ConfigBehaviorCommonButtonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x0007EB38 File Offset: 0x0007CD38
		static ConfigBehaviorCommonButtonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBehaviorCommonButtonAll.CreateStaticDefaultValue), new Action(ConfigBehaviorCommonButtonAll.ResetStaticDefaultValue));
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0007EB58 File Offset: 0x0007CD58
		public static void CreateStaticDefaultValue()
		{
			ConfigBehaviorCommonButtonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBehaviorCommonButtonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "BehaviorCommonButton"),
				new ValueTuple<string, object>("语句", "select BinData from `BehaviorCommonButton`")
			});
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0007EBD7 File Offset: 0x0007CDD7
		public static void ResetStaticDefaultValue()
		{
			ConfigBehaviorCommonButtonAll.LogPair = null;
			ConfigBehaviorCommonButtonAll.HandleId = 0;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0007EBE5 File Offset: 0x0007CDE5
		public static void Init()
		{
			ConfigBehaviorCommonButtonAll.HandleId = ConfigCommon.InitDataStatement(ConfigBehaviorCommonButtonAll.HandleId, "db_skillbutton.db", "select BinData from `BehaviorCommonButton`");
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0007EC00 File Offset: 0x0007CE00
		[NullableContext(2)]
		public static IReadOnlyList<BehaviorCommonButton> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBehaviorCommonButtonAll.HandleId, ConfigBehaviorCommonButtonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BehaviorCommonButton> readOnlyList = (IReadOnlyList<BehaviorCommonButton>)ConfigCommon.GetConfig("BehaviorCommonButtonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BehaviorCommonButton> list = new List<BehaviorCommonButton>();
			while (ConfigCommon.Step(ConfigBehaviorCommonButtonAll.HandleId, false, ConfigBehaviorCommonButtonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBehaviorCommonButtonAll.HandleId, 0, ConfigBehaviorCommonButtonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBehaviorCommonButtonAll.HandleId, ConfigBehaviorCommonButtonAll.LogPair);
					return null;
				}
				BehaviorCommonButton rootAsBehaviorCommonButton = BehaviorCommonButton.GetRootAsBehaviorCommonButton(new ByteBuffer(item2));
				list.Add(rootAsBehaviorCommonButton);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BehaviorCommonButtonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBehaviorCommonButtonAll.HandleId, ConfigBehaviorCommonButtonAll.LogPair);
			return list;
		}

		// Token: 0x040006C8 RID: 1736
		private const string DB = "db_skillbutton.db";

		// Token: 0x040006C9 RID: 1737
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040006CA RID: 1738
		private const string TABLE = "BehaviorCommonButton";

		// Token: 0x040006CB RID: 1739
		private const string COMMAND = "select BinData from `BehaviorCommonButton`";

		// Token: 0x040006CC RID: 1740
		private const string KEY_PREFIX = "BehaviorCommonButtonAll";

		// Token: 0x040006CD RID: 1741
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006CE RID: 1742
		private static int HandleId;
	}
}
