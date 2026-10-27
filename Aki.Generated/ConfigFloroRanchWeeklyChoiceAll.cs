using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000333 RID: 819
	public class ConfigFloroRanchWeeklyChoiceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x000C5F68 File Offset: 0x000C4168
		static ConfigFloroRanchWeeklyChoiceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyChoiceAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyChoiceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000C5F88 File Offset: 0x000C4188
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

		// Token: 0x06001339 RID: 4921 RVA: 0x000C6007 File Offset: 0x000C4207
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyChoiceAll.LogPair = null;
			ConfigFloroRanchWeeklyChoiceAll.HandleId = 0;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000C6015 File Offset: 0x000C4215
		public static void Init()
		{
			ConfigFloroRanchWeeklyChoiceAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyChoiceAll.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyChoice`");
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000C6030 File Offset: 0x000C4230
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

		// Token: 0x04001649 RID: 5705
		private const string DB = "db_flororanchevent.db";

		// Token: 0x0400164A RID: 5706
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x0400164B RID: 5707
		private const string TABLE = "FloroRanchWeeklyChoice";

		// Token: 0x0400164C RID: 5708
		private const string COMMAND = "select BinData from `FloroRanchWeeklyChoice`";

		// Token: 0x0400164D RID: 5709
		private const string KEY_PREFIX = "FloroRanchWeeklyChoiceAll";

		// Token: 0x0400164E RID: 5710
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400164F RID: 5711
		private static int HandleId;
	}
}
