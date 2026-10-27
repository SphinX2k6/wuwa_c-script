using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065C RID: 1628
	public class ConfigPhantomBattleBadgeRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002638 RID: 9784 RVA: 0x00131C3F File Offset: 0x0012FE3F
		static ConfigPhantomBattleBadgeRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeRewardById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00131C60 File Offset: 0x0012FE60
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadgeReward"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadgeReward` where Id=?")
			});
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00131CDF File Offset: 0x0012FEDF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeRewardById.LogPair = null;
			ConfigPhantomBattleBadgeRewardById.HandleId = 0;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00131CED File Offset: 0x0012FEED
		public static void Init()
		{
			ConfigPhantomBattleBadgeRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeRewardById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeReward` where Id=?");
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00131D08 File Offset: 0x0012FF08
		public static PhantomBattleBadgeReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeRewardById.HandleId, ConfigPhantomBattleBadgeRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleBadgeReward?(PhantomBattleBadgeReward.GetRootAsPhantomBattleBadgeReward(configBuffer));
				}
			}
			ConfigPhantomBattleBadgeRewardById.LogPair.Clear();
			ConfigPhantomBattleBadgeRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleBadgeRewardById.HandleId, 1, p0Id, ConfigPhantomBattleBadgeRewardById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleBadgeRewardById.HandleId, true, ConfigPhantomBattleBadgeRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeRewardById.HandleId, ConfigPhantomBattleBadgeRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeRewardById.HandleId, 0, ConfigPhantomBattleBadgeRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeRewardById.HandleId, ConfigPhantomBattleBadgeRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleBadgeReward rootAsPhantomBattleBadgeReward = PhantomBattleBadgeReward.GetRootAsPhantomBattleBadgeReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeRewardById.HandleId, ConfigPhantomBattleBadgeRewardById.LogPair);
			return new PhantomBattleBadgeReward?(rootAsPhantomBattleBadgeReward);
		}

		// Token: 0x04002C6A RID: 11370
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C6B RID: 11371
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C6C RID: 11372
		private const string TABLE = "PhantomBattleBadgeReward";

		// Token: 0x04002C6D RID: 11373
		private const string COMMAND = "select BinData from `PhantomBattleBadgeReward` where Id=?";

		// Token: 0x04002C6E RID: 11374
		private const string KEY_PREFIX = "PhantomBattleBadgeRewardById";

		// Token: 0x04002C6F RID: 11375
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C70 RID: 11376
		private static int HandleId;
	}
}
