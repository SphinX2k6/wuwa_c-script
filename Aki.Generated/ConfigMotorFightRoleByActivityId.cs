using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AF RID: 1455
	public class ConfigMotorFightRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002227 RID: 8743 RVA: 0x0011E1FC File Offset: 0x0011C3FC
		static ConfigMotorFightRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0011E21C File Offset: 0x0011C41C
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

		// Token: 0x06002229 RID: 8745 RVA: 0x0011E29B File Offset: 0x0011C49B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRoleByActivityId.LogPair = null;
			ConfigMotorFightRoleByActivityId.HandleId = 0;
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0011E2A9 File Offset: 0x0011C4A9
		public static void Init()
		{
			ConfigMotorFightRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRoleByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightRole` where ActivityId=?");
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0011E2C4 File Offset: 0x0011C4C4
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

		// Token: 0x040027AD RID: 10157
		private const string DB = "db_motorfight.db";

		// Token: 0x040027AE RID: 10158
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027AF RID: 10159
		private const string TABLE = "MotorFightRole";

		// Token: 0x040027B0 RID: 10160
		private const string COMMAND = "select BinData from `MotorFightRole` where ActivityId=?";

		// Token: 0x040027B1 RID: 10161
		private const string KEY_PREFIX = "MotorFightRoleByActivityId";

		// Token: 0x040027B2 RID: 10162
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027B3 RID: 10163
		private static int HandleId;
	}
}
