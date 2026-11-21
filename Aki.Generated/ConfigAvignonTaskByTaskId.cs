using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D0 RID: 208
	public class ConfigAvignonTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x00078EBB File Offset: 0x000770BB
		static ConfigAvignonTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigAvignonTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00078EDC File Offset: 0x000770DC
		public static void CreateStaticDefaultValue()
		{
			ConfigAvignonTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvignonTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avignon.db"),
				new ValueTuple<string, object>("文件", "a.阿维纽林神学院.xlsx"),
				new ValueTuple<string, object>("表名", "AvignonTask"),
				new ValueTuple<string, object>("语句", "select BinData from `AvignonTask` where TaskId=?")
			});
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00078F5B File Offset: 0x0007715B
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonTaskByTaskId.LogPair = null;
			ConfigAvignonTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00078F69 File Offset: 0x00077169
		public static void Init()
		{
			ConfigAvignonTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonTaskByTaskId.HandleId, "db_avignon.db", "select BinData from `AvignonTask` where TaskId=?");
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00078F84 File Offset: 0x00077184
		public static AvignonTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvignonTaskByTaskId.HandleId, ConfigAvignonTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvignonTask?(AvignonTask.GetRootAsAvignonTask(configBuffer));
				}
			}
			ConfigAvignonTaskByTaskId.LogPair.Clear();
			ConfigAvignonTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigAvignonTaskByTaskId.HandleId, 1, p0TaskId, ConfigAvignonTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigAvignonTaskByTaskId.HandleId, true, ConfigAvignonTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvignonTaskByTaskId.HandleId, ConfigAvignonTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvignonTaskByTaskId.HandleId, 0, ConfigAvignonTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvignonTaskByTaskId.HandleId, ConfigAvignonTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvignonTask rootAsAvignonTask = AvignonTask.GetRootAsAvignonTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvignonTaskByTaskId.HandleId, ConfigAvignonTaskByTaskId.LogPair);
			return new AvignonTask?(rootAsAvignonTask);
		}

		// Token: 0x04000594 RID: 1428
		private const string DB = "db_avignon.db";

		// Token: 0x04000595 RID: 1429
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x04000596 RID: 1430
		private const string TABLE = "AvignonTask";

		// Token: 0x04000597 RID: 1431
		private const string COMMAND = "select BinData from `AvignonTask` where TaskId=?";

		// Token: 0x04000598 RID: 1432
		private const string KEY_PREFIX = "AvignonTaskByTaskId";

		// Token: 0x04000599 RID: 1433
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400059A RID: 1434
		private static int HandleId;
	}
}
