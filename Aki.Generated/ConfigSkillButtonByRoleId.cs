using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097F RID: 2431
	public class ConfigSkillButtonByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600390D RID: 14605 RVA: 0x0019F19C File Offset: 0x0019D39C
		static ConfigSkillButtonByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonByRoleId.CreateStaticDefaultValue), new Action(ConfigSkillButtonByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x0019F1BC File Offset: 0x0019D3BC
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillButtonByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillButtonByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillButton"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillButton` where RoleId=?")
			});
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x0019F23B File Offset: 0x0019D43B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonByRoleId.LogPair = null;
			ConfigSkillButtonByRoleId.HandleId = 0;
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0019F249 File Offset: 0x0019D449
		public static void Init()
		{
			ConfigSkillButtonByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonByRoleId.HandleId, "db_skillbutton.db", "select BinData from `SkillButton` where RoleId=?");
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0019F264 File Offset: 0x0019D464
		[NullableContext(2)]
		public static IReadOnlyList<SkillButton> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillButtonByRoleId.HandleId, ConfigSkillButtonByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<SkillButton> readOnlyList = (IReadOnlyList<SkillButton>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillButtonByRoleId.LogPair.Clear();
			ConfigSkillButtonByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigSkillButtonByRoleId.HandleId, 1, p0RoleId, ConfigSkillButtonByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillButtonByRoleId.HandleId, ConfigSkillButtonByRoleId.LogPair);
				return null;
			}
			List<SkillButton> list = new List<SkillButton>();
			while (ConfigCommon.Step(ConfigSkillButtonByRoleId.HandleId, false, ConfigSkillButtonByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillButtonByRoleId.HandleId, 0, ConfigSkillButtonByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillButtonByRoleId.HandleId, ConfigSkillButtonByRoleId.LogPair);
					return null;
				}
				SkillButton rootAsSkillButton = SkillButton.GetRootAsSkillButton(new ByteBuffer(item2));
				list.Add(rootAsSkillButton);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillButtonByRoleId.HandleId, ConfigSkillButtonByRoleId.LogPair);
			return list;
		}

		// Token: 0x0400425F RID: 16991
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004260 RID: 16992
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004261 RID: 16993
		private const string TABLE = "SkillButton";

		// Token: 0x04004262 RID: 16994
		private const string COMMAND = "select BinData from `SkillButton` where RoleId=?";

		// Token: 0x04004263 RID: 16995
		private const string KEY_PREFIX = "SkillButtonByRoleId";

		// Token: 0x04004264 RID: 16996
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004265 RID: 16997
		private static int HandleId;
	}
}
