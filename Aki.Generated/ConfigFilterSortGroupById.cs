using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CD RID: 717
	public class ConfigFilterSortGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x000B886C File Offset: 0x000B6A6C
		static ConfigFilterSortGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSortGroupById.CreateStaticDefaultValue), new Action(ConfigFilterSortGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000B888C File Offset: 0x000B6A8C
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

		// Token: 0x060010D5 RID: 4309 RVA: 0x000B890B File Offset: 0x000B6B0B
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSortGroupById.LogPair = null;
			ConfigFilterSortGroupById.HandleId = 0;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000B8919 File Offset: 0x000B6B19
		public static void Init()
		{
			ConfigFilterSortGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSortGroupById.HandleId, "db_filter_sort.db", "select BinData from `FilterSortGroup` where Id = ?");
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x000B8934 File Offset: 0x000B6B34
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

		// Token: 0x0400137F RID: 4991
		private const string DB = "db_filter_sort.db";

		// Token: 0x04001380 RID: 4992
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x04001381 RID: 4993
		private const string TABLE = "FilterSortGroup";

		// Token: 0x04001382 RID: 4994
		private const string COMMAND = "select BinData from `FilterSortGroup` where Id = ?";

		// Token: 0x04001383 RID: 4995
		private const string KEY_PREFIX = "FilterSortGroupById";

		// Token: 0x04001384 RID: 4996
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001385 RID: 4997
		private static int HandleId;
	}
}
