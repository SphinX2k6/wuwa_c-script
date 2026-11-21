using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028B RID: 651
	public class ConfigEntityGravityConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x000B35BB File Offset: 0x000B17BB
		static ConfigEntityGravityConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityGravityConfigAll.CreateStaticDefaultValue), new Action(ConfigEntityGravityConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000B35DC File Offset: 0x000B17DC
		public static void CreateStaticDefaultValue()
		{
			ConfigEntityGravityConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntityGravityConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entitygravity.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Gravity/重力方向_Json_GravityAbnormalEntityList.csv"),
				new ValueTuple<string, object>("表名", "EntityGravityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EntityGravityConfig`")
			});
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000B365B File Offset: 0x000B185B
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityGravityConfigAll.LogPair = null;
			ConfigEntityGravityConfigAll.HandleId = 0;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000B3669 File Offset: 0x000B1869
		public static void Init()
		{
			ConfigEntityGravityConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEntityGravityConfigAll.HandleId, "db_entitygravity.db", "select BinData from `EntityGravityConfig`");
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000B3684 File Offset: 0x000B1884
		[NullableContext(2)]
		public static IReadOnlyList<EntityGravityConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntityGravityConfigAll.HandleId, ConfigEntityGravityConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EntityGravityConfig> readOnlyList = (IReadOnlyList<EntityGravityConfig>)ConfigCommon.GetConfig("EntityGravityConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EntityGravityConfig> list = new List<EntityGravityConfig>();
			while (ConfigCommon.Step(ConfigEntityGravityConfigAll.HandleId, false, ConfigEntityGravityConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntityGravityConfigAll.HandleId, 0, ConfigEntityGravityConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEntityGravityConfigAll.HandleId, ConfigEntityGravityConfigAll.LogPair);
					return null;
				}
				EntityGravityConfig rootAsEntityGravityConfig = EntityGravityConfig.GetRootAsEntityGravityConfig(new ByteBuffer(item2));
				list.Add(rootAsEntityGravityConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EntityGravityConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEntityGravityConfigAll.HandleId, ConfigEntityGravityConfigAll.LogPair);
			return list;
		}

		// Token: 0x040011B1 RID: 4529
		private const string DB = "db_entitygravity.db";

		// Token: 0x040011B2 RID: 4530
		private const string FILE = "UniverseEditor/Gravity/重力方向_Json_GravityAbnormalEntityList.csv";

		// Token: 0x040011B3 RID: 4531
		private const string TABLE = "EntityGravityConfig";

		// Token: 0x040011B4 RID: 4532
		private const string COMMAND = "select BinData from `EntityGravityConfig`";

		// Token: 0x040011B5 RID: 4533
		private const string KEY_PREFIX = "EntityGravityConfigAll";

		// Token: 0x040011B6 RID: 4534
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011B7 RID: 4535
		private static int HandleId;
	}
}
