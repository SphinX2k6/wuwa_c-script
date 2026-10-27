using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000709 RID: 1801
	public class ConfigPinballAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x00148598 File Offset: 0x00146798
		static ConfigPinballAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballAttrAll.CreateStaticDefaultValue), new Action(ConfigPinballAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x001485B8 File Offset: 0x001467B8
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

		// Token: 0x06002A48 RID: 10824 RVA: 0x00148637 File Offset: 0x00146837
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballAttrAll.LogPair = null;
			ConfigPinballAttrAll.HandleId = 0;
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00148645 File Offset: 0x00146845
		public static void Init()
		{
			ConfigPinballAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballAttrAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballAttr`");
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00148660 File Offset: 0x00146860
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

		// Token: 0x04003125 RID: 12581
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003126 RID: 12582
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003127 RID: 12583
		private const string TABLE = "PinballAttr";

		// Token: 0x04003128 RID: 12584
		private const string COMMAND = "select BinData from `PinballAttr`";

		// Token: 0x04003129 RID: 12585
		private const string KEY_PREFIX = "PinballAttrAll";

		// Token: 0x0400312A RID: 12586
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400312B RID: 12587
		private static int HandleId;
	}
}
