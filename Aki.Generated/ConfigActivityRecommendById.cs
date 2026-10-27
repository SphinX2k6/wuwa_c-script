using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004C RID: 76
	public class ConfigActivityRecommendById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x00063CA3 File Offset: 0x00061EA3
		static ConfigActivityRecommendById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendById.CreateStaticDefaultValue), new Action(ConfigActivityRecommendById.ResetStaticDefaultValue));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00063CC4 File Offset: 0x00061EC4
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

		// Token: 0x060001CA RID: 458 RVA: 0x00063D43 File Offset: 0x00061F43
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendById.LogPair = null;
			ConfigActivityRecommendById.HandleId = 0;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00063D51 File Offset: 0x00061F51
		public static void Init()
		{
			ConfigActivityRecommendById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendById.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommend` where Id=?");
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00063D6C File Offset: 0x00061F6C
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

		// Token: 0x040001F8 RID: 504
		private const string DB = "db_activityrecommend.db";

		// Token: 0x040001F9 RID: 505
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x040001FA RID: 506
		private const string TABLE = "ActivityRecommend";

		// Token: 0x040001FB RID: 507
		private const string COMMAND = "select BinData from `ActivityRecommend` where Id=?";

		// Token: 0x040001FC RID: 508
		private const string KEY_PREFIX = "ActivityRecommendById";

		// Token: 0x040001FD RID: 509
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001FE RID: 510
		private static int HandleId;
	}
}
