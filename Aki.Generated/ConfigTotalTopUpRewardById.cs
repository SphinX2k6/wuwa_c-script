using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E8 RID: 2536
	public class ConfigTotalTopUpRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B84 RID: 15236 RVA: 0x001AA55F File Offset: 0x001A875F
		static ConfigTotalTopUpRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRewardById.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x001AA580 File Offset: 0x001A8780
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

		// Token: 0x06003B86 RID: 15238 RVA: 0x001AA5FF File Offset: 0x001A87FF
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRewardById.LogPair = null;
			ConfigTotalTopUpRewardById.HandleId = 0;
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x001AA60D File Offset: 0x001A880D
		public static void Init()
		{
			ConfigTotalTopUpRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRewardById.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpReward` where Id=?");
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x001AA628 File Offset: 0x001A8828
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

		// Token: 0x0400453E RID: 17726
		private const string DB = "db_totaltopup.db";

		// Token: 0x0400453F RID: 17727
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004540 RID: 17728
		private const string TABLE = "TotalTopUpReward";

		// Token: 0x04004541 RID: 17729
		private const string COMMAND = "select BinData from `TotalTopUpReward` where Id=?";

		// Token: 0x04004542 RID: 17730
		private const string KEY_PREFIX = "TotalTopUpRewardById";

		// Token: 0x04004543 RID: 17731
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004544 RID: 17732
		private static int HandleId;
	}
}
