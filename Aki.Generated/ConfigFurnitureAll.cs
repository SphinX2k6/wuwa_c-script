using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000360 RID: 864
	public class ConfigFurnitureAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x000CC0A4 File Offset: 0x000CA2A4
		static ConfigFurnitureAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureAll.CreateStaticDefaultValue), new Action(ConfigFurnitureAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000CC0C4 File Offset: 0x000CA2C4
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Furniture"),
				new ValueTuple<string, object>("语句", "select BinData from `Furniture`")
			});
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000CC143 File Offset: 0x000CA343
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureAll.LogPair = null;
			ConfigFurnitureAll.HandleId = 0;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000CC151 File Offset: 0x000CA351
		public static void Init()
		{
			ConfigFurnitureAll.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureAll.HandleId, "db_furniture.db", "select BinData from `Furniture`");
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000CC16C File Offset: 0x000CA36C
		[NullableContext(2)]
		public static IReadOnlyList<Furniture> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureAll.HandleId, ConfigFurnitureAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Furniture> readOnlyList = (IReadOnlyList<Furniture>)ConfigCommon.GetConfig("FurnitureAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Furniture> list = new List<Furniture>();
			while (ConfigCommon.Step(ConfigFurnitureAll.HandleId, false, ConfigFurnitureAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureAll.HandleId, 0, ConfigFurnitureAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFurnitureAll.HandleId, ConfigFurnitureAll.LogPair);
					return null;
				}
				Furniture rootAsFurniture = Furniture.GetRootAsFurniture(new ByteBuffer(item2));
				list.Add(rootAsFurniture);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FurnitureAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFurnitureAll.HandleId, ConfigFurnitureAll.LogPair);
			return list;
		}

		// Token: 0x04001784 RID: 6020
		private const string DB = "db_furniture.db";

		// Token: 0x04001785 RID: 6021
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001786 RID: 6022
		private const string TABLE = "Furniture";

		// Token: 0x04001787 RID: 6023
		private const string COMMAND = "select BinData from `Furniture`";

		// Token: 0x04001788 RID: 6024
		private const string KEY_PREFIX = "FurnitureAll";

		// Token: 0x04001789 RID: 6025
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400178A RID: 6026
		private static int HandleId;
	}
}
