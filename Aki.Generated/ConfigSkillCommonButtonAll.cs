using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093D RID: 2365
	public class ConfigSkillCommonButtonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003781 RID: 14209 RVA: 0x0019331F File Offset: 0x0019151F
		static ConfigSkillCommonButtonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillCommonButtonAll.CreateStaticDefaultValue), new Action(ConfigSkillCommonButtonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00193340 File Offset: 0x00191540
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

		// Token: 0x06003783 RID: 14211 RVA: 0x001933BF File Offset: 0x001915BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillCommonButtonAll.LogPair = null;
			ConfigSkillCommonButtonAll.HandleId = 0;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x001933CD File Offset: 0x001915CD
		public static void Init()
		{
			ConfigSkillCommonButtonAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillCommonButtonAll.HandleId, "db_skillbutton.db", "select BinData from `SkillCommonButton`");
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x001933E8 File Offset: 0x001915E8
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

		// Token: 0x04004091 RID: 16529
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004092 RID: 16530
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004093 RID: 16531
		private const string TABLE = "SkillCommonButton";

		// Token: 0x04004094 RID: 16532
		private const string COMMAND = "select BinData from `SkillCommonButton`";

		// Token: 0x04004095 RID: 16533
		private const string KEY_PREFIX = "SkillCommonButtonAll";

		// Token: 0x04004096 RID: 16534
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004097 RID: 16535
		private static int HandleId;
	}
}
