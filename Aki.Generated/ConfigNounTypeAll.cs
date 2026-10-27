using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000617 RID: 1559
	public class ConfigNounTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600249A RID: 9370 RVA: 0x001288BB File Offset: 0x00126ABB
		static ConfigNounTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounTypeAll.CreateStaticDefaultValue), new Action(ConfigNounTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x001288DC File Offset: 0x00126ADC
		public static void CreateStaticDefaultValue()
		{
			ConfigNounTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNounTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "NounType"),
				new ValueTuple<string, object>("语句", "select BinData from `NounType`")
			});
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x0012895B File Offset: 0x00126B5B
		public static void ResetStaticDefaultValue()
		{
			ConfigNounTypeAll.LogPair = null;
			ConfigNounTypeAll.HandleId = 0;
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00128969 File Offset: 0x00126B69
		public static void Init()
		{
			ConfigNounTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigNounTypeAll.HandleId, "db_handbook.db", "select BinData from `NounType`");
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00128984 File Offset: 0x00126B84
		[NullableContext(2)]
		public static IReadOnlyList<NounType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNounTypeAll.HandleId, ConfigNounTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NounType> readOnlyList = (IReadOnlyList<NounType>)ConfigCommon.GetConfig("NounTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NounType> list = new List<NounType>();
			while (ConfigCommon.Step(ConfigNounTypeAll.HandleId, false, ConfigNounTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNounTypeAll.HandleId, 0, ConfigNounTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNounTypeAll.HandleId, ConfigNounTypeAll.LogPair);
					return null;
				}
				NounType rootAsNounType = NounType.GetRootAsNounType(new ByteBuffer(item2));
				list.Add(rootAsNounType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NounTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNounTypeAll.HandleId, ConfigNounTypeAll.LogPair);
			return list;
		}

		// Token: 0x04002A87 RID: 10887
		private const string DB = "db_handbook.db";

		// Token: 0x04002A88 RID: 10888
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002A89 RID: 10889
		private const string TABLE = "NounType";

		// Token: 0x04002A8A RID: 10890
		private const string COMMAND = "select BinData from `NounType`";

		// Token: 0x04002A8B RID: 10891
		private const string KEY_PREFIX = "NounTypeAll";

		// Token: 0x04002A8C RID: 10892
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A8D RID: 10893
		private static int HandleId;
	}
}
