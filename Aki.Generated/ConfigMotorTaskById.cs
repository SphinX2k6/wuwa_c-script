using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E0 RID: 1504
	public class ConfigMotorTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600234D RID: 9037 RVA: 0x001249A8 File Offset: 0x00122BA8
		static ConfigMotorTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTaskById.CreateStaticDefaultValue), new Action(ConfigMotorTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x001249C8 File Offset: 0x00122BC8
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTask"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTask` where Id=?")
			});
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00124A47 File Offset: 0x00122C47
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTaskById.LogPair = null;
			ConfigMotorTaskById.HandleId = 0;
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00124A55 File Offset: 0x00122C55
		public static void Init()
		{
			ConfigMotorTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTaskById.HandleId, "db_motor.db", "select BinData from `MotorTask` where Id=?");
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00124A70 File Offset: 0x00122C70
		public static MotorTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTaskById.HandleId, ConfigMotorTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorTask?(MotorTask.GetRootAsMotorTask(configBuffer));
				}
			}
			ConfigMotorTaskById.LogPair.Clear();
			ConfigMotorTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorTaskById.HandleId, 1, p0Id, ConfigMotorTaskById.LogPair) || ConfigCommon.Step(ConfigMotorTaskById.HandleId, true, ConfigMotorTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorTaskById.HandleId, ConfigMotorTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTaskById.HandleId, 0, ConfigMotorTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorTaskById.HandleId, ConfigMotorTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorTask rootAsMotorTask = MotorTask.GetRootAsMotorTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorTaskById.HandleId, ConfigMotorTaskById.LogPair);
			return new MotorTask?(rootAsMotorTask);
		}

		// Token: 0x04002904 RID: 10500
		private const string DB = "db_motor.db";

		// Token: 0x04002905 RID: 10501
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002906 RID: 10502
		private const string TABLE = "MotorTask";

		// Token: 0x04002907 RID: 10503
		private const string COMMAND = "select BinData from `MotorTask` where Id=?";

		// Token: 0x04002908 RID: 10504
		private const string KEY_PREFIX = "MotorTaskById";

		// Token: 0x04002909 RID: 10505
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400290A RID: 10506
		private static int HandleId;
	}
}
