using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000363 RID: 867
	public class ConfigFormationMotionByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001457 RID: 5207 RVA: 0x000D0068 File Offset: 0x000CE268
		static ConfigFormationMotionByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionByRoleId.CreateStaticDefaultValue), new Action(ConfigFormationMotionByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000D0088 File Offset: 0x000CE288
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

		// Token: 0x06001459 RID: 5209 RVA: 0x000D0107 File Offset: 0x000CE307
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionByRoleId.LogPair = null;
			ConfigFormationMotionByRoleId.HandleId = 0;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x000D0115 File Offset: 0x000CE315
		public static void Init()
		{
			ConfigFormationMotionByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionByRoleId.HandleId, "db_formation.db", "select BinData from `FormationMotion` where RoleId=?");
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x000D0130 File Offset: 0x000CE330
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

		// Token: 0x04001799 RID: 6041
		private const string DB = "db_formation.db";

		// Token: 0x0400179A RID: 6042
		private const string FILE = "b.编队.xlsx";

		// Token: 0x0400179B RID: 6043
		private const string TABLE = "FormationMotion";

		// Token: 0x0400179C RID: 6044
		private const string COMMAND = "select BinData from `FormationMotion` where RoleId=?";

		// Token: 0x0400179D RID: 6045
		private const string KEY_PREFIX = "FormationMotionByRoleId";

		// Token: 0x0400179E RID: 6046
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400179F RID: 6047
		private static int HandleId;
	}
}
