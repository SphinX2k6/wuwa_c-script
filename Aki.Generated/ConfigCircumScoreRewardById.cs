using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000183 RID: 387
	public class ConfigCircumScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000913 RID: 2323 RVA: 0x00090543 File Offset: 0x0008E743
		static ConfigCircumScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumScoreRewardById.CreateStaticDefaultValue), new Action(ConfigCircumScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00090564 File Offset: 0x0008E764
		public static void CreateStaticDefaultValue()
		{
			ConfigCircumScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCircumScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "CircumScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CircumScoreReward` where Id=?")
			});
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000905E3 File Offset: 0x0008E7E3
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumScoreRewardById.LogPair = null;
			ConfigCircumScoreRewardById.HandleId = 0;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000905F1 File Offset: 0x0008E7F1
		public static void Init()
		{
			ConfigCircumScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigCircumScoreRewardById.HandleId, "db_circumfluence.db", "select BinData from `CircumScoreReward` where Id=?");
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0009060C File Offset: 0x0008E80C
		public static CircumScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCircumScoreRewardById.HandleId, ConfigCircumScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CircumScoreReward?(CircumScoreReward.GetRootAsCircumScoreReward(configBuffer));
				}
			}
			ConfigCircumScoreRewardById.LogPair.Clear();
			ConfigCircumScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCircumScoreRewardById.HandleId, 1, p0Id, ConfigCircumScoreRewardById.LogPair) || ConfigCommon.Step(ConfigCircumScoreRewardById.HandleId, true, ConfigCircumScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCircumScoreRewardById.HandleId, ConfigCircumScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCircumScoreRewardById.HandleId, 0, ConfigCircumScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCircumScoreRewardById.HandleId, ConfigCircumScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CircumScoreReward rootAsCircumScoreReward = CircumScoreReward.GetRootAsCircumScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCircumScoreRewardById.HandleId, ConfigCircumScoreRewardById.LogPair);
			return new CircumScoreReward?(rootAsCircumScoreReward);
		}

		// Token: 0x04000A79 RID: 2681
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A7A RID: 2682
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A7B RID: 2683
		private const string TABLE = "CircumScoreReward";

		// Token: 0x04000A7C RID: 2684
		private const string COMMAND = "select BinData from `CircumScoreReward` where Id=?";

		// Token: 0x04000A7D RID: 2685
		private const string KEY_PREFIX = "CircumScoreRewardById";

		// Token: 0x04000A7E RID: 2686
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A7F RID: 2687
		private static int HandleId;
	}
}
