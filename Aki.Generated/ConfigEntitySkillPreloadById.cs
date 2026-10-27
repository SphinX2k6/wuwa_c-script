using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000280 RID: 640
	public class ConfigEntitySkillPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F05 RID: 3845 RVA: 0x000AE553 File Offset: 0x000AC753
		static ConfigEntitySkillPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySkillPreloadById.CreateStaticDefaultValue), new Action(ConfigEntitySkillPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000AE574 File Offset: 0x000AC774
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

		// Token: 0x06000F07 RID: 3847 RVA: 0x000AE5F3 File Offset: 0x000AC7F3
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySkillPreloadById.LogPair = null;
			ConfigEntitySkillPreloadById.HandleId = 0;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000AE601 File Offset: 0x000AC801
		public static void Init()
		{
			ConfigEntitySkillPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySkillPreloadById.HandleId, "db_entity_skill_preload.db", "select BinData from `EntitySkillPreload` where Id=?");
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000AE61C File Offset: 0x000AC81C
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

		// Token: 0x04001164 RID: 4452
		private const string DB = "db_entity_skill_preload.db";

		// Token: 0x04001165 RID: 4453
		private const string FILE = "Preload/EntitySkillPreload.csv";

		// Token: 0x04001166 RID: 4454
		private const string TABLE = "EntitySkillPreload";

		// Token: 0x04001167 RID: 4455
		private const string COMMAND = "select BinData from `EntitySkillPreload` where Id=?";

		// Token: 0x04001168 RID: 4456
		private const string KEY_PREFIX = "EntitySkillPreloadById";

		// Token: 0x04001169 RID: 4457
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400116A RID: 4458
		private static int HandleId;
	}
}
