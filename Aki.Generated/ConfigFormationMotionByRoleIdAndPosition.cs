using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034F RID: 847
	public class ConfigFormationMotionByRoleIdAndPosition : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x000C9D93 File Offset: 0x000C7F93
		static ConfigFormationMotionByRoleIdAndPosition()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionByRoleIdAndPosition.CreateStaticDefaultValue), new Action(ConfigFormationMotionByRoleIdAndPosition.ResetStaticDefaultValue));
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x000C9DB4 File Offset: 0x000C7FB4
		public static void CreateStaticDefaultValue()
		{
			ConfigFormationMotionByRoleIdAndPosition.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFormationMotionByRoleIdAndPosition.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_formation.db"),
				new ValueTuple<string, object>("文件", "b.编队.xlsx"),
				new ValueTuple<string, object>("表名", "FormationMotion"),
				new ValueTuple<string, object>("语句", "select BinData from `FormationMotion` where RoleId=? And Position=?")
			});
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000C9E33 File Offset: 0x000C8033
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionByRoleIdAndPosition.LogPair = null;
			ConfigFormationMotionByRoleIdAndPosition.HandleId = 0;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000C9E41 File Offset: 0x000C8041
		public static void Init()
		{
			ConfigFormationMotionByRoleIdAndPosition.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionByRoleIdAndPosition.HandleId, "db_formation.db", "select BinData from `FormationMotion` where RoleId=? And Position=?");
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x000C9E5C File Offset: 0x000C805C
		[NullableContext(2)]
		public static IReadOnlyList<FormationMotion> GetConfigList(int p0RoleId, int p1Position, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFormationMotionByRoleIdAndPosition.HandleId, ConfigFormationMotionByRoleIdAndPosition.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionByRoleIdAndPosition");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Position);
				IReadOnlyList<FormationMotion> readOnlyList = (IReadOnlyList<FormationMotion>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFormationMotionByRoleIdAndPosition.LogPair.Clear();
			ConfigFormationMotionByRoleIdAndPosition.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigFormationMotionByRoleIdAndPosition.LogPair.Add(new ValueTuple<string, object>("Position", p1Position));
			if (!ConfigCommon.BindInt(ConfigFormationMotionByRoleIdAndPosition.HandleId, 1, p0RoleId, ConfigFormationMotionByRoleIdAndPosition.LogPair) || !ConfigCommon.BindInt(ConfigFormationMotionByRoleIdAndPosition.HandleId, 2, p1Position, ConfigFormationMotionByRoleIdAndPosition.LogPair))
			{
				ConfigCommon.Reset(ConfigFormationMotionByRoleIdAndPosition.HandleId, ConfigFormationMotionByRoleIdAndPosition.LogPair);
				return null;
			}
			List<FormationMotion> list = new List<FormationMotion>();
			while (ConfigCommon.Step(ConfigFormationMotionByRoleIdAndPosition.HandleId, false, ConfigFormationMotionByRoleIdAndPosition.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFormationMotionByRoleIdAndPosition.HandleId, 0, ConfigFormationMotionByRoleIdAndPosition.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFormationMotionByRoleIdAndPosition.HandleId, ConfigFormationMotionByRoleIdAndPosition.LogPair);
					return null;
				}
				FormationMotion rootAsFormationMotion = FormationMotion.GetRootAsFormationMotion(new ByteBuffer(item2));
				list.Add(rootAsFormationMotion);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FormationMotionByRoleIdAndPosition");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Position);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFormationMotionByRoleIdAndPosition.HandleId, ConfigFormationMotionByRoleIdAndPosition.LogPair);
			return list;
		}

		// Token: 0x0400170D RID: 5901
		private const string DB = "db_formation.db";

		// Token: 0x0400170E RID: 5902
		private const string FILE = "b.编队.xlsx";

		// Token: 0x0400170F RID: 5903
		private const string TABLE = "FormationMotion";

		// Token: 0x04001710 RID: 5904
		private const string COMMAND = "select BinData from `FormationMotion` where RoleId=? And Position=?";

		// Token: 0x04001711 RID: 5905
		private const string KEY_PREFIX = "FormationMotionByRoleIdAndPosition";

		// Token: 0x04001712 RID: 5906
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001713 RID: 5907
		private static int HandleId;
	}
}
