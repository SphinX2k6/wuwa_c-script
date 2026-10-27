using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082F RID: 2095
	public class ConfigRogueQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600312C RID: 12588 RVA: 0x0016F6A9 File Offset: 0x0016D8A9
		static ConfigRogueQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueQualityConfigById.CreateStaticDefaultValue), new Action(ConfigRogueQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x0016F6C8 File Offset: 0x0016D8C8
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

		// Token: 0x0600312E RID: 12590 RVA: 0x0016F747 File Offset: 0x0016D947
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueQualityConfigById.LogPair = null;
			ConfigRogueQualityConfigById.HandleId = 0;
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x0016F755 File Offset: 0x0016D955
		public static void Init()
		{
			ConfigRogueQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueQualityConfigById.HandleId, "db_rogue.db", "select BinData from `RogueQualityConfig` where Id=?");
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x0016F770 File Offset: 0x0016D970
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

		// Token: 0x0400392F RID: 14639
		private const string DB = "db_rogue.db";

		// Token: 0x04003930 RID: 14640
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003931 RID: 14641
		private const string TABLE = "RogueQualityConfig";

		// Token: 0x04003932 RID: 14642
		private const string COMMAND = "select BinData from `RogueQualityConfig` where Id=?";

		// Token: 0x04003933 RID: 14643
		private const string KEY_PREFIX = "RogueQualityConfigById";

		// Token: 0x04003934 RID: 14644
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003935 RID: 14645
		private static int HandleId;
	}
}
