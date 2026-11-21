using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F5 RID: 2037
	public class ConfigRegressRecommendByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FD0 RID: 12240 RVA: 0x0016AEF4 File Offset: 0x001690F4
		static ConfigRegressRecommendByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendByType.CreateStaticDefaultValue), new Action(ConfigRegressRecommendByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x0016AF14 File Offset: 0x00169114
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

		// Token: 0x06002FD2 RID: 12242 RVA: 0x0016AF93 File Offset: 0x00169193
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendByType.LogPair = null;
			ConfigRegressRecommendByType.HandleId = 0;
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x0016AFA1 File Offset: 0x001691A1
		public static void Init()
		{
			ConfigRegressRecommendByType.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendByType.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend` where Type=?");
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x0016AFBC File Offset: 0x001691BC
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

		// Token: 0x04003799 RID: 14233
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400379A RID: 14234
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400379B RID: 14235
		private const string TABLE = "RegressRecommend";

		// Token: 0x0400379C RID: 14236
		private const string COMMAND = "select BinData from `RegressRecommend` where Type=?";

		// Token: 0x0400379D RID: 14237
		private const string KEY_PREFIX = "RegressRecommendByType";

		// Token: 0x0400379E RID: 14238
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400379F RID: 14239
		private static int HandleId;
	}
}
