using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000581 RID: 1409
	public class ConfigMotorEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002113 RID: 8467 RVA: 0x0011478C File Offset: 0x0011298C
		static ConfigMotorEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorEffectById.CreateStaticDefaultValue), new Action(ConfigMotorEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x001147AC File Offset: 0x001129AC
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

		// Token: 0x06002115 RID: 8469 RVA: 0x0011482B File Offset: 0x00112A2B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorEffectById.LogPair = null;
			ConfigMotorEffectById.HandleId = 0;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00114839 File Offset: 0x00112A39
		public static void Init()
		{
			ConfigMotorEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorEffectById.HandleId, "db_motor.db", "select BinData from `MotorEffect` where Id=?");
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00114854 File Offset: 0x00112A54
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

		// Token: 0x0400266B RID: 9835
		private const string DB = "db_motor.db";

		// Token: 0x0400266C RID: 9836
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400266D RID: 9837
		private const string TABLE = "MotorEffect";

		// Token: 0x0400266E RID: 9838
		private const string COMMAND = "select BinData from `MotorEffect` where Id=?";

		// Token: 0x0400266F RID: 9839
		private const string KEY_PREFIX = "MotorEffectById";

		// Token: 0x04002670 RID: 9840
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002671 RID: 9841
		private static int HandleId;
	}
}
