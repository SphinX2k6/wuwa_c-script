using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089A RID: 2202
	public class ConfigRogueWeekQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033AE RID: 13230 RVA: 0x00180FDB File Offset: 0x0017F1DB
		static ConfigRogueWeekQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeekQualityConfigById.CreateStaticDefaultValue), new Action(ConfigRogueWeekQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00180FFC File Offset: 0x0017F1FC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeekQualityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeekQualityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeekQualityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeekQualityConfig` where Id=?")
			});
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0018107B File Offset: 0x0017F27B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeekQualityConfigById.LogPair = null;
			ConfigRogueWeekQualityConfigById.HandleId = 0;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x00181089 File Offset: 0x0017F289
		public static void Init()
		{
			ConfigRogueWeekQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeekQualityConfigById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeekQualityConfig` where Id=?");
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x001810A4 File Offset: 0x0017F2A4
		public static RogueWeekQualityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeekQualityConfig?(RogueWeekQualityConfig.GetRootAsRogueWeekQualityConfig(configBuffer));
				}
			}
			ConfigRogueWeekQualityConfigById.LogPair.Clear();
			ConfigRogueWeekQualityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeekQualityConfigById.HandleId, 1, p0Id, ConfigRogueWeekQualityConfigById.LogPair) || ConfigCommon.Step(ConfigRogueWeekQualityConfigById.HandleId, true, ConfigRogueWeekQualityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeekQualityConfigById.HandleId, 0, ConfigRogueWeekQualityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeekQualityConfig rootAsRogueWeekQualityConfig = RogueWeekQualityConfig.GetRootAsRogueWeekQualityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair);
			return new RogueWeekQualityConfig?(rootAsRogueWeekQualityConfig);
		}

		// Token: 0x04003C1C RID: 15388
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003C1D RID: 15389
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003C1E RID: 15390
		private const string TABLE = "RogueWeekQualityConfig";

		// Token: 0x04003C1F RID: 15391
		private const string COMMAND = "select BinData from `RogueWeekQualityConfig` where Id=?";

		// Token: 0x04003C20 RID: 15392
		private const string KEY_PREFIX = "RogueWeekQualityConfigById";

		// Token: 0x04003C21 RID: 15393
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C22 RID: 15394
		private static int HandleId;
	}
}
