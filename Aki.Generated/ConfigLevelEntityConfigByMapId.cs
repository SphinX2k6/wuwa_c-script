using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E2 RID: 1250
	public class ConfigLevelEntityConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D57 RID: 7511 RVA: 0x001027B5 File Offset: 0x001009B5
		static ConfigLevelEntityConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelEntityConfigByMapId.CreateStaticDefaultValue), new Action(ConfigLevelEntityConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x001027D4 File Offset: 0x001009D4
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

		// Token: 0x06001D59 RID: 7513 RVA: 0x00102853 File Offset: 0x00100A53
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelEntityConfigByMapId.LogPair = null;
			ConfigLevelEntityConfigByMapId.HandleId = 0;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00102861 File Offset: 0x00100A61
		public static void Init()
		{
			ConfigLevelEntityConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigLevelEntityConfigByMapId.HandleId, "db_level_entity.db", "select BinData from `LevelEntityConfig` where MapId=?");
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0010287C File Offset: 0x00100A7C
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

		// Token: 0x04002212 RID: 8722
		private const string DB = "db_level_entity.db";

		// Token: 0x04002213 RID: 8723
		private const string FILE = "UniverseEditor/Entity/LevelEntity.csv";

		// Token: 0x04002214 RID: 8724
		private const string TABLE = "LevelEntityConfig";

		// Token: 0x04002215 RID: 8725
		private const string COMMAND = "select BinData from `LevelEntityConfig` where MapId=?";

		// Token: 0x04002216 RID: 8726
		private const string KEY_PREFIX = "LevelEntityConfigByMapId";

		// Token: 0x04002217 RID: 8727
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002218 RID: 8728
		private static int HandleId;
	}
}
