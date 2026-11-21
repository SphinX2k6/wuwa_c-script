using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A37 RID: 2615
	public class ConfigSortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D5E RID: 15710 RVA: 0x001B77F9 File Offset: 0x001B59F9
		static ConfigSortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSortById.CreateStaticDefaultValue), new Action(ConfigSortById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x001B7818 File Offset: 0x001B5A18
		public static void CreateStaticDefaultValue()
		{
			ConfigSortById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSortById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_filter_sort.db"),
				new ValueTuple<string, object>("文件", "s.筛选排序总表.xlsx"),
				new ValueTuple<string, object>("表名", "Sort"),
				new ValueTuple<string, object>("语句", "select BinData from `Sort` where Id=?")
			});
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x001B7897 File Offset: 0x001B5A97
		public static void ResetStaticDefaultValue()
		{
			ConfigSortById.LogPair = null;
			ConfigSortById.HandleId = 0;
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x001B78A5 File Offset: 0x001B5AA5
		public static void Init()
		{
			ConfigSortById.HandleId = ConfigCommon.InitDataStatement(ConfigSortById.HandleId, "db_filter_sort.db", "select BinData from `Sort` where Id=?");
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x001B78C0 File Offset: 0x001B5AC0
		public static Sort? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSortById.HandleId, ConfigSortById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Sort?(Sort.GetRootAsSort(configBuffer));
				}
			}
			ConfigSortById.LogPair.Clear();
			ConfigSortById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSortById.HandleId, 1, p0Id, ConfigSortById.LogPair) || ConfigCommon.Step(ConfigSortById.HandleId, true, ConfigSortById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSortById.HandleId, ConfigSortById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSortById.HandleId, 0, ConfigSortById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSortById.HandleId, ConfigSortById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Sort rootAsSort = Sort.GetRootAsSort(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSortById.HandleId, ConfigSortById.LogPair);
			return new Sort?(rootAsSort);
		}

		// Token: 0x04004767 RID: 18279
		private const string DB = "db_filter_sort.db";

		// Token: 0x04004768 RID: 18280
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x04004769 RID: 18281
		private const string TABLE = "Sort";

		// Token: 0x0400476A RID: 18282
		private const string COMMAND = "select BinData from `Sort` where Id=?";

		// Token: 0x0400476B RID: 18283
		private const string KEY_PREFIX = "SortById";

		// Token: 0x0400476C RID: 18284
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400476D RID: 18285
		private static int HandleId;
	}
}
