using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000053 RID: 83
	public class ConfigActivityRecommendByActivityGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x0006831F File Offset: 0x0006651F
		static ConfigActivityRecommendByActivityGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendByActivityGroup.CreateStaticDefaultValue), new Action(ConfigActivityRecommendByActivityGroup.ResetStaticDefaultValue));
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00068340 File Offset: 0x00066540
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityRecommendByActivityGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityRecommendByActivityGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityrecommend.db"),
				new ValueTuple<string, object>("文件", "h.活动推荐内容.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityRecommend` where ActivityGroup=?")
			});
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000683BF File Offset: 0x000665BF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendByActivityGroup.LogPair = null;
			ConfigActivityRecommendByActivityGroup.HandleId = 0;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000683CD File Offset: 0x000665CD
		public static void Init()
		{
			ConfigActivityRecommendByActivityGroup.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendByActivityGroup.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommend` where ActivityGroup=?");
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000683E8 File Offset: 0x000665E8
		[NullableContext(2)]
		public static IReadOnlyList<ActivityRecommend> GetConfigList(int p0ActivityGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityRecommendByActivityGroup.HandleId, ConfigActivityRecommendByActivityGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendByActivityGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityGroup);
				IReadOnlyList<ActivityRecommend> readOnlyList = (IReadOnlyList<ActivityRecommend>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigActivityRecommendByActivityGroup.LogPair.Clear();
			ConfigActivityRecommendByActivityGroup.LogPair.Add(new ValueTuple<string, object>("ActivityGroup", p0ActivityGroup));
			if (!ConfigCommon.BindInt(ConfigActivityRecommendByActivityGroup.HandleId, 1, p0ActivityGroup, ConfigActivityRecommendByActivityGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigActivityRecommendByActivityGroup.HandleId, ConfigActivityRecommendByActivityGroup.LogPair);
				return null;
			}
			List<ActivityRecommend> list = new List<ActivityRecommend>();
			while (ConfigCommon.Step(ConfigActivityRecommendByActivityGroup.HandleId, false, ConfigActivityRecommendByActivityGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityRecommendByActivityGroup.HandleId, 0, ConfigActivityRecommendByActivityGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityRecommendByActivityGroup.HandleId, ConfigActivityRecommendByActivityGroup.LogPair);
					return null;
				}
				ActivityRecommend rootAsActivityRecommend = ActivityRecommend.GetRootAsActivityRecommend(new ByteBuffer(item2));
				list.Add(rootAsActivityRecommend);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendByActivityGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityRecommendByActivityGroup.HandleId, ConfigActivityRecommendByActivityGroup.LogPair);
			return list;
		}

		// Token: 0x04000229 RID: 553
		private const string DB = "db_activityrecommend.db";

		// Token: 0x0400022A RID: 554
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x0400022B RID: 555
		private const string TABLE = "ActivityRecommend";

		// Token: 0x0400022C RID: 556
		private const string COMMAND = "select BinData from `ActivityRecommend` where ActivityGroup=?";

		// Token: 0x0400022D RID: 557
		private const string KEY_PREFIX = "ActivityRecommendByActivityGroup";

		// Token: 0x0400022E RID: 558
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400022F RID: 559
		private static int HandleId;
	}
}
