using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000682 RID: 1666
	public class ConfigPhantomBattleCardRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600271C RID: 10012 RVA: 0x0013A45F File Offset: 0x0013865F
		static ConfigPhantomBattleCardRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x0013A480 File Offset: 0x00138680
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

		// Token: 0x0600271E RID: 10014 RVA: 0x0013A4FF File Offset: 0x001386FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleByActivityId.LogPair = null;
			ConfigPhantomBattleCardRoleByActivityId.HandleId = 0;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0013A50D File Offset: 0x0013870D
		public static void Init()
		{
			ConfigPhantomBattleCardRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRoleByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardRole` where ActivityId=?");
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0013A528 File Offset: 0x00138728
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

		// Token: 0x04002D74 RID: 11636
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D75 RID: 11637
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D76 RID: 11638
		private const string TABLE = "PhantomBattleCardRole";

		// Token: 0x04002D77 RID: 11639
		private const string COMMAND = "select BinData from `PhantomBattleCardRole` where ActivityId=?";

		// Token: 0x04002D78 RID: 11640
		private const string KEY_PREFIX = "PhantomBattleCardRoleByActivityId";

		// Token: 0x04002D79 RID: 11641
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D7A RID: 11642
		private static int HandleId;
	}
}
