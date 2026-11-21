using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FF RID: 767
	public class ConfigFishingReputationByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011FF RID: 4607 RVA: 0x000C2C03 File Offset: 0x000C0E03
		static ConfigFishingReputationByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingReputationByLevel.CreateStaticDefaultValue), new Action(ConfigFishingReputationByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000C2C24 File Offset: 0x000C0E24
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingReputationByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingReputationByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingReputation"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingReputation` where Level=?")
			});
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x000C2CA3 File Offset: 0x000C0EA3
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingReputationByLevel.LogPair = null;
			ConfigFishingReputationByLevel.HandleId = 0;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x000C2CB1 File Offset: 0x000C0EB1
		public static void Init()
		{
			ConfigFishingReputationByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFishingReputationByLevel.HandleId, "db_fishing.db", "select BinData from `FishingReputation` where Level=?");
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x000C2CCC File Offset: 0x000C0ECC
		public static FishingReputation? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingReputationByLevel.HandleId, ConfigFishingReputationByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingReputationByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingReputation?(FishingReputation.GetRootAsFishingReputation(configBuffer));
				}
			}
			ConfigFishingReputationByLevel.LogPair.Clear();
			ConfigFishingReputationByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigFishingReputationByLevel.HandleId, 1, p0Level, ConfigFishingReputationByLevel.LogPair) || ConfigCommon.Step(ConfigFishingReputationByLevel.HandleId, true, ConfigFishingReputationByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingReputationByLevel.HandleId, ConfigFishingReputationByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingReputationByLevel.HandleId, 0, ConfigFishingReputationByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingReputationByLevel.HandleId, ConfigFishingReputationByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingReputation rootAsFishingReputation = FishingReputation.GetRootAsFishingReputation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingReputationByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingReputationByLevel.HandleId, ConfigFishingReputationByLevel.LogPair);
			return new FishingReputation?(rootAsFishingReputation);
		}

		// Token: 0x040014DD RID: 5341
		private const string DB = "db_fishing.db";

		// Token: 0x040014DE RID: 5342
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x040014DF RID: 5343
		private const string TABLE = "FishingReputation";

		// Token: 0x040014E0 RID: 5344
		private const string COMMAND = "select BinData from `FishingReputation` where Level=?";

		// Token: 0x040014E1 RID: 5345
		private const string KEY_PREFIX = "FishingReputationByLevel";

		// Token: 0x040014E2 RID: 5346
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014E3 RID: 5347
		private static int HandleId;
	}
}
