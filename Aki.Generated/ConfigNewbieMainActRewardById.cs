using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EB RID: 1515
	public class ConfigNewbieMainActRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002391 RID: 9105 RVA: 0x00122A33 File Offset: 0x00120C33
		static ConfigNewbieMainActRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActRewardById.CreateStaticDefaultValue), new Action(ConfigNewbieMainActRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00122A54 File Offset: 0x00120C54
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

		// Token: 0x06002393 RID: 9107 RVA: 0x00122AD3 File Offset: 0x00120CD3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActRewardById.LogPair = null;
			ConfigNewbieMainActRewardById.HandleId = 0;
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00122AE1 File Offset: 0x00120CE1
		public static void Init()
		{
			ConfigNewbieMainActRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActRewardById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActReward` where Id=?");
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00122AFC File Offset: 0x00120CFC
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

		// Token: 0x04002953 RID: 10579
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002954 RID: 10580
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002955 RID: 10581
		private const string TABLE = "NewbieMainActReward";

		// Token: 0x04002956 RID: 10582
		private const string COMMAND = "select BinData from `NewbieMainActReward` where Id=?";

		// Token: 0x04002957 RID: 10583
		private const string KEY_PREFIX = "NewbieMainActRewardById";

		// Token: 0x04002958 RID: 10584
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002959 RID: 10585
		private static int HandleId;
	}
}
