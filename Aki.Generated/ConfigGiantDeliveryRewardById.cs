using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A6 RID: 934
	public class ConfigGiantDeliveryRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015EA RID: 5610 RVA: 0x000D90E4 File Offset: 0x000D72E4
		static ConfigGiantDeliveryRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantDeliveryRewardById.CreateStaticDefaultValue), new Action(ConfigGiantDeliveryRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000D9104 File Offset: 0x000D7304
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

		// Token: 0x060015EC RID: 5612 RVA: 0x000D9183 File Offset: 0x000D7383
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantDeliveryRewardById.LogPair = null;
			ConfigGiantDeliveryRewardById.HandleId = 0;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000D9191 File Offset: 0x000D7391
		public static void Init()
		{
			ConfigGiantDeliveryRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantDeliveryRewardById.HandleId, "db_giant.db", "select BinData from `GiantDeliveryReward` where Id=?");
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000D91AC File Offset: 0x000D73AC
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

		// Token: 0x0400196E RID: 6510
		private const string DB = "db_giant.db";

		// Token: 0x0400196F RID: 6511
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x04001970 RID: 6512
		private const string TABLE = "GiantDeliveryReward";

		// Token: 0x04001971 RID: 6513
		private const string COMMAND = "select BinData from `GiantDeliveryReward` where Id=?";

		// Token: 0x04001972 RID: 6514
		private const string KEY_PREFIX = "GiantDeliveryRewardById";

		// Token: 0x04001973 RID: 6515
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001974 RID: 6516
		private static int HandleId;
	}
}
