using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E6 RID: 742
	public class ConfigFishingActivityGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x000BF5E3 File Offset: 0x000BD7E3
		static ConfigFishingActivityGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityGroupById.CreateStaticDefaultValue), new Action(ConfigFishingActivityGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000BF604 File Offset: 0x000BD804
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingActivityGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingActivityGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼大活动.xlsx"),
				new ValueTuple<string, object>("表名", "FishingActivityGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingActivityGroup` where Id=?")
			});
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000BF683 File Offset: 0x000BD883
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityGroupById.LogPair = null;
			ConfigFishingActivityGroupById.HandleId = 0;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000BF691 File Offset: 0x000BD891
		public static void Init()
		{
			ConfigFishingActivityGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityGroupById.HandleId, "db_fishing.db", "select BinData from `FishingActivityGroup` where Id=?");
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x000BF6AC File Offset: 0x000BD8AC
		public static FishingActivityGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingActivityGroupById.HandleId, ConfigFishingActivityGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingActivityGroup?(FishingActivityGroup.GetRootAsFishingActivityGroup(configBuffer));
				}
			}
			ConfigFishingActivityGroupById.LogPair.Clear();
			ConfigFishingActivityGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingActivityGroupById.HandleId, 1, p0Id, ConfigFishingActivityGroupById.LogPair) || ConfigCommon.Step(ConfigFishingActivityGroupById.HandleId, true, ConfigFishingActivityGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingActivityGroupById.HandleId, ConfigFishingActivityGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingActivityGroupById.HandleId, 0, ConfigFishingActivityGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingActivityGroupById.HandleId, ConfigFishingActivityGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingActivityGroup rootAsFishingActivityGroup = FishingActivityGroup.GetRootAsFishingActivityGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingActivityGroupById.HandleId, ConfigFishingActivityGroupById.LogPair);
			return new FishingActivityGroup?(rootAsFishingActivityGroup);
		}

		// Token: 0x0400142E RID: 5166
		private const string DB = "db_fishing.db";

		// Token: 0x0400142F RID: 5167
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x04001430 RID: 5168
		private const string TABLE = "FishingActivityGroup";

		// Token: 0x04001431 RID: 5169
		private const string COMMAND = "select BinData from `FishingActivityGroup` where Id=?";

		// Token: 0x04001432 RID: 5170
		private const string KEY_PREFIX = "FishingActivityGroupById";

		// Token: 0x04001433 RID: 5171
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001434 RID: 5172
		private static int HandleId;
	}
}
