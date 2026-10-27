using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000938 RID: 2360
	public class ConfigSkillButtonIndexByRoleType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003763 RID: 14179 RVA: 0x0019288C File Offset: 0x00190A8C
		static ConfigSkillButtonIndexByRoleType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonIndexByRoleType.CreateStaticDefaultValue), new Action(ConfigSkillButtonIndexByRoleType.ResetStaticDefaultValue));
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x001928AC File Offset: 0x00190AAC
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillButtonIndexByRoleType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillButtonIndexByRoleType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillButtonIndex"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillButtonIndex` where RoleType=?")
			});
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x0019292B File Offset: 0x00190B2B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonIndexByRoleType.LogPair = null;
			ConfigSkillButtonIndexByRoleType.HandleId = 0;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00192939 File Offset: 0x00190B39
		public static void Init()
		{
			ConfigSkillButtonIndexByRoleType.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonIndexByRoleType.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonIndex` where RoleType=?");
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00192954 File Offset: 0x00190B54
		[NullableContext(2)]
		public static IReadOnlyList<SkillButtonIndex> GetConfigList(int p0RoleType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillButtonIndexByRoleType.HandleId, ConfigSkillButtonIndexByRoleType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonIndexByRoleType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleType);
				IReadOnlyList<SkillButtonIndex> readOnlyList = (IReadOnlyList<SkillButtonIndex>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillButtonIndexByRoleType.LogPair.Clear();
			ConfigSkillButtonIndexByRoleType.LogPair.Add(new ValueTuple<string, object>("RoleType", p0RoleType));
			if (!ConfigCommon.BindInt(ConfigSkillButtonIndexByRoleType.HandleId, 1, p0RoleType, ConfigSkillButtonIndexByRoleType.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillButtonIndexByRoleType.HandleId, ConfigSkillButtonIndexByRoleType.LogPair);
				return null;
			}
			List<SkillButtonIndex> list = new List<SkillButtonIndex>();
			while (ConfigCommon.Step(ConfigSkillButtonIndexByRoleType.HandleId, false, ConfigSkillButtonIndexByRoleType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillButtonIndexByRoleType.HandleId, 0, ConfigSkillButtonIndexByRoleType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillButtonIndexByRoleType.HandleId, ConfigSkillButtonIndexByRoleType.LogPair);
					return null;
				}
				SkillButtonIndex rootAsSkillButtonIndex = SkillButtonIndex.GetRootAsSkillButtonIndex(new ByteBuffer(item2));
				list.Add(rootAsSkillButtonIndex);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonIndexByRoleType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillButtonIndexByRoleType.HandleId, ConfigSkillButtonIndexByRoleType.LogPair);
			return list;
		}

		// Token: 0x0400406E RID: 16494
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400406F RID: 16495
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004070 RID: 16496
		private const string TABLE = "SkillButtonIndex";

		// Token: 0x04004071 RID: 16497
		private const string COMMAND = "select BinData from `SkillButtonIndex` where RoleType=?";

		// Token: 0x04004072 RID: 16498
		private const string KEY_PREFIX = "SkillButtonIndexByRoleType";

		// Token: 0x04004073 RID: 16499
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004074 RID: 16500
		private static int HandleId;
	}
}
