using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D7 RID: 2007
	public class ConfigRegressRecommendByActivityGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F1C RID: 12060 RVA: 0x0016378B File Offset: 0x0016198B
		static ConfigRegressRecommendByActivityGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendByActivityGroup.CreateStaticDefaultValue), new Action(ConfigRegressRecommendByActivityGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x001637AC File Offset: 0x001619AC
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

		// Token: 0x06002F1E RID: 12062 RVA: 0x0016382B File Offset: 0x00161A2B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendByActivityGroup.LogPair = null;
			ConfigRegressRecommendByActivityGroup.HandleId = 0;
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00163839 File Offset: 0x00161A39
		public static void Init()
		{
			ConfigRegressRecommendByActivityGroup.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendByActivityGroup.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend` where ActivityGroup=?");
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00163854 File Offset: 0x00161A54
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

		// Token: 0x040036C7 RID: 14023
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036C8 RID: 14024
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036C9 RID: 14025
		private const string TABLE = "RegressRecommend";

		// Token: 0x040036CA RID: 14026
		private const string COMMAND = "select BinData from `RegressRecommend` where ActivityGroup=?";

		// Token: 0x040036CB RID: 14027
		private const string KEY_PREFIX = "RegressRecommendByActivityGroup";

		// Token: 0x040036CC RID: 14028
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036CD RID: 14029
		private static int HandleId;
	}
}
