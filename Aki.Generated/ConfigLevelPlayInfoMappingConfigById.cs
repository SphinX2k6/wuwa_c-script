using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D0 RID: 1232
	public class ConfigLevelPlayInfoMappingConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CEB RID: 7403 RVA: 0x000FC90F File Offset: 0x000FAB0F
		static ConfigLevelPlayInfoMappingConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLevelPlayInfoMappingConfigById.CreateStaticDefaultValue), new Action(ConfigLevelPlayInfoMappingConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000FC930 File Offset: 0x000FAB30
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

		// Token: 0x06001CED RID: 7405 RVA: 0x000FC9AF File Offset: 0x000FABAF
		public static void ResetStaticDefaultValue()
		{
			ConfigLevelPlayInfoMappingConfigById.LogPair = null;
			ConfigLevelPlayInfoMappingConfigById.HandleId = 0;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000FC9BD File Offset: 0x000FABBD
		public static void Init()
		{
			ConfigLevelPlayInfoMappingConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLevelPlayInfoMappingConfigById.HandleId, "db_levelplayinfomappingconfig.db", "select BinData from `LevelPlayInfoMappingConfig` where Id=?");
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000FC9D8 File Offset: 0x000FABD8
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

		// Token: 0x04002194 RID: 8596
		private const string DB = "db_levelplayinfomappingconfig.db";

		// Token: 0x04002195 RID: 8597
		private const string FILE = "k.可视化编辑/c.Csv/w.玩法信息映射/*.csv*";

		// Token: 0x04002196 RID: 8598
		private const string TABLE = "LevelPlayInfoMappingConfig";

		// Token: 0x04002197 RID: 8599
		private const string COMMAND = "select BinData from `LevelPlayInfoMappingConfig` where Id=?";

		// Token: 0x04002198 RID: 8600
		private const string KEY_PREFIX = "LevelPlayInfoMappingConfigById";

		// Token: 0x04002199 RID: 8601
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400219A RID: 8602
		private static int HandleId;
	}
}
