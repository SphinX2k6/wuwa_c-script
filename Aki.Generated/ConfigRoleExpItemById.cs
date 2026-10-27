using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A7 RID: 2215
	public class ConfigRoleExpItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033FC RID: 13308 RVA: 0x0017F077 File Offset: 0x0017D277
		static ConfigRoleExpItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleExpItemById.CreateStaticDefaultValue), new Action(ConfigRoleExpItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x0017F098 File Offset: 0x0017D298
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleExpItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleExpItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleExpItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleExpItem` where Id=?")
			});
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x0017F117 File Offset: 0x0017D317
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleExpItemById.LogPair = null;
			ConfigRoleExpItemById.HandleId = 0;
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x0017F125 File Offset: 0x0017D325
		public static void Init()
		{
			ConfigRoleExpItemById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleExpItemById.HandleId, "db_role.db", "select BinData from `RoleExpItem` where Id=?");
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x0017F140 File Offset: 0x0017D340
		public static RoleExpItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleExpItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleExpItem?(RoleExpItem.GetRootAsRoleExpItem(configBuffer));
				}
			}
			ConfigRoleExpItemById.LogPair.Clear();
			ConfigRoleExpItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleExpItemById.HandleId, 1, p0Id, ConfigRoleExpItemById.LogPair) || ConfigCommon.Step(ConfigRoleExpItemById.HandleId, true, ConfigRoleExpItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleExpItemById.HandleId, 0, ConfigRoleExpItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleExpItem rootAsRoleExpItem = RoleExpItem.GetRootAsRoleExpItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleExpItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair);
			return new RoleExpItem?(rootAsRoleExpItem);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x0017F2B8 File Offset: 0x0017D4B8
		[NullableContext(2)]
		public static IReadOnlyList<RoleExpItem> GetConfigList(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleExpItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				IReadOnlyList<RoleExpItem> readOnlyList = (IReadOnlyList<RoleExpItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleExpItemById.LogPair.Clear();
			ConfigRoleExpItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleExpItemById.HandleId, 1, p0Id, ConfigRoleExpItemById.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair);
				return null;
			}
			List<RoleExpItem> list = new List<RoleExpItem>();
			while (ConfigCommon.Step(ConfigRoleExpItemById.HandleId, false, ConfigRoleExpItemById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleExpItemById.HandleId, 0, ConfigRoleExpItemById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair);
					return null;
				}
				RoleExpItem rootAsRoleExpItem = RoleExpItem.GetRootAsRoleExpItem(new ByteBuffer(item2));
				list.Add(rootAsRoleExpItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleExpItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleExpItemById.HandleId, ConfigRoleExpItemById.LogPair);
			return list;
		}

		// Token: 0x04003C77 RID: 15479
		private const string DB = "db_role.db";

		// Token: 0x04003C78 RID: 15480
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003C79 RID: 15481
		private const string TABLE = "RoleExpItem";

		// Token: 0x04003C7A RID: 15482
		private const string COMMAND = "select BinData from `RoleExpItem` where Id=?";

		// Token: 0x04003C7B RID: 15483
		private const string KEY_PREFIX = "RoleExpItemById";

		// Token: 0x04003C7C RID: 15484
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C7D RID: 15485
		private static int HandleId;
	}
}
