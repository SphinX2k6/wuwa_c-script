using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B0 RID: 688
	public class ConfigFarmGoldRecommendTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x000B4B18 File Offset: 0x000B2D18
		static ConfigFarmGoldRecommendTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldRecommendTagById.CreateStaticDefaultValue), new Action(ConfigFarmGoldRecommendTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000B4B38 File Offset: 0x000B2D38
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldRecommendTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldRecommendTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldRecommendTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldRecommendTag` where Id=?")
			});
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000B4BB7 File Offset: 0x000B2DB7
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldRecommendTagById.LogPair = null;
			ConfigFarmGoldRecommendTagById.HandleId = 0;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000B4BC5 File Offset: 0x000B2DC5
		public static void Init()
		{
			ConfigFarmGoldRecommendTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldRecommendTagById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldRecommendTag` where Id=?");
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000B4BE0 File Offset: 0x000B2DE0
		public static FarmGoldRecommendTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldRecommendTagById.HandleId, ConfigFarmGoldRecommendTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldRecommendTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FarmGoldRecommendTag?(FarmGoldRecommendTag.GetRootAsFarmGoldRecommendTag(configBuffer));
				}
			}
			ConfigFarmGoldRecommendTagById.LogPair.Clear();
			ConfigFarmGoldRecommendTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFarmGoldRecommendTagById.HandleId, 1, p0Id, ConfigFarmGoldRecommendTagById.LogPair) || ConfigCommon.Step(ConfigFarmGoldRecommendTagById.HandleId, true, ConfigFarmGoldRecommendTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFarmGoldRecommendTagById.HandleId, ConfigFarmGoldRecommendTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldRecommendTagById.HandleId, 0, ConfigFarmGoldRecommendTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFarmGoldRecommendTagById.HandleId, ConfigFarmGoldRecommendTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FarmGoldRecommendTag rootAsFarmGoldRecommendTag = FarmGoldRecommendTag.GetRootAsFarmGoldRecommendTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldRecommendTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFarmGoldRecommendTagById.HandleId, ConfigFarmGoldRecommendTagById.LogPair);
			return new FarmGoldRecommendTag?(rootAsFarmGoldRecommendTag);
		}

		// Token: 0x040012B4 RID: 4788
		private const string DB = "db_farmgold.db";

		// Token: 0x040012B5 RID: 4789
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x040012B6 RID: 4790
		private const string TABLE = "FarmGoldRecommendTag";

		// Token: 0x040012B7 RID: 4791
		private const string COMMAND = "select BinData from `FarmGoldRecommendTag` where Id=?";

		// Token: 0x040012B8 RID: 4792
		private const string KEY_PREFIX = "FarmGoldRecommendTagById";

		// Token: 0x040012B9 RID: 4793
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012BA RID: 4794
		private static int HandleId;
	}
}
