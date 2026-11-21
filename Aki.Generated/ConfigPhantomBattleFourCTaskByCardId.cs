using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000690 RID: 1680
	public class ConfigPhantomBattleFourCTaskByCardId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002770 RID: 10096 RVA: 0x0013C2F0 File Offset: 0x0013A4F0
		static ConfigPhantomBattleFourCTaskByCardId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleFourCTaskByCardId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleFourCTaskByCardId.ResetStaticDefaultValue));
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0013C310 File Offset: 0x0013A510
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

		// Token: 0x06002772 RID: 10098 RVA: 0x0013C38F File Offset: 0x0013A58F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleFourCTaskByCardId.LogPair = null;
			ConfigPhantomBattleFourCTaskByCardId.HandleId = 0;
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x0013C39D File Offset: 0x0013A59D
		public static void Init()
		{
			ConfigPhantomBattleFourCTaskByCardId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleFourCTaskByCardId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleFourCTask` where CardId=?");
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x0013C3B8 File Offset: 0x0013A5B8
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

		// Token: 0x04002DD6 RID: 11734
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DD7 RID: 11735
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002DD8 RID: 11736
		private const string TABLE = "PhantomBattleFourCTask";

		// Token: 0x04002DD9 RID: 11737
		private const string COMMAND = "select BinData from `PhantomBattleFourCTask` where CardId=?";

		// Token: 0x04002DDA RID: 11738
		private const string KEY_PREFIX = "PhantomBattleFourCTaskByCardId";

		// Token: 0x04002DDB RID: 11739
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DDC RID: 11740
		private static int HandleId;
	}
}
