using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099B RID: 2459
	public class ConfigSlashAndTowerCfgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039B5 RID: 14773 RVA: 0x001A2F68 File Offset: 0x001A1168
		static ConfigSlashAndTowerCfgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashAndTowerCfgById.CreateStaticDefaultValue), new Action(ConfigSlashAndTowerCfgById.ResetStaticDefaultValue));
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x001A2F88 File Offset: 0x001A1188
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

		// Token: 0x060039B7 RID: 14775 RVA: 0x001A3007 File Offset: 0x001A1207
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashAndTowerCfgById.LogPair = null;
			ConfigSlashAndTowerCfgById.HandleId = 0;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x001A3015 File Offset: 0x001A1215
		public static void Init()
		{
			ConfigSlashAndTowerCfgById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashAndTowerCfgById.HandleId, "db_shiptower.db", "select BinData from `SlashAndTowerCfg` where Id=?");
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x001A3030 File Offset: 0x001A1230
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

		// Token: 0x04004323 RID: 17187
		private const string DB = "db_shiptower.db";

		// Token: 0x04004324 RID: 17188
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004325 RID: 17189
		private const string TABLE = "SlashAndTowerCfg";

		// Token: 0x04004326 RID: 17190
		private const string COMMAND = "select BinData from `SlashAndTowerCfg` where Id=?";

		// Token: 0x04004327 RID: 17191
		private const string KEY_PREFIX = "SlashAndTowerCfgById";

		// Token: 0x04004328 RID: 17192
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004329 RID: 17193
		private static int HandleId;
	}
}
