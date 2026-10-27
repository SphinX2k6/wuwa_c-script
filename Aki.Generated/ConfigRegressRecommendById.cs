using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D8 RID: 2008
	public class ConfigRegressRecommendById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F22 RID: 12066 RVA: 0x001639C3 File Offset: 0x00161BC3
		static ConfigRegressRecommendById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendById.CreateStaticDefaultValue), new Action(ConfigRegressRecommendById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x001639E4 File Offset: 0x00161BE4
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressRecommendById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressRecommendById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressRecommend` where Id=?")
			});
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00163A63 File Offset: 0x00161C63
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendById.LogPair = null;
			ConfigRegressRecommendById.HandleId = 0;
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00163A71 File Offset: 0x00161C71
		public static void Init()
		{
			ConfigRegressRecommendById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendById.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend` where Id=?");
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00163A8C File Offset: 0x00161C8C
		public static RegressRecommend? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressRecommendById.HandleId, ConfigRegressRecommendById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRecommendById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressRecommend?(RegressRecommend.GetRootAsRegressRecommend(configBuffer));
				}
			}
			ConfigRegressRecommendById.LogPair.Clear();
			ConfigRegressRecommendById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressRecommendById.HandleId, 1, p0Id, ConfigRegressRecommendById.LogPair) || ConfigCommon.Step(ConfigRegressRecommendById.HandleId, true, ConfigRegressRecommendById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressRecommendById.HandleId, ConfigRegressRecommendById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressRecommendById.HandleId, 0, ConfigRegressRecommendById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressRecommendById.HandleId, ConfigRegressRecommendById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressRecommend rootAsRegressRecommend = RegressRecommend.GetRootAsRegressRecommend(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRecommendById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressRecommendById.HandleId, ConfigRegressRecommendById.LogPair);
			return new RegressRecommend?(rootAsRegressRecommend);
		}

		// Token: 0x040036CE RID: 14030
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036CF RID: 14031
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036D0 RID: 14032
		private const string TABLE = "RegressRecommend";

		// Token: 0x040036D1 RID: 14033
		private const string COMMAND = "select BinData from `RegressRecommend` where Id=?";

		// Token: 0x040036D2 RID: 14034
		private const string KEY_PREFIX = "RegressRecommendById";

		// Token: 0x040036D3 RID: 14035
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036D4 RID: 14036
		private static int HandleId;
	}
}
