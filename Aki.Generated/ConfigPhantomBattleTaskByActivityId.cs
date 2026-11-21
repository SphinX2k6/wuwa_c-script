using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069D RID: 1693
	public class ConfigPhantomBattleTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027BE RID: 10174 RVA: 0x0013DE4C File Offset: 0x0013C04C
		static ConfigPhantomBattleTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x0013DE6C File Offset: 0x0013C06C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleTask"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleTask` where ActivityId=?")
			});
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0013DEEB File Offset: 0x0013C0EB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleTaskByActivityId.LogPair = null;
			ConfigPhantomBattleTaskByActivityId.HandleId = 0;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0013DEF9 File Offset: 0x0013C0F9
		public static void Init()
		{
			ConfigPhantomBattleTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleTaskByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleTask` where ActivityId=?");
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0013DF14 File Offset: 0x0013C114
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleTaskByActivityId.HandleId, ConfigPhantomBattleTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleTask> readOnlyList = (IReadOnlyList<PhantomBattleTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleTaskByActivityId.LogPair.Clear();
			ConfigPhantomBattleTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleTaskByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleTaskByActivityId.HandleId, ConfigPhantomBattleTaskByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleTask> list = new List<PhantomBattleTask>();
			while (ConfigCommon.Step(ConfigPhantomBattleTaskByActivityId.HandleId, false, ConfigPhantomBattleTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleTaskByActivityId.HandleId, 0, ConfigPhantomBattleTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleTaskByActivityId.HandleId, ConfigPhantomBattleTaskByActivityId.LogPair);
					return null;
				}
				PhantomBattleTask rootAsPhantomBattleTask = PhantomBattleTask.GetRootAsPhantomBattleTask(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleTaskByActivityId.HandleId, ConfigPhantomBattleTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002E31 RID: 11825
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E32 RID: 11826
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E33 RID: 11827
		private const string TABLE = "PhantomBattleTask";

		// Token: 0x04002E34 RID: 11828
		private const string COMMAND = "select BinData from `PhantomBattleTask` where ActivityId=?";

		// Token: 0x04002E35 RID: 11829
		private const string KEY_PREFIX = "PhantomBattleTaskByActivityId";

		// Token: 0x04002E36 RID: 11830
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E37 RID: 11831
		private static int HandleId;
	}
}
