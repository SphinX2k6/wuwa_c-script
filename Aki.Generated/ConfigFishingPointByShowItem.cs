using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E4 RID: 740
	public class ConfigFishingPointByShowItem : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x000BBA0C File Offset: 0x000B9C0C
		static ConfigFishingPointByShowItem()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPointByShowItem.CreateStaticDefaultValue), new Action(ConfigFishingPointByShowItem.ResetStaticDefaultValue));
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000BBA2C File Offset: 0x000B9C2C
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

		// Token: 0x0600115F RID: 4447 RVA: 0x000BBAAB File Offset: 0x000B9CAB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPointByShowItem.LogPair = null;
			ConfigFishingPointByShowItem.HandleId = 0;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000BBAB9 File Offset: 0x000B9CB9
		public static void Init()
		{
			ConfigFishingPointByShowItem.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPointByShowItem.HandleId, "db_fishing.db", "select BinData from `FishingPoint` where ShowItem=?");
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000BBAD4 File Offset: 0x000B9CD4
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

		// Token: 0x04001420 RID: 5152
		private const string DB = "db_fishing.db";

		// Token: 0x04001421 RID: 5153
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x04001422 RID: 5154
		private const string TABLE = "FishingPoint";

		// Token: 0x04001423 RID: 5155
		private const string COMMAND = "select BinData from `FishingPoint` where ShowItem=?";

		// Token: 0x04001424 RID: 5156
		private const string KEY_PREFIX = "FishingPointByShowItem";

		// Token: 0x04001425 RID: 5157
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001426 RID: 5158
		private static int HandleId;
	}
}
