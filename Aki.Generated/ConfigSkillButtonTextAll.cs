using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000984 RID: 2436
	public class ConfigSkillButtonTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600392B RID: 14635 RVA: 0x0019FCE3 File Offset: 0x0019DEE3
		static ConfigSkillButtonTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonTextAll.CreateStaticDefaultValue), new Action(ConfigSkillButtonTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x0019FD04 File Offset: 0x0019DF04
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillButtonTextAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillButtonTextAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillButtonText"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillButtonText`")
			});
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0019FD83 File Offset: 0x0019DF83
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonTextAll.LogPair = null;
			ConfigSkillButtonTextAll.HandleId = 0;
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x0019FD91 File Offset: 0x0019DF91
		public static void Init()
		{
			ConfigSkillButtonTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonTextAll.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonText`");
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x0019FDAC File Offset: 0x0019DFAC
		[NullableContext(2)]
		public static IReadOnlyList<SkillButtonText> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillButtonTextAll.HandleId, ConfigSkillButtonTextAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SkillButtonText> readOnlyList = (IReadOnlyList<SkillButtonText>)ConfigCommon.GetConfig("SkillButtonTextAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SkillButtonText> list = new List<SkillButtonText>();
			while (ConfigCommon.Step(ConfigSkillButtonTextAll.HandleId, false, ConfigSkillButtonTextAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillButtonTextAll.HandleId, 0, ConfigSkillButtonTextAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillButtonTextAll.HandleId, ConfigSkillButtonTextAll.LogPair);
					return null;
				}
				SkillButtonText rootAsSkillButtonText = SkillButtonText.GetRootAsSkillButtonText(new ByteBuffer(item2));
				list.Add(rootAsSkillButtonText);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SkillButtonTextAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillButtonTextAll.HandleId, ConfigSkillButtonTextAll.LogPair);
			return list;
		}

		// Token: 0x04004282 RID: 17026
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004283 RID: 17027
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004284 RID: 17028
		private const string TABLE = "SkillButtonText";

		// Token: 0x04004285 RID: 17029
		private const string COMMAND = "select BinData from `SkillButtonText`";

		// Token: 0x04004286 RID: 17030
		private const string KEY_PREFIX = "SkillButtonTextAll";

		// Token: 0x04004287 RID: 17031
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004288 RID: 17032
		private static int HandleId;
	}
}
