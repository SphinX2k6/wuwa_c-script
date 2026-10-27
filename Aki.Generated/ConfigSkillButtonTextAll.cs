using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000939 RID: 2361
	public class ConfigSkillButtonTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003769 RID: 14185 RVA: 0x00192AC3 File Offset: 0x00190CC3
		static ConfigSkillButtonTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonTextAll.CreateStaticDefaultValue), new Action(ConfigSkillButtonTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00192AE4 File Offset: 0x00190CE4
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

		// Token: 0x0600376B RID: 14187 RVA: 0x00192B63 File Offset: 0x00190D63
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonTextAll.LogPair = null;
			ConfigSkillButtonTextAll.HandleId = 0;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00192B71 File Offset: 0x00190D71
		public static void Init()
		{
			ConfigSkillButtonTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonTextAll.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonText`");
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00192B8C File Offset: 0x00190D8C
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

		// Token: 0x04004075 RID: 16501
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004076 RID: 16502
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004077 RID: 16503
		private const string TABLE = "SkillButtonText";

		// Token: 0x04004078 RID: 16504
		private const string COMMAND = "select BinData from `SkillButtonText`";

		// Token: 0x04004079 RID: 16505
		private const string KEY_PREFIX = "SkillButtonTextAll";

		// Token: 0x0400407A RID: 16506
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400407B RID: 16507
		private static int HandleId;
	}
}
