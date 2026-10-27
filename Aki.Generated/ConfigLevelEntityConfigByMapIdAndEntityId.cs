using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CD RID: 1229
	public class ConfigLevelEntityConfigByMapIdAndEntityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CD9 RID: 7385 RVA: 0x000FC297 File Offset: 0x000FA497
		static ConfigLevelEntityConfigByMapIdAndEntityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelEntityConfigByMapIdAndEntityId.CreateStaticDefaultValue), new Action(ConfigLevelEntityConfigByMapIdAndEntityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000FC2B8 File Offset: 0x000FA4B8
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

		// Token: 0x06001CDB RID: 7387 RVA: 0x000FC337 File Offset: 0x000FA537
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelEntityConfigByMapIdAndEntityId.LogPair = null;
			ConfigLevelEntityConfigByMapIdAndEntityId.HandleId = 0;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000FC345 File Offset: 0x000FA545
		public static void Init()
		{
			ConfigLevelEntityConfigByMapIdAndEntityId.HandleId = ConfigCommon.InitDataStatement(ConfigLevelEntityConfigByMapIdAndEntityId.HandleId, "db_level_entity.db", "select BinData from `LevelEntityConfig` where MapId=? and EntityId=?");
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000FC360 File Offset: 0x000FA560
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

		// Token: 0x0400217F RID: 8575
		private const string DB = "db_level_entity.db";

		// Token: 0x04002180 RID: 8576
		private const string FILE = "UniverseEditor/Entity/LevelEntity.csv";

		// Token: 0x04002181 RID: 8577
		private const string TABLE = "LevelEntityConfig";

		// Token: 0x04002182 RID: 8578
		private const string COMMAND = "select BinData from `LevelEntityConfig` where MapId=? and EntityId=?";

		// Token: 0x04002183 RID: 8579
		private const string KEY_PREFIX = "LevelEntityConfigByMapIdAndEntityId";

		// Token: 0x04002184 RID: 8580
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002185 RID: 8581
		private static int HandleId;
	}
}
