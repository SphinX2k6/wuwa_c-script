using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098D RID: 2445
	public class ConfigSkillGameplayButtonByGameplayType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003961 RID: 14689 RVA: 0x001A0FD3 File Offset: 0x0019F1D3
		static ConfigSkillGameplayButtonByGameplayType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillGameplayButtonByGameplayType.CreateStaticDefaultValue), new Action(ConfigSkillGameplayButtonByGameplayType.ResetStaticDefaultValue));
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x001A0FF4 File Offset: 0x0019F1F4
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillGameplayButtonByGameplayType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillGameplayButtonByGameplayType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillGameplayButton"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillGameplayButton` where GameplayType=?")
			});
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x001A1073 File Offset: 0x0019F273
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillGameplayButtonByGameplayType.LogPair = null;
			ConfigSkillGameplayButtonByGameplayType.HandleId = 0;
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x001A1081 File Offset: 0x0019F281
		public static void Init()
		{
			ConfigSkillGameplayButtonByGameplayType.HandleId = ConfigCommon.InitDataStatement(ConfigSkillGameplayButtonByGameplayType.HandleId, "db_skillbutton.db", "select BinData from `SkillGameplayButton` where GameplayType=?");
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x001A109C File Offset: 0x0019F29C
		[NullableContext(2)]
		public static IReadOnlyList<SkillGameplayButton> GetConfigList(int p0GameplayType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillGameplayButtonByGameplayType.HandleId, ConfigSkillGameplayButtonByGameplayType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillGameplayButtonByGameplayType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GameplayType);
				IReadOnlyList<SkillGameplayButton> readOnlyList = (IReadOnlyList<SkillGameplayButton>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillGameplayButtonByGameplayType.LogPair.Clear();
			ConfigSkillGameplayButtonByGameplayType.LogPair.Add(new ValueTuple<string, object>("GameplayType", p0GameplayType));
			if (!ConfigCommon.BindInt(ConfigSkillGameplayButtonByGameplayType.HandleId, 1, p0GameplayType, ConfigSkillGameplayButtonByGameplayType.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillGameplayButtonByGameplayType.HandleId, ConfigSkillGameplayButtonByGameplayType.LogPair);
				return null;
			}
			List<SkillGameplayButton> list = new List<SkillGameplayButton>();
			while (ConfigCommon.Step(ConfigSkillGameplayButtonByGameplayType.HandleId, false, ConfigSkillGameplayButtonByGameplayType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillGameplayButtonByGameplayType.HandleId, 0, ConfigSkillGameplayButtonByGameplayType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillGameplayButtonByGameplayType.HandleId, ConfigSkillGameplayButtonByGameplayType.LogPair);
					return null;
				}
				SkillGameplayButton rootAsSkillGameplayButton = SkillGameplayButton.GetRootAsSkillGameplayButton(new ByteBuffer(item2));
				list.Add(rootAsSkillGameplayButton);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillGameplayButtonByGameplayType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GameplayType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillGameplayButtonByGameplayType.HandleId, ConfigSkillGameplayButtonByGameplayType.LogPair);
			return list;
		}

		// Token: 0x040042C1 RID: 17089
		private const string DB = "db_skillbutton.db";

		// Token: 0x040042C2 RID: 17090
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040042C3 RID: 17091
		private const string TABLE = "SkillGameplayButton";

		// Token: 0x040042C4 RID: 17092
		private const string COMMAND = "select BinData from `SkillGameplayButton` where GameplayType=?";

		// Token: 0x040042C5 RID: 17093
		private const string KEY_PREFIX = "SkillGameplayButtonByGameplayType";

		// Token: 0x040042C6 RID: 17094
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042C7 RID: 17095
		private static int HandleId;
	}
}
