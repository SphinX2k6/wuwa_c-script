using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000845 RID: 2117
	public class ConfigRogueLimitTimeRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031B0 RID: 12720 RVA: 0x00175C40 File Offset: 0x00173E40
		static ConfigRogueLimitTimeRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueLimitTimeRewardById.CreateStaticDefaultValue), new Action(ConfigRogueLimitTimeRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x00175C60 File Offset: 0x00173E60
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueLimitTimeRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueLimitTimeRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueLimitTimeReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueLimitTimeReward` where Id=?")
			});
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00175CDF File Offset: 0x00173EDF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueLimitTimeRewardById.LogPair = null;
			ConfigRogueLimitTimeRewardById.HandleId = 0;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00175CED File Offset: 0x00173EED
		public static void Init()
		{
			ConfigRogueLimitTimeRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueLimitTimeRewardById.HandleId, "db_dreamlink.db", "select BinData from `RogueLimitTimeReward` where Id=?");
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00175D08 File Offset: 0x00173F08
		public static RogueLimitTimeReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueLimitTimeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueLimitTimeReward?(RogueLimitTimeReward.GetRootAsRogueLimitTimeReward(configBuffer));
				}
			}
			ConfigRogueLimitTimeRewardById.LogPair.Clear();
			ConfigRogueLimitTimeRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueLimitTimeRewardById.HandleId, 1, p0Id, ConfigRogueLimitTimeRewardById.LogPair) || ConfigCommon.Step(ConfigRogueLimitTimeRewardById.HandleId, true, ConfigRogueLimitTimeRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueLimitTimeRewardById.HandleId, 0, ConfigRogueLimitTimeRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueLimitTimeReward rootAsRogueLimitTimeReward = RogueLimitTimeReward.GetRootAsRogueLimitTimeReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueLimitTimeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair);
			return new RogueLimitTimeReward?(rootAsRogueLimitTimeReward);
		}

		// Token: 0x040039C9 RID: 14793
		private const string DB = "db_dreamlink.db";

		// Token: 0x040039CA RID: 14794
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x040039CB RID: 14795
		private const string TABLE = "RogueLimitTimeReward";

		// Token: 0x040039CC RID: 14796
		private const string COMMAND = "select BinData from `RogueLimitTimeReward` where Id=?";

		// Token: 0x040039CD RID: 14797
		private const string KEY_PREFIX = "RogueLimitTimeRewardById";

		// Token: 0x040039CE RID: 14798
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039CF RID: 14799
		private static int HandleId;
	}
}
