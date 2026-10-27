using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CC RID: 716
	public class ConfigFilterSortConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x000B8624 File Offset: 0x000B6824
		static ConfigFilterSortConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSortConfigById.CreateStaticDefaultValue), new Action(ConfigFilterSortConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000B8644 File Offset: 0x000B6844
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterSortConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterSortConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_filter_sort.db"),
				new ValueTuple<string, object>("文件", "s.筛选排序总表.xlsx"),
				new ValueTuple<string, object>("表名", "FilterSortConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FilterSortConfig` where Id = ?")
			});
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000B86C3 File Offset: 0x000B68C3
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSortConfigById.LogPair = null;
			ConfigFilterSortConfigById.HandleId = 0;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000B86D1 File Offset: 0x000B68D1
		public static void Init()
		{
			ConfigFilterSortConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSortConfigById.HandleId, "db_filter_sort.db", "select BinData from `FilterSortConfig` where Id = ?");
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000B86EC File Offset: 0x000B68EC
		public static FilterSortConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterSortConfigById.HandleId, ConfigFilterSortConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSortConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FilterSortConfig?(FilterSortConfig.GetRootAsFilterSortConfig(configBuffer));
				}
			}
			ConfigFilterSortConfigById.LogPair.Clear();
			ConfigFilterSortConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFilterSortConfigById.HandleId, 1, p0Id, ConfigFilterSortConfigById.LogPair) || ConfigCommon.Step(ConfigFilterSortConfigById.HandleId, true, ConfigFilterSortConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFilterSortConfigById.HandleId, ConfigFilterSortConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterSortConfigById.HandleId, 0, ConfigFilterSortConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFilterSortConfigById.HandleId, ConfigFilterSortConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FilterSortConfig rootAsFilterSortConfig = FilterSortConfig.GetRootAsFilterSortConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSortConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFilterSortConfigById.HandleId, ConfigFilterSortConfigById.LogPair);
			return new FilterSortConfig?(rootAsFilterSortConfig);
		}

		// Token: 0x04001378 RID: 4984
		private const string DB = "db_filter_sort.db";

		// Token: 0x04001379 RID: 4985
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x0400137A RID: 4986
		private const string TABLE = "FilterSortConfig";

		// Token: 0x0400137B RID: 4987
		private const string COMMAND = "select BinData from `FilterSortConfig` where Id = ?";

		// Token: 0x0400137C RID: 4988
		private const string KEY_PREFIX = "FilterSortConfigById";

		// Token: 0x0400137D RID: 4989
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400137E RID: 4990
		private static int HandleId;
	}
}
