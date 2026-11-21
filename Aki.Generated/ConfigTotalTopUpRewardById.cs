using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABD RID: 2749
	public class ConfigTotalTopUpRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004082 RID: 16514 RVA: 0x001C98F3 File Offset: 0x001C7AF3
		static ConfigTotalTopUpRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRewardById.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x001C9914 File Offset: 0x001C7B14
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpReward` where Id=?")
			});
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x001C9993 File Offset: 0x001C7B93
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRewardById.LogPair = null;
			ConfigTotalTopUpRewardById.HandleId = 0;
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x001C99A1 File Offset: 0x001C7BA1
		public static void Init()
		{
			ConfigTotalTopUpRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRewardById.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpReward` where Id=?");
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x001C99BC File Offset: 0x001C7BBC
		public static TotalTopUpReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpRewardById.HandleId, ConfigTotalTopUpRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TotalTopUpReward?(TotalTopUpReward.GetRootAsTotalTopUpReward(configBuffer));
				}
			}
			ConfigTotalTopUpRewardById.LogPair.Clear();
			ConfigTotalTopUpRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTotalTopUpRewardById.HandleId, 1, p0Id, ConfigTotalTopUpRewardById.LogPair) || ConfigCommon.Step(ConfigTotalTopUpRewardById.HandleId, true, ConfigTotalTopUpRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTotalTopUpRewardById.HandleId, ConfigTotalTopUpRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpRewardById.HandleId, 0, ConfigTotalTopUpRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTotalTopUpRewardById.HandleId, ConfigTotalTopUpRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TotalTopUpReward rootAsTotalTopUpReward = TotalTopUpReward.GetRootAsTotalTopUpReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTotalTopUpRewardById.HandleId, ConfigTotalTopUpRewardById.LogPair);
			return new TotalTopUpReward?(rootAsTotalTopUpReward);
		}

		// Token: 0x04004B11 RID: 19217
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004B12 RID: 19218
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004B13 RID: 19219
		private const string TABLE = "TotalTopUpReward";

		// Token: 0x04004B14 RID: 19220
		private const string COMMAND = "select BinData from `TotalTopUpReward` where Id=?";

		// Token: 0x04004B15 RID: 19221
		private const string KEY_PREFIX = "TotalTopUpRewardById";

		// Token: 0x04004B16 RID: 19222
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B17 RID: 19223
		private static int HandleId;
	}
}
