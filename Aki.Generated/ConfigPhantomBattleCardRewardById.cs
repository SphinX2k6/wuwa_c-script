using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000680 RID: 1664
	public class ConfigPhantomBattleCardRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002710 RID: 10000 RVA: 0x0013A083 File Offset: 0x00138283
		static ConfigPhantomBattleCardRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRewardById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x0013A0A4 File Offset: 0x001382A4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardReward"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardReward` where Id=?")
			});
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x0013A123 File Offset: 0x00138323
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRewardById.LogPair = null;
			ConfigPhantomBattleCardRewardById.HandleId = 0;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x0013A131 File Offset: 0x00138331
		public static void Init()
		{
			ConfigPhantomBattleCardRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRewardById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardReward` where Id=?");
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0013A14C File Offset: 0x0013834C
		public static PhantomBattleCardReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardRewardById.HandleId, ConfigPhantomBattleCardRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardReward?(PhantomBattleCardReward.GetRootAsPhantomBattleCardReward(configBuffer));
				}
			}
			ConfigPhantomBattleCardRewardById.LogPair.Clear();
			ConfigPhantomBattleCardRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardRewardById.HandleId, 1, p0Id, ConfigPhantomBattleCardRewardById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardRewardById.HandleId, true, ConfigPhantomBattleCardRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardRewardById.HandleId, ConfigPhantomBattleCardRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardRewardById.HandleId, 0, ConfigPhantomBattleCardRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardRewardById.HandleId, ConfigPhantomBattleCardRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardReward rootAsPhantomBattleCardReward = PhantomBattleCardReward.GetRootAsPhantomBattleCardReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardRewardById.HandleId, ConfigPhantomBattleCardRewardById.LogPair);
			return new PhantomBattleCardReward?(rootAsPhantomBattleCardReward);
		}

		// Token: 0x04002D66 RID: 11622
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D67 RID: 11623
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D68 RID: 11624
		private const string TABLE = "PhantomBattleCardReward";

		// Token: 0x04002D69 RID: 11625
		private const string COMMAND = "select BinData from `PhantomBattleCardReward` where Id=?";

		// Token: 0x04002D6A RID: 11626
		private const string KEY_PREFIX = "PhantomBattleCardRewardById";

		// Token: 0x04002D6B RID: 11627
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D6C RID: 11628
		private static int HandleId;
	}
}
