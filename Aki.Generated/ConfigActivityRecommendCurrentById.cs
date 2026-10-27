using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004F RID: 79
	public class ConfigActivityRecommendCurrentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001DA RID: 474 RVA: 0x000642C7 File Offset: 0x000624C7
		static ConfigActivityRecommendCurrentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendCurrentById.CreateStaticDefaultValue), new Action(ConfigActivityRecommendCurrentById.ResetStaticDefaultValue));
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000642E8 File Offset: 0x000624E8
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

		// Token: 0x060001DC RID: 476 RVA: 0x00064367 File Offset: 0x00062567
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendCurrentById.LogPair = null;
			ConfigActivityRecommendCurrentById.HandleId = 0;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00064375 File Offset: 0x00062575
		public static void Init()
		{
			ConfigActivityRecommendCurrentById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendCurrentById.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommendCurrent` where Id=?");
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00064390 File Offset: 0x00062590
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

		// Token: 0x0400020D RID: 525
		private const string DB = "db_activityrecommend.db";

		// Token: 0x0400020E RID: 526
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x0400020F RID: 527
		private const string TABLE = "ActivityRecommendCurrent";

		// Token: 0x04000210 RID: 528
		private const string COMMAND = "select BinData from `ActivityRecommendCurrent` where Id=?";

		// Token: 0x04000211 RID: 529
		private const string KEY_PREFIX = "ActivityRecommendCurrentById";

		// Token: 0x04000212 RID: 530
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000213 RID: 531
		private static int HandleId;
	}
}
