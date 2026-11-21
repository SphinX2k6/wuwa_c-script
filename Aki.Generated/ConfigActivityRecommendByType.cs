using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000055 RID: 85
	public class ConfigActivityRecommendByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001FE RID: 510 RVA: 0x000687A0 File Offset: 0x000669A0
		static ConfigActivityRecommendByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendByType.CreateStaticDefaultValue), new Action(ConfigActivityRecommendByType.ResetStaticDefaultValue));
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000687C0 File Offset: 0x000669C0
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

		// Token: 0x06000200 RID: 512 RVA: 0x0006883F File Offset: 0x00066A3F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendByType.LogPair = null;
			ConfigActivityRecommendByType.HandleId = 0;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0006884D File Offset: 0x00066A4D
		public static void Init()
		{
			ConfigActivityRecommendByType.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendByType.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommend` where Type=?");
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00068868 File Offset: 0x00066A68
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

		// Token: 0x04000237 RID: 567
		private const string DB = "db_activityrecommend.db";

		// Token: 0x04000238 RID: 568
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x04000239 RID: 569
		private const string TABLE = "ActivityRecommend";

		// Token: 0x0400023A RID: 570
		private const string COMMAND = "select BinData from `ActivityRecommend` where Type=?";

		// Token: 0x0400023B RID: 571
		private const string KEY_PREFIX = "ActivityRecommendByType";

		// Token: 0x0400023C RID: 572
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400023D RID: 573
		private static int HandleId;
	}
}
