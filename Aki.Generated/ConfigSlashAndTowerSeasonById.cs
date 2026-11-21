using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099E RID: 2462
	public class ConfigSlashAndTowerSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039C7 RID: 14791 RVA: 0x001A361F File Offset: 0x001A181F
		static ConfigSlashAndTowerSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerSeasonById.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x001A3640 File Offset: 0x001A1840
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

		// Token: 0x060039C9 RID: 14793 RVA: 0x001A36BF File Offset: 0x001A18BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerSeasonById.LogPair = null;
			ConfigSlashAndTowerSeasonById.HandleId = 0;
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x001A36CD File Offset: 0x001A18CD
		public static void Init()
		{
			ConfigSlashAndTowerSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerSeasonById.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerSeason` where Id=?");
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x001A36E8 File Offset: 0x001A18E8
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

		// Token: 0x04004338 RID: 17208
		private const string DB = "db_shiptower.db";

		// Token: 0x04004339 RID: 17209
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400433A RID: 17210
		private const string TABLE = "SlashAndTowerSeason";

		// Token: 0x0400433B RID: 17211
		private const string COMMAND = "select BinData from `SlashAndTowerSeason` where Id=?";

		// Token: 0x0400433C RID: 17212
		private const string KEY_PREFIX = "SlashAndTowerSeasonById";

		// Token: 0x0400433D RID: 17213
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400433E RID: 17214
		private static int HandleId;
	}
}
