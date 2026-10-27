using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000668 RID: 1640
	public class ConfigPhantomBattleCardRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002680 RID: 9856 RVA: 0x00133607 File Offset: 0x00131807
		static ConfigPhantomBattleCardRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRewardById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00133628 File Offset: 0x00131828
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

		// Token: 0x06002682 RID: 9858 RVA: 0x001336A7 File Offset: 0x001318A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRewardById.LogPair = null;
			ConfigPhantomBattleCardRewardById.HandleId = 0;
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x001336B5 File Offset: 0x001318B5
		public static void Init()
		{
			ConfigPhantomBattleCardRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRewardById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardReward` where Id=?");
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x001336D0 File Offset: 0x001318D0
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

		// Token: 0x04002CBE RID: 11454
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CBF RID: 11455
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CC0 RID: 11456
		private const string TABLE = "PhantomBattleCardReward";

		// Token: 0x04002CC1 RID: 11457
		private const string COMMAND = "select BinData from `PhantomBattleCardReward` where Id=?";

		// Token: 0x04002CC2 RID: 11458
		private const string KEY_PREFIX = "PhantomBattleCardRewardById";

		// Token: 0x04002CC3 RID: 11459
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CC4 RID: 11460
		private static int HandleId;
	}
}
