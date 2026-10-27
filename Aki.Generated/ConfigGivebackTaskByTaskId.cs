using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039F RID: 927
	public class ConfigGivebackTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015C1 RID: 5569 RVA: 0x000D48F7 File Offset: 0x000D2AF7
		static ConfigGivebackTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGivebackTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigGivebackTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000D4918 File Offset: 0x000D2B18
		public static void CreateStaticDefaultValue()
		{
			ConfigGivebackTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGivebackTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feedbackreward.db"),
				new ValueTuple<string, object>("文件", "l.老玩家回馈.xlsx"),
				new ValueTuple<string, object>("表名", "GivebackTask"),
				new ValueTuple<string, object>("语句", "select BinData from `GivebackTask` where TaskId=?")
			});
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000D4997 File Offset: 0x000D2B97
		public static void ResetStaticDefaultValue()
		{
			ConfigGivebackTaskByTaskId.LogPair = null;
			ConfigGivebackTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000D49A5 File Offset: 0x000D2BA5
		public static void Init()
		{
			ConfigGivebackTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigGivebackTaskByTaskId.HandleId, "db_feedbackreward.db", "select BinData from `GivebackTask` where TaskId=?");
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000D49C0 File Offset: 0x000D2BC0
		public static GivebackTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GivebackTask?(GivebackTask.GetRootAsGivebackTask(configBuffer));
				}
			}
			ConfigGivebackTaskByTaskId.LogPair.Clear();
			ConfigGivebackTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigGivebackTaskByTaskId.HandleId, 1, p0TaskId, ConfigGivebackTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigGivebackTaskByTaskId.HandleId, true, ConfigGivebackTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGivebackTaskByTaskId.HandleId, 0, ConfigGivebackTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GivebackTask rootAsGivebackTask = GivebackTask.GetRootAsGivebackTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGivebackTaskByTaskId.HandleId, ConfigGivebackTaskByTaskId.LogPair);
			return new GivebackTask?(rootAsGivebackTask);
		}

		// Token: 0x0400193D RID: 6461
		private const string DB = "db_feedbackreward.db";

		// Token: 0x0400193E RID: 6462
		private const string FILE = "l.老玩家回馈.xlsx";

		// Token: 0x0400193F RID: 6463
		private const string TABLE = "GivebackTask";

		// Token: 0x04001940 RID: 6464
		private const string COMMAND = "select BinData from `GivebackTask` where TaskId=?";

		// Token: 0x04001941 RID: 6465
		private const string KEY_PREFIX = "GivebackTaskByTaskId";

		// Token: 0x04001942 RID: 6466
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001943 RID: 6467
		private static int HandleId;
	}
}
