using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070D RID: 1805
	public class ConfigPinballBuffConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A5E RID: 10846 RVA: 0x00148E04 File Offset: 0x00147004
		static ConfigPinballBuffConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballBuffConfigAll.CreateStaticDefaultValue), new Action(ConfigPinballBuffConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00148E24 File Offset: 0x00147024
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballBuffConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballBuffConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_通用.xlsx"),
				new ValueTuple<string, object>("表名", "PinballBuffConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballBuffConfig`")
			});
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00148EA3 File Offset: 0x001470A3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballBuffConfigAll.LogPair = null;
			ConfigPinballBuffConfigAll.HandleId = 0;
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00148EB1 File Offset: 0x001470B1
		public static void Init()
		{
			ConfigPinballBuffConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballBuffConfigAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballBuffConfig`");
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00148ECC File Offset: 0x001470CC
		[NullableContext(2)]
		public static IReadOnlyList<PinballBuffConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballBuffConfigAll.HandleId, ConfigPinballBuffConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballBuffConfig> readOnlyList = (IReadOnlyList<PinballBuffConfig>)ConfigCommon.GetConfig("PinballBuffConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballBuffConfig> list = new List<PinballBuffConfig>();
			while (ConfigCommon.Step(ConfigPinballBuffConfigAll.HandleId, false, ConfigPinballBuffConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballBuffConfigAll.HandleId, 0, ConfigPinballBuffConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballBuffConfigAll.HandleId, ConfigPinballBuffConfigAll.LogPair);
					return null;
				}
				PinballBuffConfig rootAsPinballBuffConfig = PinballBuffConfig.GetRootAsPinballBuffConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballBuffConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballBuffConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballBuffConfigAll.HandleId, ConfigPinballBuffConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003141 RID: 12609
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003142 RID: 12610
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x04003143 RID: 12611
		private const string TABLE = "PinballBuffConfig";

		// Token: 0x04003144 RID: 12612
		private const string COMMAND = "select BinData from `PinballBuffConfig`";

		// Token: 0x04003145 RID: 12613
		private const string KEY_PREFIX = "PinballBuffConfigAll";

		// Token: 0x04003146 RID: 12614
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003147 RID: 12615
		private static int HandleId;
	}
}
