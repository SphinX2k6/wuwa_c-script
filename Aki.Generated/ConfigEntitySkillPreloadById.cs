using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000294 RID: 660
	public class ConfigEntitySkillPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x000B4817 File Offset: 0x000B2A17
		static ConfigEntitySkillPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadById.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000B4838 File Offset: 0x000B2A38
		public static void CreateStaticDefaultValue()
		{
			ConfigEntitySkillPreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntitySkillPreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_skill_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/EntitySkillPreload.csv"),
				new ValueTuple<string, object>("表名", "EntitySkillPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `EntitySkillPreload` where Id=?")
			});
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000B48B7 File Offset: 0x000B2AB7
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadById.LogPair = null;
			ConfigEntitySkillPreloadById.HandleId = 0;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x000B48C5 File Offset: 0x000B2AC5
		public static void Init()
		{
			ConfigEntitySkillPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadById.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload` where Id=?");
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000B48E0 File Offset: 0x000B2AE0
		public static EntitySkillPreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntitySkillPreloadById.HandleId, ConfigEntitySkillPreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntitySkillPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntitySkillPreload?(EntitySkillPreload.GetRootAsEntitySkillPreload(configBuffer));
				}
			}
			ConfigEntitySkillPreloadById.LogPair.Clear();
			ConfigEntitySkillPreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEntitySkillPreloadById.HandleId, 1, p0Id, ConfigEntitySkillPreloadById.LogPair) || ConfigCommon.Step(ConfigEntitySkillPreloadById.HandleId, true, ConfigEntitySkillPreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntitySkillPreloadById.HandleId, ConfigEntitySkillPreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntitySkillPreloadById.HandleId, 0, ConfigEntitySkillPreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntitySkillPreloadById.HandleId, ConfigEntitySkillPreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntitySkillPreload rootAsEntitySkillPreload = EntitySkillPreload.GetRootAsEntitySkillPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntitySkillPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntitySkillPreloadById.HandleId, ConfigEntitySkillPreloadById.LogPair);
			return new EntitySkillPreload?(rootAsEntitySkillPreload);
		}

		// Token: 0x040011F0 RID: 4592
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x040011F1 RID: 4593
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x040011F2 RID: 4594
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x040011F3 RID: 4595
		private const string COMMAND = "select BinData from `EntitySkillPreload` where Id=?";

		// Token: 0x040011F4 RID: 4596
		private const string KEY_PREFIX = "EntitySkillPreloadById";

		// Token: 0x040011F5 RID: 4597
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011F6 RID: 4598
		private static int HandleId;
	}
}
