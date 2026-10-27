using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000912 RID: 2322
	public class ConfigSheriffClueAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600367F RID: 13951 RVA: 0x0018D6D0 File Offset: 0x0018B8D0
		static ConfigSheriffClueAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffClueAll.CreateStaticDefaultValue), new Action(ConfigSheriffClueAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x0018D6F0 File Offset: 0x0018B8F0
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffClueAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffClueAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffClue"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffClue`")
			});
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x0018D76F File Offset: 0x0018B96F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffClueAll.LogPair = null;
			ConfigSheriffClueAll.HandleId = 0;
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x0018D77D File Offset: 0x0018B97D
		public static void Init()
		{
			ConfigSheriffClueAll.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffClueAll.HandleId, "db_sheriff.db", "select BinData from `SheriffClue`");
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x0018D798 File Offset: 0x0018B998
		[NullableContext(2)]
		public static IReadOnlyList<SheriffClue> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffClueAll.HandleId, ConfigSheriffClueAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SheriffClue> readOnlyList = (IReadOnlyList<SheriffClue>)ConfigCommon.GetConfig("SheriffClueAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SheriffClue> list = new List<SheriffClue>();
			while (ConfigCommon.Step(ConfigSheriffClueAll.HandleId, false, ConfigSheriffClueAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffClueAll.HandleId, 0, ConfigSheriffClueAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffClueAll.HandleId, ConfigSheriffClueAll.LogPair);
					return null;
				}
				SheriffClue rootAsSheriffClue = SheriffClue.GetRootAsSheriffClue(new ByteBuffer(item2));
				list.Add(rootAsSheriffClue);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SheriffClueAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffClueAll.HandleId, ConfigSheriffClueAll.LogPair);
			return list;
		}

		// Token: 0x04003F64 RID: 16228
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F65 RID: 16229
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F66 RID: 16230
		private const string TABLE = "SheriffClue";

		// Token: 0x04003F67 RID: 16231
		private const string COMMAND = "select BinData from `SheriffClue`";

		// Token: 0x04003F68 RID: 16232
		private const string KEY_PREFIX = "SheriffClueAll";

		// Token: 0x04003F69 RID: 16233
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F6A RID: 16234
		private static int HandleId;
	}
}
