using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F9 RID: 761
	public class ConfigFishingPointByShowItem : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011DB RID: 4571 RVA: 0x000C1F18 File Offset: 0x000C0118
		static ConfigFishingPointByShowItem()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPointByShowItem.CreateStaticDefaultValue), new Action(ConfigFishingPointByShowItem.ResetStaticDefaultValue));
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x000C1F38 File Offset: 0x000C0138
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingPointByShowItem.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingPointByShowItem.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingPoint` where ShowItem=?")
			});
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x000C1FB7 File Offset: 0x000C01B7
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPointByShowItem.LogPair = null;
			ConfigFishingPointByShowItem.HandleId = 0;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x000C1FC5 File Offset: 0x000C01C5
		public static void Init()
		{
			ConfigFishingPointByShowItem.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPointByShowItem.HandleId, "db_fishing.db", "select BinData from `FishingPoint` where ShowItem=?");
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x000C1FE0 File Offset: 0x000C01E0
		[NullableContext(2)]
		public static IReadOnlyList<FishingPoint> GetConfigList(int p0ShowItem, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingPointByShowItem.HandleId, ConfigFishingPointByShowItem.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointByShowItem");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShowItem);
				IReadOnlyList<FishingPoint> readOnlyList = (IReadOnlyList<FishingPoint>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFishingPointByShowItem.LogPair.Clear();
			ConfigFishingPointByShowItem.LogPair.Add(new ValueTuple<string, object>("ShowItem", p0ShowItem));
			if (!ConfigCommon.BindInt(ConfigFishingPointByShowItem.HandleId, 1, p0ShowItem, ConfigFishingPointByShowItem.LogPair))
			{
				ConfigCommon.Reset(ConfigFishingPointByShowItem.HandleId, ConfigFishingPointByShowItem.LogPair);
				return null;
			}
			List<FishingPoint> list = new List<FishingPoint>();
			while (ConfigCommon.Step(ConfigFishingPointByShowItem.HandleId, false, ConfigFishingPointByShowItem.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingPointByShowItem.HandleId, 0, ConfigFishingPointByShowItem.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingPointByShowItem.HandleId, ConfigFishingPointByShowItem.LogPair);
					return null;
				}
				FishingPoint rootAsFishingPoint = FishingPoint.GetRootAsFishingPoint(new ByteBuffer(item2));
				list.Add(rootAsFishingPoint);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointByShowItem");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShowItem);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingPointByShowItem.HandleId, ConfigFishingPointByShowItem.LogPair);
			return list;
		}

		// Token: 0x040014B3 RID: 5299
		private const string DB = "db_fishing.db";

		// Token: 0x040014B4 RID: 5300
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040014B5 RID: 5301
		private const string TABLE = "FishingPoint";

		// Token: 0x040014B6 RID: 5302
		private const string COMMAND = "select BinData from `FishingPoint` where ShowItem=?";

		// Token: 0x040014B7 RID: 5303
		private const string KEY_PREFIX = "FishingPointByShowItem";

		// Token: 0x040014B8 RID: 5304
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014B9 RID: 5305
		private static int HandleId;
	}
}
