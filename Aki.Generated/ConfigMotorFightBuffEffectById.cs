using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059F RID: 1439
	public class ConfigMotorFightBuffEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021C7 RID: 8647 RVA: 0x0011BF04 File Offset: 0x0011A104
		static ConfigMotorFightBuffEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBuffEffectById.CreateStaticDefaultValue), new Action(ConfigMotorFightBuffEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x0011BF24 File Offset: 0x0011A124
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightBuffEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightBuffEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightBuffEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightBuffEffect` where Id=?")
			});
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0011BFA3 File Offset: 0x0011A1A3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBuffEffectById.LogPair = null;
			ConfigMotorFightBuffEffectById.HandleId = 0;
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0011BFB1 File Offset: 0x0011A1B1
		public static void Init()
		{
			ConfigMotorFightBuffEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBuffEffectById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBuffEffect` where Id=?");
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0011BFCC File Offset: 0x0011A1CC
		public static MotorFightBuffEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightBuffEffectById.HandleId, ConfigMotorFightBuffEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightBuffEffect?(MotorFightBuffEffect.GetRootAsMotorFightBuffEffect(configBuffer));
				}
			}
			ConfigMotorFightBuffEffectById.LogPair.Clear();
			ConfigMotorFightBuffEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightBuffEffectById.HandleId, 1, p0Id, ConfigMotorFightBuffEffectById.LogPair) || ConfigCommon.Step(ConfigMotorFightBuffEffectById.HandleId, true, ConfigMotorFightBuffEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffEffectById.HandleId, ConfigMotorFightBuffEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightBuffEffectById.HandleId, 0, ConfigMotorFightBuffEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffEffectById.HandleId, ConfigMotorFightBuffEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightBuffEffect rootAsMotorFightBuffEffect = MotorFightBuffEffect.GetRootAsMotorFightBuffEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightBuffEffectById.HandleId, ConfigMotorFightBuffEffectById.LogPair);
			return new MotorFightBuffEffect?(rootAsMotorFightBuffEffect);
		}

		// Token: 0x0400273D RID: 10045
		private const string DB = "db_motorfight.db";

		// Token: 0x0400273E RID: 10046
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x0400273F RID: 10047
		private const string TABLE = "MotorFightBuffEffect";

		// Token: 0x04002740 RID: 10048
		private const string COMMAND = "select BinData from `MotorFightBuffEffect` where Id=?";

		// Token: 0x04002741 RID: 10049
		private const string KEY_PREFIX = "MotorFightBuffEffectById";

		// Token: 0x04002742 RID: 10050
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002743 RID: 10051
		private static int HandleId;
	}
}
