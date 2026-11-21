using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000378 RID: 888
	public class ConfigFurnitureBySourceTypeAndGetWayId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014D5 RID: 5333 RVA: 0x000D2BC4 File Offset: 0x000D0DC4
		static ConfigFurnitureBySourceTypeAndGetWayId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureBySourceTypeAndGetWayId.CreateStaticDefaultValue), new Action(ConfigFurnitureBySourceTypeAndGetWayId.ResetStaticDefaultValue));
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000D2BE4 File Offset: 0x000D0DE4
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

		// Token: 0x060014D7 RID: 5335 RVA: 0x000D2C63 File Offset: 0x000D0E63
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureBySourceTypeAndGetWayId.LogPair = null;
			ConfigFurnitureBySourceTypeAndGetWayId.HandleId = 0;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000D2C71 File Offset: 0x000D0E71
		public static void Init()
		{
			ConfigFurnitureBySourceTypeAndGetWayId.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureBySourceTypeAndGetWayId.HandleId, "db_furniture.db", "select BinData from `Furniture` where SourceType=? AND GetWayId=?");
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000D2C8C File Offset: 0x000D0E8C
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

		// Token: 0x0400182C RID: 6188
		private const string DB = "db_furniture.db";

		// Token: 0x0400182D RID: 6189
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x0400182E RID: 6190
		private const string TABLE = "Furniture";

		// Token: 0x0400182F RID: 6191
		private const string COMMAND = "select BinData from `Furniture` where SourceType=? AND GetWayId=?";

		// Token: 0x04001830 RID: 6192
		private const string KEY_PREFIX = "FurnitureBySourceTypeAndGetWayId";

		// Token: 0x04001831 RID: 6193
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001832 RID: 6194
		private static int HandleId;
	}
}
