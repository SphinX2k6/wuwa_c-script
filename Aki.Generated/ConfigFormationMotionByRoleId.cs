using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034E RID: 846
	public class ConfigFormationMotionByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013D9 RID: 5081 RVA: 0x000C9B5C File Offset: 0x000C7D5C
		static ConfigFormationMotionByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionByRoleId.CreateStaticDefaultValue), new Action(ConfigFormationMotionByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x000C9B7C File Offset: 0x000C7D7C
		public static void CreateStaticDefaultValue()
		{
			ConfigFormationMotionByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFormationMotionByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "FormationMotion"),
				new ValueTuple<string, object>("语句", "select BinData from `FormationMotion` where RoleId=?")
			});
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000C9BFB File Offset: 0x000C7DFB
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionByRoleId.LogPair = null;
			ConfigFormationMotionByRoleId.HandleId = 0;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x000C9C09 File Offset: 0x000C7E09
		public static void Init()
		{
			ConfigFormationMotionByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionByRoleId.HandleId, "db_formation.db", "select BinData from `FormationMotion` where RoleId=?");
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000C9C24 File Offset: 0x000C7E24
		[NullableContext(2)]
		public static IReadOnlyList<FormationMotion> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFormationMotionByRoleId.HandleId, ConfigFormationMotionByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<FormationMotion> readOnlyList = (IReadOnlyList<FormationMotion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFormationMotionByRoleId.LogPair.Clear();
			ConfigFormationMotionByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigFormationMotionByRoleId.HandleId, 1, p0RoleId, ConfigFormationMotionByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigFormationMotionByRoleId.HandleId, ConfigFormationMotionByRoleId.LogPair);
				return null;
			}
			List<FormationMotion> list = new List<FormationMotion>();
			while (ConfigCommon.Step(ConfigFormationMotionByRoleId.HandleId, false, ConfigFormationMotionByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFormationMotionByRoleId.HandleId, 0, ConfigFormationMotionByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFormationMotionByRoleId.HandleId, ConfigFormationMotionByRoleId.LogPair);
					return null;
				}
				FormationMotion rootAsFormationMotion = FormationMotion.GetRootAsFormationMotion(new ByteBuffer(item2));
				list.Add(rootAsFormationMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFormationMotionByRoleId.HandleId, ConfigFormationMotionByRoleId.LogPair);
			return list;
		}

		// Token: 0x04001706 RID: 5894
		private const string DB = "db_formation.db";

		// Token: 0x04001707 RID: 5895
		private const string FILE = "b.编队.xlsx";

		// Token: 0x04001708 RID: 5896
		private const string TABLE = "FormationMotion";

		// Token: 0x04001709 RID: 5897
		private const string COMMAND = "select BinData from `FormationMotion` where RoleId=?";

		// Token: 0x0400170A RID: 5898
		private const string KEY_PREFIX = "FormationMotionByRoleId";

		// Token: 0x0400170B RID: 5899
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400170C RID: 5900
		private static int HandleId;
	}
}
