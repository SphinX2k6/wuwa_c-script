using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002ED RID: 749
	public class ConfigFishingEntrustPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001193 RID: 4499 RVA: 0x000C0473 File Offset: 0x000BE673
		static ConfigFishingEntrustPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustPoolById.CreateStaticDefaultValue), new Action(ConfigFishingEntrustPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x000C0494 File Offset: 0x000BE694
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingEntrustPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingEntrustPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingEntrustPool"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingEntrustPool` where Id=?")
			});
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x000C0513 File Offset: 0x000BE713
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustPoolById.LogPair = null;
			ConfigFishingEntrustPoolById.HandleId = 0;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000C0521 File Offset: 0x000BE721
		public static void Init()
		{
			ConfigFishingEntrustPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustPoolById.HandleId, "db_fishing.db", "select BinData from `FishingEntrustPool` where Id=?");
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x000C053C File Offset: 0x000BE73C
		public static FishingEntrustPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingEntrustPoolById.HandleId, ConfigFishingEntrustPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingEntrustPool?(FishingEntrustPool.GetRootAsFishingEntrustPool(configBuffer));
				}
			}
			ConfigFishingEntrustPoolById.LogPair.Clear();
			ConfigFishingEntrustPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingEntrustPoolById.HandleId, 1, p0Id, ConfigFishingEntrustPoolById.LogPair) || ConfigCommon.Step(ConfigFishingEntrustPoolById.HandleId, true, ConfigFishingEntrustPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingEntrustPoolById.HandleId, ConfigFishingEntrustPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingEntrustPoolById.HandleId, 0, ConfigFishingEntrustPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingEntrustPoolById.HandleId, ConfigFishingEntrustPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingEntrustPool rootAsFishingEntrustPool = FishingEntrustPool.GetRootAsFishingEntrustPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingEntrustPoolById.HandleId, ConfigFishingEntrustPoolById.LogPair);
			return new FishingEntrustPool?(rootAsFishingEntrustPool);
		}

		// Token: 0x0400145F RID: 5215
		private const string DB = "db_fishing.db";

		// Token: 0x04001460 RID: 5216
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x04001461 RID: 5217
		private const string TABLE = "FishingEntrustPool";

		// Token: 0x04001462 RID: 5218
		private const string COMMAND = "select BinData from `FishingEntrustPool` where Id=?";

		// Token: 0x04001463 RID: 5219
		private const string KEY_PREFIX = "FishingEntrustPoolById";

		// Token: 0x04001464 RID: 5220
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001465 RID: 5221
		private static int HandleId;
	}
}
