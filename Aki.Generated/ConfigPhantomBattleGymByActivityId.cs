using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000691 RID: 1681
	public class ConfigPhantomBattleGymByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002776 RID: 10102 RVA: 0x0013C538 File Offset: 0x0013A738
		static ConfigPhantomBattleGymByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleGymByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleGymByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x0013C558 File Offset: 0x0013A758
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleGymByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleGymByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleGym"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleGym` where ActivityId=?")
			});
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x0013C5D7 File Offset: 0x0013A7D7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleGymByActivityId.LogPair = null;
			ConfigPhantomBattleGymByActivityId.HandleId = 0;
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x0013C5E5 File Offset: 0x0013A7E5
		public static void Init()
		{
			ConfigPhantomBattleGymByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleGymByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleGym` where ActivityId=?");
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x0013C600 File Offset: 0x0013A800
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleGym> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleGymByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleGym> readOnlyList = (IReadOnlyList<PhantomBattleGym>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleGymByActivityId.LogPair.Clear();
			ConfigPhantomBattleGymByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleGymByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleGymByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleGym> list = new List<PhantomBattleGym>();
			while (ConfigCommon.Step(ConfigPhantomBattleGymByActivityId.HandleId, false, ConfigPhantomBattleGymByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleGymByActivityId.HandleId, 0, ConfigPhantomBattleGymByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair);
					return null;
				}
				PhantomBattleGym rootAsPhantomBattleGym = PhantomBattleGym.GetRootAsPhantomBattleGym(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleGym);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleGymByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002DDD RID: 11741
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DDE RID: 11742
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DDF RID: 11743
		private const string TABLE = "PhantomBattleGym";

		// Token: 0x04002DE0 RID: 11744
		private const string COMMAND = "select BinData from `PhantomBattleGym` where ActivityId=?";

		// Token: 0x04002DE1 RID: 11745
		private const string KEY_PREFIX = "PhantomBattleGymByActivityId";

		// Token: 0x04002DE2 RID: 11746
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DE3 RID: 11747
		private static int HandleId;
	}
}
