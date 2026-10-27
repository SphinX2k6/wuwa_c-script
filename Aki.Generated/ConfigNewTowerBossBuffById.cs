using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FA RID: 1530
	public class ConfigNewTowerBossBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023EC RID: 9196 RVA: 0x00124A83 File Offset: 0x00122C83
		static ConfigNewTowerBossBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerBossBuffById.CreateStaticDefaultValue), new Action(ConfigNewTowerBossBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00124AA4 File Offset: 0x00122CA4
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerBossBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerBossBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerBossBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerBossBuff` where Id=?")
			});
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00124B23 File Offset: 0x00122D23
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerBossBuffById.LogPair = null;
			ConfigNewTowerBossBuffById.HandleId = 0;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00124B31 File Offset: 0x00122D31
		public static void Init()
		{
			ConfigNewTowerBossBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerBossBuffById.HandleId, "db_newtower.db", "select BinData from `NewTowerBossBuff` where Id=?");
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00124B4C File Offset: 0x00122D4C
		public static NewTowerBossBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerBossBuffById.HandleId, ConfigNewTowerBossBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerBossBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerBossBuff?(NewTowerBossBuff.GetRootAsNewTowerBossBuff(configBuffer));
				}
			}
			ConfigNewTowerBossBuffById.LogPair.Clear();
			ConfigNewTowerBossBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerBossBuffById.HandleId, 1, p0Id, ConfigNewTowerBossBuffById.LogPair) || ConfigCommon.Step(ConfigNewTowerBossBuffById.HandleId, true, ConfigNewTowerBossBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerBossBuffById.HandleId, ConfigNewTowerBossBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerBossBuffById.HandleId, 0, ConfigNewTowerBossBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerBossBuffById.HandleId, ConfigNewTowerBossBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerBossBuff rootAsNewTowerBossBuff = NewTowerBossBuff.GetRootAsNewTowerBossBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerBossBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerBossBuffById.HandleId, ConfigNewTowerBossBuffById.LogPair);
			return new NewTowerBossBuff?(rootAsNewTowerBossBuff);
		}

		// Token: 0x040029BC RID: 10684
		private const string DB = "db_newtower.db";

		// Token: 0x040029BD RID: 10685
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029BE RID: 10686
		private const string TABLE = "NewTowerBossBuff";

		// Token: 0x040029BF RID: 10687
		private const string COMMAND = "select BinData from `NewTowerBossBuff` where Id=?";

		// Token: 0x040029C0 RID: 10688
		private const string KEY_PREFIX = "NewTowerBossBuffById";

		// Token: 0x040029C1 RID: 10689
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029C2 RID: 10690
		private static int HandleId;
	}
}
