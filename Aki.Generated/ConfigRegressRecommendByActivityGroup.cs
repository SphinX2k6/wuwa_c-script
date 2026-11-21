using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F3 RID: 2035
	public class ConfigRegressRecommendByActivityGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FC4 RID: 12228 RVA: 0x0016AA73 File Offset: 0x00168C73
		static ConfigRegressRecommendByActivityGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendByActivityGroup.CreateStaticDefaultValue), new Action(ConfigRegressRecommendByActivityGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x0016AA94 File Offset: 0x00168C94
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressRecommendByActivityGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressRecommendByActivityGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressRecommend` where ActivityGroup=?")
			});
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x0016AB13 File Offset: 0x00168D13
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendByActivityGroup.LogPair = null;
			ConfigRegressRecommendByActivityGroup.HandleId = 0;
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x0016AB21 File Offset: 0x00168D21
		public static void Init()
		{
			ConfigRegressRecommendByActivityGroup.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendByActivityGroup.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend` where ActivityGroup=?");
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x0016AB3C File Offset: 0x00168D3C
		[NullableContext(2)]
		public static IReadOnlyList<RegressRecommend> GetConfigList(int p0ActivityGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressRecommendByActivityGroup.HandleId, ConfigRegressRecommendByActivityGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRecommendByActivityGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityGroup);
				IReadOnlyList<RegressRecommend> readOnlyList = (IReadOnlyList<RegressRecommend>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRegressRecommendByActivityGroup.LogPair.Clear();
			ConfigRegressRecommendByActivityGroup.LogPair.Add(new ValueTuple<string, object>("ActivityGroup", p0ActivityGroup));
			if (!ConfigCommon.BindInt(ConfigRegressRecommendByActivityGroup.HandleId, 1, p0ActivityGroup, ConfigRegressRecommendByActivityGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigRegressRecommendByActivityGroup.HandleId, ConfigRegressRecommendByActivityGroup.LogPair);
				return null;
			}
			List<RegressRecommend> list = new List<RegressRecommend>();
			while (ConfigCommon.Step(ConfigRegressRecommendByActivityGroup.HandleId, false, ConfigRegressRecommendByActivityGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressRecommendByActivityGroup.HandleId, 0, ConfigRegressRecommendByActivityGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressRecommendByActivityGroup.HandleId, ConfigRegressRecommendByActivityGroup.LogPair);
					return null;
				}
				RegressRecommend rootAsRegressRecommend = RegressRecommend.GetRootAsRegressRecommend(new ByteBuffer(item2));
				list.Add(rootAsRegressRecommend);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRecommendByActivityGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressRecommendByActivityGroup.HandleId, ConfigRegressRecommendByActivityGroup.LogPair);
			return list;
		}

		// Token: 0x0400378B RID: 14219
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400378C RID: 14220
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400378D RID: 14221
		private const string TABLE = "RegressRecommend";

		// Token: 0x0400378E RID: 14222
		private const string COMMAND = "select BinData from `RegressRecommend` where ActivityGroup=?";

		// Token: 0x0400378F RID: 14223
		private const string KEY_PREFIX = "RegressRecommendByActivityGroup";

		// Token: 0x04003790 RID: 14224
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003791 RID: 14225
		private static int HandleId;
	}
}
