using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027D RID: 637
	public class ConfigEntitySkillPreloadByActorBlueprint : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EF3 RID: 3827 RVA: 0x000ADF45 File Offset: 0x000AC145
		static ConfigEntitySkillPreloadByActorBlueprint()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadByActorBlueprint.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadByActorBlueprint.ResetStaticDefaultValue));
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000ADF64 File Offset: 0x000AC164
		public static void CreateStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByActorBlueprint.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntitySkillPreloadByActorBlueprint.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_skill_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/EntitySkillPreload.csv"),
				new ValueTuple<string, object>("表名", "EntitySkillPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `EntitySkillPreload` where ActorBlueprint=?")
			});
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000ADFE3 File Offset: 0x000AC1E3
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByActorBlueprint.LogPair = null;
			ConfigEntitySkillPreloadByActorBlueprint.HandleId = 0;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000ADFF1 File Offset: 0x000AC1F1
		public static void Init()
		{
			ConfigEntitySkillPreloadByActorBlueprint.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadByActorBlueprint.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload` where ActorBlueprint=?");
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000AE00C File Offset: 0x000AC20C
		[return: Nullable(2)]
		public static IReadOnlyList<EntitySkillPreload> GetConfigList(string p0ActorBlueprint, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntitySkillPreloadByActorBlueprint.HandleId, ConfigEntitySkillPreloadByActorBlueprint.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EntitySkillPreload> readOnlyList = (IReadOnlyList<EntitySkillPreload>)ConfigCommon.GetConfig("EntitySkillPreloadByActorBlueprint#" + p0ActorBlueprint);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEntitySkillPreloadByActorBlueprint.LogPair.Clear();
			ConfigEntitySkillPreloadByActorBlueprint.LogPair.Add(new ValueTuple<string, object>("ActorBlueprint", p0ActorBlueprint));
			if (!ConfigCommon.BindString(ConfigEntitySkillPreloadByActorBlueprint.HandleId, 1, p0ActorBlueprint, ConfigEntitySkillPreloadByActorBlueprint.LogPair))
			{
				ConfigCommon.Reset(ConfigEntitySkillPreloadByActorBlueprint.HandleId, ConfigEntitySkillPreloadByActorBlueprint.LogPair);
				return null;
			}
			List<EntitySkillPreload> list = new List<EntitySkillPreload>();
			while (ConfigCommon.Step(ConfigEntitySkillPreloadByActorBlueprint.HandleId, false, ConfigEntitySkillPreloadByActorBlueprint.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntitySkillPreloadByActorBlueprint.HandleId, 0, ConfigEntitySkillPreloadByActorBlueprint.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEntitySkillPreloadByActorBlueprint.HandleId, ConfigEntitySkillPreloadByActorBlueprint.LogPair);
					return null;
				}
				EntitySkillPreload rootAsEntitySkillPreload = EntitySkillPreload.GetRootAsEntitySkillPreload(new ByteBuffer(item2));
				list.Add(rootAsEntitySkillPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EntitySkillPreloadByActorBlueprint#" + p0ActorBlueprint, list, list.Count);
			}
			ConfigCommon.Reset(ConfigEntitySkillPreloadByActorBlueprint.HandleId, ConfigEntitySkillPreloadByActorBlueprint.LogPair);
			return list;
		}

		// Token: 0x0400114F RID: 4431
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x04001150 RID: 4432
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x04001151 RID: 4433
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x04001152 RID: 4434
		private const string COMMAND = "select BinData from `EntitySkillPreload` where ActorBlueprint=?";

		// Token: 0x04001153 RID: 4435
		private const string KEY_PREFIX = "EntitySkillPreloadByActorBlueprint";

		// Token: 0x04001154 RID: 4436
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001155 RID: 4437
		private static int HandleId;
	}
}
