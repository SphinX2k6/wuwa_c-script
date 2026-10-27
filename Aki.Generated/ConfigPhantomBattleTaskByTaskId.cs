using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000686 RID: 1670
	public class ConfigPhantomBattleTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002734 RID: 10036 RVA: 0x00137607 File Offset: 0x00135807
		static ConfigPhantomBattleTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00137628 File Offset: 0x00135828
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

		// Token: 0x06002736 RID: 10038 RVA: 0x001376A7 File Offset: 0x001358A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleTaskByTaskId.LogPair = null;
			ConfigPhantomBattleTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x001376B5 File Offset: 0x001358B5
		public static void Init()
		{
			ConfigPhantomBattleTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleTaskByTaskId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleTask` where TaskId=?");
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x001376D0 File Offset: 0x001358D0
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

		// Token: 0x04002D90 RID: 11664
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D91 RID: 11665
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D92 RID: 11666
		private const string TABLE = "PhantomBattleTask";

		// Token: 0x04002D93 RID: 11667
		private const string COMMAND = "select BinData from `PhantomBattleTask` where TaskId=?";

		// Token: 0x04002D94 RID: 11668
		private const string KEY_PREFIX = "PhantomBattleTaskByTaskId";

		// Token: 0x04002D95 RID: 11669
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D96 RID: 11670
		private static int HandleId;
	}
}
