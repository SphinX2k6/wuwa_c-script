using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200046F RID: 1135
	public class ConfigKeyTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AA4 RID: 6820 RVA: 0x000F0068 File Offset: 0x000EE268
		static ConfigKeyTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyTypeAll.CreateStaticDefaultValue), new Action(ConfigKeyTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000F0088 File Offset: 0x000EE288
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

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000F0107 File Offset: 0x000EE307
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyTypeAll.LogPair = null;
			ConfigKeyTypeAll.HandleId = 0;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000F0115 File Offset: 0x000EE315
		public static void Init()
		{
			ConfigKeyTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigKeyTypeAll.HandleId, "db_menu.db", "select BinData from `KeyType`");
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000F0130 File Offset: 0x000EE330
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

		// Token: 0x04001EED RID: 7917
		private const string DB = "db_menu.db";

		// Token: 0x04001EEE RID: 7918
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001EEF RID: 7919
		private const string TABLE = "KeyType";

		// Token: 0x04001EF0 RID: 7920
		private const string COMMAND = "select BinData from `KeyType`";

		// Token: 0x04001EF1 RID: 7921
		private const string KEY_PREFIX = "KeyTypeAll";

		// Token: 0x04001EF2 RID: 7922
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EF3 RID: 7923
		private static int HandleId;
	}
}
