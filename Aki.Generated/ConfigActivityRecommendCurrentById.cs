using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000057 RID: 87
	public class ConfigActivityRecommendCurrentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600020A RID: 522 RVA: 0x00068B7B File Offset: 0x00066D7B
		static ConfigActivityRecommendCurrentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendCurrentById.CreateStaticDefaultValue), new Action(ConfigActivityRecommendCurrentById.ResetStaticDefaultValue));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00068B9C File Offset: 0x00066D9C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityRecommendCurrentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityRecommendCurrentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityrecommend.db"),
				new ValueTuple<string, object>("文件", "h.活动推荐内容.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityRecommendCurrent"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityRecommendCurrent` where Id=?")
			});
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00068C1B File Offset: 0x00066E1B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendCurrentById.LogPair = null;
			ConfigActivityRecommendCurrentById.HandleId = 0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00068C29 File Offset: 0x00066E29
		public static void Init()
		{
			ConfigActivityRecommendCurrentById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendCurrentById.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommendCurrent` where Id=?");
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00068C44 File Offset: 0x00066E44
		public static ActivityRecommendCurrent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityRecommendCurrentById.HandleId, ConfigActivityRecommendCurrentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendCurrentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityRecommendCurrent?(ActivityRecommendCurrent.GetRootAsActivityRecommendCurrent(configBuffer));
				}
			}
			ConfigActivityRecommendCurrentById.LogPair.Clear();
			ConfigActivityRecommendCurrentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityRecommendCurrentById.HandleId, 1, p0Id, ConfigActivityRecommendCurrentById.LogPair) || ConfigCommon.Step(ConfigActivityRecommendCurrentById.HandleId, true, ConfigActivityRecommendCurrentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityRecommendCurrentById.HandleId, ConfigActivityRecommendCurrentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityRecommendCurrentById.HandleId, 0, ConfigActivityRecommendCurrentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityRecommendCurrentById.HandleId, ConfigActivityRecommendCurrentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityRecommendCurrent rootAsActivityRecommendCurrent = ActivityRecommendCurrent.GetRootAsActivityRecommendCurrent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityRecommendCurrentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityRecommendCurrentById.HandleId, ConfigActivityRecommendCurrentById.LogPair);
			return new ActivityRecommendCurrent?(rootAsActivityRecommendCurrent);
		}

		// Token: 0x04000245 RID: 581
		private const string DB = "db_activityrecommend.db";

		// Token: 0x04000246 RID: 582
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x04000247 RID: 583
		private const string TABLE = "ActivityRecommendCurrent";

		// Token: 0x04000248 RID: 584
		private const string COMMAND = "select BinData from `ActivityRecommendCurrent` where Id=?";

		// Token: 0x04000249 RID: 585
		private const string KEY_PREFIX = "ActivityRecommendCurrentById";

		// Token: 0x0400024A RID: 586
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400024B RID: 587
		private static int HandleId;
	}
}
