using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061F RID: 1567
	public class ConfigNewTowerScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x0012D0C1 File Offset: 0x0012B2C1
		static ConfigNewTowerScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreRewardById.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0012D0E0 File Offset: 0x0012B2E0
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

		// Token: 0x060024CC RID: 9420 RVA: 0x0012D15F File Offset: 0x0012B35F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreRewardById.LogPair = null;
			ConfigNewTowerScoreRewardById.HandleId = 0;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0012D16D File Offset: 0x0012B36D
		public static void Init()
		{
			ConfigNewTowerScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreRewardById.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreReward` where Id=?");
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0012D188 File Offset: 0x0012B388
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

		// Token: 0x04002ABF RID: 10943
		private const string DB = "db_newtower.db";

		// Token: 0x04002AC0 RID: 10944
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AC1 RID: 10945
		private const string TABLE = "NewTowerScoreReward";

		// Token: 0x04002AC2 RID: 10946
		private const string COMMAND = "select BinData from `NewTowerScoreReward` where Id=?";

		// Token: 0x04002AC3 RID: 10947
		private const string KEY_PREFIX = "NewTowerScoreRewardById";

		// Token: 0x04002AC4 RID: 10948
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AC5 RID: 10949
		private static int HandleId;
	}
}
