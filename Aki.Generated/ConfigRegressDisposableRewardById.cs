using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CC RID: 1996
	public class ConfigRegressDisposableRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EDA RID: 11994 RVA: 0x001621B5 File Offset: 0x001603B5
		static ConfigRegressDisposableRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDisposableRewardById.CreateStaticDefaultValue), new Action(ConfigRegressDisposableRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x001621D4 File Offset: 0x001603D4
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressDisposableRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressDisposableRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressDisposableReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressDisposableReward` where Id=?")
			});
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00162253 File Offset: 0x00160453
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDisposableRewardById.LogPair = null;
			ConfigRegressDisposableRewardById.HandleId = 0;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00162261 File Offset: 0x00160461
		public static void Init()
		{
			ConfigRegressDisposableRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDisposableRewardById.HandleId, "db_regressactivity.db", "select BinData from `RegressDisposableReward` where Id=?");
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x0016227C File Offset: 0x0016047C
		public static RegressDisposableReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDisposableRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressDisposableReward?(RegressDisposableReward.GetRootAsRegressDisposableReward(configBuffer));
				}
			}
			ConfigRegressDisposableRewardById.LogPair.Clear();
			ConfigRegressDisposableRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressDisposableRewardById.HandleId, 1, p0Id, ConfigRegressDisposableRewardById.LogPair) || ConfigCommon.Step(ConfigRegressDisposableRewardById.HandleId, true, ConfigRegressDisposableRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressDisposableRewardById.HandleId, 0, ConfigRegressDisposableRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressDisposableReward rootAsRegressDisposableReward = RegressDisposableReward.GetRootAsRegressDisposableReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDisposableRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressDisposableRewardById.HandleId, ConfigRegressDisposableRewardById.LogPair);
			return new RegressDisposableReward?(rootAsRegressDisposableReward);
		}

		// Token: 0x0400367A RID: 13946
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400367B RID: 13947
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400367C RID: 13948
		private const string TABLE = "RegressDisposableReward";

		// Token: 0x0400367D RID: 13949
		private const string COMMAND = "select BinData from `RegressDisposableReward` where Id=?";

		// Token: 0x0400367E RID: 13950
		private const string KEY_PREFIX = "RegressDisposableRewardById";

		// Token: 0x0400367F RID: 13951
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003680 RID: 13952
		private static int HandleId;
	}
}
