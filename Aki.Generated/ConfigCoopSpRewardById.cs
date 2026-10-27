using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A6 RID: 422
	public class ConfigCoopSpRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x000917F0 File Offset: 0x0008F9F0
		static ConfigCoopSpRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopSpRewardById.CreateStaticDefaultValue), new Action(ConfigCoopSpRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00091810 File Offset: 0x0008FA10
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

		// Token: 0x060009E9 RID: 2537 RVA: 0x0009188F File Offset: 0x0008FA8F
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopSpRewardById.LogPair = null;
			ConfigCoopSpRewardById.HandleId = 0;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0009189D File Offset: 0x0008FA9D
		public static void Init()
		{
			ConfigCoopSpRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigCoopSpRewardById.HandleId, "db_cooprolelevel.db", "select BinData from `CoopSpReward` where Id=?");
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000918B8 File Offset: 0x0008FAB8
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

		// Token: 0x04000B6E RID: 2926
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000B6F RID: 2927
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000B70 RID: 2928
		private const string TABLE = "CoopSpReward";

		// Token: 0x04000B71 RID: 2929
		private const string COMMAND = "select BinData from `CoopSpReward` where Id=?";

		// Token: 0x04000B72 RID: 2930
		private const string KEY_PREFIX = "CoopSpRewardById";

		// Token: 0x04000B73 RID: 2931
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B74 RID: 2932
		private static int HandleId;
	}
}
