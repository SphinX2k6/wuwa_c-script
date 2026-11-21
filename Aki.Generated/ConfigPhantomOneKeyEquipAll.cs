using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C4 RID: 1732
	public class ConfigPhantomOneKeyEquipAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028A8 RID: 10408 RVA: 0x00142FAF File Offset: 0x001411AF
		static ConfigPhantomOneKeyEquipAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomOneKeyEquipAll.CreateStaticDefaultValue), new Action(ConfigPhantomOneKeyEquipAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00142FD0 File Offset: 0x001411D0
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

		// Token: 0x060028AA RID: 10410 RVA: 0x0014304F File Offset: 0x0014124F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomOneKeyEquipAll.LogPair = null;
			ConfigPhantomOneKeyEquipAll.HandleId = 0;
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0014305D File Offset: 0x0014125D
		public static void Init()
		{
			ConfigPhantomOneKeyEquipAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomOneKeyEquipAll.HandleId, "db_visionrecommend.db", "select BinData from `PhantomOneKeyEquip`");
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00143078 File Offset: 0x00141278
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

		// Token: 0x04002F42 RID: 12098
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002F43 RID: 12099
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002F44 RID: 12100
		private const string TABLE = "PhantomOneKeyEquip";

		// Token: 0x04002F45 RID: 12101
		private const string COMMAND = "select BinData from `PhantomOneKeyEquip`";

		// Token: 0x04002F46 RID: 12102
		private const string KEY_PREFIX = "PhantomOneKeyEquipAll";

		// Token: 0x04002F47 RID: 12103
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F48 RID: 12104
		private static int HandleId;
	}
}
