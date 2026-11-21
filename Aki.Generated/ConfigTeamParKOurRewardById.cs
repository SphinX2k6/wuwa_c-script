using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9B RID: 2715
	public class ConfigTeamParKOurRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FB6 RID: 16310 RVA: 0x001C5077 File Offset: 0x001C3277
		static ConfigTeamParKOurRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurRewardById.CreateStaticDefaultValue), new Action(ConfigTeamParKOurRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x001C5098 File Offset: 0x001C3298
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

		// Token: 0x06003FB8 RID: 16312 RVA: 0x001C5117 File Offset: 0x001C3317
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurRewardById.LogPair = null;
			ConfigTeamParKOurRewardById.HandleId = 0;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x001C5125 File Offset: 0x001C3325
		public static void Init()
		{
			ConfigTeamParKOurRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurRewardById.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurReward` where Id=?");
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x001C5140 File Offset: 0x001C3340
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

		// Token: 0x04004A23 RID: 18979
		private const string DB = "db_teamparkour.db";

		// Token: 0x04004A24 RID: 18980
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04004A25 RID: 18981
		private const string TABLE = "TeamParKOurReward";

		// Token: 0x04004A26 RID: 18982
		private const string COMMAND = "select BinData from `TeamParKOurReward` where Id=?";

		// Token: 0x04004A27 RID: 18983
		private const string KEY_PREFIX = "TeamParKOurRewardById";

		// Token: 0x04004A28 RID: 18984
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A29 RID: 18985
		private static int HandleId;
	}
}
