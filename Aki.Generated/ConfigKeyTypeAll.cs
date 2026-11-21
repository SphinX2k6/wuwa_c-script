using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000485 RID: 1157
	public class ConfigKeyTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x000F67BC File Offset: 0x000F49BC
		static ConfigKeyTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyTypeAll.CreateStaticDefaultValue), new Action(ConfigKeyTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000F67DC File Offset: 0x000F49DC
		public static void CreateStaticDefaultValue()
		{
			ConfigKeyTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeyTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeyType"),
				new ValueTuple<string, object>("语句", "select BinData from `KeyType`")
			});
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000F685B File Offset: 0x000F4A5B
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyTypeAll.LogPair = null;
			ConfigKeyTypeAll.HandleId = 0;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000F6869 File Offset: 0x000F4A69
		public static void Init()
		{
			ConfigKeyTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigKeyTypeAll.HandleId, "db_menu.db", "select BinData from `KeyType`");
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000F6884 File Offset: 0x000F4A84
		[NullableContext(2)]
		public static IReadOnlyList<KeyType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeyTypeAll.HandleId, ConfigKeyTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KeyType> readOnlyList = (IReadOnlyList<KeyType>)ConfigCommon.GetConfig("KeyTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KeyType> list = new List<KeyType>();
			while (ConfigCommon.Step(ConfigKeyTypeAll.HandleId, false, ConfigKeyTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeyTypeAll.HandleId, 0, ConfigKeyTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKeyTypeAll.HandleId, ConfigKeyTypeAll.LogPair);
					return null;
				}
				KeyType rootAsKeyType = KeyType.GetRootAsKeyType(new ByteBuffer(item2));
				list.Add(rootAsKeyType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KeyTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKeyTypeAll.HandleId, ConfigKeyTypeAll.LogPair);
			return list;
		}

		// Token: 0x04001F87 RID: 8071
		private const string DB = "db_menu.db";

		// Token: 0x04001F88 RID: 8072
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F89 RID: 8073
		private const string TABLE = "KeyType";

		// Token: 0x04001F8A RID: 8074
		private const string COMMAND = "select BinData from `KeyType`";

		// Token: 0x04001F8B RID: 8075
		private const string KEY_PREFIX = "KeyTypeAll";

		// Token: 0x04001F8C RID: 8076
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F8D RID: 8077
		private static int HandleId;
	}
}
