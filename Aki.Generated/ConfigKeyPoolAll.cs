using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000468 RID: 1128
	public class ConfigKeyPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x000EF154 File Offset: 0x000ED354
		static ConfigKeyPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyPoolAll.CreateStaticDefaultValue), new Action(ConfigKeyPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000EF174 File Offset: 0x000ED374
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

		// Token: 0x06001A7C RID: 6780 RVA: 0x000EF1F3 File Offset: 0x000ED3F3
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyPoolAll.LogPair = null;
			ConfigKeyPoolAll.HandleId = 0;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000EF201 File Offset: 0x000ED401
		public static void Init()
		{
			ConfigKeyPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigKeyPoolAll.HandleId, "db_menu.db", "select BinData from `KeyPool`");
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x000EF21C File Offset: 0x000ED41C
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

		// Token: 0x04001EBC RID: 7868
		private const string DB = "db_menu.db";

		// Token: 0x04001EBD RID: 7869
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001EBE RID: 7870
		private const string TABLE = "KeyPool";

		// Token: 0x04001EBF RID: 7871
		private const string COMMAND = "select BinData from `KeyPool`";

		// Token: 0x04001EC0 RID: 7872
		private const string KEY_PREFIX = "KeyPoolAll";

		// Token: 0x04001EC1 RID: 7873
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EC2 RID: 7874
		private static int HandleId;
	}
}
