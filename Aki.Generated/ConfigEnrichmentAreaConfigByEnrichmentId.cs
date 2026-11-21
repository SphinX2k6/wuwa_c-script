using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000287 RID: 647
	public class ConfigEnrichmentAreaConfigByEnrichmentId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x000B2C70 File Offset: 0x000B0E70
		static ConfigEnrichmentAreaConfigByEnrichmentId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEnrichmentAreaConfigByEnrichmentId.CreateStaticDefaultValue), new Action(ConfigEnrichmentAreaConfigByEnrichmentId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000B2C90 File Offset: 0x000B0E90
		public static void CreateStaticDefaultValue()
		{
			ConfigEnrichmentAreaConfigByEnrichmentId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEnrichmentAreaConfigByEnrichmentId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_enrichment.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Enrichment/富集区_Json_EnrichmentArea.csv"),
				new ValueTuple<string, object>("表名", "EnrichmentAreaConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EnrichmentAreaConfig` where EnrichmentId=?")
			});
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x000B2D0F File Offset: 0x000B0F0F
		public static void ResetStaticDefaultValue()
		{
			ConfigEnrichmentAreaConfigByEnrichmentId.LogPair = null;
			ConfigEnrichmentAreaConfigByEnrichmentId.HandleId = 0;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000B2D1D File Offset: 0x000B0F1D
		public static void Init()
		{
			ConfigEnrichmentAreaConfigByEnrichmentId.HandleId = ConfigCommon.InitDataStatement(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, "db_enrichment.db", "select BinData from `EnrichmentAreaConfig` where EnrichmentId=?");
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000B2D38 File Offset: 0x000B0F38
		[NullableContext(2)]
		public static IReadOnlyList<EnrichmentAreaConfig> GetConfigList(int p0EnrichmentId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, ConfigEnrichmentAreaConfigByEnrichmentId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EnrichmentAreaConfigByEnrichmentId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EnrichmentId);
				IReadOnlyList<EnrichmentAreaConfig> readOnlyList = (IReadOnlyList<EnrichmentAreaConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEnrichmentAreaConfigByEnrichmentId.LogPair.Clear();
			ConfigEnrichmentAreaConfigByEnrichmentId.LogPair.Add(new ValueTuple<string, object>("EnrichmentId", p0EnrichmentId));
			if (!ConfigCommon.BindInt(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, 1, p0EnrichmentId, ConfigEnrichmentAreaConfigByEnrichmentId.LogPair))
			{
				ConfigCommon.Reset(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, ConfigEnrichmentAreaConfigByEnrichmentId.LogPair);
				return null;
			}
			List<EnrichmentAreaConfig> list = new List<EnrichmentAreaConfig>();
			while (ConfigCommon.Step(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, false, ConfigEnrichmentAreaConfigByEnrichmentId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, 0, ConfigEnrichmentAreaConfigByEnrichmentId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, ConfigEnrichmentAreaConfigByEnrichmentId.LogPair);
					return null;
				}
				EnrichmentAreaConfig rootAsEnrichmentAreaConfig = EnrichmentAreaConfig.GetRootAsEnrichmentAreaConfig(new ByteBuffer(item2));
				list.Add(rootAsEnrichmentAreaConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EnrichmentAreaConfigByEnrichmentId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EnrichmentId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, ConfigEnrichmentAreaConfigByEnrichmentId.LogPair);
			return list;
		}

		// Token: 0x04001195 RID: 4501
		private const string DB = "db_enrichment.db";

		// Token: 0x04001196 RID: 4502
		private const string FILE = "UniverseEditor/Enrichment/富集区_Json_EnrichmentArea.csv";

		// Token: 0x04001197 RID: 4503
		private const string TABLE = "EnrichmentAreaConfig";

		// Token: 0x04001198 RID: 4504
		private const string COMMAND = "select BinData from `EnrichmentAreaConfig` where EnrichmentId=?";

		// Token: 0x04001199 RID: 4505
		private const string KEY_PREFIX = "EnrichmentAreaConfigByEnrichmentId";

		// Token: 0x0400119A RID: 4506
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400119B RID: 4507
		private static int HandleId;
	}
}
