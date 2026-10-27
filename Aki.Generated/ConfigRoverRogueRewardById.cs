using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EE RID: 2286
	public class ConfigRoverRogueRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035A7 RID: 13735 RVA: 0x00188978 File Offset: 0x00186B78
		static ConfigRoverRogueRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRewardById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x00188998 File Offset: 0x00186B98
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueReward` where Id=?")
			});
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00188A17 File Offset: 0x00186C17
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRewardById.LogPair = null;
			ConfigRoverRogueRewardById.HandleId = 0;
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00188A25 File Offset: 0x00186C25
		public static void Init()
		{
			ConfigRoverRogueRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRewardById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueReward` where Id=?");
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00188A40 File Offset: 0x00186C40
		public static RoverRogueReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRewardById.HandleId, ConfigRoverRogueRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueReward?(RoverRogueReward.GetRootAsRoverRogueReward(configBuffer));
				}
			}
			ConfigRoverRogueRewardById.LogPair.Clear();
			ConfigRoverRogueRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRewardById.HandleId, 1, p0Id, ConfigRoverRogueRewardById.LogPair) || ConfigCommon.Step(ConfigRoverRogueRewardById.HandleId, true, ConfigRoverRogueRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRewardById.HandleId, ConfigRoverRogueRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRewardById.HandleId, 0, ConfigRoverRogueRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRewardById.HandleId, ConfigRoverRogueRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueReward rootAsRoverRogueReward = RoverRogueReward.GetRootAsRoverRogueReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRewardById.HandleId, ConfigRoverRogueRewardById.LogPair);
			return new RoverRogueReward?(rootAsRoverRogueReward);
		}

		// Token: 0x04003E68 RID: 15976
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E69 RID: 15977
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E6A RID: 15978
		private const string TABLE = "RoverRogueReward";

		// Token: 0x04003E6B RID: 15979
		private const string COMMAND = "select BinData from `RoverRogueReward` where Id=?";

		// Token: 0x04003E6C RID: 15980
		private const string KEY_PREFIX = "RoverRogueRewardById";

		// Token: 0x04003E6D RID: 15981
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E6E RID: 15982
		private static int HandleId;
	}
}
