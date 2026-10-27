using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C6 RID: 2502
	public class ConfigTeamParKOurRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AB8 RID: 15032 RVA: 0x001A5CE3 File Offset: 0x001A3EE3
		static ConfigTeamParKOurRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurRewardById.CreateStaticDefaultValue), new Action(ConfigTeamParKOurRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x001A5D04 File Offset: 0x001A3F04
		public static void CreateStaticDefaultValue()
		{
			ConfigTeamParKOurRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeamParKOurRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamparkour.db"),
				new ValueTuple<string, object>("文件", "l.联机跑酷活动.xlsx"),
				new ValueTuple<string, object>("表名", "TeamParKOurReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TeamParKOurReward` where Id=?")
			});
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x001A5D83 File Offset: 0x001A3F83
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurRewardById.LogPair = null;
			ConfigTeamParKOurRewardById.HandleId = 0;
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x001A5D91 File Offset: 0x001A3F91
		public static void Init()
		{
			ConfigTeamParKOurRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurRewardById.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurReward` where Id=?");
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x001A5DAC File Offset: 0x001A3FAC
		public static TeamParKOurReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeamParKOurRewardById.HandleId, ConfigTeamParKOurRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamParKOurRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TeamParKOurReward?(TeamParKOurReward.GetRootAsTeamParKOurReward(configBuffer));
				}
			}
			ConfigTeamParKOurRewardById.LogPair.Clear();
			ConfigTeamParKOurRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTeamParKOurRewardById.HandleId, 1, p0Id, ConfigTeamParKOurRewardById.LogPair) || ConfigCommon.Step(ConfigTeamParKOurRewardById.HandleId, true, ConfigTeamParKOurRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTeamParKOurRewardById.HandleId, ConfigTeamParKOurRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeamParKOurRewardById.HandleId, 0, ConfigTeamParKOurRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTeamParKOurRewardById.HandleId, ConfigTeamParKOurRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TeamParKOurReward rootAsTeamParKOurReward = TeamParKOurReward.GetRootAsTeamParKOurReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamParKOurRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTeamParKOurRewardById.HandleId, ConfigTeamParKOurRewardById.LogPair);
			return new TeamParKOurReward?(rootAsTeamParKOurReward);
		}

		// Token: 0x04004450 RID: 17488
		private const string DB = "db_teamparkour.db";

		// Token: 0x04004451 RID: 17489
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04004452 RID: 17490
		private const string TABLE = "TeamParKOurReward";

		// Token: 0x04004453 RID: 17491
		private const string COMMAND = "select BinData from `TeamParKOurReward` where Id=?";

		// Token: 0x04004454 RID: 17492
		private const string KEY_PREFIX = "TeamParKOurRewardById";

		// Token: 0x04004455 RID: 17493
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004456 RID: 17494
		private static int HandleId;
	}
}
