using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000612 RID: 1554
	public class ConfigNewTowerBossBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600247C RID: 9340 RVA: 0x0012B4FF File Offset: 0x001296FF
		static ConfigNewTowerBossBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerBossBuffById.CreateStaticDefaultValue), new Action(ConfigNewTowerBossBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0012B520 File Offset: 0x00129720
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

		// Token: 0x0600247E RID: 9342 RVA: 0x0012B59F File Offset: 0x0012979F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerBossBuffById.LogPair = null;
			ConfigNewTowerBossBuffById.HandleId = 0;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0012B5AD File Offset: 0x001297AD
		public static void Init()
		{
			ConfigNewTowerBossBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerBossBuffById.HandleId, "db_newtower.db", "select BinData from `NewTowerBossBuff` where Id=?");
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0012B5C8 File Offset: 0x001297C8
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

		// Token: 0x04002A64 RID: 10852
		private const string DB = "db_newtower.db";

		// Token: 0x04002A65 RID: 10853
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A66 RID: 10854
		private const string TABLE = "NewTowerBossBuff";

		// Token: 0x04002A67 RID: 10855
		private const string COMMAND = "select BinData from `NewTowerBossBuff` where Id=?";

		// Token: 0x04002A68 RID: 10856
		private const string KEY_PREFIX = "NewTowerBossBuffById";

		// Token: 0x04002A69 RID: 10857
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A6A RID: 10858
		private static int HandleId;
	}
}
