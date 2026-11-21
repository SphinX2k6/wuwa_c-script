using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A38 RID: 2616
	public class ConfigSortRuleByIdAndDataId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D64 RID: 15716 RVA: 0x001B7A40 File Offset: 0x001B5C40
		static ConfigSortRuleByIdAndDataId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSortRuleByIdAndDataId.CreateStaticDefaultValue), new Action(ConfigSortRuleByIdAndDataId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x001B7A60 File Offset: 0x001B5C60
		public static void CreateStaticDefaultValue()
		{
			ConfigSortRuleByIdAndDataId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSortRuleByIdAndDataId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_filter_sort.db"),
				new ValueTuple<string, object>("文件", "s.筛选排序总表.xlsx"),
				new ValueTuple<string, object>("表名", "SortRule"),
				new ValueTuple<string, object>("语句", "select BinData from `SortRule` where Id=? AND DataId = ?")
			});
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x001B7ADF File Offset: 0x001B5CDF
		public static void ResetStaticDefaultValue()
		{
			ConfigSortRuleByIdAndDataId.LogPair = null;
			ConfigSortRuleByIdAndDataId.HandleId = 0;
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x001B7AED File Offset: 0x001B5CED
		public static void Init()
		{
			ConfigSortRuleByIdAndDataId.HandleId = ConfigCommon.InitDataStatement(ConfigSortRuleByIdAndDataId.HandleId, "db_filter_sort.db", "select BinData from `SortRule` where Id=? AND DataId = ?");
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x001B7B08 File Offset: 0x001B5D08
		public static SortRule? GetConfig(int p0Id, int p1DataId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSortRuleByIdAndDataId.HandleId, ConfigSortRuleByIdAndDataId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SortRuleByIdAndDataId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1DataId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SortRule?(SortRule.GetRootAsSortRule(configBuffer));
				}
			}
			ConfigSortRuleByIdAndDataId.LogPair.Clear();
			ConfigSortRuleByIdAndDataId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigSortRuleByIdAndDataId.LogPair.Add(new ValueTuple<string, object>("DataId", p1DataId));
			if (!ConfigCommon.BindInt(ConfigSortRuleByIdAndDataId.HandleId, 1, p0Id, ConfigSortRuleByIdAndDataId.LogPair) || !ConfigCommon.BindInt(ConfigSortRuleByIdAndDataId.HandleId, 2, p1DataId, ConfigSortRuleByIdAndDataId.LogPair) || ConfigCommon.Step(ConfigSortRuleByIdAndDataId.HandleId, true, ConfigSortRuleByIdAndDataId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSortRuleByIdAndDataId.HandleId, ConfigSortRuleByIdAndDataId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSortRuleByIdAndDataId.HandleId, 0, ConfigSortRuleByIdAndDataId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSortRuleByIdAndDataId.HandleId, ConfigSortRuleByIdAndDataId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SortRule rootAsSortRule = SortRule.GetRootAsSortRule(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SortRuleByIdAndDataId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1DataId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSortRuleByIdAndDataId.HandleId, ConfigSortRuleByIdAndDataId.LogPair);
			return new SortRule?(rootAsSortRule);
		}

		// Token: 0x0400476E RID: 18286
		private const string DB = "db_filter_sort.db";

		// Token: 0x0400476F RID: 18287
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x04004770 RID: 18288
		private const string TABLE = "SortRule";

		// Token: 0x04004771 RID: 18289
		private const string COMMAND = "select BinData from `SortRule` where Id=? AND DataId = ?";

		// Token: 0x04004772 RID: 18290
		private const string KEY_PREFIX = "SortRuleByIdAndDataId";

		// Token: 0x04004773 RID: 18291
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004774 RID: 18292
		private static int HandleId;
	}
}
