using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062F RID: 1583
	public class ConfigNounTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600252A RID: 9514 RVA: 0x0012F337 File Offset: 0x0012D537
		static ConfigNounTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounTypeAll.CreateStaticDefaultValue), new Action(ConfigNounTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x0012F358 File Offset: 0x0012D558
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

		// Token: 0x0600252C RID: 9516 RVA: 0x0012F3D7 File Offset: 0x0012D5D7
		public static void ResetStaticDefaultValue()
		{
			ConfigNounTypeAll.LogPair = null;
			ConfigNounTypeAll.HandleId = 0;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x0012F3E5 File Offset: 0x0012D5E5
		public static void Init()
		{
			ConfigNounTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigNounTypeAll.HandleId, "db_handbook.db", "select BinData from `NounType`");
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x0012F400 File Offset: 0x0012D600
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

		// Token: 0x04002B2F RID: 11055
		private const string DB = "db_handbook.db";

		// Token: 0x04002B30 RID: 11056
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002B31 RID: 11057
		private const string TABLE = "NounType";

		// Token: 0x04002B32 RID: 11058
		private const string COMMAND = "select BinData from `NounType`";

		// Token: 0x04002B33 RID: 11059
		private const string KEY_PREFIX = "NounTypeAll";

		// Token: 0x04002B34 RID: 11060
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B35 RID: 11061
		private static int HandleId;
	}
}
