using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000953 RID: 2387
	public class ConfigSlashAndTowerSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003805 RID: 14341 RVA: 0x001963FF File Offset: 0x001945FF
		static ConfigSlashAndTowerSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerSeasonById.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00196420 File Offset: 0x00194620
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashAndTowerSeasonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashAndTowerSeasonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashAndTowerSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashAndTowerSeason` where Id=?")
			});
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x0019649F File Offset: 0x0019469F
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerSeasonById.LogPair = null;
			ConfigSlashAndTowerSeasonById.HandleId = 0;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x001964AD File Offset: 0x001946AD
		public static void Init()
		{
			ConfigSlashAndTowerSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerSeasonById.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerSeason` where Id=?");
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x001964C8 File Offset: 0x001946C8
		public static SlashAndTowerSeason? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashAndTowerSeasonById.HandleId, ConfigSlashAndTowerSeasonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SlashAndTowerSeason?(SlashAndTowerSeason.GetRootAsSlashAndTowerSeason(configBuffer));
				}
			}
			ConfigSlashAndTowerSeasonById.LogPair.Clear();
			ConfigSlashAndTowerSeasonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSlashAndTowerSeasonById.HandleId, 1, p0Id, ConfigSlashAndTowerSeasonById.LogPair) || ConfigCommon.Step(ConfigSlashAndTowerSeasonById.HandleId, true, ConfigSlashAndTowerSeasonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlashAndTowerSeasonById.HandleId, ConfigSlashAndTowerSeasonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashAndTowerSeasonById.HandleId, 0, ConfigSlashAndTowerSeasonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlashAndTowerSeasonById.HandleId, ConfigSlashAndTowerSeasonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SlashAndTowerSeason rootAsSlashAndTowerSeason = SlashAndTowerSeason.GetRootAsSlashAndTowerSeason(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlashAndTowerSeasonById.HandleId, ConfigSlashAndTowerSeasonById.LogPair);
			return new SlashAndTowerSeason?(rootAsSlashAndTowerSeason);
		}

		// Token: 0x0400412B RID: 16683
		private const string DB = "db_shiptower.db";

		// Token: 0x0400412C RID: 16684
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400412D RID: 16685
		private const string TABLE = "SlashAndTowerSeason";

		// Token: 0x0400412E RID: 16686
		private const string COMMAND = "select BinData from `SlashAndTowerSeason` where Id=?";

		// Token: 0x0400412F RID: 16687
		private const string KEY_PREFIX = "SlashAndTowerSeasonById";

		// Token: 0x04004130 RID: 16688
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004131 RID: 16689
		private static int HandleId;
	}
}
