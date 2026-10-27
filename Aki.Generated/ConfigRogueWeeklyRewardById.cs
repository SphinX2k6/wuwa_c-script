using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000878 RID: 2168
	public class ConfigRogueWeeklyRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032E2 RID: 13026 RVA: 0x0017915F File Offset: 0x0017735F
		static ConfigRogueWeeklyRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRewardById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00179180 File Offset: 0x00177380
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyReward` where Id=?")
			});
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x001791FF File Offset: 0x001773FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRewardById.LogPair = null;
			ConfigRogueWeeklyRewardById.HandleId = 0;
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0017920D File Offset: 0x0017740D
		public static void Init()
		{
			ConfigRogueWeeklyRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRewardById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyReward` where Id=?");
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00179228 File Offset: 0x00177428
		public static RogueWeeklyReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyReward?(RogueWeeklyReward.GetRootAsRogueWeeklyReward(configBuffer));
				}
			}
			ConfigRogueWeeklyRewardById.LogPair.Clear();
			ConfigRogueWeeklyRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyRewardById.HandleId, 1, p0Id, ConfigRogueWeeklyRewardById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyRewardById.HandleId, true, ConfigRogueWeeklyRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyRewardById.HandleId, 0, ConfigRogueWeeklyRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyReward rootAsRogueWeeklyReward = RogueWeeklyReward.GetRootAsRogueWeeklyReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair);
			return new RogueWeeklyReward?(rootAsRogueWeeklyReward);
		}

		// Token: 0x04003B2E RID: 15150
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B2F RID: 15151
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B30 RID: 15152
		private const string TABLE = "RogueWeeklyReward";

		// Token: 0x04003B31 RID: 15153
		private const string COMMAND = "select BinData from `RogueWeeklyReward` where Id=?";

		// Token: 0x04003B32 RID: 15154
		private const string KEY_PREFIX = "RogueWeeklyRewardById";

		// Token: 0x04003B33 RID: 15155
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B34 RID: 15156
		private static int HandleId;
	}
}
