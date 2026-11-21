using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047E RID: 1150
	public class ConfigKeyPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AFE RID: 6910 RVA: 0x000F58A8 File Offset: 0x000F3AA8
		static ConfigKeyPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyPoolAll.CreateStaticDefaultValue), new Action(ConfigKeyPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000F58C8 File Offset: 0x000F3AC8
		public static void CreateStaticDefaultValue()
		{
			ConfigKeyPoolAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeyPoolAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeyPool"),
				new ValueTuple<string, object>("语句", "select BinData from `KeyPool`")
			});
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x000F5947 File Offset: 0x000F3B47
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyPoolAll.LogPair = null;
			ConfigKeyPoolAll.HandleId = 0;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000F5955 File Offset: 0x000F3B55
		public static void Init()
		{
			ConfigKeyPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigKeyPoolAll.HandleId, "db_menu.db", "select BinData from `KeyPool`");
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000F5970 File Offset: 0x000F3B70
		[NullableContext(2)]
		public static IReadOnlyList<KeyPool> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeyPoolAll.HandleId, ConfigKeyPoolAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KeyPool> readOnlyList = (IReadOnlyList<KeyPool>)ConfigCommon.GetConfig("KeyPoolAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KeyPool> list = new List<KeyPool>();
			while (ConfigCommon.Step(ConfigKeyPoolAll.HandleId, false, ConfigKeyPoolAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeyPoolAll.HandleId, 0, ConfigKeyPoolAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKeyPoolAll.HandleId, ConfigKeyPoolAll.LogPair);
					return null;
				}
				KeyPool rootAsKeyPool = KeyPool.GetRootAsKeyPool(new ByteBuffer(item2));
				list.Add(rootAsKeyPool);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KeyPoolAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKeyPoolAll.HandleId, ConfigKeyPoolAll.LogPair);
			return list;
		}

		// Token: 0x04001F56 RID: 8022
		private const string DB = "db_menu.db";

		// Token: 0x04001F57 RID: 8023
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F58 RID: 8024
		private const string TABLE = "KeyPool";

		// Token: 0x04001F59 RID: 8025
		private const string COMMAND = "select BinData from `KeyPool`";

		// Token: 0x04001F5A RID: 8026
		private const string KEY_PREFIX = "KeyPoolAll";

		// Token: 0x04001F5B RID: 8027
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F5C RID: 8028
		private static int HandleId;
	}
}
