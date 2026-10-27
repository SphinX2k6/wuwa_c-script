using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C1 RID: 193
	public class ConfigAvignonTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000487 RID: 1159 RVA: 0x00073557 File Offset: 0x00071757
		static ConfigAvignonTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigAvignonTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00073578 File Offset: 0x00071778
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

		// Token: 0x06000489 RID: 1161 RVA: 0x000735F7 File Offset: 0x000717F7
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonTaskByTaskId.LogPair = null;
			ConfigAvignonTaskByTaskId.HandleId = 0;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00073605 File Offset: 0x00071805
		public static void Init()
		{
			ConfigAvignonTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonTaskByTaskId.HandleId, "db_avignon.db", "select BinData from `AvignonTask` where TaskId=?");
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00073620 File Offset: 0x00071820
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

		// Token: 0x0400052B RID: 1323
		private const string DB = "db_avignon.db";

		// Token: 0x0400052C RID: 1324
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x0400052D RID: 1325
		private const string TABLE = "AvignonTask";

		// Token: 0x0400052E RID: 1326
		private const string COMMAND = "select BinData from `AvignonTask` where TaskId=?";

		// Token: 0x0400052F RID: 1327
		private const string KEY_PREFIX = "AvignonTaskByTaskId";

		// Token: 0x04000530 RID: 1328
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000531 RID: 1329
		private static int HandleId;
	}
}
