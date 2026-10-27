using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000361 RID: 865
	public class ConfigFurnitureByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600144B RID: 5195 RVA: 0x000CC237 File Offset: 0x000CA437
		static ConfigFurnitureByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureByActivityId.CreateStaticDefaultValue), new Action(ConfigFurnitureByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000CC258 File Offset: 0x000CA458
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Furniture"),
				new ValueTuple<string, object>("语句", "select BinData from `Furniture` where ActivityId=?")
			});
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000CC2D7 File Offset: 0x000CA4D7
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureByActivityId.LogPair = null;
			ConfigFurnitureByActivityId.HandleId = 0;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000CC2E5 File Offset: 0x000CA4E5
		public static void Init()
		{
			ConfigFurnitureByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureByActivityId.HandleId, "db_furniture.db", "select BinData from `Furniture` where ActivityId=?");
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000CC300 File Offset: 0x000CA500
		[NullableContext(2)]
		public static IReadOnlyList<Furniture> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<Furniture> readOnlyList = (IReadOnlyList<Furniture>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFurnitureByActivityId.LogPair.Clear();
			ConfigFurnitureByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFurnitureByActivityId.HandleId, 1, p0ActivityId, ConfigFurnitureByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair);
				return null;
			}
			List<Furniture> list = new List<Furniture>();
			while (ConfigCommon.Step(ConfigFurnitureByActivityId.HandleId, false, ConfigFurnitureByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureByActivityId.HandleId, 0, ConfigFurnitureByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair);
					return null;
				}
				Furniture rootAsFurniture = Furniture.GetRootAsFurniture(new ByteBuffer(item2));
				list.Add(rootAsFurniture);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400178B RID: 6027
		private const string DB = "db_furniture.db";

		// Token: 0x0400178C RID: 6028
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x0400178D RID: 6029
		private const string TABLE = "Furniture";

		// Token: 0x0400178E RID: 6030
		private const string COMMAND = "select BinData from `Furniture` where ActivityId=?";

		// Token: 0x0400178F RID: 6031
		private const string KEY_PREFIX = "FurnitureByActivityId";

		// Token: 0x04001790 RID: 6032
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001791 RID: 6033
		private static int HandleId;
	}
}
