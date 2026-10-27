using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D1 RID: 721
	public class ConfigFishingActivityGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010EB RID: 4331 RVA: 0x000B90D7 File Offset: 0x000B72D7
		static ConfigFishingActivityGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityGroupById.CreateStaticDefaultValue), new Action(ConfigFishingActivityGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x000B90F8 File Offset: 0x000B72F8
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

		// Token: 0x060010ED RID: 4333 RVA: 0x000B9177 File Offset: 0x000B7377
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityGroupById.LogPair = null;
			ConfigFishingActivityGroupById.HandleId = 0;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x000B9185 File Offset: 0x000B7385
		public static void Init()
		{
			ConfigFishingActivityGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityGroupById.HandleId, "db_fishing.db", "select BinData from `FishingActivityGroup` where Id=?");
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000B91A0 File Offset: 0x000B73A0
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

		// Token: 0x0400139B RID: 5019
		private const string DB = "db_fishing.db";

		// Token: 0x0400139C RID: 5020
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x0400139D RID: 5021
		private const string TABLE = "FishingActivityGroup";

		// Token: 0x0400139E RID: 5022
		private const string COMMAND = "select BinData from `FishingActivityGroup` where Id=?";

		// Token: 0x0400139F RID: 5023
		private const string KEY_PREFIX = "FishingActivityGroupById";

		// Token: 0x040013A0 RID: 5024
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013A1 RID: 5025
		private static int HandleId;
	}
}
