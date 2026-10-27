using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031A RID: 794
	public class ConfigFloroRanchFilterTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x000C2C40 File Offset: 0x000C0E40
		static ConfigFloroRanchFilterTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchFilterTypeAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchFilterTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000C2C60 File Offset: 0x000C0E60
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchFilterTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchFilterType`")
			});
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000C2CDF File Offset: 0x000C0EDF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeAll.LogPair = null;
			ConfigFloroRanchFilterTypeAll.HandleId = 0;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000C2CED File Offset: 0x000C0EED
		public static void Init()
		{
			ConfigFloroRanchFilterTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchFilterTypeAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchFilterType`");
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000C2D08 File Offset: 0x000C0F08
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchFilterType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchFilterTypeAll.HandleId, ConfigFloroRanchFilterTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchFilterType> readOnlyList = (IReadOnlyList<FloroRanchFilterType>)ConfigCommon.GetConfig("FloroRanchFilterTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchFilterType> list = new List<FloroRanchFilterType>();
			while (ConfigCommon.Step(ConfigFloroRanchFilterTypeAll.HandleId, false, ConfigFloroRanchFilterTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchFilterTypeAll.HandleId, 0, ConfigFloroRanchFilterTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchFilterTypeAll.HandleId, ConfigFloroRanchFilterTypeAll.LogPair);
					return null;
				}
				FloroRanchFilterType rootAsFloroRanchFilterType = FloroRanchFilterType.GetRootAsFloroRanchFilterType(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchFilterType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchFilterTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchFilterTypeAll.HandleId, ConfigFloroRanchFilterTypeAll.LogPair);
			return list;
		}

		// Token: 0x0400159A RID: 5530
		private const string DB = "db_flororanch.db";

		// Token: 0x0400159B RID: 5531
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400159C RID: 5532
		private const string TABLE = "FloroRanchFilterType";

		// Token: 0x0400159D RID: 5533
		private const string COMMAND = "select BinData from `FloroRanchFilterType`";

		// Token: 0x0400159E RID: 5534
		private const string KEY_PREFIX = "FloroRanchFilterTypeAll";

		// Token: 0x0400159F RID: 5535
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015A0 RID: 5536
		private static int HandleId;
	}
}
