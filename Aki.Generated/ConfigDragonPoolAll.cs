using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022E RID: 558
	public class ConfigDragonPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D17 RID: 3351 RVA: 0x000A71B8 File Offset: 0x000A53B8
		static ConfigDragonPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDragonPoolAll.CreateStaticDefaultValue), new Action(ConfigDragonPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000A71D8 File Offset: 0x000A53D8
		public static void CreateStaticDefaultValue()
		{
			ConfigDragonPoolAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDragonPoolAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dragon_ball.db"),
				new ValueTuple<string, object>("文件", "m.鸣素体.xlsx"),
				new ValueTuple<string, object>("表名", "DragonPool"),
				new ValueTuple<string, object>("语句", "select BinData from `DragonPool`")
			});
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000A7257 File Offset: 0x000A5457
		public static void ResetStaticDefaultValue()
		{
			ConfigDragonPoolAll.LogPair = null;
			ConfigDragonPoolAll.HandleId = 0;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000A7265 File Offset: 0x000A5465
		public static void Init()
		{
			ConfigDragonPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigDragonPoolAll.HandleId, "db_dragon_ball.db", "select BinData from `DragonPool`");
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000A7280 File Offset: 0x000A5480
		[NullableContext(2)]
		public static IReadOnlyList<DragonPool> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDragonPoolAll.HandleId, ConfigDragonPoolAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DragonPool> readOnlyList = (IReadOnlyList<DragonPool>)ConfigCommon.GetConfig("DragonPoolAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DragonPool> list = new List<DragonPool>();
			while (ConfigCommon.Step(ConfigDragonPoolAll.HandleId, false, ConfigDragonPoolAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDragonPoolAll.HandleId, 0, ConfigDragonPoolAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDragonPoolAll.HandleId, ConfigDragonPoolAll.LogPair);
					return null;
				}
				DragonPool rootAsDragonPool = DragonPool.GetRootAsDragonPool(new ByteBuffer(item2));
				list.Add(rootAsDragonPool);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DragonPoolAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDragonPoolAll.HandleId, ConfigDragonPoolAll.LogPair);
			return list;
		}

		// Token: 0x04000F26 RID: 3878
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000F27 RID: 3879
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000F28 RID: 3880
		private const string TABLE = "DragonPool";

		// Token: 0x04000F29 RID: 3881
		private const string COMMAND = "select BinData from `DragonPool`";

		// Token: 0x04000F2A RID: 3882
		private const string KEY_PREFIX = "DragonPoolAll";

		// Token: 0x04000F2B RID: 3883
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F2C RID: 3884
		private static int HandleId;
	}
}
