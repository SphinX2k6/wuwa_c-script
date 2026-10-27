using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EA RID: 746
	public class ConfigFishingReputationByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001181 RID: 4481 RVA: 0x000BC6F7 File Offset: 0x000BA8F7
		static ConfigFishingReputationByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingReputationByLevel.CreateStaticDefaultValue), new Action(ConfigFishingReputationByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000BC718 File Offset: 0x000BA918
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

		// Token: 0x06001183 RID: 4483 RVA: 0x000BC797 File Offset: 0x000BA997
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingReputationByLevel.LogPair = null;
			ConfigFishingReputationByLevel.HandleId = 0;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000BC7A5 File Offset: 0x000BA9A5
		public static void Init()
		{
			ConfigFishingReputationByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFishingReputationByLevel.HandleId, "db_fishing.db", "select BinData from `FishingReputation` where Level=?");
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000BC7C0 File Offset: 0x000BA9C0
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

		// Token: 0x0400144A RID: 5194
		private const string DB = "db_fishing.db";

		// Token: 0x0400144B RID: 5195
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x0400144C RID: 5196
		private const string TABLE = "FishingReputation";

		// Token: 0x0400144D RID: 5197
		private const string COMMAND = "select BinData from `FishingReputation` where Level=?";

		// Token: 0x0400144E RID: 5198
		private const string KEY_PREFIX = "FishingReputationByLevel";

		// Token: 0x0400144F RID: 5199
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001450 RID: 5200
		private static int HandleId;
	}
}
