using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A51 RID: 2641
	public class ConfigTrialMotorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DFA RID: 15866 RVA: 0x001B8620 File Offset: 0x001B6820
		static ConfigTrialMotorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialMotorById.CreateStaticDefaultValue), new Action(ConfigTrialMotorById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x001B8640 File Offset: 0x001B6840
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialMotorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialMotorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "TrialMotor"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialMotor` where Id=?")
			});
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x001B86BF File Offset: 0x001B68BF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialMotorById.LogPair = null;
			ConfigTrialMotorById.HandleId = 0;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x001B86CD File Offset: 0x001B68CD
		public static void Init()
		{
			ConfigTrialMotorById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialMotorById.HandleId, "db_motor.db", "select BinData from `TrialMotor` where Id=?");
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x001B86E8 File Offset: 0x001B68E8
		public static TrialMotor? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialMotorById.HandleId, ConfigTrialMotorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialMotorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrialMotor?(TrialMotor.GetRootAsTrialMotor(configBuffer));
				}
			}
			ConfigTrialMotorById.LogPair.Clear();
			ConfigTrialMotorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrialMotorById.HandleId, 1, p0Id, ConfigTrialMotorById.LogPair) || ConfigCommon.Step(ConfigTrialMotorById.HandleId, true, ConfigTrialMotorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrialMotorById.HandleId, ConfigTrialMotorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialMotorById.HandleId, 0, ConfigTrialMotorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrialMotorById.HandleId, ConfigTrialMotorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrialMotor rootAsTrialMotor = TrialMotor.GetRootAsTrialMotor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialMotorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrialMotorById.HandleId, ConfigTrialMotorById.LogPair);
			return new TrialMotor?(rootAsTrialMotor);
		}

		// Token: 0x0400481D RID: 18461
		private const string DB = "db_motor.db";

		// Token: 0x0400481E RID: 18462
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400481F RID: 18463
		private const string TABLE = "TrialMotor";

		// Token: 0x04004820 RID: 18464
		private const string COMMAND = "select BinData from `TrialMotor` where Id=?";

		// Token: 0x04004821 RID: 18465
		private const string KEY_PREFIX = "TrialMotorById";

		// Token: 0x04004822 RID: 18466
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004823 RID: 18467
		private static int HandleId;
	}
}
