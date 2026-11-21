using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E1 RID: 737
	public class ConfigFilterSortConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600114B RID: 4427 RVA: 0x000BEB30 File Offset: 0x000BCD30
		static ConfigFilterSortConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSortConfigById.CreateStaticDefaultValue), new Action(ConfigFilterSortConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000BEB50 File Offset: 0x000BCD50
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

		// Token: 0x0600114D RID: 4429 RVA: 0x000BEBCF File Offset: 0x000BCDCF
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSortConfigById.LogPair = null;
			ConfigFilterSortConfigById.HandleId = 0;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x000BEBDD File Offset: 0x000BCDDD
		public static void Init()
		{
			ConfigFilterSortConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSortConfigById.HandleId, "db_filter_sort.db", "select BinData from `FilterSortConfig` where Id = ?");
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x000BEBF8 File Offset: 0x000BCDF8
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

		// Token: 0x0400140B RID: 5131
		private const string DB = "db_filter_sort.db";

		// Token: 0x0400140C RID: 5132
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x0400140D RID: 5133
		private const string TABLE = "FilterSortConfig";

		// Token: 0x0400140E RID: 5134
		private const string COMMAND = "select BinData from `FilterSortConfig` where Id = ?";

		// Token: 0x0400140F RID: 5135
		private const string KEY_PREFIX = "FilterSortConfigById";

		// Token: 0x04001410 RID: 5136
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001411 RID: 5137
		private static int HandleId;
	}
}
