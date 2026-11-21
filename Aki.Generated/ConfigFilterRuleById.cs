using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DC RID: 732
	public class ConfigFilterRuleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600112D RID: 4397 RVA: 0x000BE130 File Offset: 0x000BC330
		static ConfigFilterRuleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterRuleById.CreateStaticDefaultValue), new Action(ConfigFilterRuleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x000BE150 File Offset: 0x000BC350
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterRuleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterRuleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_filter_sort.db"),
				new ValueTuple<string, object>("文件", "s.筛选排序总表.xlsx"),
				new ValueTuple<string, object>("表名", "FilterRule"),
				new ValueTuple<string, object>("语句", "select BinData from `FilterRule` where Id=?")
			});
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x000BE1CF File Offset: 0x000BC3CF
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterRuleById.LogPair = null;
			ConfigFilterRuleById.HandleId = 0;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x000BE1DD File Offset: 0x000BC3DD
		public static void Init()
		{
			ConfigFilterRuleById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterRuleById.HandleId, "db_filter_sort.db", "select BinData from `FilterRule` where Id=?");
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x000BE1F8 File Offset: 0x000BC3F8
		public static FilterRule? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterRuleById.HandleId, ConfigFilterRuleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterRuleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FilterRule?(FilterRule.GetRootAsFilterRule(configBuffer));
				}
			}
			ConfigFilterRuleById.LogPair.Clear();
			ConfigFilterRuleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFilterRuleById.HandleId, 1, p0Id, ConfigFilterRuleById.LogPair) || ConfigCommon.Step(ConfigFilterRuleById.HandleId, true, ConfigFilterRuleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFilterRuleById.HandleId, ConfigFilterRuleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterRuleById.HandleId, 0, ConfigFilterRuleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFilterRuleById.HandleId, ConfigFilterRuleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FilterRule rootAsFilterRule = FilterRule.GetRootAsFilterRule(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterRuleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFilterRuleById.HandleId, ConfigFilterRuleById.LogPair);
			return new FilterRule?(rootAsFilterRule);
		}

		// Token: 0x040013E8 RID: 5096
		private const string DB = "db_filter_sort.db";

		// Token: 0x040013E9 RID: 5097
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x040013EA RID: 5098
		private const string TABLE = "FilterRule";

		// Token: 0x040013EB RID: 5099
		private const string COMMAND = "select BinData from `FilterRule` where Id=?";

		// Token: 0x040013EC RID: 5100
		private const string KEY_PREFIX = "FilterRuleById";

		// Token: 0x040013ED RID: 5101
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013EE RID: 5102
		private static int HandleId;
	}
}
