using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000173 RID: 371
	public class ConfigCircumScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008B3 RID: 2227 RVA: 0x0008A9E7 File Offset: 0x00088BE7
		static ConfigCircumScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumScoreRewardById.CreateStaticDefaultValue), new Action(ConfigCircumScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0008AA08 File Offset: 0x00088C08
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

		// Token: 0x060008B5 RID: 2229 RVA: 0x0008AA87 File Offset: 0x00088C87
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumScoreRewardById.LogPair = null;
			ConfigCircumScoreRewardById.HandleId = 0;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0008AA95 File Offset: 0x00088C95
		public static void Init()
		{
			ConfigCircumScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigCircumScoreRewardById.HandleId, "db_circumfluence.db", "select BinData from `CircumScoreReward` where Id=?");
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0008AAB0 File Offset: 0x00088CB0
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

		// Token: 0x04000A09 RID: 2569
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A0A RID: 2570
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A0B RID: 2571
		private const string TABLE = "CircumScoreReward";

		// Token: 0x04000A0C RID: 2572
		private const string COMMAND = "select BinData from `CircumScoreReward` where Id=?";

		// Token: 0x04000A0D RID: 2573
		private const string KEY_PREFIX = "CircumScoreRewardById";

		// Token: 0x04000A0E RID: 2574
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A0F RID: 2575
		private static int HandleId;
	}
}
