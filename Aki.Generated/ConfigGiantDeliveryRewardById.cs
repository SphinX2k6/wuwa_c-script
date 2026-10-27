using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000390 RID: 912
	public class ConfigGiantDeliveryRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x000D2990 File Offset: 0x000D0B90
		static ConfigGiantDeliveryRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantDeliveryRewardById.CreateStaticDefaultValue), new Action(ConfigGiantDeliveryRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000D29B0 File Offset: 0x000D0BB0
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantDeliveryRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantDeliveryRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantDeliveryReward"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantDeliveryReward` where Id=?")
			});
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000D2A2F File Offset: 0x000D0C2F
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantDeliveryRewardById.LogPair = null;
			ConfigGiantDeliveryRewardById.HandleId = 0;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000D2A3D File Offset: 0x000D0C3D
		public static void Init()
		{
			ConfigGiantDeliveryRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantDeliveryRewardById.HandleId, "db_giant.db", "select BinData from `GiantDeliveryReward` where Id=?");
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x000D2A58 File Offset: 0x000D0C58
		public static GiantDeliveryReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantDeliveryRewardById.HandleId, ConfigGiantDeliveryRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantDeliveryRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantDeliveryReward?(GiantDeliveryReward.GetRootAsGiantDeliveryReward(configBuffer));
				}
			}
			ConfigGiantDeliveryRewardById.LogPair.Clear();
			ConfigGiantDeliveryRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantDeliveryRewardById.HandleId, 1, p0Id, ConfigGiantDeliveryRewardById.LogPair) || ConfigCommon.Step(ConfigGiantDeliveryRewardById.HandleId, true, ConfigGiantDeliveryRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantDeliveryRewardById.HandleId, ConfigGiantDeliveryRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantDeliveryRewardById.HandleId, 0, ConfigGiantDeliveryRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantDeliveryRewardById.HandleId, ConfigGiantDeliveryRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantDeliveryReward rootAsGiantDeliveryReward = GiantDeliveryReward.GetRootAsGiantDeliveryReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantDeliveryRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantDeliveryRewardById.HandleId, ConfigGiantDeliveryRewardById.LogPair);
			return new GiantDeliveryReward?(rootAsGiantDeliveryReward);
		}

		// Token: 0x040018D4 RID: 6356
		private const string DB = "db_giant.db";

		// Token: 0x040018D5 RID: 6357
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040018D6 RID: 6358
		private const string TABLE = "GiantDeliveryReward";

		// Token: 0x040018D7 RID: 6359
		private const string COMMAND = "select BinData from `GiantDeliveryReward` where Id=?";

		// Token: 0x040018D8 RID: 6360
		private const string KEY_PREFIX = "GiantDeliveryRewardById";

		// Token: 0x040018D9 RID: 6361
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018DA RID: 6362
		private static int HandleId;
	}
}
