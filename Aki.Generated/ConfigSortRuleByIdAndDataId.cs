using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000963 RID: 2403
	public class ConfigSortRuleByIdAndDataId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003866 RID: 14438 RVA: 0x001986AC File Offset: 0x001968AC
		static ConfigSortRuleByIdAndDataId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSortRuleByIdAndDataId.CreateStaticDefaultValue), new Action(ConfigSortRuleByIdAndDataId.ResetStaticDefaultValue));
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x001986CC File Offset: 0x001968CC
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

		// Token: 0x06003868 RID: 14440 RVA: 0x0019874B File Offset: 0x0019694B
		public static void ResetStaticDefaultValue()
		{
			ConfigSortRuleByIdAndDataId.LogPair = null;
			ConfigSortRuleByIdAndDataId.HandleId = 0;
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x00198759 File Offset: 0x00196959
		public static void Init()
		{
			ConfigSortRuleByIdAndDataId.HandleId = ConfigCommon.InitDataStatement(ConfigSortRuleByIdAndDataId.HandleId, "db_filter_sort.db", "select BinData from `SortRule` where Id=? AND DataId = ?");
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x00198774 File Offset: 0x00196974
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

		// Token: 0x0400419B RID: 16795
		private const string DB = "db_filter_sort.db";

		// Token: 0x0400419C RID: 16796
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x0400419D RID: 16797
		private const string TABLE = "SortRule";

		// Token: 0x0400419E RID: 16798
		private const string COMMAND = "select BinData from `SortRule` where Id=? AND DataId = ?";

		// Token: 0x0400419F RID: 16799
		private const string KEY_PREFIX = "SortRuleByIdAndDataId";

		// Token: 0x040041A0 RID: 16800
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041A1 RID: 16801
		private static int HandleId;
	}
}
