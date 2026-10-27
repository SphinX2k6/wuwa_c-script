using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EE RID: 750
	public class ConfigFishingTechAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001199 RID: 4505 RVA: 0x000BCF64 File Offset: 0x000BB164
		static ConfigFishingTechAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTechAll.CreateStaticDefaultValue), new Action(ConfigFishingTechAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x000BCF84 File Offset: 0x000BB184
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingTechAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingTechAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingTech"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingTech`")
			});
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x000BD003 File Offset: 0x000BB203
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTechAll.LogPair = null;
			ConfigFishingTechAll.HandleId = 0;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000BD011 File Offset: 0x000BB211
		public static void Init()
		{
			ConfigFishingTechAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTechAll.HandleId, "db_fishing.db", "select BinData from `FishingTech`");
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000BD02C File Offset: 0x000BB22C
		[NullableContext(2)]
		public static IReadOnlyList<FishingTech> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingTechAll.HandleId, ConfigFishingTechAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingTech> readOnlyList = (IReadOnlyList<FishingTech>)ConfigCommon.GetConfig("FishingTechAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingTech> list = new List<FishingTech>();
			while (ConfigCommon.Step(ConfigFishingTechAll.HandleId, false, ConfigFishingTechAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingTechAll.HandleId, 0, ConfigFishingTechAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingTechAll.HandleId, ConfigFishingTechAll.LogPair);
					return null;
				}
				FishingTech rootAsFishingTech = FishingTech.GetRootAsFishingTech(new ByteBuffer(item2));
				list.Add(rootAsFishingTech);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingTechAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingTechAll.HandleId, ConfigFishingTechAll.LogPair);
			return list;
		}

		// Token: 0x04001466 RID: 5222
		private const string DB = "db_fishing.db";

		// Token: 0x04001467 RID: 5223
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001468 RID: 5224
		private const string TABLE = "FishingTech";

		// Token: 0x04001469 RID: 5225
		private const string COMMAND = "select BinData from `FishingTech`";

		// Token: 0x0400146A RID: 5226
		private const string KEY_PREFIX = "FishingTechAll";

		// Token: 0x0400146B RID: 5227
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400146C RID: 5228
		private static int HandleId;
	}
}
