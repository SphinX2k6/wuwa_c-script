using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000364 RID: 868
	public class ConfigFormationMotionByRoleIdAndPosition : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x000D029F File Offset: 0x000CE49F
		static ConfigFormationMotionByRoleIdAndPosition()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFormationMotionByRoleIdAndPosition.CreateStaticDefaultValue), new Action(ConfigFormationMotionByRoleIdAndPosition.ResetStaticDefaultValue));
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000D02C0 File Offset: 0x000CE4C0
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

		// Token: 0x0600145F RID: 5215 RVA: 0x000D033F File Offset: 0x000CE53F
		public static void ResetStaticDefaultValue()
		{
			ConfigFormationMotionByRoleIdAndPosition.LogPair = null;
			ConfigFormationMotionByRoleIdAndPosition.HandleId = 0;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000D034D File Offset: 0x000CE54D
		public static void Init()
		{
			ConfigFormationMotionByRoleIdAndPosition.HandleId = ConfigCommon.InitDataStatement(ConfigFormationMotionByRoleIdAndPosition.HandleId, "db_formation.db", "select BinData from `FormationMotion` where RoleId=? And Position=?");
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000D0368 File Offset: 0x000CE568
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

		// Token: 0x040017A0 RID: 6048
		private const string DB = "db_formation.db";

		// Token: 0x040017A1 RID: 6049
		private const string FILE = "b.编队.xlsx";

		// Token: 0x040017A2 RID: 6050
		private const string TABLE = "FormationMotion";

		// Token: 0x040017A3 RID: 6051
		private const string COMMAND = "select BinData from `FormationMotion` where RoleId=? And Position=?";

		// Token: 0x040017A4 RID: 6052
		private const string KEY_PREFIX = "FormationMotionByRoleIdAndPosition";

		// Token: 0x040017A5 RID: 6053
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017A6 RID: 6054
		private static int HandleId;
	}
}
