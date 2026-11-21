using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000983 RID: 2435
	public class ConfigSkillButtonIndexByRoleType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003925 RID: 14629 RVA: 0x0019FAAC File Offset: 0x0019DCAC
		static ConfigSkillButtonIndexByRoleType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonIndexByRoleType.CreateStaticDefaultValue), new Action(ConfigSkillButtonIndexByRoleType.ResetStaticDefaultValue));
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x0019FACC File Offset: 0x0019DCCC
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

		// Token: 0x06003927 RID: 14631 RVA: 0x0019FB4B File Offset: 0x0019DD4B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonIndexByRoleType.LogPair = null;
			ConfigSkillButtonIndexByRoleType.HandleId = 0;
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x0019FB59 File Offset: 0x0019DD59
		public static void Init()
		{
			ConfigSkillButtonIndexByRoleType.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonIndexByRoleType.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonIndex` where RoleType=?");
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0019FB74 File Offset: 0x0019DD74
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

		// Token: 0x0400427B RID: 17019
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400427C RID: 17020
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x0400427D RID: 17021
		private const string TABLE = "SkillButtonIndex";

		// Token: 0x0400427E RID: 17022
		private const string COMMAND = "select BinData from `SkillButtonIndex` where RoleType=?";

		// Token: 0x0400427F RID: 17023
		private const string KEY_PREFIX = "SkillButtonIndexByRoleType";

		// Token: 0x04004280 RID: 17024
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004281 RID: 17025
		private static int HandleId;
	}
}
