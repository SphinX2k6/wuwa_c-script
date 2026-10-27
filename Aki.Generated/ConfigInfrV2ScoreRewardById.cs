using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043D RID: 1085
	public class ConfigInfrV2ScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001978 RID: 6520 RVA: 0x000E9803 File Offset: 0x000E7A03
		static ConfigInfrV2ScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2ScoreRewardById.CreateStaticDefaultValue), new Action(ConfigInfrV2ScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000E9824 File Offset: 0x000E7A24
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2ScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2ScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2ScoreReward` where Id=?")
			});
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000E98A3 File Offset: 0x000E7AA3
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardById.LogPair = null;
			ConfigInfrV2ScoreRewardById.HandleId = 0;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x000E98B1 File Offset: 0x000E7AB1
		public static void Init()
		{
			ConfigInfrV2ScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2ScoreRewardById.HandleId, "db_villageinfr.db", "select BinData from `InfrV2ScoreReward` where Id=?");
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000E98CC File Offset: 0x000E7ACC
		public static InfrV2ScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2ScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2ScoreReward?(InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(configBuffer));
				}
			}
			ConfigInfrV2ScoreRewardById.LogPair.Clear();
			ConfigInfrV2ScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrV2ScoreRewardById.HandleId, 1, p0Id, ConfigInfrV2ScoreRewardById.LogPair) || ConfigCommon.Step(ConfigInfrV2ScoreRewardById.HandleId, true, ConfigInfrV2ScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2ScoreRewardById.HandleId, 0, ConfigInfrV2ScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2ScoreReward rootAsInfrV2ScoreReward = InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2ScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair);
			return new InfrV2ScoreReward?(rootAsInfrV2ScoreReward);
		}

		// Token: 0x04001D8F RID: 7567
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D90 RID: 7568
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D91 RID: 7569
		private const string TABLE = "InfrV2ScoreReward";

		// Token: 0x04001D92 RID: 7570
		private const string COMMAND = "select BinData from `InfrV2ScoreReward` where Id=?";

		// Token: 0x04001D93 RID: 7571
		private const string KEY_PREFIX = "InfrV2ScoreRewardById";

		// Token: 0x04001D94 RID: 7572
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D95 RID: 7573
		private static int HandleId;
	}
}
