using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000348 RID: 840
	public class ConfigFloroRanchWeeklyChoiceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013B5 RID: 5045 RVA: 0x000CC474 File Offset: 0x000CA674
		static ConfigFloroRanchWeeklyChoiceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyChoiceAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyChoiceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000CC494 File Offset: 0x000CA694
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyChoiceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchWeeklyChoiceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchevent.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_事件.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchWeeklyChoice"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchWeeklyChoice`")
			});
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000CC513 File Offset: 0x000CA713
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyChoiceAll.LogPair = null;
			ConfigFloroRanchWeeklyChoiceAll.HandleId = 0;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000CC521 File Offset: 0x000CA721
		public static void Init()
		{
			ConfigFloroRanchWeeklyChoiceAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyChoiceAll.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyChoice`");
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000CC53C File Offset: 0x000CA73C
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchWeeklyChoice> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchWeeklyChoiceAll.HandleId, ConfigFloroRanchWeeklyChoiceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchWeeklyChoice> readOnlyList = (IReadOnlyList<FloroRanchWeeklyChoice>)ConfigCommon.GetConfig("FloroRanchWeeklyChoiceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchWeeklyChoice> list = new List<FloroRanchWeeklyChoice>();
			while (ConfigCommon.Step(ConfigFloroRanchWeeklyChoiceAll.HandleId, false, ConfigFloroRanchWeeklyChoiceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchWeeklyChoiceAll.HandleId, 0, ConfigFloroRanchWeeklyChoiceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchWeeklyChoiceAll.HandleId, ConfigFloroRanchWeeklyChoiceAll.LogPair);
					return null;
				}
				FloroRanchWeeklyChoice rootAsFloroRanchWeeklyChoice = FloroRanchWeeklyChoice.GetRootAsFloroRanchWeeklyChoice(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchWeeklyChoice);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchWeeklyChoiceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchWeeklyChoiceAll.HandleId, ConfigFloroRanchWeeklyChoiceAll.LogPair);
			return list;
		}

		// Token: 0x040016DC RID: 5852
		private const string DB = "db_flororanchevent.db";

		// Token: 0x040016DD RID: 5853
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x040016DE RID: 5854
		private const string TABLE = "FloroRanchWeeklyChoice";

		// Token: 0x040016DF RID: 5855
		private const string COMMAND = "select BinData from `FloroRanchWeeklyChoice`";

		// Token: 0x040016E0 RID: 5856
		private const string KEY_PREFIX = "FloroRanchWeeklyChoiceAll";

		// Token: 0x040016E1 RID: 5857
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016E2 RID: 5858
		private static int HandleId;
	}
}
