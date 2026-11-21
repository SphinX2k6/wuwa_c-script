using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B8 RID: 440
	public class ConfigCoopSpRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A53 RID: 2643 RVA: 0x00097728 File Offset: 0x00095928
		static ConfigCoopSpRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopSpRewardById.CreateStaticDefaultValue), new Action(ConfigCoopSpRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00097748 File Offset: 0x00095948
		public static void CreateStaticDefaultValue()
		{
			ConfigCoopSpRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCoopSpRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cooprolelevel.db"),
				new ValueTuple<string, object>("文件", "c.3.2coop活动.xlsx"),
				new ValueTuple<string, object>("表名", "CoopSpReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CoopSpReward` where Id=?")
			});
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000977C7 File Offset: 0x000959C7
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopSpRewardById.LogPair = null;
			ConfigCoopSpRewardById.HandleId = 0;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000977D5 File Offset: 0x000959D5
		public static void Init()
		{
			ConfigCoopSpRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigCoopSpRewardById.HandleId, "db_cooprolelevel.db", "select BinData from `CoopSpReward` where Id=?");
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000977F0 File Offset: 0x000959F0
		public static CoopSpReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCoopSpRewardById.HandleId, ConfigCoopSpRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopSpRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CoopSpReward?(CoopSpReward.GetRootAsCoopSpReward(configBuffer));
				}
			}
			ConfigCoopSpRewardById.LogPair.Clear();
			ConfigCoopSpRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCoopSpRewardById.HandleId, 1, p0Id, ConfigCoopSpRewardById.LogPair) || ConfigCommon.Step(ConfigCoopSpRewardById.HandleId, true, ConfigCoopSpRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCoopSpRewardById.HandleId, ConfigCoopSpRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCoopSpRewardById.HandleId, 0, ConfigCoopSpRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCoopSpRewardById.HandleId, ConfigCoopSpRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CoopSpReward rootAsCoopSpReward = CoopSpReward.GetRootAsCoopSpReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopSpRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCoopSpRewardById.HandleId, ConfigCoopSpRewardById.LogPair);
			return new CoopSpReward?(rootAsCoopSpReward);
		}

		// Token: 0x04000BEC RID: 3052
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000BED RID: 3053
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000BEE RID: 3054
		private const string TABLE = "CoopSpReward";

		// Token: 0x04000BEF RID: 3055
		private const string COMMAND = "select BinData from `CoopSpReward` where Id=?";

		// Token: 0x04000BF0 RID: 3056
		private const string KEY_PREFIX = "CoopSpRewardById";

		// Token: 0x04000BF1 RID: 3057
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BF2 RID: 3058
		private static int HandleId;
	}
}
