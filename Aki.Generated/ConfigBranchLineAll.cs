using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011A RID: 282
	public class ConfigBranchLineAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x0007F008 File Offset: 0x0007D208
		static ConfigBranchLineAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBranchLineAll.CreateStaticDefaultValue), new Action(ConfigBranchLineAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0007F028 File Offset: 0x0007D228
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

		// Token: 0x0600069F RID: 1695 RVA: 0x0007F0A7 File Offset: 0x0007D2A7
		public static void ResetStaticDefaultValue()
		{
			ConfigBranchLineAll.LogPair = null;
			ConfigBranchLineAll.HandleId = 0;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0007F0B5 File Offset: 0x0007D2B5
		public static void Init()
		{
			ConfigBranchLineAll.HandleId = ConfigCommon.InitDataStatement(ConfigBranchLineAll.HandleId, "db_moonchasing.db", "select BinData from `BranchLine`");
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0007F0D0 File Offset: 0x0007D2D0
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

		// Token: 0x0400079A RID: 1946
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400079B RID: 1947
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400079C RID: 1948
		private const string TABLE = "BranchLine";

		// Token: 0x0400079D RID: 1949
		private const string COMMAND = "select BinData from `BranchLine`";

		// Token: 0x0400079E RID: 1950
		private const string KEY_PREFIX = "BranchLineAll";

		// Token: 0x0400079F RID: 1951
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007A0 RID: 1952
		private static int HandleId;
	}
}
