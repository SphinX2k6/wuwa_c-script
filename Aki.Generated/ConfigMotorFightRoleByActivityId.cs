using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000598 RID: 1432
	public class ConfigMotorFightRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600219D RID: 8605 RVA: 0x00117914 File Offset: 0x00115B14
		static ConfigMotorFightRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00117934 File Offset: 0x00115B34
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightRoleByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightRoleByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightRole"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightRole` where ActivityId=?")
			});
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x001179B3 File Offset: 0x00115BB3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRoleByActivityId.LogPair = null;
			ConfigMotorFightRoleByActivityId.HandleId = 0;
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x001179C1 File Offset: 0x00115BC1
		public static void Init()
		{
			ConfigMotorFightRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRoleByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightRole` where ActivityId=?");
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x001179DC File Offset: 0x00115BDC
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightRole> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightRoleByActivityId.HandleId, ConfigMotorFightRoleByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorFightRole> readOnlyList = (IReadOnlyList<MotorFightRole>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorFightRoleByActivityId.LogPair.Clear();
			ConfigMotorFightRoleByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightRoleByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightRoleByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorFightRoleByActivityId.HandleId, ConfigMotorFightRoleByActivityId.LogPair);
				return null;
			}
			List<MotorFightRole> list = new List<MotorFightRole>();
			while (ConfigCommon.Step(ConfigMotorFightRoleByActivityId.HandleId, false, ConfigMotorFightRoleByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightRoleByActivityId.HandleId, 0, ConfigMotorFightRoleByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightRoleByActivityId.HandleId, ConfigMotorFightRoleByActivityId.LogPair);
					return null;
				}
				MotorFightRole rootAsMotorFightRole = MotorFightRole.GetRootAsMotorFightRole(new ByteBuffer(item2));
				list.Add(rootAsMotorFightRole);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightRoleByActivityId.HandleId, ConfigMotorFightRoleByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400270C RID: 9996
		private const string DB = "db_motorfight.db";

		// Token: 0x0400270D RID: 9997
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400270E RID: 9998
		private const string TABLE = "MotorFightRole";

		// Token: 0x0400270F RID: 9999
		private const string COMMAND = "select BinData from `MotorFightRole` where ActivityId=?";

		// Token: 0x04002710 RID: 10000
		private const string KEY_PREFIX = "MotorFightRoleByActivityId";

		// Token: 0x04002711 RID: 10001
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002712 RID: 10002
		private static int HandleId;
	}
}
