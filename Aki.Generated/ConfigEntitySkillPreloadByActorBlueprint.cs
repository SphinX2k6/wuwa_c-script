using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000291 RID: 657
	public class ConfigEntitySkillPreloadByActorBlueprint : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F6B RID: 3947 RVA: 0x000B4209 File Offset: 0x000B2409
		static ConfigEntitySkillPreloadByActorBlueprint()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadByActorBlueprint.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadByActorBlueprint.ResetStaticDefaultValue));
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000B4228 File Offset: 0x000B2428
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

		// Token: 0x06000F6D RID: 3949 RVA: 0x000B42A7 File Offset: 0x000B24A7
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByActorBlueprint.LogPair = null;
			ConfigEntitySkillPreloadByActorBlueprint.HandleId = 0;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000B42B5 File Offset: 0x000B24B5
		public static void Init()
		{
			ConfigEntitySkillPreloadByActorBlueprint.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadByActorBlueprint.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload` where ActorBlueprint=?");
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000B42D0 File Offset: 0x000B24D0
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

		// Token: 0x040011DB RID: 4571
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x040011DC RID: 4572
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x040011DD RID: 4573
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x040011DE RID: 4574
		private const string COMMAND = "select BinData from `EntitySkillPreload` where ActorBlueprint=?";

		// Token: 0x040011DF RID: 4575
		private const string KEY_PREFIX = "EntitySkillPreloadByActorBlueprint";

		// Token: 0x040011E0 RID: 4576
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011E1 RID: 4577
		private static int HandleId;
	}
}
