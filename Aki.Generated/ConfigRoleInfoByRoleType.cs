using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B2 RID: 2226
	public class ConfigRoleInfoByRoleType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600343F RID: 13375 RVA: 0x0018088C File Offset: 0x0017EA8C
		static ConfigRoleInfoByRoleType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoByRoleType.CreateStaticDefaultValue), new Action(ConfigRoleInfoByRoleType.ResetStaticDefaultValue));
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x001808AC File Offset: 0x0017EAAC
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

		// Token: 0x06003441 RID: 13377 RVA: 0x0018092B File Offset: 0x0017EB2B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoByRoleType.LogPair = null;
			ConfigRoleInfoByRoleType.HandleId = 0;
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00180939 File Offset: 0x0017EB39
		public static void Init()
		{
			ConfigRoleInfoByRoleType.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoByRoleType.HandleId, "db_role.db", "select BinData from `RoleInfo` where RoleType=?");
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00180954 File Offset: 0x0017EB54
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

		// Token: 0x04003CC4 RID: 15556
		private const string DB = "db_role.db";

		// Token: 0x04003CC5 RID: 15557
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003CC6 RID: 15558
		private const string TABLE = "RoleInfo";

		// Token: 0x04003CC7 RID: 15559
		private const string COMMAND = "select BinData from `RoleInfo` where RoleType=?";

		// Token: 0x04003CC8 RID: 15560
		private const string KEY_PREFIX = "RoleInfoByRoleType";

		// Token: 0x04003CC9 RID: 15561
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CCA RID: 15562
		private static int HandleId;
	}
}
