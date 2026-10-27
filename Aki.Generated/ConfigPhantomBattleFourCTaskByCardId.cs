using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000678 RID: 1656
	public class ConfigPhantomBattleFourCTaskByCardId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026E0 RID: 9952 RVA: 0x00135874 File Offset: 0x00133A74
		static ConfigPhantomBattleFourCTaskByCardId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleFourCTaskByCardId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleFourCTaskByCardId.ResetStaticDefaultValue));
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00135894 File Offset: 0x00133A94
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleFourCTaskByCardId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleFourCTaskByCardId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleFourCTask"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleFourCTask` where CardId=?")
			});
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00135913 File Offset: 0x00133B13
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleFourCTaskByCardId.LogPair = null;
			ConfigPhantomBattleFourCTaskByCardId.HandleId = 0;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00135921 File Offset: 0x00133B21
		public static void Init()
		{
			ConfigPhantomBattleFourCTaskByCardId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleFourCTaskByCardId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleFourCTask` where CardId=?");
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0013593C File Offset: 0x00133B3C
		public static PhantomBattleFourCTask? GetConfig(int p0CardId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleFourCTaskByCardId.HandleId, ConfigPhantomBattleFourCTaskByCardId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleFourCTaskByCardId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CardId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleFourCTask?(PhantomBattleFourCTask.GetRootAsPhantomBattleFourCTask(configBuffer));
				}
			}
			ConfigPhantomBattleFourCTaskByCardId.LogPair.Clear();
			ConfigPhantomBattleFourCTaskByCardId.LogPair.Add(new ValueTuple<string, object>("CardId", p0CardId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleFourCTaskByCardId.HandleId, 1, p0CardId, ConfigPhantomBattleFourCTaskByCardId.LogPair) || ConfigCommon.Step(ConfigPhantomBattleFourCTaskByCardId.HandleId, true, ConfigPhantomBattleFourCTaskByCardId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleFourCTaskByCardId.HandleId, ConfigPhantomBattleFourCTaskByCardId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleFourCTaskByCardId.HandleId, 0, ConfigPhantomBattleFourCTaskByCardId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleFourCTaskByCardId.HandleId, ConfigPhantomBattleFourCTaskByCardId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleFourCTask rootAsPhantomBattleFourCTask = PhantomBattleFourCTask.GetRootAsPhantomBattleFourCTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleFourCTaskByCardId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CardId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleFourCTaskByCardId.HandleId, ConfigPhantomBattleFourCTaskByCardId.LogPair);
			return new PhantomBattleFourCTask?(rootAsPhantomBattleFourCTask);
		}

		// Token: 0x04002D2E RID: 11566
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D2F RID: 11567
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002D30 RID: 11568
		private const string TABLE = "PhantomBattleFourCTask";

		// Token: 0x04002D31 RID: 11569
		private const string COMMAND = "select BinData from `PhantomBattleFourCTask` where CardId=?";

		// Token: 0x04002D32 RID: 11570
		private const string KEY_PREFIX = "PhantomBattleFourCTaskByCardId";

		// Token: 0x04002D33 RID: 11571
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D34 RID: 11572
		private static int HandleId;
	}
}
