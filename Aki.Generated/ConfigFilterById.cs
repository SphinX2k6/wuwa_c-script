using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C6 RID: 710
	public class ConfigFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010A9 RID: 4265 RVA: 0x000B79DC File Offset: 0x000B5BDC
		static ConfigFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterById.CreateStaticDefaultValue), new Action(ConfigFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000B79FC File Offset: 0x000B5BFC
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

		// Token: 0x060010AB RID: 4267 RVA: 0x000B7A7B File Offset: 0x000B5C7B
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterById.LogPair = null;
			ConfigFilterById.HandleId = 0;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000B7A89 File Offset: 0x000B5C89
		public static void Init()
		{
			ConfigFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterById.HandleId, "db_filter_sort.db", "select BinData from `Filter` where Id=?");
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000B7AA4 File Offset: 0x000B5CA4
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

		// Token: 0x0400134E RID: 4942
		private const string DB = "db_filter_sort.db";

		// Token: 0x0400134F RID: 4943
		private const string FILE = "s.筛选排序总表.xlsx";

		// Token: 0x04001350 RID: 4944
		private const string TABLE = "Filter";

		// Token: 0x04001351 RID: 4945
		private const string COMMAND = "select BinData from `Filter` where Id=?";

		// Token: 0x04001352 RID: 4946
		private const string KEY_PREFIX = "FilterById";

		// Token: 0x04001353 RID: 4947
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001354 RID: 4948
		private static int HandleId;
	}
}
