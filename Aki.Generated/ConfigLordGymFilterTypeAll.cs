using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000513 RID: 1299
	public class ConfigLordGymFilterTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E7D RID: 7805 RVA: 0x00109214 File Offset: 0x00107414
		static ConfigLordGymFilterTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymFilterTypeAll.CreateStaticDefaultValue), new Action(ConfigLordGymFilterTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00109234 File Offset: 0x00107434
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymFilterTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymFilterTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymFilterType`")
			});
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x001092B3 File Offset: 0x001074B3
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymFilterTypeAll.LogPair = null;
			ConfigLordGymFilterTypeAll.HandleId = 0;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x001092C1 File Offset: 0x001074C1
		public static void Init()
		{
			ConfigLordGymFilterTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymFilterTypeAll.HandleId, "db_lordgym.db", "select BinData from `LordGymFilterType`");
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x001092DC File Offset: 0x001074DC
		[NullableContext(2)]
		public static IReadOnlyList<LordGymFilterType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymFilterTypeAll.HandleId, ConfigLordGymFilterTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LordGymFilterType> readOnlyList = (IReadOnlyList<LordGymFilterType>)ConfigCommon.GetConfig("LordGymFilterTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LordGymFilterType> list = new List<LordGymFilterType>();
			while (ConfigCommon.Step(ConfigLordGymFilterTypeAll.HandleId, false, ConfigLordGymFilterTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymFilterTypeAll.HandleId, 0, ConfigLordGymFilterTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymFilterTypeAll.HandleId, ConfigLordGymFilterTypeAll.LogPair);
					return null;
				}
				LordGymFilterType rootAsLordGymFilterType = LordGymFilterType.GetRootAsLordGymFilterType(new ByteBuffer(item2));
				list.Add(rootAsLordGymFilterType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LordGymFilterTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymFilterTypeAll.HandleId, ConfigLordGymFilterTypeAll.LogPair);
			return list;
		}

		// Token: 0x04002369 RID: 9065
		private const string DB = "db_lordgym.db";

		// Token: 0x0400236A RID: 9066
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x0400236B RID: 9067
		private const string TABLE = "LordGymFilterType";

		// Token: 0x0400236C RID: 9068
		private const string COMMAND = "select BinData from `LordGymFilterType`";

		// Token: 0x0400236D RID: 9069
		private const string KEY_PREFIX = "LordGymFilterTypeAll";

		// Token: 0x0400236E RID: 9070
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400236F RID: 9071
		private static int HandleId;
	}
}
