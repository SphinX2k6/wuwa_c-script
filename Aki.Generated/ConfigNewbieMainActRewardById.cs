using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000603 RID: 1539
	public class ConfigNewbieMainActRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002421 RID: 9249 RVA: 0x001294AF File Offset: 0x001276AF
		static ConfigNewbieMainActRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActRewardById.CreateStaticDefaultValue), new Action(ConfigNewbieMainActRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x001294D0 File Offset: 0x001276D0
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActReward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActReward` where Id=?")
			});
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0012954F File Offset: 0x0012774F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActRewardById.LogPair = null;
			ConfigNewbieMainActRewardById.HandleId = 0;
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0012955D File Offset: 0x0012775D
		public static void Init()
		{
			ConfigNewbieMainActRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActRewardById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActReward` where Id=?");
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00129578 File Offset: 0x00127778
		public static NewbieMainActReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActRewardById.HandleId, ConfigNewbieMainActRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieMainActReward?(NewbieMainActReward.GetRootAsNewbieMainActReward(configBuffer));
				}
			}
			ConfigNewbieMainActRewardById.LogPair.Clear();
			ConfigNewbieMainActRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActRewardById.HandleId, 1, p0Id, ConfigNewbieMainActRewardById.LogPair) || ConfigCommon.Step(ConfigNewbieMainActRewardById.HandleId, true, ConfigNewbieMainActRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieMainActRewardById.HandleId, ConfigNewbieMainActRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActRewardById.HandleId, 0, ConfigNewbieMainActRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieMainActRewardById.HandleId, ConfigNewbieMainActRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieMainActReward rootAsNewbieMainActReward = NewbieMainActReward.GetRootAsNewbieMainActReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieMainActRewardById.HandleId, ConfigNewbieMainActRewardById.LogPair);
			return new NewbieMainActReward?(rootAsNewbieMainActReward);
		}

		// Token: 0x040029FB RID: 10747
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x040029FC RID: 10748
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x040029FD RID: 10749
		private const string TABLE = "NewbieMainActReward";

		// Token: 0x040029FE RID: 10750
		private const string COMMAND = "select BinData from `NewbieMainActReward` where Id=?";

		// Token: 0x040029FF RID: 10751
		private const string KEY_PREFIX = "NewbieMainActRewardById";

		// Token: 0x04002A00 RID: 10752
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A01 RID: 10753
		private static int HandleId;
	}
}
