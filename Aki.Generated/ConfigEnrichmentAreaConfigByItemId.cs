using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000288 RID: 648
	public class ConfigEnrichmentAreaConfigByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x000B2EA7 File Offset: 0x000B10A7
		static ConfigEnrichmentAreaConfigByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEnrichmentAreaConfigByItemId.CreateStaticDefaultValue), new Action(ConfigEnrichmentAreaConfigByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000B2EC8 File Offset: 0x000B10C8
		public static void CreateStaticDefaultValue()
		{
			ConfigEnrichmentAreaConfigByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEnrichmentAreaConfigByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_enrichment.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Enrichment/富集区_Json_EnrichmentArea.csv"),
				new ValueTuple<string, object>("表名", "EnrichmentAreaConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EnrichmentAreaConfig` where ItemId=?")
			});
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000B2F47 File Offset: 0x000B1147
		public static void ResetStaticDefaultValue()
		{
			ConfigEnrichmentAreaConfigByItemId.LogPair = null;
			ConfigEnrichmentAreaConfigByItemId.HandleId = 0;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000B2F55 File Offset: 0x000B1155
		public static void Init()
		{
			ConfigEnrichmentAreaConfigByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigEnrichmentAreaConfigByItemId.HandleId, "db_enrichment.db", "select BinData from `EnrichmentAreaConfig` where ItemId=?");
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x000B2F70 File Offset: 0x000B1170
		[NullableContext(2)]
		public static IReadOnlyList<EnrichmentAreaConfig> GetConfigList(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEnrichmentAreaConfigByItemId.HandleId, ConfigEnrichmentAreaConfigByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EnrichmentAreaConfigByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				IReadOnlyList<EnrichmentAreaConfig> readOnlyList = (IReadOnlyList<EnrichmentAreaConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEnrichmentAreaConfigByItemId.LogPair.Clear();
			ConfigEnrichmentAreaConfigByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigEnrichmentAreaConfigByItemId.HandleId, 1, p0ItemId, ConfigEnrichmentAreaConfigByItemId.LogPair))
			{
				ConfigCommon.Reset(ConfigEnrichmentAreaConfigByItemId.HandleId, ConfigEnrichmentAreaConfigByItemId.LogPair);
				return null;
			}
			List<EnrichmentAreaConfig> list = new List<EnrichmentAreaConfig>();
			while (ConfigCommon.Step(ConfigEnrichmentAreaConfigByItemId.HandleId, false, ConfigEnrichmentAreaConfigByItemId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEnrichmentAreaConfigByItemId.HandleId, 0, ConfigEnrichmentAreaConfigByItemId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEnrichmentAreaConfigByItemId.HandleId, ConfigEnrichmentAreaConfigByItemId.LogPair);
					return null;
				}
				EnrichmentAreaConfig rootAsEnrichmentAreaConfig = EnrichmentAreaConfig.GetRootAsEnrichmentAreaConfig(new ByteBuffer(item2));
				list.Add(rootAsEnrichmentAreaConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EnrichmentAreaConfigByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEnrichmentAreaConfigByItemId.HandleId, ConfigEnrichmentAreaConfigByItemId.LogPair);
			return list;
		}

		// Token: 0x0400119C RID: 4508
		private const string DB = "db_enrichment.db";

		// Token: 0x0400119D RID: 4509
		private const string FILE = "UniverseEditor/Enrichment/富集区_Json_EnrichmentArea.csv";

		// Token: 0x0400119E RID: 4510
		private const string TABLE = "EnrichmentAreaConfig";

		// Token: 0x0400119F RID: 4511
		private const string COMMAND = "select BinData from `EnrichmentAreaConfig` where ItemId=?";

		// Token: 0x040011A0 RID: 4512
		private const string KEY_PREFIX = "EnrichmentAreaConfigByItemId";

		// Token: 0x040011A1 RID: 4513
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011A2 RID: 4514
		private static int HandleId;
	}
}
