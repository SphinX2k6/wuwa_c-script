using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000273 RID: 627
	public class ConfigEnrichmentAreaConfigByEnrichmentId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EB7 RID: 3767 RVA: 0x000AC9AC File Offset: 0x000AABAC
		static ConfigEnrichmentAreaConfigByEnrichmentId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEnrichmentAreaConfigByEnrichmentId.CreateStaticDefaultValue), new Action(ConfigEnrichmentAreaConfigByEnrichmentId.ResetStaticDefaultValue));
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000AC9CC File Offset: 0x000AABCC
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

		// Token: 0x06000EB9 RID: 3769 RVA: 0x000ACA4B File Offset: 0x000AAC4B
		public static void ResetStaticDefaultValue()
		{
			ConfigEnrichmentAreaConfigByEnrichmentId.LogPair = null;
			ConfigEnrichmentAreaConfigByEnrichmentId.HandleId = 0;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x000ACA59 File Offset: 0x000AAC59
		public static void Init()
		{
			ConfigEnrichmentAreaConfigByEnrichmentId.HandleId = ConfigCommon.InitDataStatement(ConfigEnrichmentAreaConfigByEnrichmentId.HandleId, "db_enrichment.db", "select BinData from `EnrichmentAreaConfig` where EnrichmentId=?");
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x000ACA74 File Offset: 0x000AAC74
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

		// Token: 0x04001109 RID: 4361
		private const string DB = "db_enrichment.db";

		// Token: 0x0400110A RID: 4362
		private const string FILE = "UniverseEditor/Enrichment/富集区_Json_EnrichmentArea.csv";

		// Token: 0x0400110B RID: 4363
		private const string TABLE = "EnrichmentAreaConfig";

		// Token: 0x0400110C RID: 4364
		private const string COMMAND = "select BinData from `EnrichmentAreaConfig` where EnrichmentId=?";

		// Token: 0x0400110D RID: 4365
		private const string KEY_PREFIX = "EnrichmentAreaConfigByEnrichmentId";

		// Token: 0x0400110E RID: 4366
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400110F RID: 4367
		private static int HandleId;
	}
}
