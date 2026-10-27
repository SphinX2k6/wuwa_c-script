using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000947 RID: 2375
	public class ConfigSkillPriorityButtonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037BD RID: 14269 RVA: 0x00194951 File Offset: 0x00192B51
		static ConfigSkillPriorityButtonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillPriorityButtonAll.CreateStaticDefaultValue), new Action(ConfigSkillPriorityButtonAll.ResetStaticDefaultValue));
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00194970 File Offset: 0x00192B70
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

		// Token: 0x060037BF RID: 14271 RVA: 0x001949EF File Offset: 0x00192BEF
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillPriorityButtonAll.LogPair = null;
			ConfigSkillPriorityButtonAll.HandleId = 0;
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x001949FD File Offset: 0x00192BFD
		public static void Init()
		{
			ConfigSkillPriorityButtonAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillPriorityButtonAll.HandleId, "db_skillbutton.db", "select BinData from `SkillPriorityButton`");
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00194A18 File Offset: 0x00192C18
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

		// Token: 0x040040D7 RID: 16599
		private const string DB = "db_skillbutton.db";

		// Token: 0x040040D8 RID: 16600
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040040D9 RID: 16601
		private const string TABLE = "SkillPriorityButton";

		// Token: 0x040040DA RID: 16602
		private const string COMMAND = "select BinData from `SkillPriorityButton`";

		// Token: 0x040040DB RID: 16603
		private const string KEY_PREFIX = "SkillPriorityButtonAll";

		// Token: 0x040040DC RID: 16604
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040DD RID: 16605
		private static int HandleId;
	}
}
