using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000920 RID: 2336
	public class ConfigRoleVoiceLanguageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036D3 RID: 14035 RVA: 0x0019279C File Offset: 0x0019099C
		static ConfigRoleVoiceLanguageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleVoiceLanguageAll.CreateStaticDefaultValue), new Action(ConfigRoleVoiceLanguageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x001927BC File Offset: 0x001909BC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleVoiceLanguageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleVoiceLanguageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "RoleVoiceLanguage"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleVoiceLanguage`")
			});
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x0019283B File Offset: 0x00190A3B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleVoiceLanguageAll.LogPair = null;
			ConfigRoleVoiceLanguageAll.HandleId = 0;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00192849 File Offset: 0x00190A49
		public static void Init()
		{
			ConfigRoleVoiceLanguageAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleVoiceLanguageAll.HandleId, "db_menu.db", "select BinData from `RoleVoiceLanguage`");
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00192864 File Offset: 0x00190A64
		[NullableContext(2)]
		public static IReadOnlyList<RoleVoiceLanguage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleVoiceLanguageAll.HandleId, ConfigRoleVoiceLanguageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleVoiceLanguage> readOnlyList = (IReadOnlyList<RoleVoiceLanguage>)ConfigCommon.GetConfig("RoleVoiceLanguageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleVoiceLanguage> list = new List<RoleVoiceLanguage>();
			while (ConfigCommon.Step(ConfigRoleVoiceLanguageAll.HandleId, false, ConfigRoleVoiceLanguageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleVoiceLanguageAll.HandleId, 0, ConfigRoleVoiceLanguageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleVoiceLanguageAll.HandleId, ConfigRoleVoiceLanguageAll.LogPair);
					return null;
				}
				RoleVoiceLanguage rootAsRoleVoiceLanguage = RoleVoiceLanguage.GetRootAsRoleVoiceLanguage(new ByteBuffer(item2));
				list.Add(rootAsRoleVoiceLanguage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleVoiceLanguageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleVoiceLanguageAll.HandleId, ConfigRoleVoiceLanguageAll.LogPair);
			return list;
		}

		// Token: 0x04003FC6 RID: 16326
		private const string DB = "db_menu.db";

		// Token: 0x04003FC7 RID: 16327
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04003FC8 RID: 16328
		private const string TABLE = "RoleVoiceLanguage";

		// Token: 0x04003FC9 RID: 16329
		private const string COMMAND = "select BinData from `RoleVoiceLanguage`";

		// Token: 0x04003FCA RID: 16330
		private const string KEY_PREFIX = "RoleVoiceLanguageAll";

		// Token: 0x04003FCB RID: 16331
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FCC RID: 16332
		private static int HandleId;
	}
}
