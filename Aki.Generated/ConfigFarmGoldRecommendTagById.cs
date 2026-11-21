using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C5 RID: 709
	public class ConfigFarmGoldRecommendTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010A3 RID: 4259 RVA: 0x000BB024 File Offset: 0x000B9224
		static ConfigFarmGoldRecommendTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldRecommendTagById.CreateStaticDefaultValue), new Action(ConfigFarmGoldRecommendTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000BB044 File Offset: 0x000B9244
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

		// Token: 0x060010A5 RID: 4261 RVA: 0x000BB0C3 File Offset: 0x000B92C3
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldRecommendTagById.LogPair = null;
			ConfigFarmGoldRecommendTagById.HandleId = 0;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000BB0D1 File Offset: 0x000B92D1
		public static void Init()
		{
			ConfigFarmGoldRecommendTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldRecommendTagById.HandleId, "db_farmgold.db", "select BinData from `FarmGoldRecommendTag` where Id=?");
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x000BB0EC File Offset: 0x000B92EC
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

		// Token: 0x04001347 RID: 4935
		private const string DB = "db_farmgold.db";

		// Token: 0x04001348 RID: 4936
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x04001349 RID: 4937
		private const string TABLE = "FarmGoldRecommendTag";

		// Token: 0x0400134A RID: 4938
		private const string COMMAND = "select BinData from `FarmGoldRecommendTag` where Id=?";

		// Token: 0x0400134B RID: 4939
		private const string KEY_PREFIX = "FarmGoldRecommendTagById";

		// Token: 0x0400134C RID: 4940
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400134D RID: 4941
		private static int HandleId;
	}
}
