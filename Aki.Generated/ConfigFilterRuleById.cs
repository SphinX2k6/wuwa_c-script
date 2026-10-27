using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C7 RID: 711
	public class ConfigFilterRuleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x000B7C24 File Offset: 0x000B5E24
		static ConfigFilterRuleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterRuleById.CreateStaticDefaultValue), new Action(ConfigFilterRuleById.ResetStaticDefaultValue));
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x000B7C44 File Offset: 0x000B5E44
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

		// Token: 0x060010B1 RID: 4273 RVA: 0x000B7CC3 File Offset: 0x000B5EC3
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterRuleById.LogPair = null;
			ConfigFilterRuleById.HandleId = 0;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x000B7CD1 File Offset: 0x000B5ED1
		public static void Init()
		{
			ConfigFilterRuleById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterRuleById.HandleId, "db_filter_sort.db", "select BinData from `FilterRule` where Id=?");
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x000B7CEC File Offset: 0x000B5EEC
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

		// Token: 0x04001355 RID: 4949
		private const string DB = "db_filter_sort.db";

		// Token: 0x04001356 RID: 4950
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x04001357 RID: 4951
		private const string TABLE = "FilterRule";

		// Token: 0x04001358 RID: 4952
		private const string COMMAND = "select BinData from `FilterRule` where Id=?";

		// Token: 0x04001359 RID: 4953
		private const string KEY_PREFIX = "FilterRuleById";

		// Token: 0x0400135A RID: 4954
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400135B RID: 4955
		private static int HandleId;
	}
}
