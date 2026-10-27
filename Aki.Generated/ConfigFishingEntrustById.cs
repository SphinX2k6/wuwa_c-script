using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D6 RID: 726
	public class ConfigFishingEntrustById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001109 RID: 4361 RVA: 0x000B9B8C File Offset: 0x000B7D8C
		static ConfigFishingEntrustById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustById.CreateStaticDefaultValue), new Action(ConfigFishingEntrustById.ResetStaticDefaultValue));
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x000B9BAC File Offset: 0x000B7DAC
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingEntrustById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingEntrustById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingEntrust"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingEntrust` where Id=?")
			});
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000B9C2B File Offset: 0x000B7E2B
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustById.LogPair = null;
			ConfigFishingEntrustById.HandleId = 0;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x000B9C39 File Offset: 0x000B7E39
		public static void Init()
		{
			ConfigFishingEntrustById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustById.HandleId, "db_fishing.db", "select BinData from `FishingEntrust` where Id=?");
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x000B9C54 File Offset: 0x000B7E54
		public static FishingEntrust? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingEntrust?(FishingEntrust.GetRootAsFishingEntrust(configBuffer));
				}
			}
			ConfigFishingEntrustById.LogPair.Clear();
			ConfigFishingEntrustById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingEntrustById.HandleId, 1, p0Id, ConfigFishingEntrustById.LogPair) || ConfigCommon.Step(ConfigFishingEntrustById.HandleId, true, ConfigFishingEntrustById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingEntrustById.HandleId, 0, ConfigFishingEntrustById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingEntrust rootAsFishingEntrust = FishingEntrust.GetRootAsFishingEntrust(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair);
			return new FishingEntrust?(rootAsFishingEntrust);
		}

		// Token: 0x040013BE RID: 5054
		private const string DB = "db_fishing.db";

		// Token: 0x040013BF RID: 5055
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x040013C0 RID: 5056
		private const string TABLE = "FishingEntrust";

		// Token: 0x040013C1 RID: 5057
		private const string COMMAND = "select BinData from `FishingEntrust` where Id=?";

		// Token: 0x040013C2 RID: 5058
		private const string KEY_PREFIX = "FishingEntrustById";

		// Token: 0x040013C3 RID: 5059
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013C4 RID: 5060
		private static int HandleId;
	}
}
