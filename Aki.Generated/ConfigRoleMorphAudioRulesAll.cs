using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B7 RID: 2231
	public class ConfigRoleMorphAudioRulesAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600345D RID: 13405 RVA: 0x001812CF File Offset: 0x0017F4CF
		static ConfigRoleMorphAudioRulesAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphAudioRulesAll.CreateStaticDefaultValue), new Action(ConfigRoleMorphAudioRulesAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x001812F0 File Offset: 0x0017F4F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleMorphAudioRulesAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleMorphAudioRulesAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleMorphAudioRules"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleMorphAudioRules`")
			});
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0018136F File Offset: 0x0017F56F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphAudioRulesAll.LogPair = null;
			ConfigRoleMorphAudioRulesAll.HandleId = 0;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x0018137D File Offset: 0x0017F57D
		public static void Init()
		{
			ConfigRoleMorphAudioRulesAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphAudioRulesAll.HandleId, "db_audio.db", "select BinData from `RoleMorphAudioRules`");
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x00181398 File Offset: 0x0017F598
		[NullableContext(2)]
		public static IReadOnlyList<RoleMorphAudioRules> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleMorphAudioRulesAll.HandleId, ConfigRoleMorphAudioRulesAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleMorphAudioRules> readOnlyList = (IReadOnlyList<RoleMorphAudioRules>)ConfigCommon.GetConfig("RoleMorphAudioRulesAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleMorphAudioRules> list = new List<RoleMorphAudioRules>();
			while (ConfigCommon.Step(ConfigRoleMorphAudioRulesAll.HandleId, false, ConfigRoleMorphAudioRulesAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleMorphAudioRulesAll.HandleId, 0, ConfigRoleMorphAudioRulesAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleMorphAudioRulesAll.HandleId, ConfigRoleMorphAudioRulesAll.LogPair);
					return null;
				}
				RoleMorphAudioRules rootAsRoleMorphAudioRules = RoleMorphAudioRules.GetRootAsRoleMorphAudioRules(new ByteBuffer(item2));
				list.Add(rootAsRoleMorphAudioRules);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleMorphAudioRulesAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleMorphAudioRulesAll.HandleId, ConfigRoleMorphAudioRulesAll.LogPair);
			return list;
		}

		// Token: 0x04003CE7 RID: 15591
		private const string DB = "db_audio.db";

		// Token: 0x04003CE8 RID: 15592
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003CE9 RID: 15593
		private const string TABLE = "RoleMorphAudioRules";

		// Token: 0x04003CEA RID: 15594
		private const string COMMAND = "select BinData from `RoleMorphAudioRules`";

		// Token: 0x04003CEB RID: 15595
		private const string KEY_PREFIX = "RoleMorphAudioRulesAll";

		// Token: 0x04003CEC RID: 15596
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CED RID: 15597
		private static int HandleId;
	}
}
