using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021C RID: 540
	public class ConfigDragonPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CAB RID: 3243 RVA: 0x000A1280 File Offset: 0x0009F480
		static ConfigDragonPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDragonPoolAll.CreateStaticDefaultValue), new Action(ConfigDragonPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000A12A0 File Offset: 0x0009F4A0
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

		// Token: 0x06000CAD RID: 3245 RVA: 0x000A131F File Offset: 0x0009F51F
		public static void ResetStaticDefaultValue()
		{
			ConfigDragonPoolAll.LogPair = null;
			ConfigDragonPoolAll.HandleId = 0;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000A132D File Offset: 0x0009F52D
		public static void Init()
		{
			ConfigDragonPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigDragonPoolAll.HandleId, "db_dragon_ball.db", "select BinData from `DragonPool`");
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000A1348 File Offset: 0x0009F548
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

		// Token: 0x04000EA8 RID: 3752
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000EA9 RID: 3753
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000EAA RID: 3754
		private const string TABLE = "DragonPool";

		// Token: 0x04000EAB RID: 3755
		private const string COMMAND = "select BinData from `DragonPool`";

		// Token: 0x04000EAC RID: 3756
		private const string KEY_PREFIX = "DragonPoolAll";

		// Token: 0x04000EAD RID: 3757
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EAE RID: 3758
		private static int HandleId;
	}
}
