using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066A RID: 1642
	public class ConfigPhantomBattleCardRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600268C RID: 9868 RVA: 0x001339E3 File Offset: 0x00131BE3
		static ConfigPhantomBattleCardRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00133A04 File Offset: 0x00131C04
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardRoleByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardRole"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardRole` where ActivityId=?")
			});
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00133A83 File Offset: 0x00131C83
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleByActivityId.LogPair = null;
			ConfigPhantomBattleCardRoleByActivityId.HandleId = 0;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00133A91 File Offset: 0x00131C91
		public static void Init()
		{
			ConfigPhantomBattleCardRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRoleByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardRole` where ActivityId=?");
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00133AAC File Offset: 0x00131CAC
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCardRole> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardRoleByActivityId.HandleId, ConfigPhantomBattleCardRoleByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleCardRole> readOnlyList = (IReadOnlyList<PhantomBattleCardRole>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleCardRoleByActivityId.LogPair.Clear();
			ConfigPhantomBattleCardRoleByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardRoleByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleCardRoleByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardRoleByActivityId.HandleId, ConfigPhantomBattleCardRoleByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleCardRole> list = new List<PhantomBattleCardRole>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardRoleByActivityId.HandleId, false, ConfigPhantomBattleCardRoleByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardRoleByActivityId.HandleId, 0, ConfigPhantomBattleCardRoleByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardRoleByActivityId.HandleId, ConfigPhantomBattleCardRoleByActivityId.LogPair);
					return null;
				}
				PhantomBattleCardRole rootAsPhantomBattleCardRole = PhantomBattleCardRole.GetRootAsPhantomBattleCardRole(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCardRole);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardRoleByActivityId.HandleId, ConfigPhantomBattleCardRoleByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002CCC RID: 11468
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CCD RID: 11469
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CCE RID: 11470
		private const string TABLE = "PhantomBattleCardRole";

		// Token: 0x04002CCF RID: 11471
		private const string COMMAND = "select BinData from `PhantomBattleCardRole` where ActivityId=?";

		// Token: 0x04002CD0 RID: 11472
		private const string KEY_PREFIX = "PhantomBattleCardRoleByActivityId";

		// Token: 0x04002CD1 RID: 11473
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CD2 RID: 11474
		private static int HandleId;
	}
}
