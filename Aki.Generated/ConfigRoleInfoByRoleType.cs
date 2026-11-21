using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CE RID: 2254
	public class ConfigRoleInfoByRoleType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034E7 RID: 13543 RVA: 0x00187B74 File Offset: 0x00185D74
		static ConfigRoleInfoByRoleType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoByRoleType.CreateStaticDefaultValue), new Action(ConfigRoleInfoByRoleType.ResetStaticDefaultValue));
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00187B94 File Offset: 0x00185D94
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoByRoleType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoByRoleType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfo` where RoleType=?")
			});
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00187C13 File Offset: 0x00185E13
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoByRoleType.LogPair = null;
			ConfigRoleInfoByRoleType.HandleId = 0;
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00187C21 File Offset: 0x00185E21
		public static void Init()
		{
			ConfigRoleInfoByRoleType.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoByRoleType.HandleId, "db_role.db", "select BinData from `RoleInfo` where RoleType=?");
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00187C3C File Offset: 0x00185E3C
		[NullableContext(2)]
		public static IReadOnlyList<RoleInfo> GetConfigList(int p0RoleType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoByRoleType.HandleId, ConfigRoleInfoByRoleType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoByRoleType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleType);
				IReadOnlyList<RoleInfo> readOnlyList = (IReadOnlyList<RoleInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleInfoByRoleType.LogPair.Clear();
			ConfigRoleInfoByRoleType.LogPair.Add(new ValueTuple<string, object>("RoleType", p0RoleType));
			if (!ConfigCommon.BindInt(ConfigRoleInfoByRoleType.HandleId, 1, p0RoleType, ConfigRoleInfoByRoleType.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleInfoByRoleType.HandleId, ConfigRoleInfoByRoleType.LogPair);
				return null;
			}
			List<RoleInfo> list = new List<RoleInfo>();
			while (ConfigCommon.Step(ConfigRoleInfoByRoleType.HandleId, false, ConfigRoleInfoByRoleType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoByRoleType.HandleId, 0, ConfigRoleInfoByRoleType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleInfoByRoleType.HandleId, ConfigRoleInfoByRoleType.LogPair);
					return null;
				}
				RoleInfo rootAsRoleInfo = RoleInfo.GetRootAsRoleInfo(new ByteBuffer(item2));
				list.Add(rootAsRoleInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoByRoleType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleInfoByRoleType.HandleId, ConfigRoleInfoByRoleType.LogPair);
			return list;
		}

		// Token: 0x04003D88 RID: 15752
		private const string DB = "db_role.db";

		// Token: 0x04003D89 RID: 15753
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D8A RID: 15754
		private const string TABLE = "RoleInfo";

		// Token: 0x04003D8B RID: 15755
		private const string COMMAND = "select BinData from `RoleInfo` where RoleType=?";

		// Token: 0x04003D8C RID: 15756
		private const string KEY_PREFIX = "RoleInfoByRoleType";

		// Token: 0x04003D8D RID: 15757
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D8E RID: 15758
		private static int HandleId;
	}
}
