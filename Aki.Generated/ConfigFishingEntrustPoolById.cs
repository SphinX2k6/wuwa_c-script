using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D8 RID: 728
	public class ConfigFishingEntrustPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001115 RID: 4373 RVA: 0x000B9F67 File Offset: 0x000B8167
		static ConfigFishingEntrustPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustPoolById.CreateStaticDefaultValue), new Action(ConfigFishingEntrustPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x000B9F88 File Offset: 0x000B8188
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

		// Token: 0x06001117 RID: 4375 RVA: 0x000BA007 File Offset: 0x000B8207
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustPoolById.LogPair = null;
			ConfigFishingEntrustPoolById.HandleId = 0;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000BA015 File Offset: 0x000B8215
		public static void Init()
		{
			ConfigFishingEntrustPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustPoolById.HandleId, "db_fishing.db", "select BinData from `FishingEntrustPool` where Id=?");
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x000BA030 File Offset: 0x000B8230
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

		// Token: 0x040013CC RID: 5068
		private const string DB = "db_fishing.db";

		// Token: 0x040013CD RID: 5069
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x040013CE RID: 5070
		private const string TABLE = "FishingEntrustPool";

		// Token: 0x040013CF RID: 5071
		private const string COMMAND = "select BinData from `FishingEntrustPool` where Id=?";

		// Token: 0x040013D0 RID: 5072
		private const string KEY_PREFIX = "FishingEntrustPoolById";

		// Token: 0x040013D1 RID: 5073
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013D2 RID: 5074
		private static int HandleId;
	}
}
