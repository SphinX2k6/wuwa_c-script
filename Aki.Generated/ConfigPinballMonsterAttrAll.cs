using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000737 RID: 1847
	public class ConfigPinballMonsterAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B5A RID: 11098 RVA: 0x00151EB0 File Offset: 0x001500B0
		static ConfigPinballMonsterAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterAttrAll.CreateStaticDefaultValue), new Action(ConfigPinballMonsterAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00151ED0 File Offset: 0x001500D0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterAttrAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterAttrAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonsterAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonsterAttr`")
			});
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x00151F4F File Offset: 0x0015014F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterAttrAll.LogPair = null;
			ConfigPinballMonsterAttrAll.HandleId = 0;
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00151F5D File Offset: 0x0015015D
		public static void Init()
		{
			ConfigPinballMonsterAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterAttrAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterAttr`");
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00151F78 File Offset: 0x00150178
		[NullableContext(2)]
		public static IReadOnlyList<PinballMonsterAttr> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterAttrAll.HandleId, ConfigPinballMonsterAttrAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballMonsterAttr> readOnlyList = (IReadOnlyList<PinballMonsterAttr>)ConfigCommon.GetConfig("PinballMonsterAttrAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballMonsterAttr> list = new List<PinballMonsterAttr>();
			while (ConfigCommon.Step(ConfigPinballMonsterAttrAll.HandleId, false, ConfigPinballMonsterAttrAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterAttrAll.HandleId, 0, ConfigPinballMonsterAttrAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballMonsterAttrAll.HandleId, ConfigPinballMonsterAttrAll.LogPair);
					return null;
				}
				PinballMonsterAttr rootAsPinballMonsterAttr = PinballMonsterAttr.GetRootAsPinballMonsterAttr(new ByteBuffer(item2));
				list.Add(rootAsPinballMonsterAttr);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballMonsterAttrAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballMonsterAttrAll.HandleId, ConfigPinballMonsterAttrAll.LogPair);
			return list;
		}

		// Token: 0x04003267 RID: 12903
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003268 RID: 12904
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x04003269 RID: 12905
		private const string TABLE = "PinballMonsterAttr";

		// Token: 0x0400326A RID: 12906
		private const string COMMAND = "select BinData from `PinballMonsterAttr`";

		// Token: 0x0400326B RID: 12907
		private const string KEY_PREFIX = "PinballMonsterAttrAll";

		// Token: 0x0400326C RID: 12908
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400326D RID: 12909
		private static int HandleId;
	}
}
