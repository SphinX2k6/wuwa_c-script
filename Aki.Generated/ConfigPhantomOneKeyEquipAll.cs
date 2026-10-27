using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AC RID: 1708
	public class ConfigPhantomOneKeyEquipAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002818 RID: 10264 RVA: 0x0013C533 File Offset: 0x0013A733
		static ConfigPhantomOneKeyEquipAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomOneKeyEquipAll.CreateStaticDefaultValue), new Action(ConfigPhantomOneKeyEquipAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0013C554 File Offset: 0x0013A754
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomOneKeyEquipAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomOneKeyEquipAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_visionrecommend.db"),
				new ValueTuple<string, object>("文件", "h.幻象推荐.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomOneKeyEquip"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomOneKeyEquip`")
			});
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x0013C5D3 File Offset: 0x0013A7D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomOneKeyEquipAll.LogPair = null;
			ConfigPhantomOneKeyEquipAll.HandleId = 0;
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x0013C5E1 File Offset: 0x0013A7E1
		public static void Init()
		{
			ConfigPhantomOneKeyEquipAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomOneKeyEquipAll.HandleId, "db_visionrecommend.db", "select BinData from `PhantomOneKeyEquip`");
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0013C5FC File Offset: 0x0013A7FC
		[NullableContext(2)]
		public static IReadOnlyList<PhantomOneKeyEquip> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomOneKeyEquipAll.HandleId, ConfigPhantomOneKeyEquipAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomOneKeyEquip> readOnlyList = (IReadOnlyList<PhantomOneKeyEquip>)ConfigCommon.GetConfig("PhantomOneKeyEquipAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomOneKeyEquip> list = new List<PhantomOneKeyEquip>();
			while (ConfigCommon.Step(ConfigPhantomOneKeyEquipAll.HandleId, false, ConfigPhantomOneKeyEquipAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomOneKeyEquipAll.HandleId, 0, ConfigPhantomOneKeyEquipAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomOneKeyEquipAll.HandleId, ConfigPhantomOneKeyEquipAll.LogPair);
					return null;
				}
				PhantomOneKeyEquip rootAsPhantomOneKeyEquip = PhantomOneKeyEquip.GetRootAsPhantomOneKeyEquip(new ByteBuffer(item2));
				list.Add(rootAsPhantomOneKeyEquip);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomOneKeyEquipAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomOneKeyEquipAll.HandleId, ConfigPhantomOneKeyEquipAll.LogPair);
			return list;
		}

		// Token: 0x04002E9A RID: 11930
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002E9B RID: 11931
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002E9C RID: 11932
		private const string TABLE = "PhantomOneKeyEquip";

		// Token: 0x04002E9D RID: 11933
		private const string COMMAND = "select BinData from `PhantomOneKeyEquip`";

		// Token: 0x04002E9E RID: 11934
		private const string KEY_PREFIX = "PhantomOneKeyEquipAll";

		// Token: 0x04002E9F RID: 11935
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EA0 RID: 11936
		private static int HandleId;
	}
}
