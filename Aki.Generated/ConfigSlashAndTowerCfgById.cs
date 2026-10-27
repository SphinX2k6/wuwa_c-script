using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000950 RID: 2384
	public class ConfigSlashAndTowerCfgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037F3 RID: 14323 RVA: 0x00195D48 File Offset: 0x00193F48
		static ConfigSlashAndTowerCfgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerCfgById.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerCfgById.ResetStaticDefaultValue));
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00195D68 File Offset: 0x00193F68
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashAndTowerCfgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashAndTowerCfgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashAndTowerCfg"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashAndTowerCfg` where Id=?")
			});
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00195DE7 File Offset: 0x00193FE7
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerCfgById.LogPair = null;
			ConfigSlashAndTowerCfgById.HandleId = 0;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00195DF5 File Offset: 0x00193FF5
		public static void Init()
		{
			ConfigSlashAndTowerCfgById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerCfgById.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerCfg` where Id=?");
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00195E10 File Offset: 0x00194010
		public static SlashAndTowerCfg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashAndTowerCfgById.HandleId, ConfigSlashAndTowerCfgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerCfgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SlashAndTowerCfg?(SlashAndTowerCfg.GetRootAsSlashAndTowerCfg(configBuffer));
				}
			}
			ConfigSlashAndTowerCfgById.LogPair.Clear();
			ConfigSlashAndTowerCfgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSlashAndTowerCfgById.HandleId, 1, p0Id, ConfigSlashAndTowerCfgById.LogPair) || ConfigCommon.Step(ConfigSlashAndTowerCfgById.HandleId, true, ConfigSlashAndTowerCfgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlashAndTowerCfgById.HandleId, ConfigSlashAndTowerCfgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashAndTowerCfgById.HandleId, 0, ConfigSlashAndTowerCfgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlashAndTowerCfgById.HandleId, ConfigSlashAndTowerCfgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SlashAndTowerCfg rootAsSlashAndTowerCfg = SlashAndTowerCfg.GetRootAsSlashAndTowerCfg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashAndTowerCfgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlashAndTowerCfgById.HandleId, ConfigSlashAndTowerCfgById.LogPair);
			return new SlashAndTowerCfg?(rootAsSlashAndTowerCfg);
		}

		// Token: 0x04004116 RID: 16662
		private const string DB = "db_shiptower.db";

		// Token: 0x04004117 RID: 16663
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004118 RID: 16664
		private const string TABLE = "SlashAndTowerCfg";

		// Token: 0x04004119 RID: 16665
		private const string COMMAND = "select BinData from `SlashAndTowerCfg` where Id=?";

		// Token: 0x0400411A RID: 16666
		private const string KEY_PREFIX = "SlashAndTowerCfgById";

		// Token: 0x0400411B RID: 16667
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400411C RID: 16668
		private static int HandleId;
	}
}
