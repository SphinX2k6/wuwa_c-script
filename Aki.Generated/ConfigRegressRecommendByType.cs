using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D9 RID: 2009
	public class ConfigRegressRecommendByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F28 RID: 12072 RVA: 0x00163C0C File Offset: 0x00161E0C
		static ConfigRegressRecommendByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendByType.CreateStaticDefaultValue), new Action(ConfigRegressRecommendByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00163C2C File Offset: 0x00161E2C
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressRecommendByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressRecommendByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressRecommend` where Type=?")
			});
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00163CAB File Offset: 0x00161EAB
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendByType.LogPair = null;
			ConfigRegressRecommendByType.HandleId = 0;
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00163CB9 File Offset: 0x00161EB9
		public static void Init()
		{
			ConfigRegressRecommendByType.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendByType.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend` where Type=?");
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00163CD4 File Offset: 0x00161ED4
		[NullableContext(2)]
		public static IReadOnlyList<RegressRecommend> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressRecommendByType.HandleId, ConfigRegressRecommendByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRecommendByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<RegressRecommend> readOnlyList = (IReadOnlyList<RegressRecommend>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRegressRecommendByType.LogPair.Clear();
			ConfigRegressRecommendByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigRegressRecommendByType.HandleId, 1, p0Type, ConfigRegressRecommendByType.LogPair))
			{
				ConfigCommon.Reset(ConfigRegressRecommendByType.HandleId, ConfigRegressRecommendByType.LogPair);
				return null;
			}
			List<RegressRecommend> list = new List<RegressRecommend>();
			while (ConfigCommon.Step(ConfigRegressRecommendByType.HandleId, false, ConfigRegressRecommendByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressRecommendByType.HandleId, 0, ConfigRegressRecommendByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressRecommendByType.HandleId, ConfigRegressRecommendByType.LogPair);
					return null;
				}
				RegressRecommend rootAsRegressRecommend = RegressRecommend.GetRootAsRegressRecommend(new ByteBuffer(item2));
				list.Add(rootAsRegressRecommend);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRecommendByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressRecommendByType.HandleId, ConfigRegressRecommendByType.LogPair);
			return list;
		}

		// Token: 0x040036D5 RID: 14037
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036D6 RID: 14038
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036D7 RID: 14039
		private const string TABLE = "RegressRecommend";

		// Token: 0x040036D8 RID: 14040
		private const string COMMAND = "select BinData from `RegressRecommend` where Type=?";

		// Token: 0x040036D9 RID: 14041
		private const string KEY_PREFIX = "RegressRecommendByType";

		// Token: 0x040036DA RID: 14042
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036DB RID: 14043
		private static int HandleId;
	}
}
