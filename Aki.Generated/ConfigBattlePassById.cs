using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E5 RID: 229
	public class ConfigBattlePassById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600055F RID: 1375 RVA: 0x00077FB4 File Offset: 0x000761B4
		static ConfigBattlePassById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassById.CreateStaticDefaultValue), new Action(ConfigBattlePassById.ResetStaticDefaultValue));
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00077FD4 File Offset: 0x000761D4
		public static void CreateStaticDefaultValue()
		{
			ConfigBattlePassById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattlePassById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battle_pass.db"),
				new ValueTuple<string, object>("文件", "z.战令.xlsx"),
				new ValueTuple<string, object>("表名", "BattlePass"),
				new ValueTuple<string, object>("语句", "select BinData from `BattlePass` where Id=?")
			});
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00078053 File Offset: 0x00076253
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassById.LogPair = null;
			ConfigBattlePassById.HandleId = 0;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00078061 File Offset: 0x00076261
		public static void Init()
		{
			ConfigBattlePassById.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassById.HandleId, "db_battle_pass.db", "select BinData from `BattlePass` where Id=?");
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0007807C File Offset: 0x0007627C
		public static BattlePass? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BattlePass?(BattlePass.GetRootAsBattlePass(configBuffer));
				}
			}
			ConfigBattlePassById.LogPair.Clear();
			ConfigBattlePassById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBattlePassById.HandleId, 1, p0Id, ConfigBattlePassById.LogPair) || ConfigCommon.Step(ConfigBattlePassById.HandleId, true, ConfigBattlePassById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattlePassById.HandleId, 0, ConfigBattlePassById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BattlePass rootAsBattlePass = BattlePass.GetRootAsBattlePass(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair);
			return new BattlePass?(rootAsBattlePass);
		}

		// Token: 0x04000627 RID: 1575
		private const string DB = "db_battle_pass.db";

		// Token: 0x04000628 RID: 1576
		private const string FILE = "z.战令.xlsx";

		// Token: 0x04000629 RID: 1577
		private const string TABLE = "BattlePass";

		// Token: 0x0400062A RID: 1578
		private const string COMMAND = "select BinData from `BattlePass` where Id=?";

		// Token: 0x0400062B RID: 1579
		private const string KEY_PREFIX = "BattlePassById";

		// Token: 0x0400062C RID: 1580
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400062D RID: 1581
		private static int HandleId;
	}
}
