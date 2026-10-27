using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000ED RID: 237
	public class ConfigBehaviorCommonButtonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x000791D4 File Offset: 0x000773D4
		static ConfigBehaviorCommonButtonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBehaviorCommonButtonAll.CreateStaticDefaultValue), new Action(ConfigBehaviorCommonButtonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000791F4 File Offset: 0x000773F4
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

		// Token: 0x06000591 RID: 1425 RVA: 0x00079273 File Offset: 0x00077473
		public static void ResetStaticDefaultValue()
		{
			ConfigBehaviorCommonButtonAll.LogPair = null;
			ConfigBehaviorCommonButtonAll.HandleId = 0;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00079281 File Offset: 0x00077481
		public static void Init()
		{
			ConfigBehaviorCommonButtonAll.HandleId = ConfigCommon.InitDataStatement(ConfigBehaviorCommonButtonAll.HandleId, "db_skillbutton.db", "select BinData from `BehaviorCommonButton`");
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0007929C File Offset: 0x0007749C
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

		// Token: 0x0400065F RID: 1631
		private const string DB = "db_skillbutton.db";

		// Token: 0x04000660 RID: 1632
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04000661 RID: 1633
		private const string TABLE = "BehaviorCommonButton";

		// Token: 0x04000662 RID: 1634
		private const string COMMAND = "select BinData from `BehaviorCommonButton`";

		// Token: 0x04000663 RID: 1635
		private const string KEY_PREFIX = "BehaviorCommonButtonAll";

		// Token: 0x04000664 RID: 1636
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000665 RID: 1637
		private static int HandleId;
	}
}
