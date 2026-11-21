using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000133 RID: 307
	public class ConfigBuffEquipItemByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00085F7B File Offset: 0x0008417B
		static ConfigBuffEquipItemByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffEquipItemByRoleId.CreateStaticDefaultValue), new Action(ConfigBuffEquipItemByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00085F9C File Offset: 0x0008419C
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

		// Token: 0x06000735 RID: 1845 RVA: 0x0008601B File Offset: 0x0008421B
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffEquipItemByRoleId.LogPair = null;
			ConfigBuffEquipItemByRoleId.HandleId = 0;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00086029 File Offset: 0x00084229
		public static void Init()
		{
			ConfigBuffEquipItemByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigBuffEquipItemByRoleId.HandleId, "db_itemattributereward.db", "select BinData from `BuffEquipItem` where RoleId = ?");
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00086044 File Offset: 0x00084244
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

		// Token: 0x04000849 RID: 2121
		private const string DB = "db_itemattributereward.db";

		// Token: 0x0400084A RID: 2122
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x0400084B RID: 2123
		private const string TABLE = "BuffEquipItem";

		// Token: 0x0400084C RID: 2124
		private const string COMMAND = "select BinData from `BuffEquipItem` where RoleId = ?";

		// Token: 0x0400084D RID: 2125
		private const string KEY_PREFIX = "BuffEquipItemByRoleId";

		// Token: 0x0400084E RID: 2126
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400084F RID: 2127
		private static int HandleId;
	}
}
