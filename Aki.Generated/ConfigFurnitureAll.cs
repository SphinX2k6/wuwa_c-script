using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000375 RID: 885
	public class ConfigFurnitureAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x000D25B0 File Offset: 0x000D07B0
		static ConfigFurnitureAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureAll.CreateStaticDefaultValue), new Action(ConfigFurnitureAll.ResetStaticDefaultValue));
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x000D25D0 File Offset: 0x000D07D0
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

		// Token: 0x060014C5 RID: 5317 RVA: 0x000D264F File Offset: 0x000D084F
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureAll.LogPair = null;
			ConfigFurnitureAll.HandleId = 0;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000D265D File Offset: 0x000D085D
		public static void Init()
		{
			ConfigFurnitureAll.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureAll.HandleId, "db_furniture.db", "select BinData from `Furniture`");
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000D2678 File Offset: 0x000D0878
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

		// Token: 0x04001817 RID: 6167
		private const string DB = "db_furniture.db";

		// Token: 0x04001818 RID: 6168
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001819 RID: 6169
		private const string TABLE = "Furniture";

		// Token: 0x0400181A RID: 6170
		private const string COMMAND = "select BinData from `Furniture`";

		// Token: 0x0400181B RID: 6171
		private const string KEY_PREFIX = "FurnitureAll";

		// Token: 0x0400181C RID: 6172
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400181D RID: 6173
		private static int HandleId;
	}
}
