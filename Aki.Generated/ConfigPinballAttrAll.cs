using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000721 RID: 1825
	public class ConfigPinballAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AD6 RID: 10966 RVA: 0x0014F014 File Offset: 0x0014D214
		static ConfigPinballAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballAttrAll.CreateStaticDefaultValue), new Action(ConfigPinballAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x0014F034 File Offset: 0x0014D234
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballAttrAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballAttrAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballAttr`")
			});
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x0014F0B3 File Offset: 0x0014D2B3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballAttrAll.LogPair = null;
			ConfigPinballAttrAll.HandleId = 0;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0014F0C1 File Offset: 0x0014D2C1
		public static void Init()
		{
			ConfigPinballAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballAttrAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballAttr`");
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x0014F0DC File Offset: 0x0014D2DC
		[NullableContext(2)]
		public static IReadOnlyList<PinballAttr> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballAttrAll.HandleId, ConfigPinballAttrAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballAttr> readOnlyList = (IReadOnlyList<PinballAttr>)ConfigCommon.GetConfig("PinballAttrAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballAttr> list = new List<PinballAttr>();
			while (ConfigCommon.Step(ConfigPinballAttrAll.HandleId, false, ConfigPinballAttrAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballAttrAll.HandleId, 0, ConfigPinballAttrAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballAttrAll.HandleId, ConfigPinballAttrAll.LogPair);
					return null;
				}
				PinballAttr rootAsPinballAttr = PinballAttr.GetRootAsPinballAttr(new ByteBuffer(item2));
				list.Add(rootAsPinballAttr);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballAttrAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballAttrAll.HandleId, ConfigPinballAttrAll.LogPair);
			return list;
		}

		// Token: 0x040031CD RID: 12749
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031CE RID: 12750
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x040031CF RID: 12751
		private const string TABLE = "PinballAttr";

		// Token: 0x040031D0 RID: 12752
		private const string COMMAND = "select BinData from `PinballAttr`";

		// Token: 0x040031D1 RID: 12753
		private const string KEY_PREFIX = "PinballAttrAll";

		// Token: 0x040031D2 RID: 12754
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031D3 RID: 12755
		private static int HandleId;
	}
}
