using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F4 RID: 2036
	public class ConfigRegressRecommendById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FCA RID: 12234 RVA: 0x0016ACAB File Offset: 0x00168EAB
		static ConfigRegressRecommendById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendById.CreateStaticDefaultValue), new Action(ConfigRegressRecommendById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x0016ACCC File Offset: 0x00168ECC
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

		// Token: 0x06002FCC RID: 12236 RVA: 0x0016AD4B File Offset: 0x00168F4B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendById.LogPair = null;
			ConfigRegressRecommendById.HandleId = 0;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0016AD59 File Offset: 0x00168F59
		public static void Init()
		{
			ConfigRegressRecommendById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendById.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend` where Id=?");
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0016AD74 File Offset: 0x00168F74
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

		// Token: 0x04003792 RID: 14226
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003793 RID: 14227
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003794 RID: 14228
		private const string TABLE = "RegressRecommend";

		// Token: 0x04003795 RID: 14229
		private const string COMMAND = "select BinData from `RegressRecommend` where Id=?";

		// Token: 0x04003796 RID: 14230
		private const string KEY_PREFIX = "RegressRecommendById";

		// Token: 0x04003797 RID: 14231
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003798 RID: 14232
		private static int HandleId;
	}
}
