using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000607 RID: 1543
	public class ConfigNewTowerScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600243A RID: 9274 RVA: 0x00126645 File Offset: 0x00124845
		static ConfigNewTowerScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreRewardById.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00126664 File Offset: 0x00124864
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerScoreReward` where Id=?")
			});
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x001266E3 File Offset: 0x001248E3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreRewardById.LogPair = null;
			ConfigNewTowerScoreRewardById.HandleId = 0;
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x001266F1 File Offset: 0x001248F1
		public static void Init()
		{
			ConfigNewTowerScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreRewardById.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreReward` where Id=?");
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0012670C File Offset: 0x0012490C
		public static NewTowerScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerScoreRewardById.HandleId, ConfigNewTowerScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerScoreReward?(NewTowerScoreReward.GetRootAsNewTowerScoreReward(configBuffer));
				}
			}
			ConfigNewTowerScoreRewardById.LogPair.Clear();
			ConfigNewTowerScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerScoreRewardById.HandleId, 1, p0Id, ConfigNewTowerScoreRewardById.LogPair) || ConfigCommon.Step(ConfigNewTowerScoreRewardById.HandleId, true, ConfigNewTowerScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerScoreRewardById.HandleId, ConfigNewTowerScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerScoreRewardById.HandleId, 0, ConfigNewTowerScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerScoreRewardById.HandleId, ConfigNewTowerScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerScoreReward rootAsNewTowerScoreReward = NewTowerScoreReward.GetRootAsNewTowerScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerScoreRewardById.HandleId, ConfigNewTowerScoreRewardById.LogPair);
			return new NewTowerScoreReward?(rootAsNewTowerScoreReward);
		}

		// Token: 0x04002A17 RID: 10775
		private const string DB = "db_newtower.db";

		// Token: 0x04002A18 RID: 10776
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A19 RID: 10777
		private const string TABLE = "NewTowerScoreReward";

		// Token: 0x04002A1A RID: 10778
		private const string COMMAND = "select BinData from `NewTowerScoreReward` where Id=?";

		// Token: 0x04002A1B RID: 10779
		private const string KEY_PREFIX = "NewTowerScoreRewardById";

		// Token: 0x04002A1C RID: 10780
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A1D RID: 10781
		private static int HandleId;
	}
}
