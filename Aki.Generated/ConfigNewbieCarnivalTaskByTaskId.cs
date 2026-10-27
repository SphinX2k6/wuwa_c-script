using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E3 RID: 1507
	public class ConfigNewbieCarnivalTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002361 RID: 9057 RVA: 0x0012197C File Offset: 0x0011FB7C
		static ConfigNewbieCarnivalTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0012199C File Offset: 0x0011FB9C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalTask` where TaskId=?")
			});
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00121A1B File Offset: 0x0011FC1B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskByTaskId.LogPair = null;
			ConfigNewbieCarnivalTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00121A29 File Offset: 0x0011FC29
		public static void Init()
		{
			ConfigNewbieCarnivalTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalTaskByTaskId.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalTask` where TaskId=?");
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00121A44 File Offset: 0x0011FC44
		public static NewbieCarnivalTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalTaskByTaskId.HandleId, ConfigNewbieCarnivalTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCarnivalTask?(NewbieCarnivalTask.GetRootAsNewbieCarnivalTask(configBuffer));
				}
			}
			ConfigNewbieCarnivalTaskByTaskId.LogPair.Clear();
			ConfigNewbieCarnivalTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalTaskByTaskId.HandleId, 1, p0TaskId, ConfigNewbieCarnivalTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigNewbieCarnivalTaskByTaskId.HandleId, true, ConfigNewbieCarnivalTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskId.HandleId, ConfigNewbieCarnivalTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalTaskByTaskId.HandleId, 0, ConfigNewbieCarnivalTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskId.HandleId, ConfigNewbieCarnivalTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCarnivalTask rootAsNewbieCarnivalTask = NewbieCarnivalTask.GetRootAsNewbieCarnivalTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskId.HandleId, ConfigNewbieCarnivalTaskByTaskId.LogPair);
			return new NewbieCarnivalTask?(rootAsNewbieCarnivalTask);
		}

		// Token: 0x0400291B RID: 10523
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x0400291C RID: 10524
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x0400291D RID: 10525
		private const string TABLE = "NewbieCarnivalTask";

		// Token: 0x0400291E RID: 10526
		private const string COMMAND = "select BinData from `NewbieCarnivalTask` where TaskId=?";

		// Token: 0x0400291F RID: 10527
		private const string KEY_PREFIX = "NewbieCarnivalTaskByTaskId";

		// Token: 0x04002920 RID: 10528
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002921 RID: 10529
		private static int HandleId;
	}
}
