using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D3 RID: 2259
	public class ConfigRoleMorphAudioRulesAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x001885B7 File Offset: 0x001867B7
		static ConfigRoleMorphAudioRulesAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphAudioRulesAll.CreateStaticDefaultValue), new Action(ConfigRoleMorphAudioRulesAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x001885D8 File Offset: 0x001867D8
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

		// Token: 0x06003507 RID: 13575 RVA: 0x00188657 File Offset: 0x00186857
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphAudioRulesAll.LogPair = null;
			ConfigRoleMorphAudioRulesAll.HandleId = 0;
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00188665 File Offset: 0x00186865
		public static void Init()
		{
			ConfigRoleMorphAudioRulesAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphAudioRulesAll.HandleId, "db_audio.db", "select BinData from `RoleMorphAudioRules`");
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00188680 File Offset: 0x00186880
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

		// Token: 0x04003DAB RID: 15787
		private const string DB = "db_audio.db";

		// Token: 0x04003DAC RID: 15788
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003DAD RID: 15789
		private const string TABLE = "RoleMorphAudioRules";

		// Token: 0x04003DAE RID: 15790
		private const string COMMAND = "select BinData from `RoleMorphAudioRules`";

		// Token: 0x04003DAF RID: 15791
		private const string KEY_PREFIX = "RoleMorphAudioRulesAll";

		// Token: 0x04003DB0 RID: 15792
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DB1 RID: 15793
		private static int HandleId;
	}
}
