using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000992 RID: 2450
	public class ConfigSkillPriorityButtonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600397F RID: 14719 RVA: 0x001A1B71 File Offset: 0x0019FD71
		static ConfigSkillPriorityButtonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillPriorityButtonAll.CreateStaticDefaultValue), new Action(ConfigSkillPriorityButtonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x001A1B90 File Offset: 0x0019FD90
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillPriorityButtonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillPriorityButtonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillPriorityButton"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillPriorityButton`")
			});
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x001A1C0F File Offset: 0x0019FE0F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillPriorityButtonAll.LogPair = null;
			ConfigSkillPriorityButtonAll.HandleId = 0;
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x001A1C1D File Offset: 0x0019FE1D
		public static void Init()
		{
			ConfigSkillPriorityButtonAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillPriorityButtonAll.HandleId, "db_skillbutton.db", "select BinData from `SkillPriorityButton`");
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x001A1C38 File Offset: 0x0019FE38
		[NullableContext(2)]
		public static IReadOnlyList<SkillPriorityButton> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillPriorityButtonAll.HandleId, ConfigSkillPriorityButtonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SkillPriorityButton> readOnlyList = (IReadOnlyList<SkillPriorityButton>)ConfigCommon.GetConfig("SkillPriorityButtonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SkillPriorityButton> list = new List<SkillPriorityButton>();
			while (ConfigCommon.Step(ConfigSkillPriorityButtonAll.HandleId, false, ConfigSkillPriorityButtonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillPriorityButtonAll.HandleId, 0, ConfigSkillPriorityButtonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillPriorityButtonAll.HandleId, ConfigSkillPriorityButtonAll.LogPair);
					return null;
				}
				SkillPriorityButton rootAsSkillPriorityButton = SkillPriorityButton.GetRootAsSkillPriorityButton(new ByteBuffer(item2));
				list.Add(rootAsSkillPriorityButton);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SkillPriorityButtonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillPriorityButtonAll.HandleId, ConfigSkillPriorityButtonAll.LogPair);
			return list;
		}

		// Token: 0x040042E4 RID: 17124
		private const string DB = "db_skillbutton.db";

		// Token: 0x040042E5 RID: 17125
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040042E6 RID: 17126
		private const string TABLE = "SkillPriorityButton";

		// Token: 0x040042E7 RID: 17127
		private const string COMMAND = "select BinData from `SkillPriorityButton`";

		// Token: 0x040042E8 RID: 17128
		private const string KEY_PREFIX = "SkillPriorityButtonAll";

		// Token: 0x040042E9 RID: 17129
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042EA RID: 17130
		private static int HandleId;
	}
}
