using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DE RID: 734
	public class ConfigFishingManualRefreshByEntrustPoolTypeAndStar : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001139 RID: 4409 RVA: 0x000BAC64 File Offset: 0x000B8E64
		static ConfigFishingManualRefreshByEntrustPoolTypeAndStar()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.CreateStaticDefaultValue), new Action(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.ResetStaticDefaultValue));
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x000BAC84 File Offset: 0x000B8E84
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingManualRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingManualRefresh` where EntrustPoolType=? And Star=?")
			});
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x000BAD03 File Offset: 0x000B8F03
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair = null;
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId = 0;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000BAD11 File Offset: 0x000B8F11
		public static void Init()
		{
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId = ConfigCommon.InitDataStatement(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, "db_fishing.db", "select BinData from `FishingManualRefresh` where EntrustPoolType=? And Star=?");
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000BAD2C File Offset: 0x000B8F2C
		[NullableContext(2)]
		public static IReadOnlyList<FishingManualRefresh> GetConfigList(int p0EntrustPoolType, int p1Star, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FishingManualRefreshByEntrustPoolTypeAndStar");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntrustPoolType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Star);
				IReadOnlyList<FishingManualRefresh> readOnlyList = (IReadOnlyList<FishingManualRefresh>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair.Clear();
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair.Add(new ValueTuple<string, object>("EntrustPoolType", p0EntrustPoolType));
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair.Add(new ValueTuple<string, object>("Star", p1Star));
			if (!ConfigCommon.BindInt(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, 1, p0EntrustPoolType, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair) || !ConfigCommon.BindInt(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, 2, p1Star, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair))
			{
				ConfigCommon.Reset(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair);
				return null;
			}
			List<FishingManualRefresh> list = new List<FishingManualRefresh>();
			while (ConfigCommon.Step(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, false, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, 0, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair);
					return null;
				}
				FishingManualRefresh rootAsFishingManualRefresh = FishingManualRefresh.GetRootAsFishingManualRefresh(new ByteBuffer(item2));
				list.Add(rootAsFishingManualRefresh);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FishingManualRefreshByEntrustPoolTypeAndStar");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntrustPoolType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Star);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair);
			return list;
		}

		// Token: 0x040013F6 RID: 5110
		private const string DB = "db_fishing.db";

		// Token: 0x040013F7 RID: 5111
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x040013F8 RID: 5112
		private const string TABLE = "FishingManualRefresh";

		// Token: 0x040013F9 RID: 5113
		private const string COMMAND = "select BinData from `FishingManualRefresh` where EntrustPoolType=? And Star=?";

		// Token: 0x040013FA RID: 5114
		private const string KEY_PREFIX = "FishingManualRefreshByEntrustPoolTypeAndStar";

		// Token: 0x040013FB RID: 5115
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013FC RID: 5116
		private static int HandleId;
	}
}
