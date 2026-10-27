using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060D RID: 1549
	public class ConfigNewTowerSeasonSAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600245E RID: 9310 RVA: 0x00127320 File Offset: 0x00125520
		static ConfigNewTowerSeasonSAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonSAwardById.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonSAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00127340 File Offset: 0x00125540
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonSAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonSAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeasonSAward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeasonSAward` where Id=?")
			});
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x001273BF File Offset: 0x001255BF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonSAwardById.LogPair = null;
			ConfigNewTowerSeasonSAwardById.HandleId = 0;
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x001273CD File Offset: 0x001255CD
		public static void Init()
		{
			ConfigNewTowerSeasonSAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonSAwardById.HandleId, "db_newtower.db", "select BinData from `NewTowerSeasonSAward` where Id=?");
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x001273E8 File Offset: 0x001255E8
		public static NewTowerSeasonSAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonSAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerSeasonSAward?(NewTowerSeasonSAward.GetRootAsNewTowerSeasonSAward(configBuffer));
				}
			}
			ConfigNewTowerSeasonSAwardById.LogPair.Clear();
			ConfigNewTowerSeasonSAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerSeasonSAwardById.HandleId, 1, p0Id, ConfigNewTowerSeasonSAwardById.LogPair) || ConfigCommon.Step(ConfigNewTowerSeasonSAwardById.HandleId, true, ConfigNewTowerSeasonSAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonSAwardById.HandleId, 0, ConfigNewTowerSeasonSAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerSeasonSAward rootAsNewTowerSeasonSAward = NewTowerSeasonSAward.GetRootAsNewTowerSeasonSAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonSAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair);
			return new NewTowerSeasonSAward?(rootAsNewTowerSeasonSAward);
		}

		// Token: 0x04002A41 RID: 10817
		private const string DB = "db_newtower.db";

		// Token: 0x04002A42 RID: 10818
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A43 RID: 10819
		private const string TABLE = "NewTowerSeasonSAward";

		// Token: 0x04002A44 RID: 10820
		private const string COMMAND = "select BinData from `NewTowerSeasonSAward` where Id=?";

		// Token: 0x04002A45 RID: 10821
		private const string KEY_PREFIX = "NewTowerSeasonSAwardById";

		// Token: 0x04002A46 RID: 10822
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A47 RID: 10823
		private static int HandleId;
	}
}
