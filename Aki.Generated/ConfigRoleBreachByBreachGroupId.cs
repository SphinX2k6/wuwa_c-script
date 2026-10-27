using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088D RID: 2189
	public class ConfigRoleBreachByBreachGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003360 RID: 13152 RVA: 0x0017BCB1 File Offset: 0x00179EB1
		static ConfigRoleBreachByBreachGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBreachByBreachGroupId.CreateStaticDefaultValue), new Action(ConfigRoleBreachByBreachGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x0017BCD0 File Offset: 0x00179ED0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBreachByBreachGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role_level.db"),
				new ValueTuple<string, object>("文件", "j.角色升级突破.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBreach"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBreach` where BreachGroupId=?")
			});
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x0017BD4F File Offset: 0x00179F4F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupId.LogPair = null;
			ConfigRoleBreachByBreachGroupId.HandleId = 0;
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x0017BD5D File Offset: 0x00179F5D
		public static void Init()
		{
			ConfigRoleBreachByBreachGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBreachByBreachGroupId.HandleId, "db_role_level.db", "select BinData from `RoleBreach` where BreachGroupId=?");
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x0017BD78 File Offset: 0x00179F78
		[NullableContext(2)]
		public static IReadOnlyList<RoleBreach> GetConfigList(int p0BreachGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				IReadOnlyList<RoleBreach> readOnlyList = (IReadOnlyList<RoleBreach>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleBreachByBreachGroupId.LogPair.Clear();
			ConfigRoleBreachByBreachGroupId.LogPair.Add(new ValueTuple<string, object>("BreachGroupId", p0BreachGroupId));
			if (!ConfigCommon.BindInt(ConfigRoleBreachByBreachGroupId.HandleId, 1, p0BreachGroupId, ConfigRoleBreachByBreachGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair);
				return null;
			}
			List<RoleBreach> list = new List<RoleBreach>();
			while (ConfigCommon.Step(ConfigRoleBreachByBreachGroupId.HandleId, false, ConfigRoleBreachByBreachGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBreachByBreachGroupId.HandleId, 0, ConfigRoleBreachByBreachGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair);
					return null;
				}
				RoleBreach rootAsRoleBreach = RoleBreach.GetRootAsRoleBreach(new ByteBuffer(item2));
				list.Add(rootAsRoleBreach);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair);
			return list;
		}

		// Token: 0x04003BC1 RID: 15297
		private const string DB = "db_role_level.db";

		// Token: 0x04003BC2 RID: 15298
		private const string FILE = "j.角色升级突破.xlsx";

		// Token: 0x04003BC3 RID: 15299
		private const string TABLE = "RoleBreach";

		// Token: 0x04003BC4 RID: 15300
		private const string COMMAND = "select BinData from `RoleBreach` where BreachGroupId=?";

		// Token: 0x04003BC5 RID: 15301
		private const string KEY_PREFIX = "RoleBreachByBreachGroupId";

		// Token: 0x04003BC6 RID: 15302
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BC7 RID: 15303
		private static int HandleId;
	}
}
