using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079E RID: 1950
	public class ConfigRacingBetsBulletScreenById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DC6 RID: 11718 RVA: 0x0015BEAC File Offset: 0x0015A0AC
		static ConfigRacingBetsBulletScreenById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsBulletScreenById.CreateStaticDefaultValue), new Action(ConfigRacingBetsBulletScreenById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x0015BECC File Offset: 0x0015A0CC
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsBulletScreenById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsBulletScreenById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsBulletScreen"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsBulletScreen` where Id=?")
			});
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x0015BF4B File Offset: 0x0015A14B
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsBulletScreenById.LogPair = null;
			ConfigRacingBetsBulletScreenById.HandleId = 0;
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0015BF59 File Offset: 0x0015A159
		public static void Init()
		{
			ConfigRacingBetsBulletScreenById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsBulletScreenById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsBulletScreen` where Id=?");
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x0015BF74 File Offset: 0x0015A174
		public static RacingBetsBulletScreen? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsBulletScreenById.HandleId, ConfigRacingBetsBulletScreenById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsBulletScreenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsBulletScreen?(RacingBetsBulletScreen.GetRootAsRacingBetsBulletScreen(configBuffer));
				}
			}
			ConfigRacingBetsBulletScreenById.LogPair.Clear();
			ConfigRacingBetsBulletScreenById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsBulletScreenById.HandleId, 1, p0Id, ConfigRacingBetsBulletScreenById.LogPair) || ConfigCommon.Step(ConfigRacingBetsBulletScreenById.HandleId, true, ConfigRacingBetsBulletScreenById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsBulletScreenById.HandleId, ConfigRacingBetsBulletScreenById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsBulletScreenById.HandleId, 0, ConfigRacingBetsBulletScreenById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsBulletScreenById.HandleId, ConfigRacingBetsBulletScreenById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsBulletScreen rootAsRacingBetsBulletScreen = RacingBetsBulletScreen.GetRootAsRacingBetsBulletScreen(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsBulletScreenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsBulletScreenById.HandleId, ConfigRacingBetsBulletScreenById.LogPair);
			return new RacingBetsBulletScreen?(rootAsRacingBetsBulletScreen);
		}

		// Token: 0x04003538 RID: 13624
		private const string DB = "db_racingbets.db";

		// Token: 0x04003539 RID: 13625
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400353A RID: 13626
		private const string TABLE = "RacingBetsBulletScreen";

		// Token: 0x0400353B RID: 13627
		private const string COMMAND = "select BinData from `RacingBetsBulletScreen` where Id=?";

		// Token: 0x0400353C RID: 13628
		private const string KEY_PREFIX = "RacingBetsBulletScreenById";

		// Token: 0x0400353D RID: 13629
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400353E RID: 13630
		private static int HandleId;
	}
}
