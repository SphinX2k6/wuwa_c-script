using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CC RID: 1228
	public class ConfigLevelEntityConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CD3 RID: 7379 RVA: 0x000FC061 File Offset: 0x000FA261
		static ConfigLevelEntityConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelEntityConfigByMapId.CreateStaticDefaultValue), new Action(ConfigLevelEntityConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000FC080 File Offset: 0x000FA280
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelEntityConfigByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelEntityConfigByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_level_entity.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/LevelEntity.csv"),
				new ValueTuple<string, object>("表名", "LevelEntityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelEntityConfig` where MapId=?")
			});
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000FC0FF File Offset: 0x000FA2FF
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelEntityConfigByMapId.LogPair = null;
			ConfigLevelEntityConfigByMapId.HandleId = 0;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000FC10D File Offset: 0x000FA30D
		public static void Init()
		{
			ConfigLevelEntityConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigLevelEntityConfigByMapId.HandleId, "db_level_entity.db", "select BinData from `LevelEntityConfig` where MapId=?");
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000FC128 File Offset: 0x000FA328
		[NullableContext(2)]
		public static IReadOnlyList<LevelEntityConfig> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelEntityConfigByMapId.HandleId, ConfigLevelEntityConfigByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LevelEntityConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<LevelEntityConfig> readOnlyList = (IReadOnlyList<LevelEntityConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLevelEntityConfigByMapId.LogPair.Clear();
			ConfigLevelEntityConfigByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigLevelEntityConfigByMapId.HandleId, 1, p0MapId, ConfigLevelEntityConfigByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigLevelEntityConfigByMapId.HandleId, ConfigLevelEntityConfigByMapId.LogPair);
				return null;
			}
			List<LevelEntityConfig> list = new List<LevelEntityConfig>();
			while (ConfigCommon.Step(ConfigLevelEntityConfigByMapId.HandleId, false, ConfigLevelEntityConfigByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelEntityConfigByMapId.HandleId, 0, ConfigLevelEntityConfigByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLevelEntityConfigByMapId.HandleId, ConfigLevelEntityConfigByMapId.LogPair);
					return null;
				}
				LevelEntityConfig rootAsLevelEntityConfig = LevelEntityConfig.GetRootAsLevelEntityConfig(new ByteBuffer(item2));
				list.Add(rootAsLevelEntityConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LevelEntityConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLevelEntityConfigByMapId.HandleId, ConfigLevelEntityConfigByMapId.LogPair);
			return list;
		}

		// Token: 0x04002178 RID: 8568
		private const string DB = "db_level_entity.db";

		// Token: 0x04002179 RID: 8569
		private const string FILE = "UniverseEditor/Entity/LevelEntity.csv";

		// Token: 0x0400217A RID: 8570
		private const string TABLE = "LevelEntityConfig";

		// Token: 0x0400217B RID: 8571
		private const string COMMAND = "select BinData from `LevelEntityConfig` where MapId=?";

		// Token: 0x0400217C RID: 8572
		private const string KEY_PREFIX = "LevelEntityConfigByMapId";

		// Token: 0x0400217D RID: 8573
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400217E RID: 8574
		private static int HandleId;
	}
}
