using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072A RID: 1834
	public class ConfigPinballRoleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B0C RID: 11020 RVA: 0x0014CBE4 File Offset: 0x0014ADE4
		static ConfigPinballRoleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleConfigAll.CreateStaticDefaultValue), new Action(ConfigPinballRoleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0014CC04 File Offset: 0x0014AE04
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleConfig`")
			});
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0014CC83 File Offset: 0x0014AE83
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleConfigAll.LogPair = null;
			ConfigPinballRoleConfigAll.HandleId = 0;
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x0014CC91 File Offset: 0x0014AE91
		public static void Init()
		{
			ConfigPinballRoleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleConfigAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleConfig`");
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x0014CCAC File Offset: 0x0014AEAC
		[NullableContext(2)]
		public static IReadOnlyList<PinballRoleConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleConfigAll.HandleId, ConfigPinballRoleConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballRoleConfig> readOnlyList = (IReadOnlyList<PinballRoleConfig>)ConfigCommon.GetConfig("PinballRoleConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballRoleConfig> list = new List<PinballRoleConfig>();
			while (ConfigCommon.Step(ConfigPinballRoleConfigAll.HandleId, false, ConfigPinballRoleConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleConfigAll.HandleId, 0, ConfigPinballRoleConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballRoleConfigAll.HandleId, ConfigPinballRoleConfigAll.LogPair);
					return null;
				}
				PinballRoleConfig rootAsPinballRoleConfig = PinballRoleConfig.GetRootAsPinballRoleConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballRoleConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballRoleConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballRoleConfigAll.HandleId, ConfigPinballRoleConfigAll.LogPair);
			return list;
		}

		// Token: 0x0400320C RID: 12812
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400320D RID: 12813
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x0400320E RID: 12814
		private const string TABLE = "PinballRoleConfig";

		// Token: 0x0400320F RID: 12815
		private const string COMMAND = "select BinData from `PinballRoleConfig`";

		// Token: 0x04003210 RID: 12816
		private const string KEY_PREFIX = "PinballRoleConfigAll";

		// Token: 0x04003211 RID: 12817
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003212 RID: 12818
		private static int HandleId;
	}
}
