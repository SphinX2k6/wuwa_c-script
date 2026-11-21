using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E2 RID: 738
	public class ConfigFilterSortGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x000BED78 File Offset: 0x000BCF78
		static ConfigFilterSortGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSortGroupById.CreateStaticDefaultValue), new Action(ConfigFilterSortGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x000BED98 File Offset: 0x000BCF98
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterSortGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterSortGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_filter_sort.db"),
				new ValueTuple<string, object>("文件", "s.筛选排序总表.xlsx"),
				new ValueTuple<string, object>("表名", "FilterSortGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `FilterSortGroup` where Id = ?")
			});
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x000BEE17 File Offset: 0x000BD017
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSortGroupById.LogPair = null;
			ConfigFilterSortGroupById.HandleId = 0;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x000BEE25 File Offset: 0x000BD025
		public static void Init()
		{
			ConfigFilterSortGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSortGroupById.HandleId, "db_filter_sort.db", "select BinData from `FilterSortGroup` where Id = ?");
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x000BEE40 File Offset: 0x000BD040
		public static FilterSortGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterSortGroupById.HandleId, ConfigFilterSortGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSortGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FilterSortGroup?(FilterSortGroup.GetRootAsFilterSortGroup(configBuffer));
				}
			}
			ConfigFilterSortGroupById.LogPair.Clear();
			ConfigFilterSortGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFilterSortGroupById.HandleId, 1, p0Id, ConfigFilterSortGroupById.LogPair) || ConfigCommon.Step(ConfigFilterSortGroupById.HandleId, true, ConfigFilterSortGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFilterSortGroupById.HandleId, ConfigFilterSortGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterSortGroupById.HandleId, 0, ConfigFilterSortGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFilterSortGroupById.HandleId, ConfigFilterSortGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FilterSortGroup rootAsFilterSortGroup = FilterSortGroup.GetRootAsFilterSortGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSortGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFilterSortGroupById.HandleId, ConfigFilterSortGroupById.LogPair);
			return new FilterSortGroup?(rootAsFilterSortGroup);
		}

		// Token: 0x04001412 RID: 5138
		private const string DB = "db_filter_sort.db";

		// Token: 0x04001413 RID: 5139
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x04001414 RID: 5140
		private const string TABLE = "FilterSortGroup";

		// Token: 0x04001415 RID: 5141
		private const string COMMAND = "select BinData from `FilterSortGroup` where Id = ?";

		// Token: 0x04001416 RID: 5142
		private const string KEY_PREFIX = "FilterSortGroupById";

		// Token: 0x04001417 RID: 5143
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001418 RID: 5144
		private static int HandleId;
	}
}
