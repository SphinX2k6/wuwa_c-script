using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D5 RID: 2261
	public class ConfigRoleVoiceLanguageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003511 RID: 13585 RVA: 0x0018557C File Offset: 0x0018377C
		static ConfigRoleVoiceLanguageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleVoiceLanguageAll.CreateStaticDefaultValue), new Action(ConfigRoleVoiceLanguageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x0018559C File Offset: 0x0018379C
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

		// Token: 0x06003513 RID: 13587 RVA: 0x0018561B File Offset: 0x0018381B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleVoiceLanguageAll.LogPair = null;
			ConfigRoleVoiceLanguageAll.HandleId = 0;
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x00185629 File Offset: 0x00183829
		public static void Init()
		{
			ConfigRoleVoiceLanguageAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleVoiceLanguageAll.HandleId, "db_menu.db", "select BinData from `RoleVoiceLanguage`");
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x00185644 File Offset: 0x00183844
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

		// Token: 0x04003DB9 RID: 15801
		private const string DB = "db_menu.db";

		// Token: 0x04003DBA RID: 15802
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04003DBB RID: 15803
		private const string TABLE = "RoleVoiceLanguage";

		// Token: 0x04003DBC RID: 15804
		private const string COMMAND = "select BinData from `RoleVoiceLanguage`";

		// Token: 0x04003DBD RID: 15805
		private const string KEY_PREFIX = "RoleVoiceLanguageAll";

		// Token: 0x04003DBE RID: 15806
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DBF RID: 15807
		private static int HandleId;
	}
}
