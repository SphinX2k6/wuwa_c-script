using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004D RID: 77
	public class ConfigActivityRecommendByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00063EEC File Offset: 0x000620EC
		static ConfigActivityRecommendByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendByType.CreateStaticDefaultValue), new Action(ConfigActivityRecommendByType.ResetStaticDefaultValue));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00063F0C File Offset: 0x0006210C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityRecommendByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityRecommendByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityrecommend.db"),
				new ValueTuple<string, object>("文件", "h.活动推荐内容.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityRecommend` where Type=?")
			});
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00063F8B File Offset: 0x0006218B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendByType.LogPair = null;
			ConfigActivityRecommendByType.HandleId = 0;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00063F99 File Offset: 0x00062199
		public static void Init()
		{
			ConfigActivityRecommendByType.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendByType.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommend` where Type=?");
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00063FB4 File Offset: 0x000621B4
		public static ActivityRecommend? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityRecommendByType.HandleId, ConfigActivityRecommendByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityRecommend?(ActivityRecommend.GetRootAsActivityRecommend(configBuffer));
				}
			}
			ConfigActivityRecommendByType.LogPair.Clear();
			ConfigActivityRecommendByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigActivityRecommendByType.HandleId, 1, p0Type, ConfigActivityRecommendByType.LogPair) || ConfigCommon.Step(ConfigActivityRecommendByType.HandleId, true, ConfigActivityRecommendByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityRecommendByType.HandleId, ConfigActivityRecommendByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityRecommendByType.HandleId, 0, ConfigActivityRecommendByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityRecommendByType.HandleId, ConfigActivityRecommendByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityRecommend rootAsActivityRecommend = ActivityRecommend.GetRootAsActivityRecommend(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityRecommendByType.HandleId, ConfigActivityRecommendByType.LogPair);
			return new ActivityRecommend?(rootAsActivityRecommend);
		}

		// Token: 0x040001FF RID: 511
		private const string DB = "db_activityrecommend.db";

		// Token: 0x04000200 RID: 512
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x04000201 RID: 513
		private const string TABLE = "ActivityRecommend";

		// Token: 0x04000202 RID: 514
		private const string COMMAND = "select BinData from `ActivityRecommend` where Type=?";

		// Token: 0x04000203 RID: 515
		private const string KEY_PREFIX = "ActivityRecommendByType";

		// Token: 0x04000204 RID: 516
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000205 RID: 517
		private static int HandleId;
	}
}
