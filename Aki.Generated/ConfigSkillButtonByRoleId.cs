using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000934 RID: 2356
	public class ConfigSkillButtonByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600374B RID: 14155 RVA: 0x00191F7C File Offset: 0x0019017C
		static ConfigSkillButtonByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonByRoleId.CreateStaticDefaultValue), new Action(ConfigSkillButtonByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00191F9C File Offset: 0x0019019C
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

		// Token: 0x0600374D RID: 14157 RVA: 0x0019201B File Offset: 0x0019021B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonByRoleId.LogPair = null;
			ConfigSkillButtonByRoleId.HandleId = 0;
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00192029 File Offset: 0x00190229
		public static void Init()
		{
			ConfigSkillButtonByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonByRoleId.HandleId, "db_skillbutton.db", "select BinData from `SkillButton` where RoleId=?");
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00192044 File Offset: 0x00190244
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

		// Token: 0x04004052 RID: 16466
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004053 RID: 16467
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004054 RID: 16468
		private const string TABLE = "SkillButton";

		// Token: 0x04004055 RID: 16469
		private const string COMMAND = "select BinData from `SkillButton` where RoleId=?";

		// Token: 0x04004056 RID: 16470
		private const string KEY_PREFIX = "SkillButtonByRoleId";

		// Token: 0x04004057 RID: 16471
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004058 RID: 16472
		private static int HandleId;
	}
}
