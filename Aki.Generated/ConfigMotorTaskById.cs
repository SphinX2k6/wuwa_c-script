using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C8 RID: 1480
	public class ConfigMotorTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022BD RID: 8893 RVA: 0x0011DF2C File Offset: 0x0011C12C
		static ConfigMotorTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTaskById.CreateStaticDefaultValue), new Action(ConfigMotorTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0011DF4C File Offset: 0x0011C14C
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

		// Token: 0x060022BF RID: 8895 RVA: 0x0011DFCB File Offset: 0x0011C1CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTaskById.LogPair = null;
			ConfigMotorTaskById.HandleId = 0;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0011DFD9 File Offset: 0x0011C1D9
		public static void Init()
		{
			ConfigMotorTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTaskById.HandleId, "db_motor.db", "select BinData from `MotorTask` where Id=?");
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0011DFF4 File Offset: 0x0011C1F4
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

		// Token: 0x0400285C RID: 10332
		private const string DB = "db_motor.db";

		// Token: 0x0400285D RID: 10333
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400285E RID: 10334
		private const string TABLE = "MotorTask";

		// Token: 0x0400285F RID: 10335
		private const string COMMAND = "select BinData from `MotorTask` where Id=?";

		// Token: 0x04002860 RID: 10336
		private const string KEY_PREFIX = "MotorTaskById";

		// Token: 0x04002861 RID: 10337
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002862 RID: 10338
		private static int HandleId;
	}
}
