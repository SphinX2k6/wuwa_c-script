using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E1 RID: 737
	public class ConfigFishingNpcPerformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600114B RID: 4427 RVA: 0x000BB384 File Offset: 0x000B9584
		static ConfigFishingNpcPerformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingNpcPerformById.CreateStaticDefaultValue), new Action(ConfigFishingNpcPerformById.ResetStaticDefaultValue));
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000BB3A4 File Offset: 0x000B95A4
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingNpcPerformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingNpcPerformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingNpcPerform"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingNpcPerform` where Id=?")
			});
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x000BB423 File Offset: 0x000B9623
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingNpcPerformById.LogPair = null;
			ConfigFishingNpcPerformById.HandleId = 0;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x000BB431 File Offset: 0x000B9631
		public static void Init()
		{
			ConfigFishingNpcPerformById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingNpcPerformById.HandleId, "db_fishing.db", "select BinData from `FishingNpcPerform` where Id=?");
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x000BB44C File Offset: 0x000B964C
		public static FishingNpcPerform? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingNpcPerformById.HandleId, ConfigFishingNpcPerformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("FishingNpcPerformById#" + p0Id);
				if (configBuffer != null)
				{
					return new FishingNpcPerform?(FishingNpcPerform.GetRootAsFishingNpcPerform(configBuffer));
				}
			}
			ConfigFishingNpcPerformById.LogPair.Clear();
			ConfigFishingNpcPerformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigFishingNpcPerformById.HandleId, 1, p0Id, ConfigFishingNpcPerformById.LogPair) || ConfigCommon.Step(ConfigFishingNpcPerformById.HandleId, true, ConfigFishingNpcPerformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingNpcPerformById.HandleId, ConfigFishingNpcPerformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingNpcPerformById.HandleId, 0, ConfigFishingNpcPerformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingNpcPerformById.HandleId, ConfigFishingNpcPerformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingNpcPerform rootAsFishingNpcPerform = FishingNpcPerform.GetRootAsFishingNpcPerform(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("FishingNpcPerformById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingNpcPerformById.HandleId, ConfigFishingNpcPerformById.LogPair);
			return new FishingNpcPerform?(rootAsFishingNpcPerform);
		}

		// Token: 0x0400140B RID: 5131
		private const string DB = "db_fishing.db";

		// Token: 0x0400140C RID: 5132
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x0400140D RID: 5133
		private const string TABLE = "FishingNpcPerform";

		// Token: 0x0400140E RID: 5134
		private const string COMMAND = "select BinData from `FishingNpcPerform` where Id=?";

		// Token: 0x0400140F RID: 5135
		private const string KEY_PREFIX = "FishingNpcPerformById";

		// Token: 0x04001410 RID: 5136
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001411 RID: 5137
		private static int HandleId;
	}
}
