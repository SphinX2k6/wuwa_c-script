using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000292 RID: 658
	public class ConfigEntitySkillPreloadByActorBlueprintAndSkillId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F71 RID: 3953 RVA: 0x000B43ED File Offset: 0x000B25ED
		static ConfigEntitySkillPreloadByActorBlueprintAndSkillId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000B440C File Offset: 0x000B260C
		public static void CreateStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_skill_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/EntitySkillPreload.csv"),
				new ValueTuple<string, object>("表名", "EntitySkillPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `EntitySkillPreload` where ActorBlueprint=? AND SkillId=?")
			});
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000B448B File Offset: 0x000B268B
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair = null;
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId = 0;
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000B4499 File Offset: 0x000B2699
		public static void Init()
		{
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload` where ActorBlueprint=? AND SkillId=?");
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000B44B4 File Offset: 0x000B26B4
		public static EntitySkillPreload? GetConfig(string p0ActorBlueprint, int p1SkillId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntitySkillPreloadByActorBlueprintAndSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ActorBlueprint);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1SkillId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntitySkillPreload?(EntitySkillPreload.GetRootAsEntitySkillPreload(configBuffer));
				}
			}
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair.Clear();
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair.Add(new ValueTuple<string, object>("ActorBlueprint", p0ActorBlueprint));
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair.Add(new ValueTuple<string, object>("SkillId", p1SkillId));
			if (!ConfigCommon.BindString(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, 1, p0ActorBlueprint, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair) || !ConfigCommon.BindInt(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, 2, p1SkillId, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair) || ConfigCommon.Step(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, true, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, 0, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntitySkillPreload rootAsEntitySkillPreload = EntitySkillPreload.GetRootAsEntitySkillPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntitySkillPreloadByActorBlueprintAndSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ActorBlueprint);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1SkillId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair);
			return new EntitySkillPreload?(rootAsEntitySkillPreload);
		}

		// Token: 0x040011E2 RID: 4578
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x040011E3 RID: 4579
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x040011E4 RID: 4580
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x040011E5 RID: 4581
		private const string COMMAND = "select BinData from `EntitySkillPreload` where ActorBlueprint=? AND SkillId=?";

		// Token: 0x040011E6 RID: 4582
		private const string KEY_PREFIX = "EntitySkillPreloadByActorBlueprintAndSkillId";

		// Token: 0x040011E7 RID: 4583
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011E8 RID: 4584
		private static int HandleId;
	}
}
