using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000553 RID: 1363
	public class ConfigMonsterHandBookTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FFF RID: 8191 RVA: 0x0010E397 File Offset: 0x0010C597
		static ConfigMonsterHandBookTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookTypeAll.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0010E3B8 File Offset: 0x0010C5B8
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterHandBookTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterHandBookTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterHandBookType"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterHandBookType`")
			});
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0010E437 File Offset: 0x0010C637
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookTypeAll.LogPair = null;
			ConfigMonsterHandBookTypeAll.HandleId = 0;
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0010E445 File Offset: 0x0010C645
		public static void Init()
		{
			ConfigMonsterHandBookTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookTypeAll.HandleId, "db_handbook.db", "select BinData from `MonsterHandBookType`");
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0010E460 File Offset: 0x0010C660
		[NullableContext(2)]
		public static IReadOnlyList<MonsterHandBookType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterHandBookTypeAll.HandleId, ConfigMonsterHandBookTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MonsterHandBookType> readOnlyList = (IReadOnlyList<MonsterHandBookType>)ConfigCommon.GetConfig("MonsterHandBookTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MonsterHandBookType> list = new List<MonsterHandBookType>();
			while (ConfigCommon.Step(ConfigMonsterHandBookTypeAll.HandleId, false, ConfigMonsterHandBookTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterHandBookTypeAll.HandleId, 0, ConfigMonsterHandBookTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMonsterHandBookTypeAll.HandleId, ConfigMonsterHandBookTypeAll.LogPair);
					return null;
				}
				MonsterHandBookType rootAsMonsterHandBookType = MonsterHandBookType.GetRootAsMonsterHandBookType(new ByteBuffer(item2));
				list.Add(rootAsMonsterHandBookType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MonsterHandBookTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMonsterHandBookTypeAll.HandleId, ConfigMonsterHandBookTypeAll.LogPair);
			return list;
		}

		// Token: 0x04002529 RID: 9513
		private const string DB = "db_handbook.db";

		// Token: 0x0400252A RID: 9514
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400252B RID: 9515
		private const string TABLE = "MonsterHandBookType";

		// Token: 0x0400252C RID: 9516
		private const string COMMAND = "select BinData from `MonsterHandBookType`";

		// Token: 0x0400252D RID: 9517
		private const string KEY_PREFIX = "MonsterHandBookTypeAll";

		// Token: 0x0400252E RID: 9518
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400252F RID: 9519
		private static int HandleId;
	}
}
