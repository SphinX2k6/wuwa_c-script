using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000962 RID: 2402
	public class ConfigSortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003860 RID: 14432 RVA: 0x00198464 File Offset: 0x00196664
		static ConfigSortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSortById.CreateStaticDefaultValue), new Action(ConfigSortById.ResetStaticDefaultValue));
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00198484 File Offset: 0x00196684
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

		// Token: 0x06003862 RID: 14434 RVA: 0x00198503 File Offset: 0x00196703
		public static void ResetStaticDefaultValue()
		{
			ConfigSortById.LogPair = null;
			ConfigSortById.HandleId = 0;
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x00198511 File Offset: 0x00196711
		public static void Init()
		{
			ConfigSortById.HandleId = ConfigCommon.InitDataStatement(ConfigSortById.HandleId, "db_filter_sort.db", "select BinData from `Sort` where Id=?");
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x0019852C File Offset: 0x0019672C
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

		// Token: 0x04004194 RID: 16788
		private const string DB = "db_filter_sort.db";

		// Token: 0x04004195 RID: 16789
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x04004196 RID: 16790
		private const string TABLE = "Sort";

		// Token: 0x04004197 RID: 16791
		private const string COMMAND = "select BinData from `Sort` where Id=?";

		// Token: 0x04004198 RID: 16792
		private const string KEY_PREFIX = "SortById";

		// Token: 0x04004199 RID: 16793
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400419A RID: 16794
		private static int HandleId;
	}
}
