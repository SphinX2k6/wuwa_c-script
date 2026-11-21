using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B8 RID: 1976
	public class ConfigRacingBetsBulletScreenById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E62 RID: 11874 RVA: 0x00162DB8 File Offset: 0x00160FB8
		static ConfigRacingBetsBulletScreenById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsBulletScreenById.CreateStaticDefaultValue), new Action(ConfigRacingBetsBulletScreenById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00162DD8 File Offset: 0x00160FD8
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

		// Token: 0x06002E64 RID: 11876 RVA: 0x00162E57 File Offset: 0x00161057
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsBulletScreenById.LogPair = null;
			ConfigRacingBetsBulletScreenById.HandleId = 0;
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00162E65 File Offset: 0x00161065
		public static void Init()
		{
			ConfigRacingBetsBulletScreenById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsBulletScreenById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsBulletScreen` where Id=?");
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00162E80 File Offset: 0x00161080
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

		// Token: 0x040035EE RID: 13806
		private const string DB = "db_racingbets.db";

		// Token: 0x040035EF RID: 13807
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035F0 RID: 13808
		private const string TABLE = "RacingBetsBulletScreen";

		// Token: 0x040035F1 RID: 13809
		private const string COMMAND = "select BinData from `RacingBetsBulletScreen` where Id=?";

		// Token: 0x040035F2 RID: 13810
		private const string KEY_PREFIX = "RacingBetsBulletScreenById";

		// Token: 0x040035F3 RID: 13811
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035F4 RID: 13812
		private static int HandleId;
	}
}
