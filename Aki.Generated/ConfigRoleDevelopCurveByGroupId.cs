using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000894 RID: 2196
	public class ConfigRoleDevelopCurveByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600338A RID: 13194 RVA: 0x0017CB84 File Offset: 0x0017AD84
		static ConfigRoleDevelopCurveByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevelopCurveByGroupId.CreateStaticDefaultValue), new Action(ConfigRoleDevelopCurveByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x0017CBA4 File Offset: 0x0017ADA4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevelopCurveByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevelopCurveByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevelopCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevelopCurve` where GroupId=?")
			});
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x0017CC23 File Offset: 0x0017AE23
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevelopCurveByGroupId.LogPair = null;
			ConfigRoleDevelopCurveByGroupId.HandleId = 0;
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x0017CC31 File Offset: 0x0017AE31
		public static void Init()
		{
			ConfigRoleDevelopCurveByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevelopCurveByGroupId.HandleId, "db_moonchasing.db", "select BinData from `RoleDevelopCurve` where GroupId=?");
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x0017CC4C File Offset: 0x0017AE4C
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevelopCurve> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevelopCurveByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<RoleDevelopCurve> readOnlyList = (IReadOnlyList<RoleDevelopCurve>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleDevelopCurveByGroupId.LogPair.Clear();
			ConfigRoleDevelopCurveByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRoleDevelopCurveByGroupId.HandleId, 1, p0GroupId, ConfigRoleDevelopCurveByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair);
				return null;
			}
			List<RoleDevelopCurve> list = new List<RoleDevelopCurve>();
			while (ConfigCommon.Step(ConfigRoleDevelopCurveByGroupId.HandleId, false, ConfigRoleDevelopCurveByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevelopCurveByGroupId.HandleId, 0, ConfigRoleDevelopCurveByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair);
					return null;
				}
				RoleDevelopCurve rootAsRoleDevelopCurve = RoleDevelopCurve.GetRootAsRoleDevelopCurve(new ByteBuffer(item2));
				list.Add(rootAsRoleDevelopCurve);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevelopCurveByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevelopCurveByGroupId.HandleId, ConfigRoleDevelopCurveByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003BF2 RID: 15346
		private const string DB = "db_moonchasing.db";

		// Token: 0x04003BF3 RID: 15347
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04003BF4 RID: 15348
		private const string TABLE = "RoleDevelopCurve";

		// Token: 0x04003BF5 RID: 15349
		private const string COMMAND = "select BinData from `RoleDevelopCurve` where GroupId=?";

		// Token: 0x04003BF6 RID: 15350
		private const string KEY_PREFIX = "RoleDevelopCurveByGroupId";

		// Token: 0x04003BF7 RID: 15351
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BF8 RID: 15352
		private static int HandleId;
	}
}
