using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B26 RID: 2854
	public class ConfigTrialMotorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042F8 RID: 17144 RVA: 0x001D79B4 File Offset: 0x001D5BB4
		static ConfigTrialMotorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialMotorById.CreateStaticDefaultValue), new Action(ConfigTrialMotorById.ResetStaticDefaultValue));
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x001D79D4 File Offset: 0x001D5BD4
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

		// Token: 0x060042FA RID: 17146 RVA: 0x001D7A53 File Offset: 0x001D5C53
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialMotorById.LogPair = null;
			ConfigTrialMotorById.HandleId = 0;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x001D7A61 File Offset: 0x001D5C61
		public static void Init()
		{
			ConfigTrialMotorById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialMotorById.HandleId, "db_motor.db", "select BinData from `TrialMotor` where Id=?");
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x001D7A7C File Offset: 0x001D5C7C
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

		// Token: 0x04004DF0 RID: 19952
		private const string DB = "db_motor.db";

		// Token: 0x04004DF1 RID: 19953
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04004DF2 RID: 19954
		private const string TABLE = "TrialMotor";

		// Token: 0x04004DF3 RID: 19955
		private const string COMMAND = "select BinData from `TrialMotor` where Id=?";

		// Token: 0x04004DF4 RID: 19956
		private const string KEY_PREFIX = "TrialMotorById";

		// Token: 0x04004DF5 RID: 19957
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DF6 RID: 19958
		private static int HandleId;
	}
}
