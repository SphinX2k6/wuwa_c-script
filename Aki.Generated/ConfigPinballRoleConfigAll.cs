using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000742 RID: 1858
	public class ConfigPinballRoleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B9C RID: 11164 RVA: 0x00153660 File Offset: 0x00151860
		static ConfigPinballRoleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleConfigAll.CreateStaticDefaultValue), new Action(ConfigPinballRoleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00153680 File Offset: 0x00151880
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

		// Token: 0x06002B9E RID: 11166 RVA: 0x001536FF File Offset: 0x001518FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleConfigAll.LogPair = null;
			ConfigPinballRoleConfigAll.HandleId = 0;
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x0015370D File Offset: 0x0015190D
		public static void Init()
		{
			ConfigPinballRoleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleConfigAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleConfig`");
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00153728 File Offset: 0x00151928
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

		// Token: 0x040032B4 RID: 12980
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032B5 RID: 12981
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x040032B6 RID: 12982
		private const string TABLE = "PinballRoleConfig";

		// Token: 0x040032B7 RID: 12983
		private const string COMMAND = "select BinData from `PinballRoleConfig`";

		// Token: 0x040032B8 RID: 12984
		private const string KEY_PREFIX = "PinballRoleConfigAll";

		// Token: 0x040032B9 RID: 12985
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032BA RID: 12986
		private static int HandleId;
	}
}
