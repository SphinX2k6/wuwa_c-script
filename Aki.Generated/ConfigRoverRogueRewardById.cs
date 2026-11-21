using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000939 RID: 2361
	public class ConfigRoverRogueRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003769 RID: 14185 RVA: 0x00195B98 File Offset: 0x00193D98
		static ConfigRoverRogueRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRewardById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00195BB8 File Offset: 0x00193DB8
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

		// Token: 0x0600376B RID: 14187 RVA: 0x00195C37 File Offset: 0x00193E37
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRewardById.LogPair = null;
			ConfigRoverRogueRewardById.HandleId = 0;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00195C45 File Offset: 0x00193E45
		public static void Init()
		{
			ConfigRoverRogueRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRewardById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueReward` where Id=?");
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00195C60 File Offset: 0x00193E60
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

		// Token: 0x04004075 RID: 16501
		private const string DB = "db_roverlike.db";

		// Token: 0x04004076 RID: 16502
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04004077 RID: 16503
		private const string TABLE = "RoverRogueReward";

		// Token: 0x04004078 RID: 16504
		private const string COMMAND = "select BinData from `RoverRogueReward` where Id=?";

		// Token: 0x04004079 RID: 16505
		private const string KEY_PREFIX = "RoverRogueRewardById";

		// Token: 0x0400407A RID: 16506
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400407B RID: 16507
		private static int HandleId;
	}
}
