using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071F RID: 1823
	public class ConfigPinballMonsterAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ACA RID: 10954 RVA: 0x0014B434 File Offset: 0x00149634
		static ConfigPinballMonsterAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterAttrAll.CreateStaticDefaultValue), new Action(ConfigPinballMonsterAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x0014B454 File Offset: 0x00149654
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

		// Token: 0x06002ACC RID: 10956 RVA: 0x0014B4D3 File Offset: 0x001496D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterAttrAll.LogPair = null;
			ConfigPinballMonsterAttrAll.HandleId = 0;
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x0014B4E1 File Offset: 0x001496E1
		public static void Init()
		{
			ConfigPinballMonsterAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterAttrAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterAttr`");
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x0014B4FC File Offset: 0x001496FC
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

		// Token: 0x040031BF RID: 12735
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031C0 RID: 12736
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x040031C1 RID: 12737
		private const string TABLE = "PinballMonsterAttr";

		// Token: 0x040031C2 RID: 12738
		private const string COMMAND = "select BinData from `PinballMonsterAttr`";

		// Token: 0x040031C3 RID: 12739
		private const string KEY_PREFIX = "PinballMonsterAttrAll";

		// Token: 0x040031C4 RID: 12740
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031C5 RID: 12741
		private static int HandleId;
	}
}
