using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E3 RID: 1251
	public class ConfigLevelEntityConfigByMapIdAndEntityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D5D RID: 7517 RVA: 0x001029EB File Offset: 0x00100BEB
		static ConfigLevelEntityConfigByMapIdAndEntityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelEntityConfigByMapIdAndEntityId.CreateStaticDefaultValue), new Action(ConfigLevelEntityConfigByMapIdAndEntityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00102A0C File Offset: 0x00100C0C
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelEntityConfigByMapIdAndEntityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelEntityConfigByMapIdAndEntityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_level_entity.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/LevelEntity.csv"),
				new ValueTuple<string, object>("表名", "LevelEntityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelEntityConfig` where MapId=? and EntityId=?")
			});
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00102A8B File Offset: 0x00100C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelEntityConfigByMapIdAndEntityId.LogPair = null;
			ConfigLevelEntityConfigByMapIdAndEntityId.HandleId = 0;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00102A99 File Offset: 0x00100C99
		public static void Init()
		{
			ConfigLevelEntityConfigByMapIdAndEntityId.HandleId = ConfigCommon.InitDataStatement(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, "db_level_entity.db", "select BinData from `LevelEntityConfig` where MapId=? and EntityId=?");
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00102AB4 File Offset: 0x00100CB4
		public static LevelEntityConfig? GetConfig(int p0MapId, int p1EntityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("LevelEntityConfigByMapIdAndEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1EntityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LevelEntityConfig?(LevelEntityConfig.GetRootAsLevelEntityConfig(configBuffer));
				}
			}
			ConfigLevelEntityConfigByMapIdAndEntityId.LogPair.Clear();
			ConfigLevelEntityConfigByMapIdAndEntityId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			ConfigLevelEntityConfigByMapIdAndEntityId.LogPair.Add(new ValueTuple<string, object>("EntityId", p1EntityId));
			if (!ConfigCommon.BindInt(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, 1, p0MapId, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair) || !ConfigCommon.BindInt(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, 2, p1EntityId, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair) || ConfigCommon.Step(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, true, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, 0, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LevelEntityConfig rootAsLevelEntityConfig = LevelEntityConfig.GetRootAsLevelEntityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("LevelEntityConfigByMapIdAndEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1EntityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, ConfigLevelEntityConfigByMapIdAndEntityId.LogPair);
			return new LevelEntityConfig?(rootAsLevelEntityConfig);
		}

		// Token: 0x04002219 RID: 8729
		private const string DB = "db_level_entity.db";

		// Token: 0x0400221A RID: 8730
		private const string FILE = "UniverseEditor/Entity/LevelEntity.csv";

		// Token: 0x0400221B RID: 8731
		private const string TABLE = "LevelEntityConfig";

		// Token: 0x0400221C RID: 8732
		private const string COMMAND = "select BinData from `LevelEntityConfig` where MapId=? and EntityId=?";

		// Token: 0x0400221D RID: 8733
		private const string KEY_PREFIX = "LevelEntityConfigByMapIdAndEntityId";

		// Token: 0x0400221E RID: 8734
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400221F RID: 8735
		private static int HandleId;
	}
}
