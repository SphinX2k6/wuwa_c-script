using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000598 RID: 1432
	public class ConfigMotorEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600219D RID: 8605 RVA: 0x0011B074 File Offset: 0x00119274
		static ConfigMotorEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorEffectById.CreateStaticDefaultValue), new Action(ConfigMotorEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0011B094 File Offset: 0x00119294
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorEffect` where Id=?")
			});
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0011B113 File Offset: 0x00119313
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorEffectById.LogPair = null;
			ConfigMotorEffectById.HandleId = 0;
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0011B121 File Offset: 0x00119321
		public static void Init()
		{
			ConfigMotorEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorEffectById.HandleId, "db_motor.db", "select BinData from `MotorEffect` where Id=?");
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0011B13C File Offset: 0x0011933C
		public static MotorEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorEffectById.HandleId, ConfigMotorEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorEffect?(MotorEffect.GetRootAsMotorEffect(configBuffer));
				}
			}
			ConfigMotorEffectById.LogPair.Clear();
			ConfigMotorEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorEffectById.HandleId, 1, p0Id, ConfigMotorEffectById.LogPair) || ConfigCommon.Step(ConfigMotorEffectById.HandleId, true, ConfigMotorEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorEffectById.HandleId, ConfigMotorEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorEffectById.HandleId, 0, ConfigMotorEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorEffectById.HandleId, ConfigMotorEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorEffect rootAsMotorEffect = MotorEffect.GetRootAsMotorEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorEffectById.HandleId, ConfigMotorEffectById.LogPair);
			return new MotorEffect?(rootAsMotorEffect);
		}

		// Token: 0x0400270C RID: 9996
		private const string DB = "db_motor.db";

		// Token: 0x0400270D RID: 9997
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400270E RID: 9998
		private const string TABLE = "MotorEffect";

		// Token: 0x0400270F RID: 9999
		private const string COMMAND = "select BinData from `MotorEffect` where Id=?";

		// Token: 0x04002710 RID: 10000
		private const string KEY_PREFIX = "MotorEffectById";

		// Token: 0x04002711 RID: 10001
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002712 RID: 10002
		private static int HandleId;
	}
}
