using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000365 RID: 869
	public class ConfigFurnitureDiyTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x000CCB7F File Offset: 0x000CAD7F
		static ConfigFurnitureDiyTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureDiyTagAll.CreateStaticDefaultValue), new Action(ConfigFurnitureDiyTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000CCBA0 File Offset: 0x000CADA0
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureDiyTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureDiyTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FurnitureDiyTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FurnitureDiyTag`")
			});
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x000CCC1F File Offset: 0x000CAE1F
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureDiyTagAll.LogPair = null;
			ConfigFurnitureDiyTagAll.HandleId = 0;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000CCC2D File Offset: 0x000CAE2D
		public static void Init()
		{
			ConfigFurnitureDiyTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureDiyTagAll.HandleId, "db_furniture.db", "select BinData from `FurnitureDiyTag`");
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000CCC48 File Offset: 0x000CAE48
		[NullableContext(2)]
		public static IReadOnlyList<FurnitureDiyTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureDiyTagAll.HandleId, ConfigFurnitureDiyTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FurnitureDiyTag> readOnlyList = (IReadOnlyList<FurnitureDiyTag>)ConfigCommon.GetConfig("FurnitureDiyTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FurnitureDiyTag> list = new List<FurnitureDiyTag>();
			while (ConfigCommon.Step(ConfigFurnitureDiyTagAll.HandleId, false, ConfigFurnitureDiyTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureDiyTagAll.HandleId, 0, ConfigFurnitureDiyTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFurnitureDiyTagAll.HandleId, ConfigFurnitureDiyTagAll.LogPair);
					return null;
				}
				FurnitureDiyTag rootAsFurnitureDiyTag = FurnitureDiyTag.GetRootAsFurnitureDiyTag(new ByteBuffer(item2));
				list.Add(rootAsFurnitureDiyTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FurnitureDiyTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFurnitureDiyTagAll.HandleId, ConfigFurnitureDiyTagAll.LogPair);
			return list;
		}

		// Token: 0x040017A7 RID: 6055
		private const string DB = "db_furniture.db";

		// Token: 0x040017A8 RID: 6056
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x040017A9 RID: 6057
		private const string TABLE = "FurnitureDiyTag";

		// Token: 0x040017AA RID: 6058
		private const string COMMAND = "select BinData from `FurnitureDiyTag`";

		// Token: 0x040017AB RID: 6059
		private const string KEY_PREFIX = "FurnitureDiyTagAll";

		// Token: 0x040017AC RID: 6060
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017AD RID: 6061
		private static int HandleId;
	}
}
