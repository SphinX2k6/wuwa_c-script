using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DB RID: 731
	public class ConfigFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		static ConfigFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterById.CreateStaticDefaultValue), new Action(ConfigFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000BDF08 File Offset: 0x000BC108
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_filter_sort.db"),
				new ValueTuple<string, object>("文件", "s.筛选排序总表.xlsx"),
				new ValueTuple<string, object>("表名", "Filter"),
				new ValueTuple<string, object>("语句", "select BinData from `Filter` where Id=?")
			});
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x000BDF87 File Offset: 0x000BC187
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterById.LogPair = null;
			ConfigFilterById.HandleId = 0;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000BDF95 File Offset: 0x000BC195
		public static void Init()
		{
			ConfigFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterById.HandleId, "db_filter_sort.db", "select BinData from `Filter` where Id=?");
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000BDFB0 File Offset: 0x000BC1B0
		public static Filter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterById.HandleId, ConfigFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Filter?(Filter.GetRootAsFilter(configBuffer));
				}
			}
			ConfigFilterById.LogPair.Clear();
			ConfigFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFilterById.HandleId, 1, p0Id, ConfigFilterById.LogPair) || ConfigCommon.Step(ConfigFilterById.HandleId, true, ConfigFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFilterById.HandleId, ConfigFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterById.HandleId, 0, ConfigFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFilterById.HandleId, ConfigFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Filter rootAsFilter = Filter.GetRootAsFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFilterById.HandleId, ConfigFilterById.LogPair);
			return new Filter?(rootAsFilter);
		}

		// Token: 0x040013E1 RID: 5089
		private const string DB = "db_filter_sort.db";

		// Token: 0x040013E2 RID: 5090
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x040013E3 RID: 5091
		private const string TABLE = "Filter";

		// Token: 0x040013E4 RID: 5092
		private const string COMMAND = "select BinData from `Filter` where Id=?";

		// Token: 0x040013E5 RID: 5093
		private const string KEY_PREFIX = "FilterById";

		// Token: 0x040013E6 RID: 5094
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013E7 RID: 5095
		private static int HandleId;
	}
}
