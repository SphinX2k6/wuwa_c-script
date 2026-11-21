using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FB RID: 1531
	public class ConfigNewbieCarnivalTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023F1 RID: 9201 RVA: 0x001283F8 File Offset: 0x001265F8
		static ConfigNewbieCarnivalTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00128418 File Offset: 0x00126618
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

		// Token: 0x060023F3 RID: 9203 RVA: 0x00128497 File Offset: 0x00126697
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskByTaskId.LogPair = null;
			ConfigNewbieCarnivalTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x001284A5 File Offset: 0x001266A5
		public static void Init()
		{
			ConfigNewbieCarnivalTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalTaskByTaskId.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalTask` where TaskId=?");
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x001284C0 File Offset: 0x001266C0
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

		// Token: 0x040029C3 RID: 10691
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x040029C4 RID: 10692
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x040029C5 RID: 10693
		private const string TABLE = "NewbieCarnivalTask";

		// Token: 0x040029C6 RID: 10694
		private const string COMMAND = "select BinData from `NewbieCarnivalTask` where TaskId=?";

		// Token: 0x040029C7 RID: 10695
		private const string KEY_PREFIX = "NewbieCarnivalTaskByTaskId";

		// Token: 0x040029C8 RID: 10696
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029C9 RID: 10697
		private static int HandleId;
	}
}
