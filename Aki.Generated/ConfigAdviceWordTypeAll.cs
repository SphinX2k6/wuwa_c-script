using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007D RID: 125
	public class ConfigAdviceWordTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002EE RID: 750 RVA: 0x0006A057 File Offset: 0x00068257
		static ConfigAdviceWordTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordTypeAll.CreateStaticDefaultValue), new Action(ConfigAdviceWordTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0006A078 File Offset: 0x00068278
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceWordTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceWordTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceWordType"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceWordType`")
			});
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0006A0F7 File Offset: 0x000682F7
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordTypeAll.LogPair = null;
			ConfigAdviceWordTypeAll.HandleId = 0;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0006A105 File Offset: 0x00068305
		public static void Init()
		{
			ConfigAdviceWordTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordTypeAll.HandleId, "db_advice.db", "select BinData from `AdviceWordType`");
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0006A120 File Offset: 0x00068320
		[NullableContext(2)]
		public static IReadOnlyList<AdviceWordType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceWordTypeAll.HandleId, ConfigAdviceWordTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdviceWordType> readOnlyList = (IReadOnlyList<AdviceWordType>)ConfigCommon.GetConfig("AdviceWordTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdviceWordType> list = new List<AdviceWordType>();
			while (ConfigCommon.Step(ConfigAdviceWordTypeAll.HandleId, false, ConfigAdviceWordTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceWordTypeAll.HandleId, 0, ConfigAdviceWordTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdviceWordTypeAll.HandleId, ConfigAdviceWordTypeAll.LogPair);
					return null;
				}
				AdviceWordType rootAsAdviceWordType = AdviceWordType.GetRootAsAdviceWordType(new ByteBuffer(item2));
				list.Add(rootAsAdviceWordType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdviceWordTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdviceWordTypeAll.HandleId, ConfigAdviceWordTypeAll.LogPair);
			return list;
		}

		// Token: 0x0400034F RID: 847
		private const string DB = "db_advice.db";

		// Token: 0x04000350 RID: 848
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000351 RID: 849
		private const string TABLE = "AdviceWordType";

		// Token: 0x04000352 RID: 850
		private const string COMMAND = "select BinData from `AdviceWordType`";

		// Token: 0x04000353 RID: 851
		private const string KEY_PREFIX = "AdviceWordTypeAll";

		// Token: 0x04000354 RID: 852
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000355 RID: 853
		private static int HandleId;
	}
}
