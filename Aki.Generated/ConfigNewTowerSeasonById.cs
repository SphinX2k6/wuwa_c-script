using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000624 RID: 1572
	public class ConfigNewTowerSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024E8 RID: 9448 RVA: 0x0012DB53 File Offset: 0x0012BD53
		static ConfigNewTowerSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonById.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0012DB74 File Offset: 0x0012BD74
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeason` where Id=?")
			});
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0012DBF3 File Offset: 0x0012BDF3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonById.LogPair = null;
			ConfigNewTowerSeasonById.HandleId = 0;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0012DC01 File Offset: 0x0012BE01
		public static void Init()
		{
			ConfigNewTowerSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonById.HandleId, "db_newtower.db", "select BinData from `NewTowerSeason` where Id=?");
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0012DC1C File Offset: 0x0012BE1C
		public static NewTowerSeason? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerSeason?(NewTowerSeason.GetRootAsNewTowerSeason(configBuffer));
				}
			}
			ConfigNewTowerSeasonById.LogPair.Clear();
			ConfigNewTowerSeasonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerSeasonById.HandleId, 1, p0Id, ConfigNewTowerSeasonById.LogPair) || ConfigCommon.Step(ConfigNewTowerSeasonById.HandleId, true, ConfigNewTowerSeasonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonById.HandleId, 0, ConfigNewTowerSeasonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerSeason rootAsNewTowerSeason = NewTowerSeason.GetRootAsNewTowerSeason(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair);
			return new NewTowerSeason?(rootAsNewTowerSeason);
		}

		// Token: 0x04002AE2 RID: 10978
		private const string DB = "db_newtower.db";

		// Token: 0x04002AE3 RID: 10979
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AE4 RID: 10980
		private const string TABLE = "NewTowerSeason";

		// Token: 0x04002AE5 RID: 10981
		private const string COMMAND = "select BinData from `NewTowerSeason` where Id=?";

		// Token: 0x04002AE6 RID: 10982
		private const string KEY_PREFIX = "NewTowerSeasonById";

		// Token: 0x04002AE7 RID: 10983
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AE8 RID: 10984
		private static int HandleId;
	}
}
