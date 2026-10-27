using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000124 RID: 292
	public class ConfigBuffEquipItemByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x00080617 File Offset: 0x0007E817
		static ConfigBuffEquipItemByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffEquipItemByRoleId.CreateStaticDefaultValue), new Action(ConfigBuffEquipItemByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00080638 File Offset: 0x0007E838
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffEquipItemByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffEquipItemByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_itemattributereward.db"),
				new ValueTuple<string, object>("文件", "s.属性奖励.xlsx"),
				new ValueTuple<string, object>("表名", "BuffEquipItem"),
				new ValueTuple<string, object>("语句", "select BinData from `BuffEquipItem` where RoleId = ?")
			});
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000806B7 File Offset: 0x0007E8B7
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffEquipItemByRoleId.LogPair = null;
			ConfigBuffEquipItemByRoleId.HandleId = 0;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000806C5 File Offset: 0x0007E8C5
		public static void Init()
		{
			ConfigBuffEquipItemByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigBuffEquipItemByRoleId.HandleId, "db_itemattributereward.db", "select BinData from `BuffEquipItem` where RoleId = ?");
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000806E0 File Offset: 0x0007E8E0
		[NullableContext(2)]
		public static IReadOnlyList<BuffEquipItem> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffEquipItemByRoleId.HandleId, ConfigBuffEquipItemByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffEquipItemByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<BuffEquipItem> readOnlyList = (IReadOnlyList<BuffEquipItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBuffEquipItemByRoleId.LogPair.Clear();
			ConfigBuffEquipItemByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigBuffEquipItemByRoleId.HandleId, 1, p0RoleId, ConfigBuffEquipItemByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigBuffEquipItemByRoleId.HandleId, ConfigBuffEquipItemByRoleId.LogPair);
				return null;
			}
			List<BuffEquipItem> list = new List<BuffEquipItem>();
			while (ConfigCommon.Step(ConfigBuffEquipItemByRoleId.HandleId, false, ConfigBuffEquipItemByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffEquipItemByRoleId.HandleId, 0, ConfigBuffEquipItemByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBuffEquipItemByRoleId.HandleId, ConfigBuffEquipItemByRoleId.LogPair);
					return null;
				}
				BuffEquipItem rootAsBuffEquipItem = BuffEquipItem.GetRootAsBuffEquipItem(new ByteBuffer(item2));
				list.Add(rootAsBuffEquipItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffEquipItemByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBuffEquipItemByRoleId.HandleId, ConfigBuffEquipItemByRoleId.LogPair);
			return list;
		}

		// Token: 0x040007E0 RID: 2016
		private const string DB = "db_itemattributereward.db";

		// Token: 0x040007E1 RID: 2017
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x040007E2 RID: 2018
		private const string TABLE = "BuffEquipItem";

		// Token: 0x040007E3 RID: 2019
		private const string COMMAND = "select BinData from `BuffEquipItem` where RoleId = ?";

		// Token: 0x040007E4 RID: 2020
		private const string KEY_PREFIX = "BuffEquipItemByRoleId";

		// Token: 0x040007E5 RID: 2021
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007E6 RID: 2022
		private static int HandleId;
	}
}
