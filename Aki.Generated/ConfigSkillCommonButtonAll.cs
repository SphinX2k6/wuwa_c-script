using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000988 RID: 2440
	public class ConfigSkillCommonButtonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003943 RID: 14659 RVA: 0x001A053F File Offset: 0x0019E73F
		static ConfigSkillCommonButtonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillCommonButtonAll.CreateStaticDefaultValue), new Action(ConfigSkillCommonButtonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x001A0560 File Offset: 0x0019E760
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillCommonButtonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillCommonButtonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillCommonButton"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillCommonButton`")
			});
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x001A05DF File Offset: 0x0019E7DF
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillCommonButtonAll.LogPair = null;
			ConfigSkillCommonButtonAll.HandleId = 0;
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x001A05ED File Offset: 0x0019E7ED
		public static void Init()
		{
			ConfigSkillCommonButtonAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillCommonButtonAll.HandleId, "db_skillbutton.db", "select BinData from `SkillCommonButton`");
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x001A0608 File Offset: 0x0019E808
		[NullableContext(2)]
		public static IReadOnlyList<SkillCommonButton> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillCommonButtonAll.HandleId, ConfigSkillCommonButtonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SkillCommonButton> readOnlyList = (IReadOnlyList<SkillCommonButton>)ConfigCommon.GetConfig("SkillCommonButtonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SkillCommonButton> list = new List<SkillCommonButton>();
			while (ConfigCommon.Step(ConfigSkillCommonButtonAll.HandleId, false, ConfigSkillCommonButtonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillCommonButtonAll.HandleId, 0, ConfigSkillCommonButtonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillCommonButtonAll.HandleId, ConfigSkillCommonButtonAll.LogPair);
					return null;
				}
				SkillCommonButton rootAsSkillCommonButton = SkillCommonButton.GetRootAsSkillCommonButton(new ByteBuffer(item2));
				list.Add(rootAsSkillCommonButton);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SkillCommonButtonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillCommonButtonAll.HandleId, ConfigSkillCommonButtonAll.LogPair);
			return list;
		}

		// Token: 0x0400429E RID: 17054
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400429F RID: 17055
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040042A0 RID: 17056
		private const string TABLE = "SkillCommonButton";

		// Token: 0x040042A1 RID: 17057
		private const string COMMAND = "select BinData from `SkillCommonButton`";

		// Token: 0x040042A2 RID: 17058
		private const string KEY_PREFIX = "SkillCommonButtonAll";

		// Token: 0x040042A3 RID: 17059
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042A4 RID: 17060
		private static int HandleId;
	}
}
