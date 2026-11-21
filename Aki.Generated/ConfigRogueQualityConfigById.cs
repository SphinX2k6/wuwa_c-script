using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084B RID: 2123
	public class ConfigRogueQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031D4 RID: 12756 RVA: 0x00176991 File Offset: 0x00174B91
		static ConfigRogueQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueQualityConfigById.CreateStaticDefaultValue), new Action(ConfigRogueQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x001769B0 File Offset: 0x00174BB0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueQualityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueQualityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueQualityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueQualityConfig` where Id=?")
			});
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x00176A2F File Offset: 0x00174C2F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueQualityConfigById.LogPair = null;
			ConfigRogueQualityConfigById.HandleId = 0;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x00176A3D File Offset: 0x00174C3D
		public static void Init()
		{
			ConfigRogueQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueQualityConfigById.HandleId, "db_rogue.db", "select BinData from `RogueQualityConfig` where Id=?");
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00176A58 File Offset: 0x00174C58
		public static RogueQualityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueQualityConfigById.HandleId, ConfigRogueQualityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueQualityConfig?(RogueQualityConfig.GetRootAsRogueQualityConfig(configBuffer));
				}
			}
			ConfigRogueQualityConfigById.LogPair.Clear();
			ConfigRogueQualityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueQualityConfigById.HandleId, 1, p0Id, ConfigRogueQualityConfigById.LogPair) || ConfigCommon.Step(ConfigRogueQualityConfigById.HandleId, true, ConfigRogueQualityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueQualityConfigById.HandleId, ConfigRogueQualityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueQualityConfigById.HandleId, 0, ConfigRogueQualityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueQualityConfigById.HandleId, ConfigRogueQualityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueQualityConfig rootAsRogueQualityConfig = RogueQualityConfig.GetRootAsRogueQualityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueQualityConfigById.HandleId, ConfigRogueQualityConfigById.LogPair);
			return new RogueQualityConfig?(rootAsRogueQualityConfig);
		}

		// Token: 0x040039F3 RID: 14835
		private const string DB = "db_rogue.db";

		// Token: 0x040039F4 RID: 14836
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040039F5 RID: 14837
		private const string TABLE = "RogueQualityConfig";

		// Token: 0x040039F6 RID: 14838
		private const string COMMAND = "select BinData from `RogueQualityConfig` where Id=?";

		// Token: 0x040039F7 RID: 14839
		private const string KEY_PREFIX = "RogueQualityConfigById";

		// Token: 0x040039F8 RID: 14840
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039F9 RID: 14841
		private static int HandleId;
	}
}
