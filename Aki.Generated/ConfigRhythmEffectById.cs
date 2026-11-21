using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080B RID: 2059
	public class ConfigRhythmEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003054 RID: 12372 RVA: 0x0016DF08 File Offset: 0x0016C108
		static ConfigRhythmEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmEffectById.CreateStaticDefaultValue), new Action(ConfigRhythmEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0016DF28 File Offset: 0x0016C128
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmEffect` where Id=?")
			});
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x0016DFA7 File Offset: 0x0016C1A7
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmEffectById.LogPair = null;
			ConfigRhythmEffectById.HandleId = 0;
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x0016DFB5 File Offset: 0x0016C1B5
		public static void Init()
		{
			ConfigRhythmEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmEffectById.HandleId, "db_rhythmship.db", "select BinData from `RhythmEffect` where Id=?");
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0016DFD0 File Offset: 0x0016C1D0
		public static RhythmEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmEffect?(RhythmEffect.GetRootAsRhythmEffect(configBuffer));
				}
			}
			ConfigRhythmEffectById.LogPair.Clear();
			ConfigRhythmEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmEffectById.HandleId, 1, p0Id, ConfigRhythmEffectById.LogPair) || ConfigCommon.Step(ConfigRhythmEffectById.HandleId, true, ConfigRhythmEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmEffectById.HandleId, 0, ConfigRhythmEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmEffect rootAsRhythmEffect = RhythmEffect.GetRootAsRhythmEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair);
			return new RhythmEffect?(rootAsRhythmEffect);
		}

		// Token: 0x04003833 RID: 14387
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003834 RID: 14388
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003835 RID: 14389
		private const string TABLE = "RhythmEffect";

		// Token: 0x04003836 RID: 14390
		private const string COMMAND = "select BinData from `RhythmEffect` where Id=?";

		// Token: 0x04003837 RID: 14391
		private const string KEY_PREFIX = "RhythmEffectById";

		// Token: 0x04003838 RID: 14392
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003839 RID: 14393
		private static int HandleId;
	}
}
