using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000277 RID: 631
	public class ConfigEntityGravityConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ECF RID: 3791 RVA: 0x000AD2F7 File Offset: 0x000AB4F7
		static ConfigEntityGravityConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityGravityConfigAll.CreateStaticDefaultValue), new Action(ConfigEntityGravityConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000AD318 File Offset: 0x000AB518
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

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000AD397 File Offset: 0x000AB597
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityGravityConfigAll.LogPair = null;
			ConfigEntityGravityConfigAll.HandleId = 0;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000AD3A5 File Offset: 0x000AB5A5
		public static void Init()
		{
			ConfigEntityGravityConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEntityGravityConfigAll.HandleId, "db_entitygravity.db", "select BinData from `EntityGravityConfig`");
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000AD3C0 File Offset: 0x000AB5C0
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

		// Token: 0x04001125 RID: 4389
		private const string DB = "db_entitygravity.db";

		// Token: 0x04001126 RID: 4390
		private const string FILE = "UniverseEditor/Gravity/重力方向_Json_GravityAbnormalEntityList.csv";

		// Token: 0x04001127 RID: 4391
		private const string TABLE = "EntityGravityConfig";

		// Token: 0x04001128 RID: 4392
		private const string COMMAND = "select BinData from `EntityGravityConfig`";

		// Token: 0x04001129 RID: 4393
		private const string KEY_PREFIX = "EntityGravityConfigAll";

		// Token: 0x0400112A RID: 4394
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400112B RID: 4395
		private static int HandleId;
	}
}
