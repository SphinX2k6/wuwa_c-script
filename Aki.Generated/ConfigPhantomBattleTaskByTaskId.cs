using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069E RID: 1694
	public class ConfigPhantomBattleTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027C4 RID: 10180 RVA: 0x0013E083 File Offset: 0x0013C283
		static ConfigPhantomBattleTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0013E0A4 File Offset: 0x0013C2A4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleTask"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleTask` where TaskId=?")
			});
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0013E123 File Offset: 0x0013C323
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleTaskByTaskId.LogPair = null;
			ConfigPhantomBattleTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0013E131 File Offset: 0x0013C331
		public static void Init()
		{
			ConfigPhantomBattleTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleTaskByTaskId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleTask` where TaskId=?");
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0013E14C File Offset: 0x0013C34C
		public static PhantomBattleTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleTaskByTaskId.HandleId, ConfigPhantomBattleTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleTask?(PhantomBattleTask.GetRootAsPhantomBattleTask(configBuffer));
				}
			}
			ConfigPhantomBattleTaskByTaskId.LogPair.Clear();
			ConfigPhantomBattleTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleTaskByTaskId.HandleId, 1, p0TaskId, ConfigPhantomBattleTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigPhantomBattleTaskByTaskId.HandleId, true, ConfigPhantomBattleTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleTaskByTaskId.HandleId, ConfigPhantomBattleTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleTaskByTaskId.HandleId, 0, ConfigPhantomBattleTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleTaskByTaskId.HandleId, ConfigPhantomBattleTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleTask rootAsPhantomBattleTask = PhantomBattleTask.GetRootAsPhantomBattleTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleTaskByTaskId.HandleId, ConfigPhantomBattleTaskByTaskId.LogPair);
			return new PhantomBattleTask?(rootAsPhantomBattleTask);
		}

		// Token: 0x04002E38 RID: 11832
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E39 RID: 11833
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E3A RID: 11834
		private const string TABLE = "PhantomBattleTask";

		// Token: 0x04002E3B RID: 11835
		private const string COMMAND = "select BinData from `PhantomBattleTask` where TaskId=?";

		// Token: 0x04002E3C RID: 11836
		private const string KEY_PREFIX = "PhantomBattleTaskByTaskId";

		// Token: 0x04002E3D RID: 11837
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E3E RID: 11838
		private static int HandleId;
	}
}
