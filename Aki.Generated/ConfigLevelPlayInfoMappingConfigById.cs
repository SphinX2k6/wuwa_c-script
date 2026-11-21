using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E6 RID: 1254
	public class ConfigLevelPlayInfoMappingConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D6F RID: 7535 RVA: 0x00103063 File Offset: 0x00101263
		static ConfigLevelPlayInfoMappingConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayInfoMappingConfigById.CreateStaticDefaultValue), new Action(ConfigLevelPlayInfoMappingConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00103084 File Offset: 0x00101284
		public static void CreateStaticDefaultValue()
		{
			ConfigLevelPlayInfoMappingConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLevelPlayInfoMappingConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_levelplayinfomappingconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/w.玩法信息映射/*.csv*"),
				new ValueTuple<string, object>("表名", "LevelPlayInfoMappingConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LevelPlayInfoMappingConfig` where Id=?")
			});
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00103103 File Offset: 0x00101303
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayInfoMappingConfigById.LogPair = null;
			ConfigLevelPlayInfoMappingConfigById.HandleId = 0;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00103111 File Offset: 0x00101311
		public static void Init()
		{
			ConfigLevelPlayInfoMappingConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayInfoMappingConfigById.HandleId, "db_levelplayinfomappingconfig.db", "select BinData from `LevelPlayInfoMappingConfig` where Id=?");
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0010312C File Offset: 0x0010132C
		public static LevelPlayInfoMappingConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLevelPlayInfoMappingConfigById.HandleId, ConfigLevelPlayInfoMappingConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LevelPlayInfoMappingConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LevelPlayInfoMappingConfig?(LevelPlayInfoMappingConfig.GetRootAsLevelPlayInfoMappingConfig(configBuffer));
				}
			}
			ConfigLevelPlayInfoMappingConfigById.LogPair.Clear();
			ConfigLevelPlayInfoMappingConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLevelPlayInfoMappingConfigById.HandleId, 1, p0Id, ConfigLevelPlayInfoMappingConfigById.LogPair) || ConfigCommon.Step(ConfigLevelPlayInfoMappingConfigById.HandleId, true, ConfigLevelPlayInfoMappingConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLevelPlayInfoMappingConfigById.HandleId, ConfigLevelPlayInfoMappingConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLevelPlayInfoMappingConfigById.HandleId, 0, ConfigLevelPlayInfoMappingConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLevelPlayInfoMappingConfigById.HandleId, ConfigLevelPlayInfoMappingConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LevelPlayInfoMappingConfig rootAsLevelPlayInfoMappingConfig = LevelPlayInfoMappingConfig.GetRootAsLevelPlayInfoMappingConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LevelPlayInfoMappingConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLevelPlayInfoMappingConfigById.HandleId, ConfigLevelPlayInfoMappingConfigById.LogPair);
			return new LevelPlayInfoMappingConfig?(rootAsLevelPlayInfoMappingConfig);
		}

		// Token: 0x0400222E RID: 8750
		private const string DB = "db_levelplayinfomappingconfig.db";

		// Token: 0x0400222F RID: 8751
		private const string FILE = "k.可视化编辑/c.Csv/w.玩法信息映射/*.csv*";

		// Token: 0x04002230 RID: 8752
		private const string TABLE = "LevelPlayInfoMappingConfig";

		// Token: 0x04002231 RID: 8753
		private const string COMMAND = "select BinData from `LevelPlayInfoMappingConfig` where Id=?";

		// Token: 0x04002232 RID: 8754
		private const string KEY_PREFIX = "LevelPlayInfoMappingConfigById";

		// Token: 0x04002233 RID: 8755
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002234 RID: 8756
		private static int HandleId;
	}
}
