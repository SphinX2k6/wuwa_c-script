using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000674 RID: 1652
	public class ConfigPhantomBattleBadgeRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026C8 RID: 9928 RVA: 0x001386BB File Offset: 0x001368BB
		static ConfigPhantomBattleBadgeRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeRewardById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x001386DC File Offset: 0x001368DC
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

		// Token: 0x060026CA RID: 9930 RVA: 0x0013875B File Offset: 0x0013695B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeRewardById.LogPair = null;
			ConfigPhantomBattleBadgeRewardById.HandleId = 0;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00138769 File Offset: 0x00136969
		public static void Init()
		{
			ConfigPhantomBattleBadgeRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeRewardById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeReward` where Id=?");
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00138784 File Offset: 0x00136984
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

		// Token: 0x04002D12 RID: 11538
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D13 RID: 11539
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D14 RID: 11540
		private const string TABLE = "PhantomBattleBadgeReward";

		// Token: 0x04002D15 RID: 11541
		private const string COMMAND = "select BinData from `PhantomBattleBadgeReward` where Id=?";

		// Token: 0x04002D16 RID: 11542
		private const string KEY_PREFIX = "PhantomBattleBadgeRewardById";

		// Token: 0x04002D17 RID: 11543
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D18 RID: 11544
		private static int HandleId;
	}
}
