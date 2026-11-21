using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A1 RID: 417
	public class ConfigCompositeRewardDisplayAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009C8 RID: 2504 RVA: 0x0009466C File Offset: 0x0009286C
		static ConfigCompositeRewardDisplayAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCompositeRewardDisplayAll.CreateStaticDefaultValue), new Action(ConfigCompositeRewardDisplayAll.ResetStaticDefaultValue));
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0009468C File Offset: 0x0009288C
		public static void CreateStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCompositeRewardDisplayAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rewardui.db"),
				new ValueTuple<string, object>("文件", "j.奖励界面表现.xlsx"),
				new ValueTuple<string, object>("表名", "CompositeRewardDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `CompositeRewardDisplay`")
			});
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0009470B File Offset: 0x0009290B
		public static void ResetStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayAll.LogPair = null;
			ConfigCompositeRewardDisplayAll.HandleId = 0;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00094719 File Offset: 0x00092919
		public static void Init()
		{
			ConfigCompositeRewardDisplayAll.HandleId = ConfigCommon.InitDataStatement(ConfigCompositeRewardDisplayAll.HandleId, "db_rewardui.db", "select BinData from `CompositeRewardDisplay`");
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00094734 File Offset: 0x00092934
		[NullableContext(2)]
		public static IReadOnlyList<CompositeRewardDisplay> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCompositeRewardDisplayAll.HandleId, ConfigCompositeRewardDisplayAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CompositeRewardDisplay> readOnlyList = (IReadOnlyList<CompositeRewardDisplay>)ConfigCommon.GetConfig("CompositeRewardDisplayAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CompositeRewardDisplay> list = new List<CompositeRewardDisplay>();
			while (ConfigCommon.Step(ConfigCompositeRewardDisplayAll.HandleId, false, ConfigCompositeRewardDisplayAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCompositeRewardDisplayAll.HandleId, 0, ConfigCompositeRewardDisplayAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCompositeRewardDisplayAll.HandleId, ConfigCompositeRewardDisplayAll.LogPair);
					return null;
				}
				CompositeRewardDisplay rootAsCompositeRewardDisplay = CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(new ByteBuffer(item2));
				list.Add(rootAsCompositeRewardDisplay);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CompositeRewardDisplayAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCompositeRewardDisplayAll.HandleId, ConfigCompositeRewardDisplayAll.LogPair);
			return list;
		}

		// Token: 0x04000B4B RID: 2891
		private const string DB = "db_rewardui.db";

		// Token: 0x04000B4C RID: 2892
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000B4D RID: 2893
		private const string TABLE = "CompositeRewardDisplay";

		// Token: 0x04000B4E RID: 2894
		private const string COMMAND = "select BinData from `CompositeRewardDisplay`";

		// Token: 0x04000B4F RID: 2895
		private const string KEY_PREFIX = "CompositeRewardDisplayAll";

		// Token: 0x04000B50 RID: 2896
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B51 RID: 2897
		private static int HandleId;
	}
}
