using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BA RID: 2234
	public class ConfigRoleMorphByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600346F RID: 13423 RVA: 0x001818F4 File Offset: 0x0017FAF4
		static ConfigRoleMorphByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleMorphByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00181914 File Offset: 0x0017FB14
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleMorphByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleMorphByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleMorph"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleMorph` where RoleId=?")
			});
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00181993 File Offset: 0x0017FB93
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphByRoleId.LogPair = null;
			ConfigRoleMorphByRoleId.HandleId = 0;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x001819A1 File Offset: 0x0017FBA1
		public static void Init()
		{
			ConfigRoleMorphByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphByRoleId.HandleId, "db_role.db", "select BinData from `RoleMorph` where RoleId=?");
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x001819BC File Offset: 0x0017FBBC
		[NullableContext(2)]
		public static IReadOnlyList<RoleMorph> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<RoleMorph> readOnlyList = (IReadOnlyList<RoleMorph>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleMorphByRoleId.LogPair.Clear();
			ConfigRoleMorphByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleMorphByRoleId.HandleId, 1, p0RoleId, ConfigRoleMorphByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair);
				return null;
			}
			List<RoleMorph> list = new List<RoleMorph>();
			while (ConfigCommon.Step(ConfigRoleMorphByRoleId.HandleId, false, ConfigRoleMorphByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleMorphByRoleId.HandleId, 0, ConfigRoleMorphByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair);
					return null;
				}
				RoleMorph rootAsRoleMorph = RoleMorph.GetRootAsRoleMorph(new ByteBuffer(item2));
				list.Add(rootAsRoleMorph);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair);
			return list;
		}

		// Token: 0x04003CFC RID: 15612
		private const string DB = "db_role.db";

		// Token: 0x04003CFD RID: 15613
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003CFE RID: 15614
		private const string TABLE = "RoleMorph";

		// Token: 0x04003CFF RID: 15615
		private const string COMMAND = "select BinData from `RoleMorph` where RoleId=?";

		// Token: 0x04003D00 RID: 15616
		private const string KEY_PREFIX = "RoleMorphByRoleId";

		// Token: 0x04003D01 RID: 15617
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D02 RID: 15618
		private static int HandleId;
	}
}
