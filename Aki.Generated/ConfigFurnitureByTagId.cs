using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000364 RID: 868
	public class ConfigFurnitureByTagId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x000CC947 File Offset: 0x000CAB47
		static ConfigFurnitureByTagId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureByTagId.CreateStaticDefaultValue), new Action(ConfigFurnitureByTagId.ResetStaticDefaultValue));
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000CC968 File Offset: 0x000CAB68
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

		// Token: 0x0600145F RID: 5215 RVA: 0x000CC9E7 File Offset: 0x000CABE7
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureByTagId.LogPair = null;
			ConfigFurnitureByTagId.HandleId = 0;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000CC9F5 File Offset: 0x000CABF5
		public static void Init()
		{
			ConfigFurnitureByTagId.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureByTagId.HandleId, "db_furniture.db", "select BinData from `Furniture` where TagId=?");
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000CCA10 File Offset: 0x000CAC10
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

		// Token: 0x040017A0 RID: 6048
		private const string DB = "db_furniture.db";

		// Token: 0x040017A1 RID: 6049
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x040017A2 RID: 6050
		private const string TABLE = "Furniture";

		// Token: 0x040017A3 RID: 6051
		private const string COMMAND = "select BinData from `Furniture` where TagId=?";

		// Token: 0x040017A4 RID: 6052
		private const string KEY_PREFIX = "FurnitureByTagId";

		// Token: 0x040017A5 RID: 6053
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017A6 RID: 6054
		private static int HandleId;
	}
}
