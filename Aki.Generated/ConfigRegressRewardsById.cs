using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F6 RID: 2038
	public class ConfigRegressRewardsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FD6 RID: 12246 RVA: 0x0016B12B File Offset: 0x0016932B
		static ConfigRegressRewardsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRewardsById.CreateStaticDefaultValue), new Action(ConfigRegressRewardsById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0016B14C File Offset: 0x0016934C
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressRewardsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressRewardsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "RegressRewards"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressRewards` where Id=?")
			});
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x0016B1CB File Offset: 0x001693CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRewardsById.LogPair = null;
			ConfigRegressRewardsById.HandleId = 0;
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x0016B1D9 File Offset: 0x001693D9
		public static void Init()
		{
			ConfigRegressRewardsById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRewardsById.HandleId, "db_circumfluence.db", "select BinData from `RegressRewards` where Id=?");
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x0016B1F4 File Offset: 0x001693F4
		public static RegressRewards? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRewardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressRewards?(RegressRewards.GetRootAsRegressRewards(configBuffer));
				}
			}
			ConfigRegressRewardsById.LogPair.Clear();
			ConfigRegressRewardsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressRewardsById.HandleId, 1, p0Id, ConfigRegressRewardsById.LogPair) || ConfigCommon.Step(ConfigRegressRewardsById.HandleId, true, ConfigRegressRewardsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressRewardsById.HandleId, 0, ConfigRegressRewardsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressRewards rootAsRegressRewards = RegressRewards.GetRootAsRegressRewards(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRewardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair);
			return new RegressRewards?(rootAsRegressRewards);
		}

		// Token: 0x040037A0 RID: 14240
		private const string DB = "db_circumfluence.db";

		// Token: 0x040037A1 RID: 14241
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x040037A2 RID: 14242
		private const string TABLE = "RegressRewards";

		// Token: 0x040037A3 RID: 14243
		private const string COMMAND = "select BinData from `RegressRewards` where Id=?";

		// Token: 0x040037A4 RID: 14244
		private const string KEY_PREFIX = "RegressRewardsById";

		// Token: 0x040037A5 RID: 14245
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037A6 RID: 14246
		private static int HandleId;
	}
}
