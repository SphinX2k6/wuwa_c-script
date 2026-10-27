using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018F RID: 399
	public class ConfigCompositeRewardDisplayAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600095C RID: 2396 RVA: 0x0008E734 File Offset: 0x0008C934
		static ConfigCompositeRewardDisplayAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCompositeRewardDisplayAll.CreateStaticDefaultValue), new Action(ConfigCompositeRewardDisplayAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0008E754 File Offset: 0x0008C954
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

		// Token: 0x0600095E RID: 2398 RVA: 0x0008E7D3 File Offset: 0x0008C9D3
		public static void ResetStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayAll.LogPair = null;
			ConfigCompositeRewardDisplayAll.HandleId = 0;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0008E7E1 File Offset: 0x0008C9E1
		public static void Init()
		{
			ConfigCompositeRewardDisplayAll.HandleId = ConfigCommon.InitDataStatement(ConfigCompositeRewardDisplayAll.HandleId, "db_rewardui.db", "select BinData from `CompositeRewardDisplay`");
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0008E7FC File Offset: 0x0008C9FC
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

		// Token: 0x04000ACD RID: 2765
		private const string DB = "db_rewardui.db";

		// Token: 0x04000ACE RID: 2766
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000ACF RID: 2767
		private const string TABLE = "CompositeRewardDisplay";

		// Token: 0x04000AD0 RID: 2768
		private const string COMMAND = "select BinData from `CompositeRewardDisplay`";

		// Token: 0x04000AD1 RID: 2769
		private const string KEY_PREFIX = "CompositeRewardDisplayAll";

		// Token: 0x04000AD2 RID: 2770
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AD3 RID: 2771
		private static int HandleId;
	}
}
