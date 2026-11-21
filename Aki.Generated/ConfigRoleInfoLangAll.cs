using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CF RID: 2255
	public class ConfigRoleInfoLangAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034ED RID: 13549 RVA: 0x00187DAB File Offset: 0x00185FAB
		static ConfigRoleInfoLangAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoLangAll.CreateStaticDefaultValue), new Action(ConfigRoleInfoLangAll.ResetStaticDefaultValue));
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x00187DCC File Offset: 0x00185FCC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoLangAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoLangAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfoLang"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfoLang`")
			});
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00187E4B File Offset: 0x0018604B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoLangAll.LogPair = null;
			ConfigRoleInfoLangAll.HandleId = 0;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00187E59 File Offset: 0x00186059
		public static void Init()
		{
			ConfigRoleInfoLangAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoLangAll.HandleId, "db_audio.db", "select BinData from `RoleInfoLang`");
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00187E74 File Offset: 0x00186074
		[NullableContext(2)]
		public static IReadOnlyList<RoleInfoLang> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoLangAll.HandleId, ConfigRoleInfoLangAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleInfoLang> readOnlyList = (IReadOnlyList<RoleInfoLang>)ConfigCommon.GetConfig("RoleInfoLangAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleInfoLang> list = new List<RoleInfoLang>();
			while (ConfigCommon.Step(ConfigRoleInfoLangAll.HandleId, false, ConfigRoleInfoLangAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoLangAll.HandleId, 0, ConfigRoleInfoLangAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleInfoLangAll.HandleId, ConfigRoleInfoLangAll.LogPair);
					return null;
				}
				RoleInfoLang rootAsRoleInfoLang = RoleInfoLang.GetRootAsRoleInfoLang(new ByteBuffer(item2));
				list.Add(rootAsRoleInfoLang);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleInfoLangAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleInfoLangAll.HandleId, ConfigRoleInfoLangAll.LogPair);
			return list;
		}

		// Token: 0x04003D8F RID: 15759
		private const string DB = "db_audio.db";

		// Token: 0x04003D90 RID: 15760
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003D91 RID: 15761
		private const string TABLE = "RoleInfoLang";

		// Token: 0x04003D92 RID: 15762
		private const string COMMAND = "select BinData from `RoleInfoLang`";

		// Token: 0x04003D93 RID: 15763
		private const string KEY_PREFIX = "RoleInfoLangAll";

		// Token: 0x04003D94 RID: 15764
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D95 RID: 15765
		private static int HandleId;
	}
}
