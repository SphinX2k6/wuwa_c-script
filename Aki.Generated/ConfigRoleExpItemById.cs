using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C3 RID: 2243
	public class ConfigRoleExpItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034A4 RID: 13476 RVA: 0x0018635F File Offset: 0x0018455F
		static ConfigRoleExpItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleExpItemById.CreateStaticDefaultValue), new Action(ConfigRoleExpItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00186380 File Offset: 0x00184580
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

		// Token: 0x060034A6 RID: 13478 RVA: 0x001863FF File Offset: 0x001845FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleExpItemById.LogPair = null;
			ConfigRoleExpItemById.HandleId = 0;
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x0018640D File Offset: 0x0018460D
		public static void Init()
		{
			ConfigRoleExpItemById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleExpItemById.HandleId, "db_role.db", "select BinData from `RoleExpItem` where Id=?");
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00186428 File Offset: 0x00184628
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

		// Token: 0x060034A9 RID: 13481 RVA: 0x001865A0 File Offset: 0x001847A0
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

		// Token: 0x04003D3B RID: 15675
		private const string DB = "db_role.db";

		// Token: 0x04003D3C RID: 15676
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D3D RID: 15677
		private const string TABLE = "RoleExpItem";

		// Token: 0x04003D3E RID: 15678
		private const string COMMAND = "select BinData from `RoleExpItem` where Id=?";

		// Token: 0x04003D3F RID: 15679
		private const string KEY_PREFIX = "RoleExpItemById";

		// Token: 0x04003D40 RID: 15680
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D41 RID: 15681
		private static int HandleId;
	}
}
