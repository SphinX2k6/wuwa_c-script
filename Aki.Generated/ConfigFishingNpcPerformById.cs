using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F6 RID: 758
	public class ConfigFishingNpcPerformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011C9 RID: 4553 RVA: 0x000C1890 File Offset: 0x000BFA90
		static ConfigFishingNpcPerformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingNpcPerformById.CreateStaticDefaultValue), new Action(ConfigFishingNpcPerformById.ResetStaticDefaultValue));
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000C18B0 File Offset: 0x000BFAB0
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

		// Token: 0x060011CB RID: 4555 RVA: 0x000C192F File Offset: 0x000BFB2F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingNpcPerformById.LogPair = null;
			ConfigFishingNpcPerformById.HandleId = 0;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000C193D File Offset: 0x000BFB3D
		public static void Init()
		{
			ConfigFishingNpcPerformById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingNpcPerformById.HandleId, "db_fishing.db", "select BinData from `FishingNpcPerform` where Id=?");
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x000C1958 File Offset: 0x000BFB58
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

		// Token: 0x0400149E RID: 5278
		private const string DB = "db_fishing.db";

		// Token: 0x0400149F RID: 5279
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040014A0 RID: 5280
		private const string TABLE = "FishingNpcPerform";

		// Token: 0x040014A1 RID: 5281
		private const string COMMAND = "select BinData from `FishingNpcPerform` where Id=?";

		// Token: 0x040014A2 RID: 5282
		private const string KEY_PREFIX = "FishingNpcPerformById";

		// Token: 0x040014A3 RID: 5283
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014A4 RID: 5284
		private static int HandleId;
	}
}
