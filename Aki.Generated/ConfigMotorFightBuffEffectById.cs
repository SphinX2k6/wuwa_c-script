using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000588 RID: 1416
	public class ConfigMotorFightBuffEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600213D RID: 8509 RVA: 0x0011561C File Offset: 0x0011381C
		static ConfigMotorFightBuffEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBuffEffectById.CreateStaticDefaultValue), new Action(ConfigMotorFightBuffEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0011563C File Offset: 0x0011383C
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

		// Token: 0x0600213F RID: 8511 RVA: 0x001156BB File Offset: 0x001138BB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBuffEffectById.LogPair = null;
			ConfigMotorFightBuffEffectById.HandleId = 0;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x001156C9 File Offset: 0x001138C9
		public static void Init()
		{
			ConfigMotorFightBuffEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBuffEffectById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBuffEffect` where Id=?");
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x001156E4 File Offset: 0x001138E4
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

		// Token: 0x0400269C RID: 9884
		private const string DB = "db_motorfight.db";

		// Token: 0x0400269D RID: 9885
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x0400269E RID: 9886
		private const string TABLE = "MotorFightBuffEffect";

		// Token: 0x0400269F RID: 9887
		private const string COMMAND = "select BinData from `MotorFightBuffEffect` where Id=?";

		// Token: 0x040026A0 RID: 9888
		private const string KEY_PREFIX = "MotorFightBuffEffectById";

		// Token: 0x040026A1 RID: 9889
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026A2 RID: 9890
		private static int HandleId;
	}
}
