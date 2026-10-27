using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EF RID: 1519
	public class ConfigNewbieMainActTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023A9 RID: 9129 RVA: 0x0012328F File Offset: 0x0012148F
		static ConfigNewbieMainActTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTaskById.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x001232B0 File Offset: 0x001214B0
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActTask` where Id=?")
			});
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0012332F File Offset: 0x0012152F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTaskById.LogPair = null;
			ConfigNewbieMainActTaskById.HandleId = 0;
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0012333D File Offset: 0x0012153D
		public static void Init()
		{
			ConfigNewbieMainActTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTaskById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTask` where Id=?");
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00123358 File Offset: 0x00121558
		public static NewbieMainActTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieMainActTask?(NewbieMainActTask.GetRootAsNewbieMainActTask(configBuffer));
				}
			}
			ConfigNewbieMainActTaskById.LogPair.Clear();
			ConfigNewbieMainActTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActTaskById.HandleId, 1, p0Id, ConfigNewbieMainActTaskById.LogPair) || ConfigCommon.Step(ConfigNewbieMainActTaskById.HandleId, true, ConfigNewbieMainActTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActTaskById.HandleId, 0, ConfigNewbieMainActTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieMainActTask rootAsNewbieMainActTask = NewbieMainActTask.GetRootAsNewbieMainActTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair);
			return new NewbieMainActTask?(rootAsNewbieMainActTask);
		}

		// Token: 0x0400296F RID: 10607
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002970 RID: 10608
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002971 RID: 10609
		private const string TABLE = "NewbieMainActTask";

		// Token: 0x04002972 RID: 10610
		private const string COMMAND = "select BinData from `NewbieMainActTask` where Id=?";

		// Token: 0x04002973 RID: 10611
		private const string KEY_PREFIX = "NewbieMainActTaskById";

		// Token: 0x04002974 RID: 10612
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002975 RID: 10613
		private static int HandleId;
	}
}
