using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000942 RID: 2370
	public class ConfigSkillGameplayButtonByGameplayType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600379F RID: 14239 RVA: 0x00193DB3 File Offset: 0x00191FB3
		static ConfigSkillGameplayButtonByGameplayType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillGameplayButtonByGameplayType.CreateStaticDefaultValue), new Action(ConfigSkillGameplayButtonByGameplayType.ResetStaticDefaultValue));
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00193DD4 File Offset: 0x00191FD4
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

		// Token: 0x060037A1 RID: 14241 RVA: 0x00193E53 File Offset: 0x00192053
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillGameplayButtonByGameplayType.LogPair = null;
			ConfigSkillGameplayButtonByGameplayType.HandleId = 0;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00193E61 File Offset: 0x00192061
		public static void Init()
		{
			ConfigSkillGameplayButtonByGameplayType.HandleId = ConfigCommon.InitDataStatement(ConfigSkillGameplayButtonByGameplayType.HandleId, "db_skillbutton.db", "select BinData from `SkillGameplayButton` where GameplayType=?");
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00193E7C File Offset: 0x0019207C
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

		// Token: 0x040040B4 RID: 16564
		private const string DB = "db_skillbutton.db";

		// Token: 0x040040B5 RID: 16565
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040040B6 RID: 16566
		private const string TABLE = "SkillGameplayButton";

		// Token: 0x040040B7 RID: 16567
		private const string COMMAND = "select BinData from `SkillGameplayButton` where GameplayType=?";

		// Token: 0x040040B8 RID: 16568
		private const string KEY_PREFIX = "SkillGameplayButtonByGameplayType";

		// Token: 0x040040B9 RID: 16569
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040BA RID: 16570
		private static int HandleId;
	}
}
