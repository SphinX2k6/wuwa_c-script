using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000054 RID: 84
	public class ConfigActivityRecommendById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00068557 File Offset: 0x00066757
		static ConfigActivityRecommendById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendById.CreateStaticDefaultValue), new Action(ConfigActivityRecommendById.ResetStaticDefaultValue));
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00068578 File Offset: 0x00066778
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityRecommendById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityRecommendById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityrecommend.db"),
				new ValueTuple<string, object>("文件", "h.活动推荐内容.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityRecommend` where Id=?")
			});
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000685F7 File Offset: 0x000667F7
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendById.LogPair = null;
			ConfigActivityRecommendById.HandleId = 0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00068605 File Offset: 0x00066805
		public static void Init()
		{
			ConfigActivityRecommendById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendById.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommend` where Id=?");
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00068620 File Offset: 0x00066820
		public static ActivityRecommend? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityRecommendById.HandleId, ConfigActivityRecommendById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityRecommend?(ActivityRecommend.GetRootAsActivityRecommend(configBuffer));
				}
			}
			ConfigActivityRecommendById.LogPair.Clear();
			ConfigActivityRecommendById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityRecommendById.HandleId, 1, p0Id, ConfigActivityRecommendById.LogPair) || ConfigCommon.Step(ConfigActivityRecommendById.HandleId, true, ConfigActivityRecommendById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityRecommendById.HandleId, ConfigActivityRecommendById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityRecommendById.HandleId, 0, ConfigActivityRecommendById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityRecommendById.HandleId, ConfigActivityRecommendById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityRecommend rootAsActivityRecommend = ActivityRecommend.GetRootAsActivityRecommend(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityRecommendById.HandleId, ConfigActivityRecommendById.LogPair);
			return new ActivityRecommend?(rootAsActivityRecommend);
		}

		// Token: 0x04000230 RID: 560
		private const string DB = "db_activityrecommend.db";

		// Token: 0x04000231 RID: 561
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x04000232 RID: 562
		private const string TABLE = "ActivityRecommend";

		// Token: 0x04000233 RID: 563
		private const string COMMAND = "select BinData from `ActivityRecommend` where Id=?";

		// Token: 0x04000234 RID: 564
		private const string KEY_PREFIX = "ActivityRecommendById";

		// Token: 0x04000235 RID: 565
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000236 RID: 566
		private static int HandleId;
	}
}
