using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000363 RID: 867
	public class ConfigFurnitureBySourceTypeAndGetWayId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001457 RID: 5207 RVA: 0x000CC6B8 File Offset: 0x000CA8B8
		static ConfigFurnitureBySourceTypeAndGetWayId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureBySourceTypeAndGetWayId.CreateStaticDefaultValue), new Action(ConfigFurnitureBySourceTypeAndGetWayId.ResetStaticDefaultValue));
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000CC6D8 File Offset: 0x000CA8D8
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureBySourceTypeAndGetWayId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureBySourceTypeAndGetWayId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Furniture"),
				new ValueTuple<string, object>("语句", "select BinData from `Furniture` where SourceType=? AND GetWayId=?")
			});
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x000CC757 File Offset: 0x000CA957
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureBySourceTypeAndGetWayId.LogPair = null;
			ConfigFurnitureBySourceTypeAndGetWayId.HandleId = 0;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x000CC765 File Offset: 0x000CA965
		public static void Init()
		{
			ConfigFurnitureBySourceTypeAndGetWayId.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, "db_furniture.db", "select BinData from `Furniture` where SourceType=? AND GetWayId=?");
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x000CC780 File Offset: 0x000CA980
		[NullableContext(2)]
		public static IReadOnlyList<Furniture> GetConfigList(int p0SourceType, int p1GetWayId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, ConfigFurnitureBySourceTypeAndGetWayId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureBySourceTypeAndGetWayId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SourceType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GetWayId);
				IReadOnlyList<Furniture> readOnlyList = (IReadOnlyList<Furniture>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFurnitureBySourceTypeAndGetWayId.LogPair.Clear();
			ConfigFurnitureBySourceTypeAndGetWayId.LogPair.Add(new ValueTuple<string, object>("SourceType", p0SourceType));
			ConfigFurnitureBySourceTypeAndGetWayId.LogPair.Add(new ValueTuple<string, object>("GetWayId", p1GetWayId));
			if (!ConfigCommon.BindInt(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, 1, p0SourceType, ConfigFurnitureBySourceTypeAndGetWayId.LogPair) || !ConfigCommon.BindInt(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, 2, p1GetWayId, ConfigFurnitureBySourceTypeAndGetWayId.LogPair))
			{
				ConfigCommon.Reset(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, ConfigFurnitureBySourceTypeAndGetWayId.LogPair);
				return null;
			}
			List<Furniture> list = new List<Furniture>();
			while (ConfigCommon.Step(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, false, ConfigFurnitureBySourceTypeAndGetWayId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, 0, ConfigFurnitureBySourceTypeAndGetWayId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, ConfigFurnitureBySourceTypeAndGetWayId.LogPair);
					return null;
				}
				Furniture rootAsFurniture = Furniture.GetRootAsFurniture(new ByteBuffer(item2));
				list.Add(rootAsFurniture);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureBySourceTypeAndGetWayId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SourceType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GetWayId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, ConfigFurnitureBySourceTypeAndGetWayId.LogPair);
			return list;
		}

		// Token: 0x04001799 RID: 6041
		private const string DB = "db_furniture.db";

		// Token: 0x0400179A RID: 6042
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x0400179B RID: 6043
		private const string TABLE = "Furniture";

		// Token: 0x0400179C RID: 6044
		private const string COMMAND = "select BinData from `Furniture` where SourceType=? AND GetWayId=?";

		// Token: 0x0400179D RID: 6045
		private const string KEY_PREFIX = "FurnitureBySourceTypeAndGetWayId";

		// Token: 0x0400179E RID: 6046
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400179F RID: 6047
		private static int HandleId;
	}
}
