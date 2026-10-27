using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027E RID: 638
	public class ConfigEntitySkillPreloadByActorBlueprintAndSkillId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x000AE129 File Offset: 0x000AC329
		static ConfigEntitySkillPreloadByActorBlueprintAndSkillId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.ResetStaticDefaultValue));
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x000AE148 File Offset: 0x000AC348
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

		// Token: 0x06000EFB RID: 3835 RVA: 0x000AE1C7 File Offset: 0x000AC3C7
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.LogPair = null;
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId = 0;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000AE1D5 File Offset: 0x000AC3D5
		public static void Init()
		{
			ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadByActorBlueprintAndSkillId.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload` where ActorBlueprint=? AND SkillId=?");
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000AE1F0 File Offset: 0x000AC3F0
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

		// Token: 0x04001156 RID: 4438
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x04001157 RID: 4439
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x04001158 RID: 4440
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x04001159 RID: 4441
		private const string COMMAND = "select BinData from `EntitySkillPreload` where ActorBlueprint=? AND SkillId=?";

		// Token: 0x0400115A RID: 4442
		private const string KEY_PREFIX = "EntitySkillPreloadByActorBlueprintAndSkillId";

		// Token: 0x0400115B RID: 4443
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400115C RID: 4444
		private static int HandleId;
	}
}
