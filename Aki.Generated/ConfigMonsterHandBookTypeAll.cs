using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000569 RID: 1385
	public class ConfigMonsterHandBookTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x00114AEB File Offset: 0x00112CEB
		static ConfigMonsterHandBookTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookTypeAll.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00114B0C File Offset: 0x00112D0C
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

		// Token: 0x06002085 RID: 8325 RVA: 0x00114B8B File Offset: 0x00112D8B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookTypeAll.LogPair = null;
			ConfigMonsterHandBookTypeAll.HandleId = 0;
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00114B99 File Offset: 0x00112D99
		public static void Init()
		{
			ConfigMonsterHandBookTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookTypeAll.HandleId, "db_handbook.db", "select BinData from `MonsterHandBookType`");
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00114BB4 File Offset: 0x00112DB4
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

		// Token: 0x040025C3 RID: 9667
		private const string DB = "db_handbook.db";

		// Token: 0x040025C4 RID: 9668
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040025C5 RID: 9669
		private const string TABLE = "MonsterHandBookType";

		// Token: 0x040025C6 RID: 9670
		private const string COMMAND = "select BinData from `MonsterHandBookType`";

		// Token: 0x040025C7 RID: 9671
		private const string KEY_PREFIX = "MonsterHandBookTypeAll";

		// Token: 0x040025C8 RID: 9672
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025C9 RID: 9673
		private static int HandleId;
	}
}
