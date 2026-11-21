using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F3 RID: 755
	public class ConfigFishingManualRefreshByEntrustPoolTypeAndStar : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011B7 RID: 4535 RVA: 0x000C1170 File Offset: 0x000BF370
		static ConfigFishingManualRefreshByEntrustPoolTypeAndStar()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.CreateStaticDefaultValue), new Action(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.ResetStaticDefaultValue));
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x000C1190 File Offset: 0x000BF390
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

		// Token: 0x060011B9 RID: 4537 RVA: 0x000C120F File Offset: 0x000BF40F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.LogPair = null;
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId = 0;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000C121D File Offset: 0x000BF41D
		public static void Init()
		{
			ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId = ConfigCommon.InitDataStatement(ConfigFishingManualRefreshByEntrustPoolTypeAndStar.HandleId, "db_fishing.db", "select BinData from `FishingManualRefresh` where EntrustPoolType=? And Star=?");
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x000C1238 File Offset: 0x000BF438
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

		// Token: 0x04001489 RID: 5257
		private const string DB = "db_fishing.db";

		// Token: 0x0400148A RID: 5258
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x0400148B RID: 5259
		private const string TABLE = "FishingManualRefresh";

		// Token: 0x0400148C RID: 5260
		private const string COMMAND = "select BinData from `FishingManualRefresh` where EntrustPoolType=? And Star=?";

		// Token: 0x0400148D RID: 5261
		private const string KEY_PREFIX = "FishingManualRefreshByEntrustPoolTypeAndStar";

		// Token: 0x0400148E RID: 5262
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400148F RID: 5263
		private static int HandleId;
	}
}
