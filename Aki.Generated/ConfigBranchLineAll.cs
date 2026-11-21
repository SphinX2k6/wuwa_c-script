using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000129 RID: 297
	public class ConfigBranchLineAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x0008496C File Offset: 0x00082B6C
		static ConfigBranchLineAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBranchLineAll.CreateStaticDefaultValue), new Action(ConfigBranchLineAll.ResetStaticDefaultValue));
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0008498C File Offset: 0x00082B8C
		public static void CreateStaticDefaultValue()
		{
			ConfigBranchLineAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBranchLineAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "BranchLine"),
				new ValueTuple<string, object>("语句", "select BinData from `BranchLine`")
			});
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00084A0B File Offset: 0x00082C0B
		public static void ResetStaticDefaultValue()
		{
			ConfigBranchLineAll.LogPair = null;
			ConfigBranchLineAll.HandleId = 0;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00084A19 File Offset: 0x00082C19
		public static void Init()
		{
			ConfigBranchLineAll.HandleId = ConfigCommon.InitDataStatement(ConfigBranchLineAll.HandleId, "db_moonchasing.db", "select BinData from `BranchLine`");
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00084A34 File Offset: 0x00082C34
		[NullableContext(2)]
		public static IReadOnlyList<BranchLine> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBranchLineAll.HandleId, ConfigBranchLineAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BranchLine> readOnlyList = (IReadOnlyList<BranchLine>)ConfigCommon.GetConfig("BranchLineAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BranchLine> list = new List<BranchLine>();
			while (ConfigCommon.Step(ConfigBranchLineAll.HandleId, false, ConfigBranchLineAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBranchLineAll.HandleId, 0, ConfigBranchLineAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBranchLineAll.HandleId, ConfigBranchLineAll.LogPair);
					return null;
				}
				BranchLine rootAsBranchLine = BranchLine.GetRootAsBranchLine(new ByteBuffer(item2));
				list.Add(rootAsBranchLine);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BranchLineAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBranchLineAll.HandleId, ConfigBranchLineAll.LogPair);
			return list;
		}

		// Token: 0x04000803 RID: 2051
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000804 RID: 2052
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04000805 RID: 2053
		private const string TABLE = "BranchLine";

		// Token: 0x04000806 RID: 2054
		private const string COMMAND = "select BinData from `BranchLine`";

		// Token: 0x04000807 RID: 2055
		private const string KEY_PREFIX = "BranchLineAll";

		// Token: 0x04000808 RID: 2056
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000809 RID: 2057
		private static int HandleId;
	}
}
