using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037A RID: 890
	public class ConfigFurnitureDiyTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014E1 RID: 5345 RVA: 0x000D308B File Offset: 0x000D128B
		static ConfigFurnitureDiyTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureDiyTagAll.CreateStaticDefaultValue), new Action(ConfigFurnitureDiyTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000D30AC File Offset: 0x000D12AC
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

		// Token: 0x060014E3 RID: 5347 RVA: 0x000D312B File Offset: 0x000D132B
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureDiyTagAll.LogPair = null;
			ConfigFurnitureDiyTagAll.HandleId = 0;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000D3139 File Offset: 0x000D1339
		public static void Init()
		{
			ConfigFurnitureDiyTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureDiyTagAll.HandleId, "db_furniture.db", "select BinData from `FurnitureDiyTag`");
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000D3154 File Offset: 0x000D1354
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

		// Token: 0x0400183A RID: 6202
		private const string DB = "db_furniture.db";

		// Token: 0x0400183B RID: 6203
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x0400183C RID: 6204
		private const string TABLE = "FurnitureDiyTag";

		// Token: 0x0400183D RID: 6205
		private const string COMMAND = "select BinData from `FurnitureDiyTag`";

		// Token: 0x0400183E RID: 6206
		private const string KEY_PREFIX = "FurnitureDiyTagAll";

		// Token: 0x0400183F RID: 6207
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001840 RID: 6208
		private static int HandleId;
	}
}
