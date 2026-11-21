using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000379 RID: 889
	public class ConfigFurnitureByTagId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014DB RID: 5339 RVA: 0x000D2E53 File Offset: 0x000D1053
		static ConfigFurnitureByTagId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureByTagId.CreateStaticDefaultValue), new Action(ConfigFurnitureByTagId.ResetStaticDefaultValue));
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000D2E74 File Offset: 0x000D1074
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureByTagId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureByTagId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Furniture"),
				new ValueTuple<string, object>("语句", "select BinData from `Furniture` where TagId=?")
			});
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000D2EF3 File Offset: 0x000D10F3
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureByTagId.LogPair = null;
			ConfigFurnitureByTagId.HandleId = 0;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000D2F01 File Offset: 0x000D1101
		public static void Init()
		{
			ConfigFurnitureByTagId.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureByTagId.HandleId, "db_furniture.db", "select BinData from `Furniture` where TagId=?");
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000D2F1C File Offset: 0x000D111C
		[NullableContext(2)]
		public static IReadOnlyList<Furniture> GetConfigList(int p0TagId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureByTagId.HandleId, ConfigFurnitureByTagId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureByTagId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TagId);
				IReadOnlyList<Furniture> readOnlyList = (IReadOnlyList<Furniture>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFurnitureByTagId.LogPair.Clear();
			ConfigFurnitureByTagId.LogPair.Add(new ValueTuple<string, object>("TagId", p0TagId));
			if (!ConfigCommon.BindInt(ConfigFurnitureByTagId.HandleId, 1, p0TagId, ConfigFurnitureByTagId.LogPair))
			{
				ConfigCommon.Reset(ConfigFurnitureByTagId.HandleId, ConfigFurnitureByTagId.LogPair);
				return null;
			}
			List<Furniture> list = new List<Furniture>();
			while (ConfigCommon.Step(ConfigFurnitureByTagId.HandleId, false, ConfigFurnitureByTagId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureByTagId.HandleId, 0, ConfigFurnitureByTagId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFurnitureByTagId.HandleId, ConfigFurnitureByTagId.LogPair);
					return null;
				}
				Furniture rootAsFurniture = Furniture.GetRootAsFurniture(new ByteBuffer(item2));
				list.Add(rootAsFurniture);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureByTagId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TagId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFurnitureByTagId.HandleId, ConfigFurnitureByTagId.LogPair);
			return list;
		}

		// Token: 0x04001833 RID: 6195
		private const string DB = "db_furniture.db";

		// Token: 0x04001834 RID: 6196
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001835 RID: 6197
		private const string TABLE = "Furniture";

		// Token: 0x04001836 RID: 6198
		private const string COMMAND = "select BinData from `Furniture` where TagId=?";

		// Token: 0x04001837 RID: 6199
		private const string KEY_PREFIX = "FurnitureByTagId";

		// Token: 0x04001838 RID: 6200
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001839 RID: 6201
		private static int HandleId;
	}
}
