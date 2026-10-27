using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000685 RID: 1669
	public class ConfigPhantomBattleTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600272E RID: 10030 RVA: 0x001373D0 File Offset: 0x001355D0
		static ConfigPhantomBattleTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x001373F0 File Offset: 0x001355F0
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

		// Token: 0x06002730 RID: 10032 RVA: 0x0013746F File Offset: 0x0013566F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleTaskByActivityId.LogPair = null;
			ConfigPhantomBattleTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0013747D File Offset: 0x0013567D
		public static void Init()
		{
			ConfigPhantomBattleTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleTaskByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleTask` where ActivityId=?");
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00137498 File Offset: 0x00135698
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

		// Token: 0x04002D89 RID: 11657
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D8A RID: 11658
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D8B RID: 11659
		private const string TABLE = "PhantomBattleTask";

		// Token: 0x04002D8C RID: 11660
		private const string COMMAND = "select BinData from `PhantomBattleTask` where ActivityId=?";

		// Token: 0x04002D8D RID: 11661
		private const string KEY_PREFIX = "PhantomBattleTaskByActivityId";

		// Token: 0x04002D8E RID: 11662
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D8F RID: 11663
		private static int HandleId;
	}
}
